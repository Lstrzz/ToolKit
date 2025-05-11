using Hardcodet.Wpf.TaskbarNotification;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace ToolKit
{
    internal class Classes
    {
        public ICommand SettingsCommand => new RelayCommand(
        () =>
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        });


        public ICommand ExitCommand => new RelayCommand(
            () => Application.Current.Shutdown());
    }
}
