using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class ToggleButtonView : UserControl
{
    public ToggleButtonView()
    {
        InitializeComponent();
        CodeBlock.Text = """
                         <WrapPanel
                             HorizontalAlignment="Center"
                             VerticalAlignment="Center"
                             Orientation="Horizontal">
                             <WrapPanel.Styles>
                                 <Style Selector="ToggleButton">
                                     <Setter Property="Margin" Value="4" />
                                 </Style>
                             </WrapPanel.Styles>
                             <ToggleButton Content="Default" />
                             <ToggleButton Classes="Primary" Content="Primary" />
                             <ToggleButton Classes="Outline" Content="Outlined" />
                             <ToggleButton Classes="Outline" Content="Outline Disabled" IsEnabled="False" />
                         </WrapPanel>
                         """;
    }
}