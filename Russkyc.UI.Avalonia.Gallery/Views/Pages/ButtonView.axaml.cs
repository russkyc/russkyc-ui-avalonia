using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class ButtonView : UserControl
{
    public ButtonView()
    {
        InitializeComponent();
        CodeBlock.Text = """
                         <WrapPanel
                             HorizontalAlignment="Center"
                             VerticalAlignment="Center"
                             Orientation="Horizontal">
                             <WrapPanel.Styles>
                                 <Style Selector="Button">
                                     <Setter Property="Margin" Value="4" />
                                 </Style>
                             </WrapPanel.Styles>
                             <Button Content="Primary" />
                             <Button Classes="Destructive" Content="Destructive" />
                             <Button Classes="Outline" Content="Outline" />
                             <Button Classes="Ghost" Content="Ghost" />
                             <Button Classes="Link" Content="Link" />
                             <Button Content="Disabled" IsEnabled="False" />
                         </WrapPanel>
                         """;
    }
}