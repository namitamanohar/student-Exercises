using System;
using System.Collections.Generic;

namespace StudentExercises
{
  public class Student
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public string StudentCohort { get; set; }
    // The collection of exercises that the student is currently working on
    public List<Exercise> ExerciseCollection { get; set; } = new List<Exercise>();


    public Student(string firstName, string lastName, string slackHandle, string studentCohort)
    {
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = slackHandle;
      StudentCohort = studentCohort;
    }
    public void Description()
    {
      Console.WriteLine($"Student First Name: {FirstName}");
      Console.WriteLine($"Student Last Name: {LastName}");
      Console.WriteLine($"Student Slack Handle: {SlackHandle}");
      Console.WriteLine($"Student Cohort: {StudentCohort}");


    }
  }
}