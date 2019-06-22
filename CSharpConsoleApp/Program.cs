using System;

namespace CSharpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpType emp = EmpType.contractor;
            AskForBonus(emp);
            Console.WriteLine($"{emp.ToString()}");

        }

        static void AskForBonus(EmpType emp)
        {
            switch (emp) {

                case EmpType.manager:
                    Console.WriteLine("Manager");
                break;

                case EmpType.contractor:
                    Console.WriteLine("Contractor");
                break;

                case EmpType.grunt:
                    Console.WriteLine("Grunt");
                break;

                case EmpType.VicePresident:
                    Console.WriteLine("VicePresident");
                break;
            }
        }

        private static void SimpleArrays()
        {
            int[] myInts = new int[3] { 1, 0, 3};
            string[] booksOnDonet = new string[100];
            Array.Sort(myInts);
            foreach (int i in myInts) {
                Console.Write($"{i} ");
            }           
            

                
        }

        private static void GetUserData()
        {
            Console.WriteLine("Please enter name");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter age");
            string userAge = Console.ReadLine();

            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Hello {0} You are {1}", userName, userAge);

            Console.ForegroundColor = prevColor;

            
        }

        static int Add(int x, int y) { return x + y; }
        static double Add(double x, double y) { return x + y; }
        static long Add(long x, long y) { return x + y; }

        static void EnterLogdata(string message, string owner = "Programmer") {
            Console.Beep();
            Console.WriteLine("Error {0}", message);
            Console.WriteLine($"Owner of Error {owner}");
        }

        enum EmpType {
            manager = 102,
            grunt = 103,
            contractor = 104,
            VicePresident = 105

        }


    }
}
