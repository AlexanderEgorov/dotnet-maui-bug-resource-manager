﻿using Microsoft.Maui.Controls;

namespace DXMauiApp;

public partial class App : Application {
    public App() {
        InitializeComponent();

        MainPage = new AppShell();
    }
}
