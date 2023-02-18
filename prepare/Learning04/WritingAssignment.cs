public class WritingAssignment : Assignment {
    private string _title;

    // Constructor: inherits studentName and topic from base class (Assignment)
    public WritingAssignment(string studentName, string topic, string title)
    : base (studentName, topic) {
        _title = title;
    }

    // Can access _studentName because it is protected, not private
    public string GetWritingInformation() {
        return $"{_title} by {_studentName}";
    }
}