/*
Hashing for files
*/

using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Security.Cryptography;
using System.Collections.Generic;
using System.Management.Automation;

namespace FalconOrchestrator.Forensics
{
    public class FileHashing
    {
        public static string HashSHA(string filename)
        {
            byte[] bytes = new UTF8Encoding().GetBytes(filename);
            byte[] hashBytes;
            using (SHA512 algorithm = new SHA512Managed())
            {
                using (var stream = File.OpenRead(filename))
                {
                    hashBytes = algorithm.ComputeHash(bytes);
                }
            }
            return Convert.ToBase64String(hashBytes);
        }

        public static string HashMD5(string filename)
        {
            return "";
        }
    }
}
