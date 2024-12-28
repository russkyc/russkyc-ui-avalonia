using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class CardView : UserControl
{
    public CardView()
    {
        InitializeComponent();
        CodeBlock.Text = """
                         <Border Classes="Card"
                                 Margin="20"
                                 Width="350"
                                 VerticalAlignment="Center"
                                 Background="{DynamicResource BackgroundBrush}"
                                 BoxShadow="0 3 4 2 #EFEFEF">
                             <StackPanel Spacing="7">
                                 <StackPanel Margin="0,0,0,16">
                                     <TextBlock Text="Login" FontSize="24" FontWeight="Bold"/>
                                     <TextBlock FontSize="16" Foreground="#3F3F3F" Text="Login or sign-up to an account"/>
                                 </StackPanel>
                                 <TextBox Watermark="Username"/>
                                 <TextBox Watermark="Password" PasswordChar="•" Classes="ShowHide">Password</TextBox>
                                 <Button Margin="0,16,0,0" HorizontalAlignment="Stretch" Content="Login" />
                                 <Button HorizontalAlignment="Stretch" Classes="Ghost" Content="Create Account" />
                             </StackPanel>
                         </Border>
                         """;
    }
}