﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Login_page_mvp.ForgotPasswordPage.Model.SendCodeModel.CodeGenerate
{
    internal class CodeGenerator : ICodeGenerator
    {

        public string GenerateCode()
        {
            return new Random().Next(100000,999999).ToString();
        }
    }
}
