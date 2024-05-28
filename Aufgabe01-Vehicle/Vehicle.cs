using System;
using System.Xml.Linq;

namespace Aufgabe01_Vehicle
{
    class Vehicle
    {
        public string? Id { get; private set; }

        public Vehicle(string id)
        {
            this.Id = id;
            Console.WriteLine("Konstruktor der Klasse Vehicle");
        }

        public void SayId()
        {
            Console.WriteLine($"Vehicle Id: {this.Id}\n");
        }

        public override string ToString()
        {
            return $"Vehicle Id: {Id}";
        }
    }

    class Car : Vehicle
    {
        public string? LicenceNumber { get; private set; }

        public Car(string id, string licenceNumber) : base(id)
        {
            this.LicenceNumber = licenceNumber;
            Console.WriteLine("Konstruktor der Klasse Car");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nLicenceNumber: {LicenceNumber}";
        }
    }

    class Ship : Car
    {
        public string? Name { get; private set; }

        public Ship(string id, string licenceNumber, string name) : base(id,licenceNumber)
        {
            this.Name = name;
            Console.WriteLine("Konstruktor der Klasse Ship");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nName: {Name}";
        }
    }

    class SailingShip : Ship
    {
        public int? Poles { get; private set; }

        public SailingShip(string id, string licenceNumber, string name, int poles) : base(id, licenceNumber, name)
        {
            this.Poles = poles;
            Console.WriteLine("Konstruktor der Klasse SailingShip");
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nPoles: {Poles}";
        }
    }
}

