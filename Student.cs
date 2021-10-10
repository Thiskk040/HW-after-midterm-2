using System;
namespace ActivityProgram001
{
    class Student : Person
    {
        private string studentID;

        public Student(string name, string address, string citizenID, string studentID,string activity, int expday,string month,int year) : base(name, address, citizenID,activity,expday,month,year)
        {
            this.studentID = studentID;
        }

    }
}
