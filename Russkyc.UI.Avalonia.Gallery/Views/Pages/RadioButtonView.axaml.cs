using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class RadioButtonView : UserControl
{
    public RadioButtonView()
    {
        InitializeComponent();
        CodeBlock.Text = """
                         <Border Height="200" Classes="Card">
                             <WrapPanel
                                 HorizontalAlignment="Center"
                                 VerticalAlignment="Center"
                                 Orientation="Horizontal">
                                 <WrapPanel.Styles>
                                     <Style Selector="RadioButton">
                                         <Setter Property="Margin" Value="4" />
                                     </Style>
                                 </WrapPanel.Styles>
                                 <RadioButton VerticalAlignment="Center" Content="Default" />
                                 <RadioButton
                                     VerticalAlignment="Center"
                                     Content="Default Disabled"
                                     IsEnabled="False" />
                                 <RadioButton
                                     VerticalAlignment="Center"
                                     Classes="Toggle"
                                     Content="Toggle" />
                                 <RadioButton
                                     VerticalAlignment="Center"
                                     Classes="Toggle Primary"
                                     Content="Toggle Primary" />
                                 <RadioButton
                                     VerticalAlignment="Center"
                                     Classes="Toggle"
                                     Content="Toggle Disabled"
                                     IsEnabled="False" />
                             </WrapPanel>
                         </Border>
                         """;
    }
}