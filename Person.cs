using System;
namespace ActivityProgram001
{
    class Person
    {
        protected string name;
        protected string address;
        protected string citizenID;
        protected string activity;
        protected int expday;
        protected string month;
        protected int year;

        public Person(string name, string address, string citizenID, string activity, int expday,string month,int year)
        {
            this.name = name;
            this.address = address;
            this.citizenID = citizenID;
            this.activity = activity;
            this.expday = expday;
            this.month = month;
            this.year = year;

        }
        public string GetName()
        {
            return this.name;

        }
        public string GetActivity()
        {
            return this.activity;
        }
        public int GetExpDay()
        {
            return this.expday;
        }
        public string GetMonth()
        {
            return this.month;
        }
        public int GetYear()
        {
            return this.year;
        }
        
    }
}
