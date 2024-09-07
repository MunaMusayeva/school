using ConsoleApp19;
using Microsoft.EntityFrameworkCore;

class Program
{
    static async Task Main(string[] args)
    {
        using var dbContext = new SchoolContext();
        //var newTeacher = new Teacher
        //{
        //    Name = "Jane Smith"
        //};
        //await dbContext.Teachers.AddAsync(newTeacher);
        //await dbContext.SaveChangesAsync();
        //Console.WriteLine("Muellim elave edildi.");

        //var teacherToUpdate = await dbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == 1);

        //teacherToUpdate.Name = "John Doe";
        //await dbContext.SaveChangesAsync();
        //Console.WriteLine("Muellim yenilendi.");
        //var teacherToDelete = await dbContext.Teachers.FirstOrDefaultAsync(t => t.TeacherId == 1);

        //dbContext.Teachers.Remove(teacherToDelete);
        //await dbContext.SaveChangesAsync();
        //Console.WriteLine("Muellim silindi.");


        //var newGroup = new Group
        //{
        //    GroupName = "Mathematics Group",
        //    TeacherId = 2
        //};
        //await dbContext.Groups.AddAsync(newGroup);
        //await dbContext.SaveChangesAsync();
        //Console.WriteLine("Qrup elave edildi.");

        //var groupToUpdate = await dbContext.Groups.FirstOrDefaultAsync(g => g.GroupId == 2);

        //groupToUpdate.GroupName = "Science Group";
        //await dbContext.SaveChangesAsync();
        //Console.WriteLine("Qrup yenilendi.");


        //var groupToDelete = await dbContext.Groups.FirstOrDefaultAsync(g => g.GroupId == 2);

        // dbContext.Groups.Remove(groupToDelete);
        // await dbContext.SaveChangesAsync();
        // Console.WriteLine("Qrup silindi.");


        //var newStudent = new Student
        //{
        //    Name = "John Doe",
        //    GroupId = 3
        //};
        //await dbContext.Students.AddAsync(newStudent);
        //await dbContext.SaveChangesAsync();
        //Console.WriteLine("Telebe elave edildi.");

        //var studentToUpdate = await dbContext.Students.FirstOrDefaultAsync(s => s.StudentId == 1);

        //studentToUpdate.Name = "Jane Brown";
        //await dbContext.SaveChangesAsync();
        //Console.WriteLine("Telebe yenilendi.");

        //var studentToDelete = await dbContext.Students.FirstOrDefaultAsync(s => s.StudentId == 1);
        //dbContext.Students.Remove(studentToDelete);
        //await dbContext.SaveChangesAsync();
        //Console.WriteLine("Telebe silindi.");
        
       
    }

}
