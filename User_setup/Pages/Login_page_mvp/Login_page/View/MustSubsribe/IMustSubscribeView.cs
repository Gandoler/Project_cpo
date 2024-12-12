﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Pages.Login_page_mvp.Login_page.View.MustSubsribe
{
    internal interface IMustSubscribeView
    {
        //exit button
        event Action ExitButtonClick;
        event Action ExitButtonEntered;
        event Action ExitButtonLeavd;

        //tg button
        event Action TgBotButtonClickClick;


        //code Field
        event EventHandler<EventArgs> CodeFieldTextChenged;
        event Action LeaveCodeField;


        //enter code button
        event Action CodeEnterButtonClciked;




        void MakeErrorImageVisibleTrue();
        void MakeErrorImageVisibleFalse();
        void MakeEnterCodeButtonEnable();
        void MakeEnterCodeEnterButtonDisable();
        void MakeExitButtonForeRed();
        void MakeExitButtonForeBlack();

    }
}
