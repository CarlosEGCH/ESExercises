using System.Collections.Generic;

class MyApp
{

    // Exercise 1:


    public class Fib
    {
        private Dictionary<int, long> memo = new Dictionary<int, long>();

        public long fibonacci(int n)
        {

            if (memo.ContainsKey(n))
            {
                return memo[n];
            }

            if (n == 0 || n == 1)
            {
                memo[n] = n;
                return n;
            }

            long result = fibonacci(n - 1) + fibonacci(n - 2);
            memo[n] = result;
            return result;
        }

        public void printFibonacci(int n)
        {
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(i + 1 + "nth: " + fibonacci(i) + ", ");
            }
        }
    }


    // Exercise 2:

    static double leibniz(int n)
    {
        double res = 0.0;
        bool add = true;

        if (n == 0) return 0.0;

        for (double i = 1.0; i < n; i = i + 2.0)
        {

            res = add ? res + (4.0 / (i)) : res - (4.0 / (i));

            add = !add;
        }

        return res;

    }

    // Exercise 3:

    static void readBigger()
    {

        System.Console.Write("Type a number: ");

        int firstNumber = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Type another number: ");

        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber == secondNumber) System.Console.WriteLine("Both numbers are equal.");
        else if (firstNumber > secondNumber) System.Console.WriteLine(firstNumber + " is bigger.");
        else System.Console.WriteLine(secondNumber + " is bigger.");

    }


    // Exercise 4:

    static void averageInput()
    {

        // Taking a string
        System.Console.WriteLine("Write 10 numbers separated ONLY by colon ( , )");
        String? str = Console.ReadLine();

        String[] separator = { "," };
        Int32 count = 10;

        // using the method
        String[] strlist = str.Split(separator, count,
               StringSplitOptions.RemoveEmptyEntries);


        int res = 0;

        foreach (String s in strlist)
        {
            res = res + Convert.ToInt32(s);
        }

        System.Console.WriteLine("Average: " + res / 10);
    }


    // Exercise 5:

    static void printReverse()
    {


        System.Console.WriteLine("Write a sequence of numbers separated ONLY by colon ( , ): ");
        String? str = Console.ReadLine();

        String[] separator = { "," };
        Int32 count = 10;

        String[]? strlist = str?.Split(separator, count,
               StringSplitOptions.RemoveEmptyEntries);

        System.Console.WriteLine("Reverse order:");
        for (int i = 9; i >= 0; i--)
        {
            System.Console.Write(strlist?[i] + ",");
        }
    }

    // Exercise 7:
    static readonly string textFile = "text.txt";

    static void readFileAndPrint()
    {

        string text = File.ReadAllText(textFile);
        text = text.Replace(Environment.NewLine, " ");
        text = text.ToLower();

        System.Console.WriteLine(text);

    }


    // Exercise 8:

    static void readNumbersAndCalculate()
    {

        System.Console.Write("Write a decimal number: ");
        int? num1 = Convert.ToInt32(Console.ReadLine());

        System.Console.Write("Write another decimal number: ");
        int? num2 = Convert.ToInt32(Console.ReadLine());

        for (; ; )
        {

            System.Console.WriteLine("Choose an Option: ");
            System.Console.WriteLine("1) Add");
            System.Console.WriteLine("2) Subtract");
            System.Console.WriteLine("3) Multiply");
            System.Console.WriteLine("4) Divide");
            System.Console.WriteLine("0) Exit");

            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {

                case 1:
                    System.Console.WriteLine(num1 + " + " + num2 + " = " + (num1 + num2));
                    break;
                case 2:
                    System.Console.WriteLine(num1 + " - " + num2 + " = " + (num1 - num2));
                    break;
                case 3:
                    System.Console.WriteLine(num1 + " x " + num2 + " = " + (num1 * num2));
                    break;
                case 4:
                    System.Console.WriteLine(num1 + " + " + num2 + " = " + (num1 / num2));
                    break;
                case 0:
                    System.Console.WriteLine("Exiting the program...");
                    return;
                default:
                    System.Console.WriteLine("Please choose an existing option");
                    break;
            }

        }


    }

    static void Main()
    {

        // Exercise 1: Print the first 20 Fibonacci numbers

        Fib myFib = new Fib();

        myFib.printFibonacci(50);


        // Exercise 2: Print the Nth iteration of Leibniz's Pi Formula

        // System.Console.WriteLine(leibniz(200));


        // Exercise 3: Read 2 numbers and print out the biggest

        // readBigger();


        // Exercise 4: Read a list of numbers and print out the average

        // averageInput();


        // Exercise 5: Read a sequence of numbers and print them in reverse order

        // printReverse();


        // Exercise 7: Read a file and print the contents in a single line and lowercased

        // readFileAndPrint();


        // Exercise 8: Read two decimal numbers and allow the user to choose an option (Calculator).

        // readNumbersAndCalculate();

    }

}