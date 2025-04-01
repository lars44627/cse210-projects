using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Tech Rd", "Seattle", "WA", "USA");
        Lecture lecture = new Lecture("AI Summit", "A deep dive into AI advancements.", "June 10, 2025", "10:00 AM", address1, "Dr. Jane Smith", 150);

        Address address2 = new Address("456 Party Blvd", "Austin", "TX", "USA");
        Reception reception = new Reception("Startup Mixer", "Networking event for entrepreneurs.", "July 20, 2025", "6:00 PM", address2, "rsvp@startupmixer.com");

        Address address3 = new Address("789 Nature Park", "Denver", "CO", "USA");
        OutdoorGathering outdoor = new OutdoorGathering("Summer Fest", "Outdoor fun with food trucks and live music.", "August 15, 2025", "12:00 PM", address3, "Sunny with clear skies");

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