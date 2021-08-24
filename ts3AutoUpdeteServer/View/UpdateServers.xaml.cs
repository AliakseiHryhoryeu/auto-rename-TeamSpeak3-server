using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows;
using ts3AutoUpdeteServer.DataModel;

namespace ts3AutoUpdeteServer.View
{
    /// <summary>
    /// Interaction logic for UpdateServers.xaml
    /// </summary>
    public partial class UpdateServers : Window
    {

        public UpdateServers()
        {
            InitializeComponent();
        }


        private readonly By _createServerButton = By.XPath("//span[text()='CREATE SERVER']");
        private readonly By _singInButton1 = By.XPath("//a[text()='Log in to panel']");
        private readonly By _singInButton2 = By.XPath("//button[text()='Login']");
        private readonly By renameServerButton = By.XPath("//button[text()='SAVE NEW NAME']");
        //private readonly By logOutButton = By.XPath("//a[text()=' Log out']");

        private readonly By renameServerInput = By.XPath("//input[@placeholder='New server name']");
        private readonly By _loginInput = By.XPath("//input[@name='email']");
        private readonly By _passwordInput = By.XPath("//input[@name='password']");

        private void Button_Click_UpdateServer(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(UpdateServerIdTxtbox.Text);
                string login = "a";
                string password = "a";
                string name1 = "a";
                string name2 = "a";
                var servers = GetDb.GetServerEf();
                foreach (var server in servers)
                {
                    if (server.ServerId == id)
                    {
                        login = server.Login;
                        password = server.Password;
                        name1 = server.Name1;
                        name2 = server.Name2;
                        break;
                    }
                }

                //driver = new ChromeDriver("D:\\3rdparty\\chrome");
                //driver.Navigate().GoToUrl("https://www.ts3.cloud/");
                //driver.Navigate().GoToUrl("https://freepanel.ts3.cloud/");
                //var singIn1 = driver.FindElement(_singInButton1);
                //singIn1.Click();


                IWebDriver driver = new ChromeDriver(@"C:\\Test\\");
                driver.Navigate().GoToUrl("https://freepanel.ts3.cloud/login.php");
                var loginTemp = driver.FindElement(_loginInput);
                var passwordTemp = driver.FindElement(_passwordInput);
                loginTemp.SendKeys(login);
                passwordTemp.SendKeys(password);
                var singIn2 = driver.FindElement(_singInButton2);
                singIn2.Click();
                var serverName = driver.FindElement(By.XPath("//h4[text()='New group token']"));
                int counter1 = 0;

                try
                {
                    string tmp = "//b[text()='" + name1 + "']";
                    serverName = driver.FindElement(By.XPath(tmp));
                    counter1 = 1;
                }
                catch { }
                try
                {
                    string tmp = "//b[text()='" + name2 + "']";
                    serverName = driver.FindElement(By.XPath(tmp));
                    counter1 = 2;

                }
                catch { }
                if (counter1 >= 1)
                {
                    if (counter1 == 1)
                    {
                        var renameServer1 = driver.FindElement(renameServerInput);
                        renameServer1.SendKeys(name2);
                        var renameServer2 = driver.FindElement(renameServerButton);
                        renameServer2.Click();
                    }
                    else
                    {
                        var renameServer1 = driver.FindElement(renameServerInput);
                        renameServer1.SendKeys(name1);
                        var renameServer2 = driver.FindElement(renameServerButton);
                        renameServer2.Click();
                    }
                }
                else
                {
                    var renameServer1 = driver.FindElement(renameServerInput);
                    renameServer1.SendKeys(name1);
                    var renameServer2 = driver.FindElement(renameServerButton);
                    renameServer2.Click();

                }
                //var logOut = driver.FindElement(logOutButton);
                //logOut.Click();
                //driver.Close();
                driver.Dispose();
                MessageBox.Show("Sucessful");


            }
            catch
            {
                MessageBox.Show("Error");

            }
        }

        private void Button_Click_UpdateAllServers(object sender, RoutedEventArgs e)
        {
            try
            {
                var servers = GetDb.GetServerEf();
                foreach (var server in servers)
                {

                    string login = server.Login;
                    string password = server.Password;
                    string name1 = server.Name1;
                    string name2 = server.Name2;


                    //driver = new ChromeDriver("D:\\3rdparty\\chrome");
                    //driver.Navigate().GoToUrl("https://www.ts3.cloud/");
                    //driver.Navigate().GoToUrl("https://freepanel.ts3.cloud/");
                    //var singIn1 = driver.FindElement(_singInButton1);
                    //singIn1.Click();

                    IWebDriver driver = new ChromeDriver(@"C:\\Test\\");
                    driver.Navigate().GoToUrl("https://freepanel.ts3.cloud/login.php");
                    var loginTemp = driver.FindElement(_loginInput);
                    var passwordTemp = driver.FindElement(_passwordInput);
                    loginTemp.SendKeys(login);
                    passwordTemp.SendKeys(password);
                    var singIn2 = driver.FindElement(_singInButton2);
                    singIn2.Click();
                    var serverName = driver.FindElement(By.XPath("//h4[text()='New group token']"));
                    int counter1 = 0;

                    try
                    {
                        string tmp = "//b[text()='" + name1 + "']";
                        serverName = driver.FindElement(By.XPath(tmp));
                        counter1 = 1;
                    }
                    catch { }
                    try
                    {
                        string tmp = "//b[text()='" + name2 + "']";
                        serverName = driver.FindElement(By.XPath(tmp));
                        counter1 = 2;

                    }
                    catch { }
                    if (counter1 >= 1)
                    {
                        if (counter1 == 1)
                        {
                            var renameServer1 = driver.FindElement(renameServerInput);
                            renameServer1.SendKeys(name2);
                            var renameServer2 = driver.FindElement(renameServerButton);
                            renameServer2.Click();
                        }
                        else
                        {
                            var renameServer1 = driver.FindElement(renameServerInput);
                            renameServer1.SendKeys(name1);
                            var renameServer2 = driver.FindElement(renameServerButton);
                            renameServer2.Click();
                        }
                    }
                    else
                    {
                        var renameServer1 = driver.FindElement(renameServerInput);
                        renameServer1.SendKeys(name1);
                        var renameServer2 = driver.FindElement(renameServerButton);
                        renameServer2.Click();

                    }
                    //var logOut = driver.FindElement(logOutButton);
                    //logOut.Click();
                    //driver.Close();
                    driver.Dispose();

                }
                MessageBox.Show("Sucessful");

            }
            catch
            {
                MessageBox.Show("Error");
            }

        }
    }
}
