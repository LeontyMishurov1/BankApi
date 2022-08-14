﻿using System;
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

namespace BankClient
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        Repository repository = new();
        /// <summary>
        /// регистрация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        // обращаться к асинхронному методу мы можем из асинхронного метода
        private async void btnRegistr_Click(object sender, RoutedEventArgs e)
        {

            await repository.Registration(tbLogin.Text, tbPassword.Text);
            await repository.Authorization(tbLogin.Text, tbPassword.Text);
            //await repository.Registration(tbLogin.Text, tbPassword.Text);
        }
        /// <summary>
        /// авторизация
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAuthorization_Click(object sender, RoutedEventArgs e)
        {
            await repository.Authorization(tbLogin.Text, tbPassword.Text);
        }
    }
}
