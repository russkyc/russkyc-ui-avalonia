using System;
using System.Globalization;
using Avalonia;
using Avalonia.Data.Converters;

namespace Russkyc.UI.Avalonia.Converters;

public class FocusBorderRadiusConverter : IValueConverter
{
    public static FocusBorderRadiusConverter Instance => new();
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is not CornerRadius thickness) return null;
        var padding = 2;
        return new CornerRadius(thickness.TopLeft+padding, thickness.TopRight+padding, thickness.BottomRight+padding, thickness.BottomLeft+padding);
        return null;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return null;
    }
}