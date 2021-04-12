using MyFirstWeb.Model;
using Newtonsoft.Json.Linq;

namespace MyFirstWeb.DTO
{
    public class CourseDTO
    {
        public static Course FromJson(JObject json)
        {
            var isvu = json["isvu"].ToObject<string>();
            var name = json["name"].ToObject<string>();
            var shortName = json["shortname"].ToObject<string>();
            var level = json["level"].ToObject<string>();
            var ects = json["ects"].ToObject<int>();
            var department = json["department"].ToObject<string>();

            return new Course(0, isvu, name, shortName, level, ects, department);
        }
    }
}