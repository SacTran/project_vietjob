using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace du_an1
{
    class Contact
    {
        string ho;
        string ten;
        string diachi;
        string sodt;
        public Contact(string ho, string ten, string diachi, string sodt)
        {
            this.ho = ho;
            this.ten =ten;
            this.diachi = diachi;
            this.sodt = sodt;
        }
        public void SetHo(string ho)
        {
            this.ho = ho;
        }
        public string GetHo()
        {
            return this.ho;
        }
        public void SetTen(string ten)
        {
            this.ten = ten;
        }
        public string GetTen()
        {
            return this.ten;
        }
        public void SetDiachi(string diachi)
        {
            this.diachi = diachi;
        }
        public string GetDiachi()
        {
            return this.diachi;
        }
        public void SetSodt(string sodt)
        {
            this.sodt = sodt;
        }
        public string GetSodt()
        {
            return this.sodt;
        }
    }
}
