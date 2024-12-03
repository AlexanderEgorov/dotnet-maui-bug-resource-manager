using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace DXMauiApp;

public partial class MainPage : ContentPage {
    public MainPage() {
        InitializeComponent();
        r = CreateResourceManager();
        label.Text = r.GetString(StringId.SimpleString);
    }

    ResourceManager r;
    ResourceManager CreateResourceManager() => new ResourceManager("DXMauiApp.Resources.Strings.AppResources", typeof(MainPage).Assembly);
    void ChangeCulture() {
        var culture = CultureInfo.CurrentCulture == fr ? en : fr;
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentUICulture = culture;
    }
    void OnClicked(object sender, EventArgs e) {
        ChangeCulture();
        label.Text =  r.GetString(StringId.SimpleString);
    }

    static readonly CultureInfo en = new CultureInfo("en-us");
    static readonly CultureInfo fr = new CultureInfo("fr-FR");
}
public static class StringId {
    public const string SimpleString = nameof(SimpleString);
    public const string ParameterizedString = nameof(ParameterizedString);
}