using WebApplication1.Properties.Data;
using WebApplication1.Search;
namespace WebApplication1.Services
{
    public interface IProjectListService
    {
        Task<PagedResult<ProjectList>> List(int page, int pageSize, ProjectListSearch search = null);
        Task<ProjectList> Get(int id);
        Task Save(ProjectList list);
        Task Delete(int id);
    }
}

