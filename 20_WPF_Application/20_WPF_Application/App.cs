using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _20_WPF_Application
{
    public partial class App : Application
    {
        AppSettings settings = new AppSettings();

        public AppSettings Settings
        {
            get { return settings; }
            set { settings = value; }
        }
        public App()
        {
            this.Exit += Appexit;
        }
        public void Appexit(object sender, ExitEventArgs e)
        {
            settings.Save();
        }
    }
}
