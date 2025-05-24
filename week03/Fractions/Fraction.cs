using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    // Constructor 1: no parameters
    public Fraction()
    {
        _top = 1;
        _bottom = 1; // Default to 1 to avoid division by zero
    }

    // Constructor 2: one parameter (top)
    public Fraction(int top)
    {
        _top = top;
        _bottom = 1; // Default to 1 to avoid division by zero
    }

    // Constructor 3: two parameters (top and bottom)
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;

    }

    // Getters and Setters
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;

    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }

    // Method to return the fraction as a string
    public string GetFractionString()
    {
        return $"{_top}/{_bottom}";
    }

    // Method to return the decimal value
    public double GetDecimalValue()
    {
        return (double)_top / _bottom;
    }
}