﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccess
{
    public class BaseRepository
    {
        protected IDbConnection con;

        public BaseRepository()
        {
            string connectString = "Data Source=VUDUCTRUNG\\MSSQLSERVER02;Initial Catalog=QLNV;Integrated Security=True";
            con = new SqlConnection(connectString);
        }
    }
}
