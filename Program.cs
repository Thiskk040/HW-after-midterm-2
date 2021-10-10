using System;
enum Menu
{
    RegisterNewStudent = 1,
    RegisterNewTeacher = 2,
    CheckEXPActivityPersons = 3,
    Exit = 4
}

namespace ActivityProgram001
{
    /// โปรแกรมการลงทะเบียนกิจกรรม โดยให้ใส่ชื่อ,ที่อยู่,รหัสนักศึกษา,รหัสบัตรปชช,ชื่อกิจกรรมนักศึกษา,และ วันเดือนปี ที่ลงทะเบียนกิจกรรมนักศึกษา
    /// โดยโปรแกรมจะเก็บค่าทั้งหมดไว้และ ไปเก็บอยู่ที่ Class PersonList และ แสดงชื่อของผู้ลงทะเบียน ประเภทของบุคลากร และวันหมดอายุของการประเมิณกิจกรรมนั้นๆโดยจะตั้งไว้ว่าหมดอายุภายใน 1 ปี นับจากวันที่ลงทะเบียน
    /// จัดทำโดย นาย คุณานนต์ เงาเบญจกุล
    class Program
    {
        static PersonList personList;

        static void Main(string[] args)
        {
            Program.personList = new PersonList();
            PrintMenuScreen();
           
        }
        static void PrintMenuScreen()
        {
            Console.WriteLine("Welcome to Register Activity in KMUTT!!!");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("1. Register new student.");
            Console.WriteLine("2. Register new Teacher.");
            Console.WriteLine("3. Get List Name and Exp activity name.");
            Console.WriteLine("4. Exit the program.");
            Console.Write("Please Select Menu: ");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);

        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewStudent)
            {
                ShowInputRegisterNewStudentScreen();
            }
            else if (menu == Menu.RegisterNewTeacher)
            {
                ShowInputRegisterNewTeacherScreen();
            }
            else if (menu == Menu.CheckEXPActivityPersons)
            {
                ShowGetListPersonScreen();
            }
            else if(menu == Menu.Exit)
            {
                Console.Clear();
            }    
            else
            {
                Console.Clear();
                Console.WriteLine("Menu Incorrect Please try again.");
                Console.Write("Please Select Menu: ");
                menu = (Menu)(int.Parse(Console.ReadLine()));

                PresentMenu(menu);

            }
        }

        static void ShowInputRegisterNewStudentScreen()
        {
            Console.Clear();
            PrintHeaderRegisterStudent();

            int totalStudent = TotalNewStudents();
            InputNewStudentFromKeyboard(totalStudent);
        }

        static void ShowInputRegisterNewTeacherScreen()
        {
            Console.Clear();
            PrintHeaderRegisterTeacher();

            int totalTeacher = TotalNewTeacher();
            InputNewTeacherFromKeyboard(totalTeacher);
        }

        static void ShowGetListPersonScreen()
        {
            Console.Clear();
            Program.personList.FetchPersonsList();
            InputExitFromKeyboard();
        }

        static void InputExitFromKeyboard()
        {
            Console.WriteLine();
            Console.WriteLine("Press >> e << to exit to the main interface");
            string text = "";
            while (text != "e")
            {
                Console.Write("Input: ");
                text = Console.ReadLine();
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewTeacherFromKeyboard(int totalTeacher)
        {
            for (int i = 0; i < totalTeacher; i++)
            {
                Console.Clear();
                PrintHeaderRegisterTeacher();

                Teacher teacher = CreateNewTeacher();
                Program.personList.AddNewPerson(teacher);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static void InputNewStudentFromKeyboard(int totalStudent)
        {
            for (int i = 0; i < totalStudent; i++)
            {
                Console.Clear();
                PrintHeaderRegisterStudent();

                Student student = CreateNewStudent();
                Program.personList.AddNewPerson(student);
            }

            Console.Clear();
            PrintMenuScreen();
        }

        static Student CreateNewStudent()
        {
            return new Student(InputName(),
             InputAddress(),
             InputCitizenID(),
             InputStudentID(),
            InputActivityName(),
            InputLoginday(),
            InputMonth(),
            InputYear());
        }

        static Teacher CreateNewTeacher()
        {
            return new Teacher(InputName(),
            InputAddress(),
            InputCitizenID(),
            InputEmployeeID(),
            InputActivityName(),
            InputLoginday(),
            InputMonth(),
            InputYear());
        }

        static string InputName()
        {
            Console.Write("Name: ");

            return Console.ReadLine();
        }

        static string InputStudentID()
        {
            Console.Write("Student ID: ");

            return Console.ReadLine();
        }

        static string InputAddress()
        {
            Console.Write("Address: ");

            return Console.ReadLine();
        }

        static string InputCitizenID()
        {
            Console.Write("Citizen ID: ");

            return Console.ReadLine();
        }

        static string InputEmployeeID()
        {
            Console.Write("Employee ID: ");

            return Console.ReadLine();
        }
        static string InputActivityName()
        {
            Console.Write("Activity Name: ");

            return Console.ReadLine();
        }
        static int InputLoginday()
        {
            Console.Write("Day register activity: ");

            return int.Parse(Console.ReadLine());
        }
        static string InputMonth()
        {
            Console.Write("Month register activity: ");

            return Console.ReadLine();
        }
        static int InputYear()
        {
            Console.Write("Year register activity: ");

            return int.Parse(Console.ReadLine());
        }



        static int TotalNewStudents()
        {
            Console.Write("Input Total new Student: ");

            return int.Parse(Console.ReadLine());
        }

        static int TotalNewTeacher()
        {
            Console.Write("Input Total new Teacher: ");

            return int.Parse(Console.ReadLine());
        }

        static void PrintHeaderRegisterStudent()
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        static void PrintHeaderRegisterTeacher()
        {
            Console.WriteLine("Register new teacher.");
            Console.WriteLine("---------------------");
        }

        
    }

}

