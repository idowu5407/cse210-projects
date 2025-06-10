// WritingAssignment.cs
using System;

public class WritingAssignment : Assignment
{
    // Private member variables specific to WritingAssignment
    private string _title;

    // Constructor - accepts all 3 parameters
    public WritingAssignment(string studentName, string topic, string title)
    // Call base class constructor
        : base(studentName, topic) 
    {
        _title = title;
    }

    // Method to get the writing information
    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        // We use GetStudentName() from base class
        return $"{_title} by {studentName}";
    }
}