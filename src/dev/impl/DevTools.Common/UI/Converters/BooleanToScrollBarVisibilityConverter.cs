﻿#nullable enable

using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Data;

namespace DevTools.Common.UI.Converters
{
    /// <summary>
    /// Convert a <see cref="bool"/> to a <see cref="ScrollBarVisibility"/> value.
    /// </summary>
    public sealed class BooleanToScrollBarVisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Gets or sets the scroll bar visibility to apply when the input is true.
        /// </summary>
        public ScrollBarVisibility ScrollBarVisibilityOnTrue { get; set; }

        /// <summary>
        /// Gets or sets the scroll bar visibility to apply when the input is false.
        /// </summary>
        public ScrollBarVisibility ScrollBarVisibilityOnFalse { get; set; }

        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var valueBool = value as bool?;
            if (valueBool == null)
            {
                return DependencyProperty.UnsetValue;
            }

            return valueBool.Value ? ScrollBarVisibilityOnTrue : ScrollBarVisibilityOnFalse;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
