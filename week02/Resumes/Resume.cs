using System;
using System.Runtime.CompilerServices;
public class Resume
{
    public string _name;
    public List<Job> _jobsList = new List<Job>();

    public void DisplayResume()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs: ");

        foreach (Job item in _jobsList)
        {
            item.DisplayJobDetails();
        }
    }
}