using HelpClasses;

namespace Entities
{
    public class Teacher : Person
    {
        public List<Course> courses { get; set; }
    }
}
