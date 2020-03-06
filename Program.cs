using System;
using System.Collections.Generic;

namespace StudentExercises
{
  class Program
  {
    static void Main(string[] args)
    {
      // Create 4, or more, exercises.
      Exercise Nutshell = new Exercise("Nutshell", "React");
      Exercise HolidayRoad = new Exercise("Holiday Road", "Vanilla Javascript");
      Exercise BankHeist = new Exercise("Bank Heist", "C#");
      Exercise MartinsAquarium = new Exercise("Martin's Aquarium", "Vanilla Javascript");
      // Create 3, or more, cohorts.
      Cohort Evening10 = new Cohort("Evening Cohort 10");
      Cohort Day37 = new Cohort("Day Cohort 37");
      Cohort Data8 = new Cohort("Data Analytics Cohort 8");

      // Create 4, or more, students and assign them to one of the cohorts.

      Student James = new Student("James", "Nitz", "_jamesClimb", "Day Cohort 37");
      Student Willy = new Student("Willy", "Metcalf", "_willyRaves", "Data Analytics Cohort 8");
      Student William = new Student("William", "Green", "_williamPizza", "Evening Cohort 10");
      Student Audrey = new Student("Audrey", "Borgra", "_audreyCodes", "Day Cohort 37");

      Evening10.AddStudent(William);
      Day37.AddStudent(James);
      Day37.AddStudent(Audrey);
      Data8.AddStudent(Willy);
      // Create 3, or more, instructors and assign them to one of the cohorts.
      Instructor Mo = new Instructor("Mo", "Silvera", "_moMoney", "Day Cohort 37", "Being Awesome");
      Instructor Brenda = new Instructor("Brenda", "Long", "_brendaBreaksDownCode", "Data Analytics Cohort 8", "Designing websites");
      Instructor Steve = new Instructor("Steve", "Brownlee", "_steveChoortlehort", "Evening Cohort 10", "Dad Jokes");

      Day37.AddInstructor(Mo);
      Data8.AddInstructor(Brenda);
      // Have each instructor assign 2 exercises to each of the students.
      Mo.AddExercise(James, Nutshell);
      Mo.AddExercise(James, MartinsAquarium);
      Mo.AddExercise(Audrey, Nutshell);
      Mo.AddExercise(Audrey, MartinsAquarium);

      Brenda.AddExercise(Willy, BankHeist);
      Brenda.AddExercise(Willy, HolidayRoad);

      Steve.AddExercise(William, Nutshell);
      Steve.AddExercise(William, HolidayRoad);

      List<Student> students = new List<Student>();
      students.Add(James);
      students.Add(Willy);
      students.Add(William);
      students.Add(Audrey);

      List<Exercise> exercises = new List<Exercise>();

      exercises.Add(Nutshell);
      exercises.Add(HolidayRoad);
      exercises.Add(MartinsAquarium);
      exercises.Add(BankHeist);

      foreach (Exercise exercise in exercises)
      {
        Console.WriteLine($"{exercise.ExerciseName}");
        // loops student  
        foreach (Student student in students)
        {
          // loops exercise collection and then conditional 
          //   student.ExerciseCollection list of exercise which is a class
          foreach (Exercise studentExercise in student.ExerciseCollection)
          {
            if (studentExercise == exercise)
            {
              Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
          }
        }
        Console.WriteLine($"---------------------------------------------------");
      }

    }
  }
}
