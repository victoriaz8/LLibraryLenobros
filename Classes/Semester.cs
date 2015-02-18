using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace classesForLibraryExcel
{
    class Semester
    {
        //This is the semester class that we can use to 
        //easily store an array of semesters into a student class
        //has basic getters and setters for Enrollment Units,
        //credit hours, and the name of the semester
        private static int EUnits = 0;
        private static int creditHours = 0;
        private static string semesterName = "";
        public Semester() { }
        public Semester(string semesterName1, int creditHours1, int EUnits1) {
            semesterName = semesterName1;
            creditHours = creditHours1;
            EUnits = EUnits1;
        }
        public static int getEUnits() { return EUnits; }
        public static void setEUnits(int EUnits1) { EUnits = EUnits1; }
        public static int getCreditHours() { return creditHours; }
        public static void setCreditHours(int creditHours1) { creditHours = creditHours1; }
        public static string getSemesterName() { return semesterName; }
        public static void setSemesterName(string semesterName1) { semesterName = semesterName1; }
    }
}
