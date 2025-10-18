using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class ListBoxView : UserControl
{
    public ListBoxView()
    {
        InitializeComponent();
        CodeBlock.Text = """
                         <Border Classes="Card">
                             <StackPanel
                                 Width="300"
                                 Margin="20"
                                 HorizontalAlignment="Center"
                                 VerticalAlignment="Center"
                                 Spacing="8">
                                 <ListBox HorizontalAlignment="Stretch">
                                     <ListBoxItem>Apple</ListBoxItem>
                                     <ListBoxItem>Banana</ListBoxItem>
                                     <ListBoxItem>Blueberry</ListBoxItem>
                                     <ListBoxItem>Grapes</ListBoxItem>
                                     <ListBoxItem>Pineapple</ListBoxItem>
                                 </ListBox>
                                 <ListBox
                                     HorizontalAlignment="Stretch"
                                     IsEnabled="False">
                                     <ListBoxItem>Apple</ListBoxItem>
                                     <ListBoxItem>Banana</ListBoxItem>
                                     <ListBoxItem>Blueberry</ListBoxItem>
                                     <ListBoxItem>Grapes</ListBoxItem>
                                     <ListBoxItem>Pineapple</ListBoxItem>
                                 </ListBox>
                             </StackPanel>
                         </Border>
                         """;
    }
}

