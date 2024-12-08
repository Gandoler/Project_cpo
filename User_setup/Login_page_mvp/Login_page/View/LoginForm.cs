﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Interface.Login_page_mvp.Login.View.Registr;
using User_Interface.Login_page_mvp.Login_page.View;

namespace User_Interface.Login_page_mvp.View
{
    internal partial class LoginFrom : Form, ILoginView
    {
        public LoginFrom()
        {
            InitializeComponent();
            // 
            // textBoxLogin
            // 

            textBoxLoginGuna.KeyPress += (s, e) => CharKeyPresd?.Invoke(labelOnlyDigits, e);
            // 
            // textBoxPassword
            // 

            // 
            // checkBoxSWhowPsw
            // 
            checkBoxSWhowPsw.CheckedChanged += (s, e) => Show_Psw?.Invoke(this, checkBoxSWhowPsw.Checked);
            // 
            // buttonExit
            // 
            ExitButton.Click += (s, e) => ExitApl?.Invoke(this, EventArgs.Empty);
            // 
            // buttonEnter
            // 
            guna2ButtonLogin.Click += (s, e) => Enter?.Invoke(this, EventArgs.Empty);
            // 
            // registrButton
            // 
            guna2ButtonRegistr.Click += (s, e) => Registr_click?.Invoke(this, EventArgs.Empty);
            //
            // forgotPasswordLinkClcik
            //
            ForgotPasswordLink.Click += (s, e) => forgotPassworLinkClick?.Invoke();
        }

        

        public string Password => textBoxPasswordGuna.Text;

        public string Login => textBoxLoginGuna.Text;


        public event EventHandler<bool> Show_Psw;
        public event EventHandler ExitApl;
        public event EventHandler Enter;
        public event EventHandler<EventArgs> CharKeyPresd;
        public event EventHandler Registr_click;

        // for forgot password
        public event Action forgotPassworLinkClick;

        public void ClearAll()
        {
           textBoxPasswordGuna?.Clear();
           textBoxLoginGuna?.Clear();
        }

        public (string, string) CopyUserLogin()=>(textBoxLoginGuna.Text, textBoxPasswordGuna.Text); 
       

        public void NextPage()
        {
            var newPage = new RegistrForm();
            newPage.Show();
            this.Hide();
        }

        public void ShowPsw()
        {
            textBoxPasswordGuna.PasswordChar = '\0';
        }

    

        public void UnShowPsw()
        {
            textBoxPasswordGuna.PasswordChar = '*';
        }
    }
}
