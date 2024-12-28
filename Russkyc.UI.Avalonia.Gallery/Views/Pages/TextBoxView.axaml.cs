using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class TextBoxView : UserControl
{
    public TextBoxView()
    {
        InitializeComponent();
        CodeBlock.Text = """
                         <StackPanel
                         Margin="20"
                         HorizontalAlignment="Center"
                         VerticalAlignment="Center"
                         Spacing="8">
                         <TextBox Watermark="Default Textbox" />
                         <TextBox
                             IsEnabled="False"
                             Text="Disabled Textbox"
                             Watermark="Disabled Textbox" />
                         <TextBox Classes="Clearable">Clear</TextBox>
                         <TextBox Classes="ShowHide" PasswordChar="●">Password</TextBox>
                         <TextBox Watermark="Watermark" />
                         <TextBox UseFloatingWatermark="True" Watermark="Floating Watermark">Content</TextBox>
                         <TextBox Text="Error">
                             <DataValidationErrors.Error>
                                 <system:Exception />
                             </DataValidationErrors.Error>
                         </TextBox>
                         """;
    }
}