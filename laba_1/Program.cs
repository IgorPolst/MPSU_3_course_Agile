class Program
{
    static void Main()
    {
        Computer comp = new Computer("MSI", "China", 100);

        Console.WriteLine(comp.ToString());
        comp.changingRAM(10);
        Console.WriteLine(comp.ToString());
    }
}
