public class Assignment {
    // Instead of being protected, could leave private and make
    // a getter method that returns _studentName so other classes
    // could access this member variable.
    protected string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic) {
        _studentName = studentName;
        _topic = topic;
    }

    public string GetSummary() {
        return $"{_studentName} - {_topic}";
    }
}