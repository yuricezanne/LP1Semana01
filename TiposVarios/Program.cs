class Program
{
    static void Main(string[] args)
    {
        int inteiro1 = 1;
        int inteiro2 = 2;
        string string1 = "LP1";
        string string2 = "\u2647";
        bool boleano1 = true;
        bool boleano2 = false;

        Console.WriteLine(boleano1);
        Console.WriteLine(boleano2); 
        Console.WriteLine(string.Concat(inteiro1, inteiro2, string1));
        Console.WriteLine(char.Parse(string2));
   
    }
}