﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Login_page_mvp.ForgotPasswordPage.View.ChangePassword
{
    internal interface IViewChangePasswod
    {

        public void MakeCloseButtonRed();
        public void MakeCloseButtonBlack();
        public void ClearPasswords();
        public void EnablepasswordSField();
        public void DisablepasswordSField();

        public void MakeVisibleErrorLable();
        public void MakeNotVisibleErrorLable();


        //fields
        event EventHandler<string> LeaveCodeField;
        event Action EnterInPassswordsFields;

        // save new password button
        event EventHandler<(string, string)> Save_New_Password_buttonClick;

        //exit button
        event Action ExitForgotpageButtonClick;
        event EventHandler<Color> ExitButtonEntered;
        event EventHandler<Color> ExitButtonLeavd;

        //Back button
        event Action GoBackButtonCLick;

    }
}
