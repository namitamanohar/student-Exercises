namespace StudentExercises
{
  public class Instructor
  {

    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SlackHandle { get; set; }
    public string InstructorCohort { get; set; }
    public string InstructorSpeciality { get; set; }

    public void AddExercise(Student student, Exercise exercise)
    {
      student.ExerciseCollection.Add(exercise);
    }
    public Instructor(string firstName, string lastName, string slackHandle, string instructorCohort, string instructorSpeciality)
    {
      FirstName = firstName;
      LastName = lastName;
      SlackHandle = slackHandle;
      InstructorCohort = instructorCohort;
      InstructorSpeciality = instructorSpeciality;

    }
  }
}