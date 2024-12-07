﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Interface.Login_page_mvp.Registr_page.View
{
    internal interface IRegistrView
    {
        string Login { get; }
        string Email { get; }
        string Password { get; }
        string ConfirmPassword { get; }
        event EventHandler ExitApl;
        event EventHandler<string> leaveLEmailTextBox;
        event EventHandler<string> leavePasswordTextBox;
        event EventHandler<string> leaveSecondPasswordTextBox;
        event EventHandler<string> leaveLoginTextBox;
        event EventHandler<bool> show_Psw;
        event EventHandler enter;
        event EventHandler<EventArgs> charKeyPresd;


        void ShowPasswordMismatchMessageBox(string message);
        void ClearPasswords();
        void BlockSecPsw();
        void UnBlockSecPsw();

        void ShowPsw();
        void UnShowPsw();
    }
}
