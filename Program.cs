

class MyApp
{

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

    static void Main()
    {

        // Exercise 1: Print the first 20 Fibonacci numbers

        printFibonacci(20);
    }

}