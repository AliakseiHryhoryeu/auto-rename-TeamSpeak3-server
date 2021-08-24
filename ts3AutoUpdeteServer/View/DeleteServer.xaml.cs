using System;
using System.Windows;
using ts3AutoUpdeteServer.DataModel;

namespace ts3AutoUpdeteServer.View
{
    /// <summary>
    /// Interaction logic for DeleteServer.xaml
    /// </summary>
    public partial class DeleteServer : Window
    {
        public DeleteServer()
        {
            InitializeComponent();
        }

        private void Button_Click_DeleteServer(object sender, RoutedEventArgs e)
        {
            try
            {
                DeleteDb.DeleteServer(Convert.ToInt32(DeleteServerIdTxtbox.Text));
                MessageBox.Show("Sucessful delete server");
            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
