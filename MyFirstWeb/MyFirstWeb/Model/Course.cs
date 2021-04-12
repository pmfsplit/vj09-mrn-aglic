namespace MyFirstWeb.Model
{
    public class Course
    {
        public int Id { get; set; }
        public string Isvu { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Ects { get; set; }
        public string Level { get; set; }
        public string Department { get; set; }

        public Course(int id, string isvu, string name, string shortName, string level, int ects, string department)
        {
            Id = id;
            Isvu = isvu;
            Name = name;
            ShortName = shortName;
            Ects = ects;
            Level = level;
            Department = department;
        }
    }
}