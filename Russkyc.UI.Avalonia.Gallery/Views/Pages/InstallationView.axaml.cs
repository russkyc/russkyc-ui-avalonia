﻿using Avalonia.Controls;

namespace Russkyc.UI.Avalonia.Gallery.Views.Pages;

public partial class InstallationView : UserControl
{
    public InstallationView()
    {
        InitializeComponent();
        ConfigurationBlock.Text = """
                                  <Application
                                      x:Class="Russkyc.UI.Avalonia.Gallery.App"
                                      xmlns="https://github.com/avaloniaui"
                                      xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
                                      RequestedThemeVariant="Light">
                                      <!--  RequestedThemeVariant="Default" ThemeVariant follows system theme variant.  -->
                                      <!--  "Dark" or "Light" are other available options.  -->
                                      <Application.Styles>
                                          <FluentTheme />
                                      </Application.Styles>
                                      <Application.Resources>
                                          <ResourceDictionary>
                                              <ResourceDictionary.MergedDictionaries>
                                                  <!--  Theme (Customizable)  -->
                                                  <ResourceInclude Source="avares://Russkyc.UI.Avalonia/Themes/Zinc.axaml" />
                                                  <!--  Base (Required)  -->
                                                  <ResourceInclude Source="avares://Russkyc.UI.Avalonia/Base.axaml" />
                                                  <ResourceInclude Source="avares://Russkyc.UI.Avalonia/Controls.axaml" />
                                              </ResourceDictionary.MergedDictionaries>
                                          </ResourceDictionary>
                                      </Application.Resources>
                                  </Application>
                                  """;
    }
}