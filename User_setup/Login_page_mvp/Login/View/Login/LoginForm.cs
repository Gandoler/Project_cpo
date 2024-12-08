﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using User_Interface.Login_page_mvp.Login.View;
using User_Interface.Login_page_mvp.Login.View.Registr;


namespace User_Interface.Login_page_mvp.View
{
    internal partial class formLogin : Form, ILoginView
    {
        public formLogin()
        {
            InitializeComponent();
            // 
            // textBoxLogin
            // 
            textBoxLoginGuna.Leave += (s, e) => LeaveLoginTextBox?.Invoke(this, textBoxLoginGuna.Text);
            textBoxLoginGuna.KeyPress += (s, e) => CharKeyPresd?.Invoke(labelOnlyDigits, e);
            // 
            // textBoxPassword
            // 
            textBoxPasswordGuna.Leave += (s, e) => LeavePasswordTextBox?.Invoke(this, textBoxPasswordGuna.Text);
            textBoxPasswordGuna.KeyDown += (s, e) => LeavePasswordTextBox?.Invoke(this, textBoxPasswordGuna.Text);

            // 
            // textBoxSecPasswordT
            // 
            //textBoxSecPasswordT_def.Leave += (s, e) => leaveSecondPasswordTextBox?.Invoke(this, textBoxSecPasswordT_def.Text);
            //textBoxSecPasswordT_def.KeyDown += (s, e) => leaveSecondPasswordTextBox?.Invoke(this, textBoxSecPasswordT_def.Text);
            // 
            // checkBoxSWhowPsw
            // 
            checkBoxSWhowPsw.CheckedChanged += (s, e) => Show_Psw?.Invoke(this, checkBoxSWhowPsw.Checked);
            // 
            // buttonExit
            // 
            buttonExit.Click += (s, e) => ExitApl?.Invoke(this, EventArgs.Empty);
            // 
            // buttonEnter
            // 
            guna2ButtonLogin.Click += (s, e) => Enter?.Invoke(this, EventArgs.Empty);
            // 
            // registrButton
            // 
            guna2ButtonRegistr.Click += (s, e) => Registr_click?.Invoke(this, EventArgs.Empty);
        }

        

        public string Password => textBoxPasswordGuna.Text;
        //public string ConfirmPassword => textBoxSecPasswordT_def.Text;

        public string Login => textBoxLoginGuna.Text;

        public event EventHandler<string> LeavePasswordTextBox;
        public event EventHandler<bool> Show_Psw;
        public event EventHandler ExitApl;
        public event EventHandler<string> leaveSecondPasswordTextBox;
        public event EventHandler<string> LeaveLoginTextBox;
        public event EventHandler Enter;
        public event EventHandler<EventArgs> CharKeyPresd;
        public event EventHandler Registr_click;

        public void NextPage()
        {
            var newPage = new RegistrForm();
            newPage.Show();
            this.Hide();
        }



        //public void BlockSecPsw()
        //{
        //    textBoxSecPasswordT_def.Enabled = false;
        //}



        //public void ClearPasswords()
        //{
        //    textBoxPassword_def.Text = "";
        //    textBoxSecPasswordT_def.Text = "";

        //}

        //public void ShowPasswordMismatchMessageBox(string message)
        //{
        //    MessageBox.Show(message, "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //}

        public void ShowPsw()
        {
            //textBoxSecPasswordT_def.UseSystemPasswordChar = false;
            textBoxPasswordGuna.PasswordChar = '\0';

        }

        //public void UnBlockSecPsw()
        //{
        //    textBoxSecPasswordT_def.Enabled = true;
        //}

        public void UnShowPsw()
        {
            //textBoxSecPasswordT_def.UseSystemPasswordChar = true;
            textBoxPasswordGuna.PasswordChar = '*';

        }

        private void formLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
