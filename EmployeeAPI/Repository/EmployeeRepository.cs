using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EmployeeAPI.Models
{
    public static class EmployeeRepository
    {
        public static List<Employee> lstEmployees = new List<Employee>(){
            new Employee () {Name = "Ponnuraj", Id=1, Email="r@gm.com", CurrentTitle = new Title(){ Id=1, Name="Architect", From=Convert.ToDateTime("2024/4/10"), To=DateTime.Now, Status=true} },
            new Employee () {Name = "deepa", Id=2, Email="d@gm.com", CurrentTitle = new Title(){ Id=2, Name="Developer", From=Convert.ToDateTime("2024/1/1"), To=Convert.ToDateTime("2024/4/9"), Status=false} },
        };
    }
}