using System;
namespace ActivityProgram001
{
    class Teacher : Person
    {
        private string employeeID;

        public Teacher(string name, string address, string citizenID, string employeeID,string activity, int expday,string month,int year) : base(name, address, citizenID,activity,expday,month,year)
        {
            this.employeeID = employeeID;
        }

    }
}
