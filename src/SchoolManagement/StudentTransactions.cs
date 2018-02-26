using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace WindowsFormsApplication2
{
    class StudentTransactions
    {
        DBTransactions db = new DBTransactions();
        public DataSet search(string firstname, string lastname)
        {
            return db.list("SELECT * FROM Students WHERE Firstname LIKE '" + firstname + "%' AND Lastname LIKE '" + lastname + "%'");
        }

        public DataSet search(string searchValue)
        {
            return db.list("SELECT * FROM Students WHERE Firstname LIKE '" + searchValue  + "%' OR Lastname LIKE '" + searchValue  + "%' OR Middlename LIKE '" + searchValue + "%'");
        }

        public DataSet getStudentByID(int studentID)
        {
            return db.list("SELECT * FROM Students WHERE StudentID = " + studentID);
        }

        public void insertStudent(string firstname, string middlename, string lastname, int age, string gender)
        {
            db.executeSql("INSERT INTO Students (Firstname, Middlename, Lastname, Age, Gender) VALUES ('" + firstname  + "', '" + middlename  + "', '" + lastname  + "', " + age + ", '" + gender  + "')");
        }

        public void updateStudent(int studentID, string firstname, string middlename, string lastname, int age, string gender)
        {
            db.executeSql("UPDATE Students SET Firstname = '" + firstname + "', Middlename = '" + middlename + "', Lastname = '" + lastname + "', Age = " + age + ", Gender = '" + gender + "' WHERE StudentID = " + studentID + "");
        }
        public void deleteStudent(int studentID)
        {
            db.executeSql("DELETE FROM Students WHERE StudentID = " + studentID + "");
        }

        public void enrollStudent(int studentID, string course, string admissiondate)
        {
            db.executeSql("UPDATE Students SET Course = '" + course + "', Admissiondate = '" + admissiondate + "' WHERE StudentID = " + studentID + " ");
        }

        public DataSet checkNotEnrolled(string searchVal)
        {
            return(db.list("SELECT * FROM Students WHERE Firstname LIKE '" + searchVal + "%' OR Lastname LIKE '" + searchVal + "%' AND Course = 'BS %' "));
        }
    }
}
