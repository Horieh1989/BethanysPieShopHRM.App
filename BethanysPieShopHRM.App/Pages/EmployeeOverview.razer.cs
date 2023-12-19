using BethanysPieShopHRM.App.Models;
using BethanysPieShopHRM.Shared.Domain;


namespace BethanysPieShopHRM.App.Pages
{
    public partial class EmployeeOverview //we can have the same class with the same name if we put partial 
    {
        public List<Employee> Employees { get; set; } = default!;


        protected override void OnInitialized()
        {
            Employees = MockDataService.Employees;
        }

    }
}
