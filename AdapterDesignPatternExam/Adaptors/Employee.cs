namespace AdapterDesignPatternExam.Adaptors;

public class Employee
{
    public Employee(int id, string name, int salary)
    {
        this.Id = id;
        this.Name = name;
        this.Salary = salary;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
}
