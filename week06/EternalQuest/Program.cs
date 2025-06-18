using System;

// I add level up functionality to the Eternal Quest game
// Goal deletion feature
// Visual point and level feedback in menu

partial class Program
{
    // Main entry point for the Eternal Quest game
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
 
}