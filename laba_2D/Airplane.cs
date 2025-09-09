using System.Runtime.CompilerServices;
using System.Security;

namespace laba_2D;

class Airplane
{
    public string RegisterNumber { get; init; }
    public string AirCompany { get; init; }
    public int CountOfSeatPlace { get; init; }
    public List<Seat> Seats { get; init; }

    public List<Passenger> Passengers { get; set; }

    public Airplane(string registerNumber, string airCompany, int countOfSeatPlace, List<Seat> seats = null)
    {
        RegisterNumber = registerNumber;
        AirCompany = airCompany;
        CountOfSeatPlace = countOfSeatPlace;
        Seats = seats.Take(countOfSeatPlace).ToList();
        Passengers = new List<Passenger>();
    }

    public void AddPassenger(Passenger passenger)
    {
        if (VerificationTicket(passenger))
        {
            Passengers.Add(passenger);
            Console.WriteLine($"Добро пожаловать на борт: {passenger.Name}");
        }
        else
            Console.WriteLine(wrongChoice);
    }

    public override string ToString()
    {
        string res = $"Самолёт номер: {RegisterNumber}\nКомпании: {AirCompany}\n";
        res += "Посадочные места: \n";
        foreach (var obj in Seats) res += $"\t{obj}";

        res += "Пассажиры на борту: \n";
        foreach (var obj in Passengers) res += $"\t{obj}";

        return res;
    }

    private bool VerificationTicket(Passenger passenger)
    {
        foreach (var obj in Seats)
        {
            if (obj.ChairNumber == passenger.Place.ChairNumber)
                return true;
        }
        return false;
    }

    private string wrongChoice = "Вы ошиблись саммолётом!";



}