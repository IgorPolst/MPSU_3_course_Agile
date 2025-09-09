namespace laba_2D;
class Program
{
    static void Main(string[] args)
    {
        List<Seat> seats = new List<Seat>
        {
            new Seat("1A", "Economy"),
            new Seat("1B", "Economy"),
            new Seat("1C", "Economy"),
            new Seat("2A", "Economy"),
            new Seat("2B", "Economy"),
            new Seat("2C", "Economy"),
            new Seat("3A", "Business"),
            new Seat("3B", "Business"),
            new Seat("3C", "Business"),
            new Seat("4A", "First")
        };

        Airplane newAirplane = new Airplane("A0001", "КБ Звезда", 20, seats);

        List<Passenger> passengers = new List<Passenger>
        {
            new Passenger("Alice", "TCK123", new Seat("1A", "Economy")),
            new Passenger("Bob", "TCK124", new Seat("1D", "Economy")),
            new Passenger("Charlie", "TCK125", new Seat("2F", "Economy")),
            new Passenger("Diana", "TCK126", new Seat("3A", "Business")),
            new Passenger("Edward", "TCK127", new Seat("4A", "First"))
        };

        foreach (var obj in passengers) newAirplane.AddPassenger(obj);

        Console.WriteLine(newAirplane);


    }
}