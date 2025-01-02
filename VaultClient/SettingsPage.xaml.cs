namespace VaultClient
{
    public partial class SettingsPage : ContentPage
    {
        public SettingsPage()
        {
            InitializeComponent();

                if (Checkbox.IsChecked == true)
                {
                    System.Diagnostics.Debug.WriteLine("ohio enabled");
                }
                else
                {
                    System.Diagnostics.Debug.WriteLine("ohio disabled");
                }
            
        }
    }
}
