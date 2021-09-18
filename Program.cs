using System;

namespace Inheritance
{
    class School
    {
        private string schoolName, schoolAddress;


        public School(string name, string address)
        {
            this.schoolName = name;
            this.schoolAddress = address;
        }
        public void printAll()
        {
            Console.WriteLine("School Name: " + schoolName);
            Console.WriteLine("School Address: " + schoolAddress);
        }


        class Student : School
        {
            private string studentName, studentAddress;
            protected int studentID;
            protected char grades;
            public Student(string name, string address, int id, char grade, string sname, string saddress) : base(sname, saddress)
            {
                this.studentName = name;
                this.studentAddress = address;
                this.studentID = id;
                this.grades = grade;
            }
            public void printAll()
            {
                base.printAll();
                Console.WriteLine("Student Name: " + studentName);
                Console.WriteLine("Student Address: " + studentAddress);
                Console.WriteLine("Student ID: " + studentID);
                Console.WriteLine("Student Grades: " + grades);

            }
        }
        static void Main(string[] args)
        {
            Student stud1 = new Student("John", "abc123", 001, 'A', "Lala High Sch", "cba321");
            stud1.printAll();
            Console.ReadLine();
        }
    }
}
