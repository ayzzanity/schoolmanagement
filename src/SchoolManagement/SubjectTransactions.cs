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

        public DataSet getStudentSubject(int studentID)
        {
            return (db.list("SELECT subjectcode, subjectname, lec_units, lab_units, schyear, studentsubjects.semester, grade " +
                            "FROM Students " +
                            "INNER JOIN Courses ON (Students.courseID = Courses.courseID) "+
                            "INNER JOIN Subjects ON (Subjects.courseID = Courses.courseID) "+
                            "LEFT JOIN Studentsubjects ON (Subjects.subjectID = Studentsubjects.subjectID AND Students.studentID = Studentsubjects.studentID) "+
                            "WHERE Students.studentID LIKE '" + studentID + "' "));
        }
    }
}
