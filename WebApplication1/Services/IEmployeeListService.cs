using WebApplication1.Properties.Data;
using WebApplication1.Search;

namespace WebApplication1.Services
{
    public interface IEmployeeListService
    {
        Task<PagedResult<EmployeeList>> List(int page, int pageSize, EmployeeListSearch search = null);
        Task<EmployeeList> Get(int id);
        Task Save(EmployeeList list);
        Task Delete(int id);
    }
}

