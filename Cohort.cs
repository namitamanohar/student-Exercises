using System.Collections.Generic;

namespace StudentExercises
{
  public class Cohort
  {
    public string CohortName { get; set; }
    // list of the stduent class called StudentCollection
    public List<Student> StudentCollection { get; set; } = new List<Student>();
    public List<Instructor> InstructorCollection { get; set; } = new List<Instructor>();


    public void AddStudent(Student student)
    {
      StudentCollection.Add(student);
    }

    public void AddInstructor(Instructor instructor)
    {
      InstructorCollection.Add(instructor);
    }
    public Cohort(string cohortName)
    {
      CohortName = cohortName;

    }
  }
}