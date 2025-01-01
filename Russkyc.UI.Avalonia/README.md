## Russkyc.UI.Avalonia - Create Beautiful UI's for Avalonia

Russkyc.UI.Avalonia provides clean, beautifully-designed, and customizable components inspired by the design of [shadcn/ui](https://ui.shadcn.com) for Avalonia applications.

## Configuration

Update Resources in App.axaml

```xaml
<Application.Resources>
    <ResourceDictionary>
        <ResourceDictionary.MergedDictionaries>
            <!-- Theme (Customizable) -->
            <ResourceInclude Source="avares://Russkyc.UI.Avalonia/Themes/Zinc.axaml" />
            <!-- Base (Required) -->
            <ResourceInclude Source="avares://Russkyc.UI.Avalonia/Base.axaml" />
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

## Theming and More Information

[Github Repository](https://github.com/russkyc/russkyc-ui-avalonia)