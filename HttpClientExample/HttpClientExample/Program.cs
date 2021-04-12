using System;
using System.Net.Http;
using System.Net.Http.Json;

namespace HttpClientExample
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
    class Program
    {
        static void Main(string[] args)
        {
            var httpClient = new HttpClient();
            var result = httpClient.GetStringAsync("http://localhost:5000/api/courses").Result;
            Console.WriteLine(result);
        }
    }
}