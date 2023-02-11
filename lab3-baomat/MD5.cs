using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace lab3_baomat
{
    class MEthod
    {
        public string conversion(string input)
        {
            //Tao doi tuong su dung MD5
            MD5 conver = MD5.Create();
            //chuyen doi tu chuoi input qua mot mang byte va tinh toan băm
            byte[] data = conver.ComputeHash(Encoding.Default.GetBytes(input));
            //khoi tao mot StringBuilder de duyet cac byte 
            //va tao chuoi moi
            StringBuilder build = new StringBuilder();
            //duyet qua cac byte trong chuoi băm
            //chuyen ve dang thap luc phan
            for (int i = 0; i < data.Length; i++)
            {
                build.Append(data[i].ToString("x2"));
            }
            //tra ve chuoi thap luc phan da duoc ma hoa
            return build.ToString();
        }


    }
}
