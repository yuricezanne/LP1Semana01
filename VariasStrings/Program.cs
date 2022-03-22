class Program
{
    static void Main(string[] args)
    {
        string string1 = "ULHT";
        string string2 = string.Concat(string1, " - Videojogos");
        string string3 = $"Universidade {string1}";
        string string4 = string.Format("O valor da string1 é {0}", string1);
        Console.WriteLine(@"Teste, {0}", string1);
        Console.WriteLine(string1);
        Console.WriteLine(string2);
        Console.WriteLine(string3);
        Console.WriteLine(string4);
    }
}