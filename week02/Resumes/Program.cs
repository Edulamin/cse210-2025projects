using System;

class Program
{
    static void Main(string[] args)
    {   
        // adding value to the parameters for each object (instance)
        Job job1 = new Job();

        job1._company = "Sony";
        job1._jobTitle = "Developer";
        job1._startYear = 2010;
        job1._endYear = 2018;

        Job job2 = new Job();

        job2._company = "Samsung";
        job2._jobTitle = "Product Leader";
        job2._startYear = 2018;
        job2._endYear = 2025;

        //resume part

        //creating new instance for resume
        Resume myResume = new Resume();

        //adding items to the list
        myResume._jobsList.Add(job1);
        myResume._jobsList.Add(job2);

        myResume._name = "John Adams";

        //display part
        myResume.DisplayResume();

    }
}