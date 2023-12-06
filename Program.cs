using Assignment;
using System;

class Program
{
    static void Main(string[] args)
    {
        // Exercise 1
        Car car = new Car("Toyota", 2023, 250000);
        car.DisplayInfo();

        // Exercise 2
        BankAccount account = new BankAccount("1234567890");
        account.Deposit(1000);
        account.Withdraw(500);
        Console.WriteLine($"Balance: {account.GetBalance()}");

        // Exercise 3
        Rectangle rect = new Rectangle(4.5f, 3.2f);
        Console.WriteLine($"Area of Rectangle: {rect.CalculateArea()}");

        // Exercise 4
        Circle circle = new Circle(5);
        Console.WriteLine($"Area of Circle: {circle.CalculateArea()}");

        // Exercise 5
        Student student = new Student("Numa Limbu", 21, "Computer Science");
        student.Introduce();

        // Exercise 6
        Stack<int> intStack = new Stack<int>();
        intStack.Push(5);
        intStack.Push(10);
        intStack.Push(15);
        Console.WriteLine($"Is Stack Empty: {intStack.IsEmpty()}");

        // Exercise 7
        Calendar.PrintWeekdays();

        // Exercise 8
        Point2D point1 = new Point2D { x = 1, y = 2 };
        Point2D point2 = new Point2D { x = 4, y = 6 };
        Console.WriteLine($"Distance between points: {CalculateDistance(point1, point2)}");
    }
   
    // Exercise 8 (continued)
    static double CalculateDistance(Point2D point1, Point2D point2)
    {
        return Math.Sqrt(Math.Pow((point2.x - point1.x), 2) + Math.Pow((point2.y - point1.y), 2));
    }
}
