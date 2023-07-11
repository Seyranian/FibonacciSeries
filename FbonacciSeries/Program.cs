static int FindFibonacciSeriesToTheGivenNumber(int n)
{
    if(n == 0) return 0;
    if(n == 1) return 1;
    else return FindFibonacciSeriesToTheGivenNumber(n - 1) + FindFibonacciSeriesToTheGivenNumber(n - 2);
}

Console.Write("Enter the last number of the Fibonacci Series: ");
int lastNumber = Convert.ToInt32(Console.ReadLine());
for (int i = 0;; i++)
{
    if (FindFibonacciSeriesToTheGivenNumber(i) < lastNumber)
    {
        Console.Write("{0} ", FindFibonacciSeriesToTheGivenNumber(i));
    }
    else return;
}