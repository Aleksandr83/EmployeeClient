// Copyright (c) 2021 Lukin Aleksandr
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeClient.Data.Types
{
    public class ConnectionString
    {
        private Func<String, String> _PasswordDecoder;

        public String Server    { get; private set; }
        public String Database  { get; private set; }
        public String Login     { get; private set; }
        public String Password  { get; private set; }
        public bool IsPasswordDecode    { get; set; }


        public ConnectionString
            (String server, String database, String login, string password)
        {
            Server = server;
            Database = database;
            Login = login;
            Password = password;
        }

        private Func<String, String> GetPasswordDecoder() => _PasswordDecoder;
        void SetPasswordDecoder(Func<String, String> decoder)
        {
            _PasswordDecoder = decoder;
        }

        public string ToMSSQL()
        {
            return String.Format
                (
                    "Data Source={0};" +
                    "Initial Catalog={1};" +
                    "User id={2};" +
                    "Password={3};",
                    Server,
                    Database,
                    Login,
                    IsPasswordDecode ? GetPasswordDecoder().Invoke(Password) : Password
                );
        }

    }
}
