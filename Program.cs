// 1. Create a class called Employee with properties for name, age, and salary. Implement a method to display employee details


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Salary: {Salary}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Satyam Narayan Dubey";
            employee.Age = 23;
            employee.Salary = 50000.00;

            Console.WriteLine("Employee Details:");
            employee.DisplayDetails();
            Console.ReadLine();
        }
    }
}



// 2. Create a class called BankAccount with properties for account number, account holder name, and balance. Implement methods for deposit, withdrawal, and displaying the account details


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class BankAccount
    {
        public string AccountNumber { get; }
        public string AccountHolderName { get; }
        public decimal Balance { get; private set; }
        public BankAccount(string accountNumber, string accountHolderName, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            Balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
                Console.WriteLine($"{amount} deposited successfully. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= Balance)
            {
                Balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully. New balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient balance.");
            }
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Holder Name: {AccountHolderName}");
            Console.WriteLine($"Balance: {Balance}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("123456789", "Satyam Narayan Dubey", 1000.00m);
            account.Deposit(500.00m);
            account.Withdraw(200.00m);
            account.DisplayAccountDetails();
            Console.ReadLine();
        }
    }
}



// 3. Create a static utility class named MathHelper with a static method CalculateAverage that takes an array of integers as input and returns their average


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class MathHelper
    {
        public static double CalculateAverage(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("The array must contain at least one element.", nameof(numbers));
            }
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }
            double average = (double)sum / numbers.Length;
            return average;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 10, 15, 20, 25 };
            double average = MathHelper.CalculateAverage(numbers);
            Console.WriteLine($"The average is: {average}");
            Console.ReadLine();
        }
    }
}



// 4. Implement a static logger class called Logger that has a method LogMessage for writing messages on console. Demonstrate its usage in a simple console application


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public static class Logger
    {
        public static void LogMessage(string message)
        {
            Console.WriteLine($"[{DateTime.Now}] - {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Logger.LogMessage("Starting the application...");
            Logger.LogMessage("Application finished.");
            Console.ReadLine();
        }
    }
}





// 6.Create a partial class Employee with properties representing employee details. In another part, implement methods for calculating salary based on different factors


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal CalculateSalary()
        {
            return BaseSalary;
        }
        public decimal CalculateSalaryWithBonus(decimal bonusAmount)
        {
            return BaseSalary + bonusAmount;
        }
        public decimal CalculateSalaryWithOvertime(decimal overtimeHours, decimal overtimeRate)
        {
            decimal overtimePay = overtimeHours * overtimeRate;
            return BaseSalary + overtimePay;
        }
        public decimal CalculateSalaryWithIncrease(decimal percentageIncrease)
        {
            decimal increaseAmount = BaseSalary * (percentageIncrease / 100);
            return BaseSalary + increaseAmount;
        }
    }
    class EmployeeSalary
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmployeeId = 1;
            employee.FirstName = "Satyam Narayan";
            employee.LastName = "Dubey";
            employee.BaseSalary = 50000;

            decimal totalSalary = employee.CalculateSalary();
            decimal bonusSalary = employee.CalculateSalaryWithBonus(2000);
            decimal overtimeSalary = employee.CalculateSalaryWithOvertime(10, 150);
            decimal increasedSalary = employee.CalculateSalaryWithIncrease(5);

            Console.WriteLine($"Total Salary: {totalSalary}");
            Console.WriteLine($"Salary with Bonus: {bonusSalary}");
            Console.WriteLine($"Salary with Overtime: {overtimeSalary}");
            Console.WriteLine($"Salary with Increase: {increasedSalary}");
            Console.ReadLine();
        }
    }
}



// 7. Define an abstract base class Shape with an abstract method CalculateArea. Derive classes like Circle and Rectangle from Shape and implement the area calculation methods for each


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class Shape
    {
        public abstract double CalculateArea();
    }
    class Circle : Shape
    {
        private double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }
    }
    class Rectangle : Shape
    {
        private double width;
        private double height;
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        public override double CalculateArea()
        {
            return width * height;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(4, 6);

            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.ReadLine();
        }
    }
}



// 8. Design an abstract class Animal with properties like Name and Age. Derive classes like Dog and Cat from Animal with their unique methods


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public abstract void MakeSound();
    }
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the dog says Woof!");
        }
        public void Fetch()
        {
            Console.WriteLine($"{Name} is fetching the ball.");
        }
    }
    class Cat : Animal
    {
        public Cat(string name, int age) : base(name, age)
        {
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the cat says Meow!");
        }
        public void Scratch()
        {
            Console.WriteLine($"{Name} is scratching the furniture.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("Buddy", 3);
            Cat cat = new Cat("Whiskers", 2);

            dog.MakeSound();
            dog.Fetch();

            cat.MakeSound();
            cat.Scratch();
            Console.ReadLine();
        }
    }
}



// 9. Create a base class Vehicle with methods like StartEngine and StopEngine. Derive a class Car from Vehicle and seal it. Try to create a class that inherits from Car and observe the behavior


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Vehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Engine started");
        }

        public void StopEngine()
        {
            Console.WriteLine("Engine stopped");
        }
    }

    sealed class Car : Vehicle
    {
    }

    class AnotherClass : Car
    {
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.StartEngine();
            car.StopEngine();
            Console.ReadLine();
        }
    }

}



// 10. Design a class BankAccount with properties like AccountNumber and Balance. Implement a sealed class SavingsAccount that extends BankAccount with methods for interest calculation


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class BankAccount
    {
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }

        public BankAccount(string accountNumber, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            Balance = initialBalance;
        }

        public virtual void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
                return;
            }

            Balance += amount;
            Console.WriteLine($"Deposited {amount}. New balance: {Balance}");
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount > Balance)
            {
                Console.WriteLine("Insufficient balance.");
                return;
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount}. New balance: {Balance}");
        }
    }
    sealed class SavingsAccount : BankAccount
    {
        private decimal InterestRate { get; }

        public SavingsAccount(string accountNumber, decimal initialBalance, decimal interestRate)
            : base(accountNumber, initialBalance)
        {
            InterestRate = interestRate;
        }
        public void CalculateInterest()
        {
            decimal interestAmount = Balance * InterestRate;
            Deposit(interestAmount);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount savingsAccount = new SavingsAccount("123456", 1000, 0.05m);

            Console.WriteLine($"Account Number: {savingsAccount.AccountNumber}");
            Console.WriteLine($"Initial Balance: {savingsAccount.Balance}");

            savingsAccount.Deposit(500);
            savingsAccount.Withdraw(200);

            savingsAccount.CalculateInterest();
            Console.ReadLine();
        }
    }

}
