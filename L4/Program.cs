using System;

namespace L4
{
    public class Student
    {
        private string Name;
        private string LastName;
        private string Group;
        private int Year;
        private string Adress;
        private string Passport;
        private int Age;
        private string Telephone;
        private int Rating;
        public Student()
        {

        }
        public string N
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }

        }
        public string L_N
        {
            get
            {
                return LastName;
            }
            set
            {
                LastName = value;
            }

        }
        public string G
        {
            get
            {
                return Group;
            }
            set
            {
                Group = value;
            }

        }
        public int Y
        {
            get
            {
                return Year;
            }
            set
            {
                if (value > 0)
                    Year = value;
                else
                    throw new Exception("Year is wrong.");
            }

        }
        public string A_D
        {
            get
            {
                return Adress;
            }
            set
            {
                Adress = value;
            }

        }
        public string P
        {
            get
            {
                return Passport;
            }
            set
            {
                if (value.Length == 9)
                    Passport = value;
                else
                    throw new Exception("Passport is wrong.");
            }

        }
        public int A_G
        {
            get
            {
                return Age;
            }
            set
            {
                if (value > 0)
                    Age = value;
                else
                    throw new Exception("Age is wrong.");
            }

        }
        public string T
        {
            get
            {
                return Telephone;
            }
            set
            {
                if (value.Length == 10)
                    Telephone = value;
                else
                    throw new Exception("Telephone is wrong.");
            }

        }
        public int R
        {
            get
            {
                return Rating;
            }
            set
            {
                if ((value <= 100 )&&(value >= 0))
                    Rating = value;
                else
                    throw new Exception("Rating is wrong.");
        }

    }
        public string StudentRating(int R)
        {
            string r = "";
            if (R >= 90)  r = "Congratulations, excellent student!";
            if ((R >= 75)&&(R < 90)) r = "You can study better.";
            if (R < 75) r = "Pay more attention to studying.";
            Console.WriteLine(r);
            return r;
        }

    }
    class Program
    {
        public static void Main()
        {
            Student s1 = new Student();
            s1.N = "Viktoriia";
            s1.L_N = "Zdeoruk";
            s1.G = "IT-11";
            s1.Y = 1;
            s1.A_D = "Stepana Bandery street, 12";
            s1.P = "001553333";
            s1.A_G = 17;
            s1.T = "0991249033";
            s1.R = 50;
            Console.WriteLine("Name: " + s1.N);
            Console.WriteLine("LastName: " + s1.L_N);
            Console.WriteLine("Group: " + s1.G);
            Console.WriteLine("Year: " + s1.Y);
            Console.WriteLine("Adress: " + s1.A_D);
            Console.WriteLine("Passport: " + s1.P);
            Console.WriteLine("Age: " + s1.A_G);
            Console.WriteLine("Telephone: +38" + s1.T);
            Console.WriteLine("Rating: " + s1.R);
            s1.StudentRating(s1.R);
            Console.ReadKey();

        }
    }
}
