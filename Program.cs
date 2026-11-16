//using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

namespace InheritancePart1
{

    public class Program
    {
        /* class Person
         {
             public string? Name { get; set; }
             public int Age { get; set; }
             public Person(string? name, int age)
             {
                 Name = name;
                 Age = age;
             }
         } 
        class Student : Person
         {
             public int StudentId;
             public float Grade;
        public   Student(int studentId, float grade, string? name, int age) : base(name, age)
             {
                 StudentId = studentId;
                 Grade = grade;
             }

         }
      class Theacher : Student
         {
             public string? Subject { get; set; }
             public double Salary { get; set; }
             public Theacher (int studentId, float grade, string? name, int age,string subject,double salary):base(studentId,grade,name,age)
             {
                 Subject = subject;
                 Salary = salary;
             }

         }

         public class Vehicle
         {
             public string ? Brand { set; get; }
             public float PricePerDay { get; set; }
             public Vehicle(string brand,float priceperday)
             {
                 Brand = brand;
                 PricePerDay = priceperday;

             }

         }
        public class Car : Vehicle
         {
             public int NumberOfDoors { get; set; }
             public Car(string brand, float priceperday , int numberofdoors):base(brand,priceperday)
             {
                 NumberOfDoors = numberofdoors;
             }
         }
         public class MotorBike : Car
         {
             public bool HasHelmet;
             public MotorBike(string brand, float priceperday, int numberofdoors, bool hashelmet) : base(brand, priceperday, numberofdoors)
             {
                 HasHelmet = hashelmet;
             }
             public void ShowInfo()
             {
                 Console.WriteLine($"Brand:{Brand}\n,priceperday{PricePerDay}\n,numberofdoors{NumberOfDoors}\n,hashelmet{HasHelmet}");
             }*/
        public class Account
        {
            public int AccountNumber;
            public double Balance;
            public Account(int accountnumber, float balance)
            {
                AccountNumber = accountnumber;
                Balance = balance;

            }
            public double AddDeposit(double Amount)
            {
                return Balance += Amount;
            }
        }
        public class SavingAccount : Account
        {
            public float InterstRate;
            public SavingAccount(int accountnumber, float balance, float interstrate) : base(accountnumber, balance)
            {
                InterstRate = interstrate;
            }
        }
        public class CurrentAccount : Account
        {
            public double Overdraftlimit;
            public CurrentAccount(int accountnumber, float balance, double overdraftlimit)
            : base(accountnumber, balance)
            { Overdraftlimit = overdraftlimit; }
        }
        class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }

            public Character(string name, int health)
            {
                Name = name;
                Health = health;
            }
        }

        class Warrior : Character
        {
            public int Strength { get; set; }

            public Warrior(string name, int health, int strength) : base(name, health)
            {
                Strength = strength;
            }

            public void Attack()
            {
                Console.WriteLine($"{Name} (Health: {Health}) attacks with strength {Strength}!");
            }
        }

        class Mage : Character
        {
            public int Mana { get; set; }

            public Mage(string name, int health, int mana) : base(name, health)
            {
                Mana = mana;
            }

            public void CastSpell()
            {
                Console.WriteLine($"{Name} (Health: {Health}) casts a spell using {Mana} mana!");
            }
        }
        public class MenuItem
        {
            public string? Name { get; set; }
            public decimal Price { get; set; }

            public void ShowBasicInfo()
            {
                Console.WriteLine($"Item: {Name}, Price: {Price:C}");
            }
        }

        public class Dish : MenuItem
        {
            public int CookingTime { get; set; }

            public void Prepare()
            {
                Console.WriteLine($"Preparing {Name}... Estimated time: {CookingTime} mins.");
            }
        }

        public class SpecialDish : Dish
        {
            public string? ChefName { get; set; }

            public void ShowChefNote()
            {
                Console.WriteLine($"Special Dish '{Name}' is crafted by Chef {ChefName}.");
            }
        }

        public class Employee
        {
            public string Name { get; set; }
            public decimal Salary { get; set; }

            public Employee(string name, decimal salary)
            {
                Name = name;
                Salary = salary;
            }

            public void Work()
            {
                Console.WriteLine($"{Name} is working. Salary: {Salary:C}");
            }
            public class Developer : Employee
            {
                public string ProgrammingLanguage { get; set; }

                public Developer(string name, decimal salary, string programmingLanguage)
                    : base(name, salary)
                {
                    ProgrammingLanguage = programmingLanguage;
                }

                public void WriteCode()
                {
                    Console.WriteLine($"{Name} is writing code in {ProgrammingLanguage}.");
                }
            }

            public class SeniorDeveloper : Developer
            {
                public int YearsOfExperience { get; set; }

                public SeniorDeveloper(string name, decimal salary, string programmingLanguage, int yearsOfExperience)
                    : base(name, salary, programmingLanguage)
                {
                    YearsOfExperience = yearsOfExperience;
                }
                public void ReviewCode()
                {
                    Console.WriteLine($"{Name} ({YearsOfExperience} years exp.) is reviewing the team's code.");
                }
            }





            static void Main(string[] args)
            {
                #region q1
                //Person p = new Person("Hadeer", 20);
                //Student s = new Student(123, 90.5f, "Menna", 30);
                //Theacher T= new Theacher(123, 90.5f, "Engy", 30, "Math", 5000);

                //Console.WriteLine($"Person: Name={p.Name}, Age={p.Age}");
                //Console.WriteLine($"Student: Name={s.Name}, Age={s.Age}, StudentId={s.StudentId}, Grade={s.Grade}");
                //Console.WriteLine($"Teacher: Name={T.Name}, Age={T.Age}, Subject={T.Subject}, Salary={T.Salary}");
                #endregion
                #region q2
                //Vehicle V = new Vehicle("BMW", 50);
                //Car C = new Car("BMW", 50,7);
                //MotorBike M=new MotorBike("BMW", 50, 7,true);

                //M.ShowInfo();
                #endregion
                #region q3 
                //Account a = new Account(3, 1000);
                //SavingAccount S = new SavingAccount(3, 10000, 13);
                //CurrentAccount C = new CurrentAccount(10000, 13, 34);
                //C.AddDeposit(500);
                //Console.WriteLine(C.);

                #endregion

                #region q4
                //Warrior warrior = new Warrior("Arthur", 100, 85);
                //Mage mage = new Mage("Merlin", 70, 120);

                //warrior.Attack();
                //mage.CastSpell();
                #endregion
                #region Q5

                //SpecialDish special = new SpecialDish
                //{
                //    Name = "Grilled Wagyu Steak",
                //    Price = 450.00m,
                //    CookingTime = 25,
                //    ChefName = "Ahmed"
                //};


                //special.ShowBasicInfo(); 
                //special.Prepare();       
                //special.ShowChefNote();
                #endregion
                #region
                //SeniorDeveloper seniorDev = new SeniorDeveloper("Hadeer", 25000m, "C#", 5);

                //seniorDev.Work();
                //seniorDev.WriteCode();
                //seniorDev.ReviewCode();
                #endregion
            }
        }
    }
}


