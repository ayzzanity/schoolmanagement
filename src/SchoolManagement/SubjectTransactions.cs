using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class SubjectTransactions
    {
        DBTransMySQL db = new DBTransMySQL();
        public DataSet getSubjects(string course, string year, string sem)
        {
            return (db.list("SELECT * FROM Subjects INNER JOIN Courses ON Subjects.courseID = Courses.courseID WHERE subjects.courseID LIKE '" + course + "%' AND yearlevel LIKE '"+year+"%' AND semester LIKE '"+sem+"%' "));
        }
    }
}
