﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace hastane
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
           
            SqlConnection baglan = new SqlConnection("Data Source=KEREM;Initial Catalog=Hastane;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
}
