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

        private void saveButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("saved");
        }
    }
}
