using System.Net;

namespace HelpClasses
{
    public abstract class Person
    {
        public int Identity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
    }
}
