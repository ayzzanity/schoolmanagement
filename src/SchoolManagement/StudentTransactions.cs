using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace SchoolManagement
{
    class StudentTransactions
    {
        DBTransMySQL db = new DBTransMySQL();
        DBTransactions db1 = new DBTransactions();

        public DataSet search(string firstname, string lastname)
        {
            return db.list("SELECT * FROM Students WHERE Firstname LIKE '" + firstname + "%' AND Lastname LIKE '" + lastname + "%'");
        }

        public DataSet search(string searchValue)
        {
            return db.list("SELECT studentID AS 'Student ID', firstname AS 'First Name', middlename as 'Middle Name', lastname AS 'Last Name', age AS 'Age', gender AS 'Gender', admissiondate AS 'Admission Date', Students.courseID as 'Course ID' FROM Students WHERE Firstname LIKE '" + searchValue  + "%' OR Lastname LIKE '" + searchValue  + "%' OR Middlename LIKE '" + searchValue + "%'");
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

        public DataSet getStudentCount()
        {
            return db.list("SELECT COUNT(studentID) FROM Students");
        }
        
    }
}
