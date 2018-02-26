using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    class CourseTransactions
    {
        DBTransMySQL db = new DBTransMySQL();
        DBTransactions db1 = new DBTransactions();

        public void enrollStudent(int studentID, int courseID, string admissiondate)
        {
            db.executeSql("UPDATE Students SET courseID = '" + courseID + "', admissiondate = '" + admissiondate + "' WHERE StudentID = " + studentID + " ");
        }

        public DataSet searchEnrolled(string searchValue)
        {
            return db.list("SELECT studentID AS 'Student ID', firstname AS 'First Name', middlename as 'Middle Name', lastname AS 'Last Name', age AS 'Age', gender AS 'Gender', admissiondate AS 'Admission Date', Students.courseID as 'Course ID', coursecode AS 'Course', description AS 'Description' FROM Students INNER JOIN Courses ON Students.courseID = Courses.courseID WHERE Firstname LIKE '" + searchValue + "%' OR Lastname LIKE '" + searchValue + "%' OR Middlename LIKE '" + searchValue + "%'");
        }

        public DataSet searchNotEnrolled(string searchValue)
        {
            return db.list("SELECT studentID AS 'Student ID', firstname AS 'First Name', middlename as 'Middle Name', lastname AS 'Last Name', age AS 'Age', gender AS 'Gender' FROM Students WHERE Students.courseID = 0 AND (Firstname LIKE '" + searchValue + "%' OR Lastname LIKE '" + searchValue + "%' OR Middlename LIKE '" + searchValue + "%') ");
        }

        public DataSet searchByStudentId(int studentID)
        {
            return db.list("SELECT studentID AS 'Student ID', firstname AS 'First Name', middlename as 'Middle Name', lastname AS 'Last Name', age AS 'Age', gender AS 'Gender', admissiondate AS 'Admission Date', Students.courseID as 'Course ID', coursecode AS 'Course', description AS 'Description' FROM Students INNER JOIN Courses ON Students.courseID = Courses.courseID WHERE studentID LIKE '"+studentID+"%' ");
        }

        public DataSet getCourseByCode(string coursecode)
        {
            return db.list("SELECT courseID FROM Courses WHERE coursecode = '" + coursecode + "' ");
        }

        public DataSet getCourseByDesc(string desc)
        {
            return db.list("SELECT courseID FROM Courses WHERE description LIKE '" + desc + "' ");
        }

        public DataSet getCourses()
        {
            return db.list("SELECT description from Courses");
        }
        public DataSet getEnrolledCount()
        {
            return db.list("SELECT COUNT(studentID) FROM Students INNER JOIN Courses ON Students.courseID = Courses.courseID");
        }

        public DataSet getNotEnrolledCount()
        {
            return db.list("SELECT COUNT(studentID) FROM Students WHERE Students.courseID = 0");
        }
    }
}
