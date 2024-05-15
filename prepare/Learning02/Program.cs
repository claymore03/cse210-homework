using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        
        job1.GetJobTitle();
        job1.GetCompanyName();
        job1.GetStartYear();
        job1.GetEndYear();

        job1.DisplayJobs();
    }
}