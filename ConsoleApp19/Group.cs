namespace ConsoleApp19;

public class Group
{
    public int GroupId { get; set; }
    public string GroupName { get; set; }
    public ICollection<Student> Students { get; set; }
    public int TeacherId { get; set; }
    public Teacher Teacher { get; set; }
}
