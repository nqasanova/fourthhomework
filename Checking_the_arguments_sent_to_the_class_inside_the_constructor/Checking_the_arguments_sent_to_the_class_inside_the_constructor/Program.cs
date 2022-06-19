using System;

namespace Checking_the_arguments_sent_to_the_class_inside_the_constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Note : (Name's first letter must start with an uppercase letter, name's length should be between 2 and 20, name should only contain letters)");
                Console.Write("Insert Name : ");
                string employeeName = Console.ReadLine();
                Console.WriteLine("Note : (Surname's first letter must start with an uppercase letter, surname's length should be between 2 and 35, surname should only contain letters)");
                Console.Write("Insert Surname : ");
                string employeeSurname = Console.ReadLine();
                Console.WriteLine("Note : (Father's name's length should be between 2 and 20, Father's name must only contain letters)");
                Console.Write("Insert Father Name : ");
                string employeeFatherName = Console.ReadLine();
                Console.WriteLine("Note : (Age must be between 18 and 65)");
                Console.Write("Insert Age : ");
                int employeeAge = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Note : (FIN's length should be equal to 7, FIN can only contain uppercase letters and numbers)");
                Console.Write("Insert Finn number : ");
                string employeeFin = Console.ReadLine();
                Console.WriteLine("Note : (Telephone number's general length must be equal to 13, telephone number must start with +994 such as ((+994503144847, +994703144846))");
                Console.Write("Insert Telephone number : +");
                string employeeNumber = Console.ReadLine();
                Console.WriteLine("Note : (Position can only be HR, Audit, or Engineer)");
                Console.Write("Insert Position : ");
                string employeePosition = Console.ReadLine();
                Console.WriteLine("Note : (Salary must be between 1500 and 5000)");
                Console.Write("Insert Salary : ");
                int employeeSalary = Convert.ToInt32(Console.ReadLine());


                Employee infoEmployee = new Employee(employeeName, employeeSurname, employeeFatherName, employeeAge, employeeFin, employeeNumber, employeeName, employeeSalary);
                Console.WriteLine($"Name is {infoEmployee.NameChechk(employeeName)}");
                Console.WriteLine($"Surname is {infoEmployee.SurnameChechk(employeeSurname)}");
                Console.WriteLine($"Father's name is {infoEmployee.FatherNameChechk(employeeFatherName)}");
                Console.WriteLine($"Age is {infoEmployee.AgeChechker(employeeAge)}");
                Console.WriteLine($"FIN is {infoEmployee.MainFinnChechk(employeeFin)}");
                Console.WriteLine($"Telephone number is {infoEmployee.FirstNumberChechk(employeeNumber)}");
                Console.WriteLine($"Position is {infoEmployee.PositionChechk(employeePosition)}");
                Console.WriteLine($"Salary is {infoEmployee.SalaryChechk(employeeSalary)}");
                Console.WriteLine("Would you like to get information about an employee? Please write 'yes' or 'no' ");
                string targetGetInfo = Console.ReadLine();

                if (targetGetInfo == "yes")
                {
                    Console.WriteLine($"Employee's name is {employeeName}");
                    Console.WriteLine($"Employee's surname is {employeeSurname}");
                    Console.WriteLine($"Employee's father's name is {employeeFatherName}");
                    Console.WriteLine($"Employee's age is {employeeAge}");
                    Console.WriteLine($"Employee's FIN is {employeeFin}");
                    Console.WriteLine($"Employee's number is {employeeNumber}");
                    Console.WriteLine($"Employee's position is {employeePosition}");
                    Console.WriteLine($"Employee's salary is {employeeSalary}");
                }

                else
                {
                    Console.WriteLine("Bye");
                }
            }
        }
    }

    class Employee
    {
        public string _employeeName;
        public string _employeeSurname;
        public string _employeeFatherName;
        public int _employeeAge;
        public string _employeeFin;
        public string _employeeTelephoneNumber;
        public string _employeePosition;
        public int _employeeSalary;

        public Employee(string employeeName, string employeeSurname, string employeeFatherName, int employeeAge, string employeeFin, string employeeTelephoneNumber, string employeePosition, int employeeSalary)
        {
            _employeeName = employeeName;
            _employeeSurname = employeeSurname;
            _employeeFatherName = employeeFatherName;
            _employeeAge = employeeAge;
            _employeeFin = employeeFin;
            _employeeTelephoneNumber = employeeTelephoneNumber;
            _employeePosition = employeePosition;
            _employeeSalary = employeeSalary;
        }

        public bool NameChechk(string employeeName)
        {
            return FirstNameMethod(employeeName) && SecondNameMethod(employeeName) && ThirdNameMethod(employeeName);

        }

        public bool SurnameChechk(string employeeSurname)
        {
            return FirstNameMethod(employeeSurname) && SecondSNameMethod(employeeSurname) && ThirdNameMethod(employeeSurname);
        }

        public bool FatherNameChechk(string employeeFatherName)
        {
            return FirstNameMethod(employeeFatherName) && SecondNameMethod(employeeFatherName) && ThirdNameMethod(employeeFatherName);
        }

        public bool MainFinnChechk(string employeeFin)
        {
            return FirstFinCheck(employeeFin) && SecondFinCheck(employeeFin);
        }

        public bool MainNumberChechk(string employeeTelephoneNumber)
        {
            return FirstNumberChechk(employeeTelephoneNumber);
        }

        public bool FirstNameMethod(string employeeName)
        {
            char[] lettersLowerCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < lettersLowerCase.Length; i++)
            {
                if (employeeName[0] == lettersLowerCase[i])
                {
                    return false;
                }
            }

            return true;
        }

        public bool SecondNameMethod(string employeeName)
        {
            for (int i = 0; i < employeeName.Length; i++)
            {
                if (employeeName.Length <= 2 || employeeName.Length >= 20)
                {
                    return false;
                }
            }

            return true;
        }

        public bool ThirdNameMethod(string employeeName)
        {
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int i = 0; i < letters.Length; i++)
            {
                if (employeeName[0] == letters[i])
                {
                    return true;
                }
            }

            return false;
        }

        public bool SecondSNameMethod(string employeeSurname)
        {
            for (int i = 0; i < employeeSurname.Length; i++)
            {
                if (employeeSurname.Length <= 2 || employeeSurname.Length >= 35)
                {
                    return false;
                }
            }

            return true;
        }

        public bool AgeChechker(int employeeAge)
        {
            if (employeeAge <= 18 || employeeAge >= 65)
            {
                return false;
            }

            return true;

        }

        public bool FirstFinCheck(string employeeFin)
        {
            for (int i = 0; i < employeeFin.Length; i++)
            {
                if (employeeFin.Length < 7 || _employeeName.Length > 7)
                {
                    return false;
                }
            }

            return true;
        }
        public bool SecondFinCheck(string employeeFin)
        {
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            for (int i = 0; i < letters.Length; i++)
            {
                for (int k = 0; k < employeeFin.Length; k++)
                {
                    if (employeeFin[k] == letters[i])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public bool FirstNumberChechk(string employeeTelephoneNumber)
        {
            foreach (char element in employeeTelephoneNumber)
            {
                if (element < '0' || element > '9' || employeeTelephoneNumber.Length < 12 || employeeTelephoneNumber.Length > 12)
                {
                    return false;
                }
            }

            return true;
        }

        public bool PositionChechk(string employeePosition)
        {
            if (employeePosition != "HR" && employeePosition != "Audit" && employeePosition != "Engineer")
            {
                return false;
            }

            return true;
        }

        public bool SalaryChechk(int employeeSalary)
        {
            if (employeeSalary < 1500 || employeeSalary > 5000)
            {
                return false;
            }

            return true;
        }
    }
}
