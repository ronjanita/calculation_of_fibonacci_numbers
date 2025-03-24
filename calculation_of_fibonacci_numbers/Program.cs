class Program
{
    static void Main()
    {
        Console.WriteLine("enter how many fibonacci numbers you want to calculate:");
        int userInput = int.Parse(Console.ReadLine());  //um3wandlung string in int
        List<long> fibonacci = new List<long>();   //long statt int für grösseren wertbereich

        for (int i = 0; i < userInput; i++)
        {
            if (i == 0)
            {
                fibonacci.Add(0);  //hinzufügen zu liste vcon 0
            }
            else if (i == 1)
            {
                fibonacci.Add(1);   //hinzufügen zu lsite von 1
            }
            else
            {
                long continuingFibonacciNumber = fibonacci[i-1] + fibonacci[i-2];   //long weil int zu kurz, berechnung der letzten beiden benutzten zahlen zusammen, ergebniss wird wieder zu lsite hinzugefpügt
                fibonacci.Add(continuingFibonacciNumber);
            }
        }
        Console.WriteLine("here are all the fibonacci numbers:");
        for (int i = 0;i < fibonacci.Count;i++)    //scheölife damit jedes element der Liste durchgegangen wird und ausgegeben wird.
        {
            Console.WriteLine(fibonacci[i]);   //eckige klammern notwenig umd auf listen oder array zuzugreifen zu können
        }
    }
}
