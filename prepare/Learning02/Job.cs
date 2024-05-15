public class Job
{
    string _jobTitle;
    string _companyName;
    int _startYear;
    int _endYear;
    
    public void GetJobTitle()
    {
        Console.WriteLine("Enter job title: ");
        _jobTitle = Console.ReadLine();
    }

    public void GetCompanyName()
    {
        Console.WriteLine("Enter the company's name: ");
        _companyName = Console.ReadLine();
    }

    public void GetStartYear()
    {
        Console.WriteLine("Enter start year: ");
        _startYear = Convert.ToInt32(Console.ReadLine());
        Convert.ToString(_startYear);
        
    }

    public void GetEndYear()
    {
        Console.WriteLine("Enter end year: ");
        _endYear = Convert.ToInt32(Console.ReadLine());
        Convert.ToString(_endYear);
        
    }
    
    public void DisplayJobs()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear}");
    }
}