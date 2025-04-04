﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BookHaven_Bookstore_Management_System.Helpers
{
    public static class SecurityHelper
    {
       public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }

        public static bool VerifyPasswordHash(string password, string passwordHash)
        {
            string hashedPassword = HashPassword(password);
            return hashedPassword == passwordHash;
        }
    }
}
