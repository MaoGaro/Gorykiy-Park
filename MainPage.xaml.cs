using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Прокат
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void EnterButtonClick(object sender, RoutedEventArgs e)
        {
            var currentData = AppDataClass.dataBase.Пользователи.FirstOrDefault(u => u.Логин == loginBox.Text && u.Пароль == passwordBox.Text);

            if (currentData != null)
            {
                NavigationService.Navigate(new WorkPage());
        }
            else
            {
                MessageBox.Show("Данного пользователя нет в базе");
            }
}
    }
}
