using System;
using System.Windows;
using ts3AutoUpdeteServer.DataModel;

namespace ts3AutoUpdeteServer.View
{
    /// <summary>
    /// Interaction logic for SettingsProgram.xaml
    /// </summary>
    public partial class SettingsProgram : Window
    {
        public SettingsProgram()
        {
            InitializeComponent();
        }

        private void Button_Click_AutoUpdateSettings(object sender, RoutedEventArgs e)
        {
            //AddDb.AddSettingsEf(1, 600, DateTime.Now);

            try
            {
                AddDb.AddSettingsEf(1, 600, DateTime.Now);

                EditDb.EditSetingsEf(1, Convert.ToInt32(AutoUpdateSettingsTxtbox.Text));
                MessageBox.Show("Sucessful");

            }
            catch
            {
                MessageBox.Show("Error");
            }
        }


    }
}
