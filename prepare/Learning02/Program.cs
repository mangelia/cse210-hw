using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        /*Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        Console.WriteLine(job1._jobTitle);*/

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "(Microsoft)";
        job1._startYear = 2019;
        job1._endYear = 2022;


        /*Job job2 = new Job();
        job2._jobTitle = "Field Engineer";
        Console.WriteLine(job2._jobTitle);*/

        Job job2 = new Job();
        job2._jobTitle = "Field Engineer";
        job2._company = "(Cisco)";
        job2._startYear = 2010;
        job2._endYear = 2019;

        /*Prints the Job details

        job1.DisplayJobDetails();
        job2.DisplayJobDetails();
        */

        //Add the two jobs you created earlier, to the list of jobs in the resume object.

        Resume resume1 = new Resume();
        resume1._member = "Jane Doe";

        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);
        
        /* Checking I am actually able to access the created list
    
        Console.WriteLine(resume1._jobs[0]._jobTitle);
        Console.WriteLine(resume1._jobs[1]._jobTitle);
        */
        resume1.DisplayResume();
    }
}