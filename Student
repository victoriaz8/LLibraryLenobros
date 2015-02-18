using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classesForLibraryExcel
{
    class Student {
        //this Student class holds a GWid as a string, 
        //the name of the student, and an arraylist of 
        //the semesters that the student is taking, based
        //on how we implement the program, we can either add
        //a whole arraylist of semester at a time, or add them one
        //at a time
        private static string GWid = "";
        private static string studentName = "";
        private static ArrayList studentSemesters = new ArrayList();
        public Student(string GWid1, string studentName1, ArrayList studentSemester1) {
            GWid = GWid1;
            studentName = studentName1;
            studentSemesters = studentSemester1;
        }
        public Student() { }
        public static string getGWid() { return GWid; }
        public static void setGWid(string GWid1) { GWid = GWid1; }
        public static string getStudentName() { return studentName; }
        public static void setStudentName(string studentName1) { studentName = studentName1; }
        public static ArrayList getStudentSemesters() { return studentSemesters; }
        public static void setStudentSemesters(ArrayList studentSemester1) { studentSemesters = studentSemester1; }
        public static void setSingleSemester(Semester singleSemester) { studentSemesters.Add(singleSemester); }
    }
}
