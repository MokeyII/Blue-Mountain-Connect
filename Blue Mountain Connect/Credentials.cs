﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blue_Mountain_Connect
{
    public class Credentials
    {
        //Salt
        public string salt = "abc1@3$5^7*9)-+xyz";

        //Generate Random Salt, Not currently being used!
        public String GenSalt(int size)
        {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }
        
        // Generate Hash
        public String GenHash(String input, String salt)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            System.Security.Cryptography.SHA256Managed sha256hashstring =
                new System.Security.Cryptography.SHA256Managed();
            byte[] hash = sha256hashstring.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

        // Getter and Setter for credentials
        public string Username { get; set; }
        public string Password { get; set; }
    }
}