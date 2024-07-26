using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DTO
{
    public class userName
    {
        private string _userName;
        private string _password;
        private int _STK;
        private string _NganHang;
        public userName()
        {}
        public userName(string userName, string password, int sTK, string nganHang)
        {
            this._userName = userName;
            this._password = password;
            this._STK = sTK;
            this._NganHang = nganHang;
        }
        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public int STK
        {
            get { return _STK; }
            set { _STK = value; }
        }

        public string NganHang
        {
            get { return _NganHang; }
            set { _NganHang = value; }
        }
    }

}
