using Microsoft.AspNetCore.Components.Web;

namespace EmployeeAPI.Models
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }

        public Title CurrentTitle { get; set; }
    }
}