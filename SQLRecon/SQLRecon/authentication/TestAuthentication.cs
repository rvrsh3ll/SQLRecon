﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace SQLRecon.Auth
{
    public class TestAuthentication
    {
        public SqlConnection Send(String conString, String user, String sqlServer)
        {
            SqlConnection con = new SqlConnection(conString);

            try
            {
                con.Open();
                //Console.WriteLine("[+] Success! " + user + " can log in to " + sqlServer);
                return con;
            }

            catch
            {
                Console.WriteLine("[!] Failed! " + user + " can not log in to " + sqlServer + "\n");
                Environment.Exit(0);
                return null;
            }
        } // end TestAuthentication
    }
}
