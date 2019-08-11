using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInfo1
{
    public class PersonalInfo
    {
        public string firstName;
        public string lastName;
        public DateTime birthdate;
        public string addressLine1;
        public string addressLine2;
        public string city;
        public string state;
        public string zipcode;
        public string country;
    }

    public class TeacherInfo : PersonalInfo
    {

    }

    public class StudentInfo : PersonalInfo
    {

    }

    public class UProgramInfo
    {
        public string programeName;
        public string departmentHead;
        public string degrees;
    }

    public class DegreeInfo
    {
        public string degreeName;
        public int creditRequired;
    }

    public class CourseInfo
    {
        public string courseName;
        public int credits;
        public int durationInWeeks;
        public string teacher;
    }

    class CollegeInfo1
    {

        static void Main(string[] args)
        {
            TeacherInfo teacherInfo;
            teacherInfo = new TeacherInfo();
            teacherInfo.lastName = "Scott";
            teacherInfo.firstName = "Moley";
            teacherInfo.birthdate = new DateTime(1989, 04, 09);
            teacherInfo.addressLine1 = "12345 NE 123 ave";
            teacherInfo.addressLine2 = "";
            teacherInfo.city = "Everland";
            teacherInfo.state = "WA";
            teacherInfo.zipcode = "91234";
            teacherInfo.country = "USA";

            Console.WriteLine("Teacher Information");
            Console.WriteLine("Last name:  {0}", teacherInfo.lastName);
            Console.WriteLine("First name: {0}", teacherInfo.firstName);
            Console.WriteLine("Birthdate:  {0}", teacherInfo.birthdate);
            Console.WriteLine("Address:    {0}", teacherInfo.addressLine1);
            Console.WriteLine("            {0}", teacherInfo.addressLine2);
            Console.WriteLine("City:       {0}", teacherInfo.city);
            Console.WriteLine("State:      {0}", teacherInfo.state);
            Console.WriteLine("Zipcode:    {0}", teacherInfo.zipcode);
            Console.WriteLine("Country:    {0}\n", teacherInfo.country);


            StudentInfo studentInfo;
            studentInfo = new StudentInfo();
            studentInfo.lastName = "McDonald";
            studentInfo.firstName = "Challotte";
            studentInfo.birthdate = new DateTime(2000, 11, 05);
            studentInfo.addressLine1 = "54321 NE 789 pl";
            studentInfo.addressLine2 = "Apt. #3";
            studentInfo.city = "Almond";
            studentInfo.state = "WA";
            studentInfo.zipcode = "91335";
            studentInfo.country = "USA";

            Console.WriteLine("Student Information");
            Console.WriteLine("Last name:  {0}", studentInfo.lastName);
            Console.WriteLine("First name: {0}", studentInfo.firstName);
            Console.WriteLine("Birthdate:  {0}", studentInfo.birthdate);
            Console.WriteLine("Address:    {0}", studentInfo.addressLine1);
            Console.WriteLine("            {0}", studentInfo.addressLine2);
            Console.WriteLine("City:       {0}", studentInfo.city);
            Console.WriteLine("State:      {0}", studentInfo.state);
            Console.WriteLine("Zipcode:    {0}", studentInfo.zipcode);
            Console.WriteLine("Country:    {0}\n", studentInfo.country);


            UProgramInfo uProgramInfo;
            uProgramInfo = new UProgramInfo();
            uProgramInfo.programeName = "Computer Science";
            uProgramInfo.departmentHead = "Maria Callas";
            uProgramInfo.degrees = "Master";

            Console.WriteLine("UProgram Information");
            Console.WriteLine("Program Name:      {0}", uProgramInfo.programeName);
            Console.WriteLine("Department Head:   {0}", uProgramInfo.departmentHead);
            Console.WriteLine("Degrees:	          {0}\n", uProgramInfo.degrees);

            DegreeInfo degreeInfo;
            degreeInfo = new DegreeInfo();
            degreeInfo.degreeName = "Master";
            degreeInfo.creditRequired = 30;

            Console.WriteLine("Degree Information");
            Console.WriteLine("Degree Name:       {0}", degreeInfo.degreeName);
            Console.WriteLine("Credit Required:   {0}\n", degreeInfo.creditRequired);

            CourseInfo courseInfo;
            courseInfo = new CourseInfo();
            courseInfo.courseName = "Non-linear Programming";
            courseInfo.credits = 3;
            courseInfo.durationInWeeks = 4;
            courseInfo.teacher = "Challotte MacDonald";

            Console.WriteLine("Course Information");
            Console.WriteLine("Course Name:       {0}", courseInfo.courseName);
            Console.WriteLine("Credits:           {0}", courseInfo.credits);
            Console.WriteLine("Duration in Weeks: {0}", courseInfo.durationInWeeks);
            Console.WriteLine("Teacher:           {0}\n", courseInfo.teacher);
        }
    }
}


