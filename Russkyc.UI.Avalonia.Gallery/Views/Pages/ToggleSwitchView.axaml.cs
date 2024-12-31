using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class ToggleSwitchView : UserControl
{
    public ToggleSwitchView()
    {
        InitializeComponent();
        CodeBlock.Text = """
                         <Border Height="200" Classes="Card">
                             <WrapPanel
                                 HorizontalAlignment="Center"
                                 VerticalAlignment="Center"
                                 Orientation="Horizontal">
                                 <WrapPanel.Styles>
                                     <Style Selector="ToggleSwitch">
                                         <Setter Property="Margin" Value="4" />
                                     </Style>
                                 </WrapPanel.Styles>
                                 <ToggleSwitch VerticalAlignment="Bottom" />
                                 <ToggleSwitch
                                     VerticalAlignment="Bottom"
                                     OffContent="Off Content"
                                     OnContent="On Content" />
                                 <ToggleSwitch
                                     VerticalAlignment="Bottom"
                                     IsEnabled="False"
                                     OffContent="Disabled"
                                     OnContent="Disabled" />
                             </WrapPanel>
                         </Border>
                         """;
    }
}