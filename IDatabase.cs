﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace CNIT355_Final_Project
{
    public interface IDatabase
    {
        SQLiteConnection ConnectToDB();
    }
}
