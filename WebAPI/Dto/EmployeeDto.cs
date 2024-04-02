namespace WebAPI.Dto
{
    public class EmployeeDto
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public EmployeeDto(string name, int age)
        { 
            Name = name;
            Age = age;
        }
    }
}
