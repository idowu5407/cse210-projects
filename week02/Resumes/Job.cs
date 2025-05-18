public class Job
{
    // Member variables
    public string _jobTitle;
    public string _companyName;
    public int _startDate;
    public int _endDate;

    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startDate}-{_endDate}");
    }
}