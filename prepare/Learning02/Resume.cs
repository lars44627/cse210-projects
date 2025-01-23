
using System.Configuration.Assemblies;

public class Resume{

    public string _MemberName = "";
    public List<Job> _Jobs = new List<Job>();

    public void display_details(){
        Console.WriteLine($"Name: {_MemberName}");
        Console.WriteLine($"Jobs: ");
       foreach (var job in _Jobs)
        {
            job.display_details();
        }
    }

}