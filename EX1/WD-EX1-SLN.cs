using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Student
    {
        protected string name;
        protected string adress;

        public Student(string name, string adress)
        {
            this.name = name;
            this.Address = Address;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return adress; }
            set { adress = value; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Adress: {1}", name, adress);
        }
    }

    class AdultStudent : Student
    {
        private int birth;

        public AdultStudent(string name, string address, int birth)
            : base(name, address)
        {
            this.birth = birth;
        }

        public override string ToString()
        {
            return base.ToString() +  string.Format("Birth: {0}", birth.ToString());
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;

            AdultStudent s = (AdultStudent)obj;
            if (this.name.Equals(s.name) &&
                this.adress.Equals(s.adress) &&
                this.birth == s.birth) return true;

            return false;
        }
    }

    class FlowerStudent : Student
    {
        private int schoolClass;
        private string school;

        public FlowerStudent(string name, string address, int schoolClass, string school)
    : base(name, address)
        {
            this.schoolClass = schoolClass;
            this.school = school;
        }

        public override string ToString()
        {
            return base.ToString() +  string.Format("Class: {0}, School: {1}", schoolClass.ToString(), school);
        }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (this.GetType() != obj.GetType()) return false;

            FlowerStudent f = (FlowerStudent)obj;
            if (this.name.Equals(f.name) &&
                this.adress.Equals(f.adress) &&
                this.schoolClass == f.schoolClass &&
                this.school.Equals(f.school)) return false;

            return true;
        }
    }

    class Course
    {
        private string name;
        private string teacher;
        private Student[] students;
        private int counter;

        public Course(string name, string teacher)
        {
            this.name = name;
            this.teacher = teacher;

            students = new Student[30];
        }

        public bool IsRegisterd(Student s)
        {
            for(int i=0; i<counter; i++)
            {
                if (students[i].Equals(s))
                    return true;
            }

            return false;
        }

        public bool Register(Student s)
        {
            if (IsRegisterd(s))
                return false;

            if (counter < students.Length)
            {
                students[counter++] = s;
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            string s = string.Format("Course name: {0}, Course teacher: {1}, Students: \n", name, teacher);

            for (int i = 0; i < counter; i++)
                s = s + students[i].ToString();

            return s;
        }

        public int CountAdultStudents()
        {
            int count = 0;
            for (int i = 0; i < counter; i++)
                if (students[i].GetType() == typeof(AdultStudent)) // or students[i] is AdultStudent
                    count++;

            return count;
        }
    }

}
