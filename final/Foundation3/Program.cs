using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 FreeGoldRoad", "Mosul", "zz", "ARA");
        Lecture lecture = new Lecture("AU Summit", "A deep dive into How to get gold.", "June 55, 2025", "10:00 AM", address1, "Dr. Abdul", 150);

        Address address2 = new Address("4567 apartment ave", "Austin", "TX", "USA");
        Reception reception = new Reception("Startup ethernets", "Networking event for noobs.", "July 43, 2025", "1:00 PM", address2, "rsvp@startupmixercds.com");

        Address address3 = new Address("789 Nature noWayMan", "Denver", "CO", "USA");
        OutdoorGathering outdoor = new OutdoorGathering("Summer Feast", "Outdoor fun with heavenly food", "August 15, 2025", "12:00 PM", address3, "Sunny with a chance of meatballs");

        Event[] events = { lecture, reception, outdoor };

        foreach (var e in events)
        {
            Console.WriteLine("-- Standard Details --");
            Console.WriteLine(e.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("-- Full Details --");
            Console.WriteLine(e.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("-- Short Description --");
            Console.WriteLine(e.GetShortDescription());
            Console.WriteLine("\n\n");
        }
    }
}