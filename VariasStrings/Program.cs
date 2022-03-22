class Program
{
    static void Main(string[] args)
    {
        string string1 = "ULHT";
        string string2 = string.Concat(string1, " - Videojogos");
        string string3 = $"Universidade {string1}";
        string string4 = string.Format("O valor da string1 é {0}", string1);
        double xx = 0.12345;
        int ii = 18;
        string hexValue = ii.ToString("X");

        Console.WriteLine(Math.Round(xx, 2));
        Console.WriteLine(xx.ToString("#0.##%"));
        Console.WriteLine(@"Teste, {0}", string1);
        Console.WriteLine(ii.ToString("C0"));
        Console.WriteLine(hexValue);
        Console.WriteLine(string1);
        Console.WriteLine(string2);
        Console.WriteLine(string3);
        Console.WriteLine(string4);
    }
}