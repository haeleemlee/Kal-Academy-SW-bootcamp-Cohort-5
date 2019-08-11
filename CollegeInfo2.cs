using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeInfo2
{
    public class PersonalInfo
    {
        public string firstName;
        public string lastName;
        public string birthday;
        public string addressLine1;
        public string addressLine2;
        public string city;
        public string state;
        public string zipcode;
        public string country;

        public void validateBirthday()
        {
            throw new NotImplementedException();
        }
    }

    public class TeacherInfo : PersonalInfo
    {
        public void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's birthday: ");
            birthday = Console.ReadLine();
            Console.WriteLine("Enter the teacher's address: ");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's address(such as apt#):");
            addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the teacher's city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter the teacher's state: ");
            state = Console.ReadLine();
            Console.WriteLine("Enter the teacher's zipcode: ");
            zipcode = Console.ReadLine();
            Console.WriteLine("Enter the student's country: ");
            country = Console.ReadLine();
        }

        public void PrintTeacherDetails()
        {
            Console.WriteLine($"Teacher {firstName} {lastName} was born on: {birthday}");
            Console.WriteLine($"And lives on {addressLine1} {addressLine2}, {city}, {state} {zipcode}, {country} \r\n");
        }

    }

    public class StudentInfo : PersonalInfo
    {
        public void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Enter the student's birthday: ");
            birthday = Console.ReadLine();
            Console.WriteLine("Enter the student's address: ");
            addressLine1 = Console.ReadLine();
            Console.WriteLine("Enter the student's address(such as apt#):");
            addressLine2 = Console.ReadLine();
            Console.WriteLine("Enter the student's city: ");
            city = Console.ReadLine();
            Console.WriteLine("Enter the student's state: ");
            state = Console.ReadLine();
            Console.WriteLine("Enter the student's zipcode: ");
            zipcode = Console.ReadLine();
            Console.WriteLine("Enter the student's country: ");
            country = Console.ReadLine();
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine($"Student {firstName} {lastName} was born on: {birthday}");
            Console.WriteLine($"And lives on {addressLine1} {addressLine2}, {city}, {state} {zipcode}, {country} \r\n");
        }
    }

    public class UProgramInfo
    {
        public string programName;
        public string departmentHead;
        public string degrees;

        public void GetUProgramInformation()
        {
            Console.WriteLine("Enter name of the program : ");
            programName = Console.ReadLine();
            Console.WriteLine("Enter name of the department Head: ");
            departmentHead = Console.ReadLine();
            Console.WriteLine("Enter name of the degrees: ");
            degrees = Console.ReadLine();
        }

        public void PrintUProgramDetails()
        {
            Console.WriteLine($"Program {programName}");
            Console.WriteLine($"Head of Department is {departmentHead}");
            Console.WriteLine($"This program provide {degrees} degree \r\n");
        }
    }

    public class DegreeInfo
    {
        public string degreeName;
        public int creditRequired;

        public void GetDegreeInformation()
        {
            Console.WriteLine("Enter name of the Degree : ");
            degreeName = Console.ReadLine();
            Console.WriteLine("Enter the number of credits required: ");
            creditRequired = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintDegreeDetails()
        {
            Console.WriteLine($"{degreeName} degree requires {creditRequired} credits \r\n");
        }
    }

    public class CourseInfo
    {
        public string courseName;
        public int credits;
        public int durationInWeeks;
        public string teacher;

        public void GetCourseInformation()
        {
            Console.WriteLine("Enter name of the course : ");
            courseName = Console.ReadLine();
            Console.WriteLine("Enter number of credits of the course: ");
            credits = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter duration in weeks of the course: ");
            durationInWeeks = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name of the teacher: ");
            teacher = Console.ReadLine();
        }
        public void PrintCourseDetails()
        {
            Console.WriteLine($"You can earn {credits} from the Course {courseName} for {durationInWeeks} weeks");
            Console.WriteLine($"Teacher of the course is {teacher} \r\n");
        }
    }

    class CollegeInfo2
    {
        static void Main(string[] args)
        {
            TeacherInfo teacherInfo;
            teacherInfo = new TeacherInfo();
            teacherInfo.GetTeacherInformation();
            teacherInfo.PrintTeacherDetails();

            StudentInfo studentInfo;
            studentInfo = new StudentInfo();
            studentInfo.GetStudentInformation();
            studentInfo.PrintStudentDetails();

            UProgramInfo uprogramInfo;
            uprogramInfo = new UProgramInfo();
            uprogramInfo.GetUProgramInformation();
            uprogramInfo.PrintUProgramDetails();

            DegreeInfo degreeInfo;
            degreeInfo = new DegreeInfo();
            degreeInfo.GetDegreeInformation();
            degreeInfo.PrintDegreeDetails();

            CourseInfo courseInfo;
            courseInfo = new CourseInfo();
            courseInfo.GetCourseInformation();
            courseInfo.PrintCourseDetails();

            //Exceptions 
            teacherInfo.validateBirthday();

        }
    }
}


