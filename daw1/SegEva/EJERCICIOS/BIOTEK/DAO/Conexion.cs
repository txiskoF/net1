﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;

namespace DAO
{
    public class Conexion
    {
        public SqlConnection cnn;

        public Conexion()
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["BiotekConnectionString"].ConnectionString);
        }

        public void abrir()
        {
            if (cnn.State == ConnectionState.Closed || cnn.State == ConnectionState.Broken)
            {
                cnn.Open();
            }
        }
        public void cerrar()
        {
            if (cnn.State == ConnectionState.Open)
            {
                cnn.Close();
            }
        }
    }
}
