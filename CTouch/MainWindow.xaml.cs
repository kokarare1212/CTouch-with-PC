using CefSharp;
using CefSharp.Wpf;
using System;
using System.Windows;

namespace CTouch
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CefSettings cefSettings = new CefSettings()
            {
                UserAgent = "iPad CPU OS 13_6_1 like Safari",
                CachePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\cache",
            };
            Cef.Initialize(cefSettings);
            Cef.EnableHighDPISupport();
            var browser = new ChromiumWebBrowser("https://d2.benesse.ne.jp/");
            Content = browser;
        }
    }
}
