using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class ConnectionString
    {
        public string connString() {
            return @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=G:\Elective\DBMS Updated\SchoolDB.mdb";
        }
        public string connString2()
        {
            return @"Server=192.168.1.50;Database=school;Uid=locksystem;Pwd=adminpass;convert zero datetime=True";
        }
    }
}
