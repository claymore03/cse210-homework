// Name: Clayton Redding
// Instructor: Brother Gibbons
// Class: CSE 210
// Date: 05/22/2024
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World Learning02!");
        
        Job job1 = new Job();
        Job job2 = new Job();
        Resume myResume = new Resume();
        
        job1.GetJobTitle();
        job1.GetCompanyName();
        job1.GetStartYear();
        job1.GetEndYear();

        job2.GetJobTitle();
        job2.GetCompanyName();
        job2.GetStartYear();
        job2.GetEndYear();

        
        myResume._name = "Clayton Redding";
        
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();

        

        // job1.DisplayJobs();
    }
}