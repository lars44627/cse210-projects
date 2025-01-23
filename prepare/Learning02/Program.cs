using System;

class Program
{
    static void Main(string[] args)
    {
        Job job = new Job();
        job._JobTitle = "Software Engineer";
        job._JobCompany = "Microsoft";
        job._JobDates = "2020-2024";

        Job job2 = new Job();
        job2._JobTitle = "Electrical Engineer";
        job2._JobCompany = "Power Guy";
        job2._JobDates = "2000-2020";

        job.display_details();
        job2.display_details();

    }
}