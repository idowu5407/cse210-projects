using System;

public class Assignment
{
    // Private member variables
    private string _studentName;
    private string _topic;

    // Constructor to initialize the assignment with student name and topic
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // Public method to get the student name
    public string GetStudentName()
    {
        return $"Student: {_studentName}, Topic: {_topic}";
    }
}