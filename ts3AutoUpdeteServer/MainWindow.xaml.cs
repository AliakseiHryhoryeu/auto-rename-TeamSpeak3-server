using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Windows;
using System.Windows.Threading;
using ts3AutoUpdeteServer.DataModel;
using ts3AutoUpdeteServer.View;

namespace ts3AutoUpdeteServer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly By _createServerButton = By.XPath("//span[text()='CREATE SERVER']");
        private readonly By _singInButton1 = By.XPath("//a[text()='Log in to panel']");
        private readonly By _singInButton2 = By.XPath("//button[text()='Login']");
        private readonly By renameServerButton = By.XPath("//button[text()='SAVE NEW NAME']");
        //private readonly By logOutButton = By.XPath("//a[text()=' Log out']");

        private readonly By renameServerInput = By.XPath("//input[@placeholder='New server name']");
        private readonly By _loginInput = By.XPath("//input[@name='email']");
        private readonly By _passwordInput = By.XPath("//input[@name='password']");

        public int secondsCount = 0;
        public bool autoUpdateStart = false;

        public int tmpCount1 = 0;
        public int tmpCount2 = 0;
        public int tmpCount3 = 0;


        public MainWindow()
        {
            InitializeComponent();
            UpdateServers();
            DispatcherTimer disTmr = new DispatcherTimer();
            disTmr.Tick += new EventHandler(disTmr_Tick);
            disTmr.Tick += new EventHandler(UpdateServerTimer);
            disTmr.Interval = new TimeSpan(0, 0, 1);
            disTmr.Start();


        }
        public void disTmr_Tick(object sender, EventArgs e)
        {
            secondsCount++;
            secondsBlock.Text = secondsCount + " Seconds";
        }

        public void UpdateServerTimer(object sender, EventArgs e)
        {
            if (autoUpdateStart)
            {
                while (secondsCount == tmpCount1 | secondsCount == tmpCount2 | secondsCount == tmpCount3)
                {
                    UpdateServer1();
                    break;
                }
            }


        }
        private void UpdateServers()
        {
            dgTableServers.Items.Clear();
            var servers = GetDb.GetServerEf();
            foreach (var server in servers)
            {
                Server temp1 = new Server();
                temp1.ServerId = server.ServerId;
                temp1.Login = server.Login;
                temp1.Password = server.Password;
                temp1.ServerIp = server.ServerIp;
                temp1.Name1 = server.Name1;
                temp1.Name2 = server.Name2;
                temp1.DateUpdate = server.DateUpdate;
                dgTableServers.Items.Add(temp1);
            }
        }


        private void Button_Click_Run(object sender, RoutedEventArgs e)
        {
            UpdateServers updateServers = new UpdateServers();
            updateServers.Show();
        }

        private void Button_Click_Add(object sender, RoutedEventArgs e)
        {
            AddNewServer addNewServer = new AddNewServer();
            addNewServer.Show();
        }

        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {
            EditServer editServer = new EditServer();
            editServer.Show();
        }

        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            DeleteServer deleteServer = new DeleteServer();
            deleteServer.Show();
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            UpdateServers();
        }
        private void Button_Click_Settings(object sender, RoutedEventArgs e)
        {
            SettingsProgram settingsProgram = new SettingsProgram();
            settingsProgram.Show();
        }
        private void Button_Click_Info(object sender, RoutedEventArgs e)
        {
            InfoPage infoPage = new InfoPage();
            infoPage.Show();
        }

        private void Button_Click_Start(object sender, RoutedEventArgs e)
        {
            try { AddDb.AddSettingsEf(1, 600, DateTime.Now); } catch { }
            if (autoUpdateStart)
            {
                autoUpdateStart = false;
            }
            else
            {
                autoUpdateStart = true;

                int timeAutoUpdate = GetDb.GetSettingsEf(1);
                tmpCount1 = secondsCount + timeAutoUpdate + 10;
                tmpCount2 = secondsCount + timeAutoUpdate + 10;
                tmpCount3 = secondsCount + timeAutoUpdate + 10;

            }


        }


        private void UpdateServer1()
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

            }
            catch
            {
            }

        }

    }
}
