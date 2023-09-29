using System.Threading.Tasks.Dataflow;

public class Resume
{
    public string _member;
    public List<Job> _jobs = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name {_member}");
        Console.WriteLine("Jobs:");
        foreach (Job i in _jobs)
        {
            i.DisplayJobDetails();
        }
    }
}