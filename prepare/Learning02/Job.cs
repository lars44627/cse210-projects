

public class Job{
    public string _JobTitle = "";
    public string _JobCompany = "";
    public string _JobDates = "";

    public void display_details()
    {
        Console.WriteLine($"{_JobTitle} ({_JobCompany}) {_JobDates}");
    }
}