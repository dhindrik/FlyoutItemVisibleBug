﻿namespace FlyoutItemVisibleBug
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            BindingContext = new AppShellViewModel();
        }
    }
}
