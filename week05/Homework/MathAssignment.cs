// MathAssignment.cs
using System;

public class MathAssignment : Assignment
{
    // Private member variables specific to MathAssignment
    private string _textbookSection;
    private string _problems;

    // Constructor - accepts all 4 parameters
    public MathAssignment(string studentName, string topic, string textbookSection, string problems)
    // Call base class constructor
        : base(studentName, topic) 
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    // Method to get the homework list
    public string GetHomeworkList()
    {
        return $"Section: {_textbookSection} Problems: {_problems}";
    }
}