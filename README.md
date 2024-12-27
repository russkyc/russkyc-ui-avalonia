<a href="#">
    <img src=".github/resources/images/banner.svg" style="width: 100%;" />
</a>

<h2 align="center">Russkyc.UI.Avalonia - Create Beautiful UI's for Avalonia</h2>

<p style="text-align: justify">
Russkyc.UI.Avalonia provides clean, beautifully-designed, and customizable components inspired by the design of <a href="https://ui.shadcn.com">shadcn/ui</a> for Avalonia applications.
</p>

## Installation

#### 1. Download

> [!WARNING]  
> Russkyc.UI.Avalonia is in early development stage and currently has no available nuget packages

#### 2. Configuration

Update Resources in App.axaml

```xaml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <!-- Theme Resource -->
            <ResourceInclude Source="avares://Russkyc.UI.Avalonia/Themes/Zinc.axaml" />
            <!-- Controls Resource -->
            <ResourceInclude Source="avares://Russkyc.UI.Avalonia/Controls.axaml" />
        </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
</Application.Resources>
```

All theme colors and defaults (including radius, border thickness, and more) can be customized. Please see [Theme and Styling](#theme-and-styling)

## Usage

```xaml
<!-- Button Sampler -->
<StackPanel Orientation="Horizontal" Spacing="7">
    <Button Content="Primary" />
    <Button Content="Destructive" Classes="Destructive" />
    <Button Content="Outline" Classes="Outline" />
    <Button Content="Ghost" Classes="Ghost" />
    <Button Content="Link" Classes="Link" />
    <Button Content="Disabled" IsEnabled="False" />
</StackPanel>
```
Components are built on top of the existing Avalonia controls.
No fancy namespace imports needed, all supported controls are
automatically themed and changed using supported class variants.

## Theme and Styling

The theme can be customized using a resource dictionary with the following template.
All components use the defaults and theme provided in this template.

```xaml
<ResourceDictionary xmlns="https://github.com/avaloniaui"
                    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">
    <!-- Defaults -->
    <CornerRadius x:Key="Radius">5</CornerRadius>
    <Thickness x:Key="BorderThickness">1</Thickness>
    <Thickness x:Key="Padding">12,6</Thickness>
    <!-- Theme -->
    <ResourceDictionary.ThemeDictionaries>
        <!-- Light -->
        <ResourceDictionary x:Key="Light">
            <!-- Colors -->
            <Color x:Key="Background">#FFFFFF</Color>
            <Color x:Key="Foreground">#000000</Color>
            <Color x:Key="Card">#FFFFFF</Color>
            <Color x:Key="CardForeground">#000000</Color>
            <Color x:Key="Popover">#FFFFFF</Color>
            <Color x:Key="PopoverForeground">#000000</Color>
            <Color x:Key="Primary">	#18181b</Color>
            <Color x:Key="PrimaryForeground">#FAFAFA</Color>
            <Color x:Key="Secondary">	#f4f4f5</Color>
            <Color x:Key="SecondaryForeground">#18181B</Color>
            <Color x:Key="Muted">#F4F4F5</Color>
            <Color x:Key="MutedForeground">#71717A</Color>
            <Color x:Key="Accent">#F4F4F5</Color>
            <Color x:Key="AccentForeground">#18181B</Color>
            <Color x:Key="Destructive">#EF4444</Color>
            <Color x:Key="DestructiveForeground">#FAFAFA</Color>
            <Color x:Key="Border">#E4E4E7</Color>
            <Color x:Key="Input">#E4E4E7</Color>
            <Color x:Key="LightOverlay">#06FFFFFF</Color>
            <Color x:Key="LightenOverlay">#12FFFFFF</Color>
            <Color x:Key="DarkOverlay">#06000000</Color>
            <Color x:Key="DarkenOverlay">#12000000</Color>
            <!-- Brushes -->
            <SolidColorBrush x:Key="BackgroundBrush" Color="{DynamicResource Background}" />
            <SolidColorBrush x:Key="ForegroundBrush" Color="{DynamicResource Foreground}" />
            <SolidColorBrush x:Key="CardBrush" Color="{DynamicResource Card}" />
            <SolidColorBrush x:Key="CardForegroundBrush" Color="{DynamicResource CardForeground}" />
            <SolidColorBrush x:Key="PopoverBrush" Color="{DynamicResource Popover}" />
            <SolidColorBrush x:Key="PopoverForegroundBrush" Color="{DynamicResource PopoverForeground}" />
            <SolidColorBrush x:Key="PrimaryBrush" Color="{DynamicResource Primary}" />
            <SolidColorBrush x:Key="PrimaryForegroundBrush" Color="{DynamicResource PrimaryForeground}" />
            <SolidColorBrush x:Key="SecondaryBrush" Color="{DynamicResource Secondary}" />
            <SolidColorBrush x:Key="SecondaryForegroundBrush" Color="{DynamicResource SecondaryForeground}" />
            <SolidColorBrush x:Key="MutedBrush" Color="{DynamicResource Muted}" />
            <SolidColorBrush x:Key="MutedForegroundBrush" Color="{DynamicResource MutedForeground}" />
            <SolidColorBrush x:Key="AccentBrush" Color="{DynamicResource Accent}" />
            <SolidColorBrush x:Key="AccentForegroundBrush" Color="{DynamicResource AccentForeground}" />
            <SolidColorBrush x:Key="DestructiveBrush" Color="{DynamicResource Destructive}" />
            <SolidColorBrush x:Key="DestructiveForegroundBrush" Color="{DynamicResource DestructiveForeground}" />
            <SolidColorBrush x:Key="BorderBrush" Color="{DynamicResource Border}" />
            <SolidColorBrush x:Key="InputBrush" Color="{DynamicResource Input}" />
            <SolidColorBrush x:Key="LightOverlayBrush" Color="{DynamicResource LightOverlay}"/>
            <SolidColorBrush x:Key="LightenOverlayBrush" Color="{DynamicResource LightenOverlay}"/>
            <SolidColorBrush x:Key="DarkOverlayBrush" Color="{DynamicResource DarkOverlay}"/>
            <SolidColorBrush x:Key="DarkenOverlayBrush" Color="{DynamicResource DarkenOverlay}"/>
        </ResourceDictionary>
        <!-- Dark -->
        <ResourceDictionary x:Key="Dark">
            <!-- Colors -->
            <Color x:Key="Background">#09090B</Color>
            <Color x:Key="Foreground">#FAFAFA</Color>
            <Color x:Key="Card">#09090B</Color>
            <Color x:Key="CardForeground">#FAFAFA</Color>
            <Color x:Key="Popover">#09090B</Color>
            <Color x:Key="PopoverForeground">#FAFAFA</Color>
            <Color x:Key="Primary">	#FAFAFA</Color>
            <Color x:Key="PrimaryForeground">#18181B</Color>
            <Color x:Key="Secondary">	#27272A</Color>
            <Color x:Key="SecondaryForeground">#FAFAFA</Color>
            <Color x:Key="Muted">#27272A</Color>
            <Color x:Key="MutedForeground">#A1A1AA</Color>
            <Color x:Key="Accent">#27272A</Color>
            <Color x:Key="AccentForeground">#FAFAFA</Color>
            <Color x:Key="Destructive">#7F1D1D</Color>
            <Color x:Key="DestructiveForeground">#FAFAFA</Color>
            <Color x:Key="Border">#27272A</Color>
            <Color x:Key="Input">#27272A</Color>
            <Color x:Key="LightOverlay">#06FFFFFF</Color>
            <Color x:Key="LightenOverlay">#12FFFFFF</Color>
            <Color x:Key="DarkOverlay">#06000000</Color>
            <Color x:Key="DarkenOverlay">#12000000</Color>
            <!-- Brushes -->
            <SolidColorBrush x:Key="BackgroundBrush" Color="{DynamicResource Background}" />
            <SolidColorBrush x:Key="ForegroundBrush" Color="{DynamicResource Foreground}" />
            <SolidColorBrush x:Key="CardBrush" Color="{DynamicResource Card}" />
            <SolidColorBrush x:Key="CardForegroundBrush" Color="{DynamicResource CardForeground}" />
            <SolidColorBrush x:Key="PopoverBrush" Color="{DynamicResource Popover}" />
            <SolidColorBrush x:Key="PopoverForegroundBrush" Color="{DynamicResource PopoverForeground}" />
            <SolidColorBrush x:Key="PrimaryBrush" Color="{DynamicResource Primary}" />
            <SolidColorBrush x:Key="PrimaryForegroundBrush" Color="{DynamicResource PrimaryForeground}" />
            <SolidColorBrush x:Key="SecondaryBrush" Color="{DynamicResource Secondary}" />
            <SolidColorBrush x:Key="SecondaryForegroundBrush" Color="{DynamicResource SecondaryForeground}" />
            <SolidColorBrush x:Key="MutedBrush" Color="{DynamicResource Muted}" />
            <SolidColorBrush x:Key="MutedForegroundBrush" Color="{DynamicResource MutedForeground}" />
            <SolidColorBrush x:Key="AccentBrush" Color="{DynamicResource Accent}" />
            <SolidColorBrush x:Key="AccentForegroundBrush" Color="{DynamicResource AccentForeground}" />
            <SolidColorBrush x:Key="DestructiveBrush" Color="{DynamicResource Destructive}" />
            <SolidColorBrush x:Key="DestructiveForegroundBrush" Color="{DynamicResource DestructiveForeground}" />
            <SolidColorBrush x:Key="BorderBrush" Color="{DynamicResource Border}" />
            <SolidColorBrush x:Key="InputBrush" Color="{DynamicResource Input}" />
            <SolidColorBrush x:Key="LightOverlayBrush" Color="{DynamicResource LightOverlay}"/>
            <SolidColorBrush x:Key="LightenOverlayBrush" Color="{DynamicResource LightenOverlay}"/>
            <SolidColorBrush x:Key="DarkOverlayBrush" Color="{DynamicResource DarkOverlay}"/>
            <SolidColorBrush x:Key="DarkenOverlayBrush" Color="{DynamicResource DarkenOverlay}"/>
        </ResourceDictionary>
    </ResourceDictionary.ThemeDictionaries>
</ResourceDictionary>
```

> [!NOTE]  
> Only the `Defaults`, and `Colors` sections of the theme need to be changed.
> The brushes use references from the `Colors` section and does not need any changes.

## License

This project is licensed under the [MIT License](LICENSE.md)

<h2 align="center">Special Thanks</h2>

<div align="center">
    <a href="https://www.jetbrains.com/community/opensource/#support">
        <img width="48px" src="https://resources.jetbrains.com/storage/products/company/brand/logos/jb_beam.png" alt="JetBrains logo">
    </a>
    <a href="https://www.jetbrains.com/community/opensource/#support">
        <img width="48px" src="https://avatars.githubusercontent.com/u/139895814?s=48&v=4" alt="shadcn/ui logo">
    </a>
</div>

<p style="text-align: justify">
This project is made possible by Jetbrains and shadcn.
Jetbrains provided free use of <a href="https://www.jetbrains.com/rider">Rider</a>, the IDE used in the development
of this project. Design and styling is inspired by <a href="https://ui.shadcn.com">shadcn/ui</a>
</p>
