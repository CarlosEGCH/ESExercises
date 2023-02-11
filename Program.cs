

class MyApp
{

    // Exercise 1:

    static int fibonacci(int n)
    {

        // 1, 1, 2, 3, 5, 8, 13
        if (n == 0 || n == 1)
        {
            return 1;
        }

        return fibonacci(n - 1) + fibonacci(n - 2);
    }

    static void printFibonacci(int n)
    {
        for (int i = 0; i < n; i++)
        {
            System.Console.Write(fibonacci(i) + ", ");
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

    static void Main()
    {

        // Exercise 1: Print the first 20 Fibonacci numbers

        // printFibonacci(20);


        // Exercise 2: Print the Nth iteration of Leibniz's Pi Formula

        // System.Console.WriteLine(leibniz(200));

        // Exercise 3: Read 2 numbers and print out the biggest

        // readBigger();

    }

}