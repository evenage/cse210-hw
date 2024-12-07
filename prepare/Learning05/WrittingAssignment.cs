public class WrittingAssignment : Assignment
{
    private string _title; 
    //{get, set}

    public WrittingAssignment(string title, string studentName, string topic): base(studentName, topic)
    {
        _title = title;
    }

     

    public string GetWrittingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}
