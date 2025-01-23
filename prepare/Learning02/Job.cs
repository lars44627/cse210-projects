

public class Job{
    public string _JobTitle = "";
    public string _JobCompany = "";
    public int _JobDates = 0;

    public void display_details()
    {
        Console.WriteLine($"{_JobTitle}, {_JobCompany}, {_JobDates}");
    }

}