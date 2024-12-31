using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class ComboBoxView : UserControl
{
    public ComboBoxView()
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
                                 <ComboBox HorizontalAlignment="Stretch" PlaceholderText="Default ComboBox">
                                     <ComboBoxItem>Apple</ComboBoxItem>
                                     <ComboBoxItem>Banana</ComboBoxItem>
                                     <ComboBoxItem>Blueberry</ComboBoxItem>
                                     <ComboBoxItem>Grapes</ComboBoxItem>
                                     <ComboBoxItem>Pineapple</ComboBoxItem>
                                 </ComboBox>
                                 <ComboBox
                                     HorizontalAlignment="Stretch"
                                     IsEnabled="False"
                                     PlaceholderText="Disabled ComboBox">
                                     <ComboBoxItem>Apple</ComboBoxItem>
                                     <ComboBoxItem>Banana</ComboBoxItem>
                                     <ComboBoxItem>Blueberry</ComboBoxItem>
                                     <ComboBoxItem>Grapes</ComboBoxItem>
                                     <ComboBoxItem>Pineapple</ComboBoxItem>
                                 </ComboBox>
                                 <ComboBox HorizontalAlignment="Stretch" PlaceholderText="Error">
                                     <DataValidationErrors.Error>
                                         <system:Exception>
                                             <x:Arguments>
                                                 <x:String>Please select a fruit</x:String>
                                             </x:Arguments>
                                         </system:Exception>
                                     </DataValidationErrors.Error>
                                     <ComboBoxItem>Apple</ComboBoxItem>
                                     <ComboBoxItem>Banana</ComboBoxItem>
                                     <ComboBoxItem>Blueberry</ComboBoxItem>
                                     <ComboBoxItem>Grapes</ComboBoxItem>
                                     <ComboBoxItem>Pineapple</ComboBoxItem>
                                 </ComboBox>
                             </StackPanel>
                         </Border>
                         """;
    }
}