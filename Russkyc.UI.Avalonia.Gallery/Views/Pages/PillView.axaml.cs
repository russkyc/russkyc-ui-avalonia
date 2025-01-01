using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class PillView : UserControl
{
    public PillView()
    {
        InitializeComponent();
        CodeBlock.Text = """
                         <Border Classes="Card">
                             <WrapPanel
                                 HorizontalAlignment="Center"
                                 VerticalAlignment="Center"
                                 Orientation="Horizontal">
                                 <WrapPanel.Styles>
                                     <Style Selector="Border">
                                         <Setter Property="Margin" Value="4" />
                                     </Style>
                                 </WrapPanel.Styles>
                                 <Border Classes="Pill">
                                     <TextBlock Text="Standard Pill" />
                                 </Border>
                                 <Border Classes="Pill Primary">
                                     <TextBlock Text="Primary Pill" />
                                 </Border>
                                 <Border Classes="Pill Secondary">
                                     <TextBlock Text="Secondary Pill" />
                                 </Border>
                                 <Border Classes="Pill Destructive">
                                     <TextBlock Text="Destructive Pill" />
                                 </Border>
                             </WrapPanel>
                         </Border>
                         """;
    }
}