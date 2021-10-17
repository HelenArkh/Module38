﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Module38.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        // Константа для текста кнопки
        public const string BUTTON_TEXT = "Войти";
        // Переменная счетчика
        public static int loginCouner = 0;

        public LoginPage()
        {
            InitializeComponent();

            // Изменяем внешний вид кнопки для Windows-версии
            if (Device.RuntimePlatform == Device.UWP)
                loginButton.CornerRadius = 0;
        }

        /// <summary>
        /// По клику обрабатываем счётчик и выводим разные сообщения
        /// </summary>
        private void Login_Click(object sender, EventArgs e)
        {
            if (loginCouner == 0)
            {
                // Если первая попытка - просто меняем сообщения
                loginButton.Text = $"Выполняется вход..";
            }
            else if (loginCouner > 5) // Слишком много попыток - показываем ошибку
            {
                // Деактивируем кнопку
                loginButton.IsEnabled = false;
                
                var infoMessage = (Label)stackLayout.Children.Last();
                infoMessage.Text = "Слишком много попыток! Попробуйте позже";
                // задаем красный цвет сообщения
                infoMessage.TextColor = Color.FromRgb(255, 0, 0);
            }
            else
            {
                // Изменяем текст кнопки и показываем количество попыток входа
                loginButton.Text = $"Выполняется вход...   Попыток входа: {loginCouner}";
            }

            // Увеличиваем счетчик
            loginCouner += 1;
        }
    }
}