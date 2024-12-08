﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.DBTools.Operations
{
    internal interface ISqlOperation
    {
        void Insert(string query);
        void Delete(string query);
        void Update(string query);
        void Select(string query, out DataTable results);
    }
}