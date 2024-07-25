using System;
using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        List<Studentdetail> studentdetails = new List<Studentdetail>();
        studentdetails.Add(new Studentdetail(12, "Ram", "10", "A", "Butwal", 34));
        studentdetails.Add(new Studentdetail(13, "Shyam", "10", "A", "Kathmandu", 35));
        studentdetails.Add(new Studentdetail(14, "Hari", "10", "A", "Pokhara", 36));
        studentdetails.Add(new Studentdetail(15, "Sita", "10", "A", "Bhaktapur", 37));
        studentdetails.Add(new Studentdetail(16, "Gita", "10", "A", "Lalitpur", 38));
        studentdetails.Add(new Studentdetail(17, "Rita", "10", "A", "Dharan", 39));
        studentdetails.Add(new Studentdetail(18, "Mina", "10", "A", "Biratnagar", 40));
        studentdetails.Add(new Studentdetail(19, "Bina", "10", "A", "Janakpur", 41));
        studentdetails.Add(new Studentdetail(20, "Nita", "10", "A", "Hetauda", 42));
        studentdetails.Add(new Studentdetail(21, "Lina", "10", "A", "Nepalgunj", 43));

        Studentdetail.Student_detail(studentdetails);
    }
}
public class Studentdetail
{

    public int Rollno { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public string Section { get; set; }
    public string Address { get; set; }
    public int Gpa { get; set; }
    public Studentdetail(int rollno, string name, string classs, string section, string address, int gpa)
    {
        Name = name;
        Class = classs;
        Section = section;
        Address = address;
        Gpa = gpa;
    }
    public static void Student_detail(List<Studentdetail> student_details)
    {
        foreach (Studentdetail student in student_details)
        {
            Console.Write("Enter the student name  :  ");
            string name = Console.ReadLine();
            if (name == student.Name)
            {
                Console.WriteLine("Student Name : " + student.Name);
                Console.WriteLine("Student Class : " + student.Class);
                Console.WriteLine("Student Section :" + student.Section);
                Console.WriteLine("Student Address  :" + student.Address);
                Console.WriteLine("Student Gpa  :" + student.Gpa);

                break;
            }
            else
            {
                Console.WriteLine("sorry you search gpa rank is not found");

            }
        }
    }


}
