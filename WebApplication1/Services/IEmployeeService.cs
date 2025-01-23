using WebApplication1.Properties.Data;
using WebApplication1.Search;
namespace WebApplication1.Services
{
    public interface IEmployeeService
    {
        Task<PagedResult<Employee>> List(int page, int pageSize, EmployeeSearch search = null);
        Task<Employee> Get(int id);
        Task Save(Employee list);
        Task Delete(int id);
    }
}

