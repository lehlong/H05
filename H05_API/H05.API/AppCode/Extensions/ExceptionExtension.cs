﻿using System.Collections;
using System.Reflection;
using System.Text;

namespace H05.API.AppCode.Extensions
{
    public static class ExceptionExtension
    {
        public static string ToDetailedString(this Exception exception) =>
            ToDetailedString(exception, ExceptionOptions.Default);

        public static string ToDetailedString(this Exception exception, ExceptionOptions options)
        {
            ArgumentNullException.ThrowIfNull(exception);

            var stringBuilder = new StringBuilder();

            AppendValue(stringBuilder, "Type", exception.GetType().FullName, options);

            foreach (PropertyInfo property in exception
                .GetType()
                .GetProperties()
                .OrderByDescending(x => string.Equals(x.Name, nameof(exception.Message), StringComparison.Ordinal))
                .ThenByDescending(x => string.Equals(x.Name, nameof(exception.Source), StringComparison.Ordinal))
                .ThenBy(x => string.Equals(x.Name, nameof(exception.InnerException), StringComparison.Ordinal))
                .ThenBy(x => string.Equals(x.Name, nameof(AggregateException.InnerExceptions), StringComparison.Ordinal)))
            {
                var value = property.GetValue(exception, null);
                if (value == null && options.OmitNullProperties)
                {
                    if (options.OmitNullProperties)
                    {
                        continue;
                    }
                    else
                    {
                        value = string.Empty;
                    }
                }

                AppendValue(stringBuilder, property.Name, value, options);
            }

            return stringBuilder.ToString().TrimEnd('\r', '\n');
        }

        private static void AppendCollection(
            StringBuilder stringBuilder,
            string propertyName,
            IEnumerable collection,
            ExceptionOptions options)
        {
            stringBuilder.AppendLine($"{options.Indent}{propertyName} =");

            var innerOptions = new ExceptionOptions(options, options.CurrentIndentLevel + 1);

            var i = 0;
            foreach (var item in collection)
            {
                var innerPropertyName = $"[{i}]";

                if (item is Exception innerException)
                {
                    AppendException(
                        stringBuilder,
                        innerPropertyName,
                        innerException,
                        innerOptions);
                }
                else
                {
                    AppendValue(
                        stringBuilder,
                        innerPropertyName,
                        item,
                        innerOptions);
                }

                ++i;
            }
        }

        private static void AppendException(
            StringBuilder stringBuilder,
            string propertyName,
            Exception exception,
            ExceptionOptions options)
        {
            var innerExceptionString = ToDetailedString(
                exception,
                new ExceptionOptions(options, options.CurrentIndentLevel + 1));

            stringBuilder.AppendLine($"{options.Indent}{propertyName} =");
            stringBuilder.AppendLine(innerExceptionString);
        }

        private static void AppendValue(
            StringBuilder stringBuilder,
            string propertyName,
            object value,
            ExceptionOptions options)
        {
            if (value is DictionaryEntry dictionaryEntry)
            {
                stringBuilder.AppendLine($"{options.Indent}{propertyName} = {dictionaryEntry.Key} : {dictionaryEntry.Value}");
            }
            else if (value is Exception innerException)
            {
                AppendException(
                    stringBuilder,
                    propertyName,
                    innerException,
                    options);
            }
            else if (value is IEnumerable enumerable && value is not string)
            {
                var collection = enumerable;
                if (collection.GetEnumerator().MoveNext())
                {
                    AppendCollection(
                        stringBuilder,
                        propertyName,
                        collection,
                        options);
                }
            }
            else
            {
                stringBuilder.AppendLine($"{options.Indent}{propertyName} = {value}");
            }
        }
    }

    public struct ExceptionOptions
    {
        public static readonly ExceptionOptions Default = new()
        {
            CurrentIndentLevel = 0,
            IndentSpaces = 4,
            OmitNullProperties = true
        };

        internal ExceptionOptions(ExceptionOptions options, int currentIndent)
        {
            CurrentIndentLevel = currentIndent;
            IndentSpaces = options.IndentSpaces;
            OmitNullProperties = options.OmitNullProperties;
        }

        internal readonly string Indent { get { return new string(' ', IndentSpaces * CurrentIndentLevel); } }

        internal int CurrentIndentLevel { get; set; }

        public int IndentSpaces { get; set; }

        public bool OmitNullProperties { get; set; }
    }
}
