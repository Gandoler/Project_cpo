﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User_Interface.ExtendedTool.Connect_and_query;
using User_Interface.ExtendedTool.Connect_and_query.query;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace User_Interface.Login_page_mvp.Login_page.Model
{
    internal class ModelLogin : ImodelLogin
    {
        //
        private long _login;
        private string? _password;
        private string? _email;

        public event Action LoginGo;
        public event Action LogMismatch;
        //public event Action UserExist;

        public string Login
        {

            set
            {
                long tmp;
                try
                {
                    tmp = long.Parse(value);
                }
                catch (Exception exception)
                {
                    throw new Exception("Bad parse"+exception.Message);
                }
                if (tmp <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(value));
                }
                else
                {
                    _login = tmp;
                }
            }
        }


        public string Password
        {

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    ArgumentNullException argumentNullException = new(nameof(_login));
                    throw argumentNullException;
                }
                else
                {
                    _password = value;
                }


            }
        }

      

        public void LogInApl()
        {
            try
            {


                if (CheckExistANDRegistrUsers.CheckOFExistUser(RealConnect.Connection, _login, _password ?? throw new Exception("Bad Password")))
                {
                    
                    OTSC_ui.Properties.Settings1.Default.ID = _login;
                    LoginGo.Invoke();
                }
                else
                {
                    LogMismatch.Invoke();
                }
            }
            catch (Exception ex)
            {
                // Обработка ошибок в случае проблем с подключением
                MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine($"Ошибка при подключении: {ex.Message}");
            }

        }

        //public void Regisrt()
        //{
        //    try
        //    {


        //        if (CheckExistANDRegistrUsers.RegistrUser(RealConnect.Connection, _login, _password ?? throw new Exception("Bad Password"), _email ?? throw new Exception("Bad Email")))
        //        {
        //            Properties.Settings1.Default.ID = _login;
        //            LoginGo.Invoke();
        //        }
        //        else
        //        {
        //            LogMismatch.Invoke();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Ошибка при подключении к базе данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        Console.WriteLine($"Ошибка при подключении: {ex.Message}");
        //    }
        //}


    }
}
