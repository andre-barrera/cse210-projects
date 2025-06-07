public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string _studentName, string _topic, string title) : base(_studentName, _topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
       return $"{GetStudentName()} - {_topic}\n{_title}";
    }
    
}