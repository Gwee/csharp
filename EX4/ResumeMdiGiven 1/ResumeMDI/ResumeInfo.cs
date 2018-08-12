using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResumeMDI
{
    class ResumeInfo
    {
        private string name, address, birth, phone;

        public ResumeInfo(string n, string a, string b, string p)
        {
            name = n;
            address = a;
            birth = b;
            phone = p;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public string Birth
        {
            get
            {
                return birth;
            }
            set
            {
                birth = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
    }
}
