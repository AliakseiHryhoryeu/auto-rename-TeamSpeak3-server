using System;
using System.Windows;
using ts3AutoUpdeteServer.DataModel;

namespace ts3AutoUpdeteServer.View
{
    /// <summary>
    /// Interaction logic for AddNewServer.xaml
    /// </summary>
    public partial class AddNewServer : Window
    {
        public AddNewServer()
        {
            InitializeComponent();
        }

        private void Button_Click_AddServer(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AddServerIdTxtbox.Text == "" ^ AddServerLoginTxtbox.Text == "" ^ AddServerPasswordTxtbox.Text == "" ^ AddServerIpTxtbox.Text == "" ^ AddServerName1Txtbox.Text == "" ^ AddServerName2Txtbox.Text == "")
                {
                    MessageBox.Show("Error");

                }
                else
                {
                    int id = Convert.ToInt32(AddServerIdTxtbox.Text);
                    string login = AddServerLoginTxtbox.Text;
                    string password = AddServerPasswordTxtbox.Text;
                    string serverip = AddServerIpTxtbox.Text;
                    string name1 = AddServerName1Txtbox.Text;
                    string name2 = AddServerName2Txtbox.Text;
                    AddDb.AddServerEf(id, login, password, serverip, name1, name2);
                    MessageBox.Show("Sucessful add new server");
                }

            }
            catch
            {
                MessageBox.Show("Error");

            }
        }
    }
}
