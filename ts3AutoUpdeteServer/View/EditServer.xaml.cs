using System;
using System.Windows;
using ts3AutoUpdeteServer.DataModel;

namespace ts3AutoUpdeteServer.View
{
    /// <summary>
    /// Interaction logic for EditServer.xaml
    /// </summary>
    public partial class EditServer : Window
    {
        public EditServer()
        {
            InitializeComponent();
        }

        private void Button_Click_EditServer(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(EditServerIdTxtbox.Text);
                string login = EditServerLoginTxtbox.Text;
                string password = EditServerPasswordTxtbox.Text;
                string serverip = EditServerIpTxtbox.Text;
                string name1 = EditServerName1Txtbox.Text;
                string name2 = EditServerName2Txtbox.Text;
                EditDb.EditServerEf(id, login, password, serverip, name1, name2);
                MessageBox.Show("Sucessful edit server");
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
