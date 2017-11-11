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
        public static List<string> BuildHashList(string algo, list<string> filelocations){
            List<string> hashedlist = new List<string>();
            if(algo.Equals("SHA")){
                foreach(var item in filelocations){
                    string hash = HashSHA(item);
                    hashedlist.Add(hash);
                }
            }
            else if(algo.Equals("MD5")){
                foreach(var item in filelocations){
                    string hash = HashMD5(item);
                    hashedlist.Add(hash);
                }
            }
            return hashedlist;
        }

        public static List<string> CompareLists(List<string> lista, List<string> listb){
            List<string> matchedlist = new List<string>();
            foreach(var item in lista){
                var result = listb.Find(item);
                if(result != null){
                    matchedlist.Add(item);
                } 
            }
            return matchedlist;
        }

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
            using (var md5 = MD5.Create())
            {
                using (var stream = File.OpenRead(filename))
                {
                    return BitConverter.ToString(md5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
                return "";
        }
    }
}
