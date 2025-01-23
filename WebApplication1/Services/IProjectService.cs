using WebApplication1.Properties.Data;
using WebApplication1.Search;
namespace WebApplication1.Services
{
    public interface IProjectService
    {
        Task<PagedResult<Project>> List(int page, int pageSize, ProjectSearch search = null);
        Task<Project> Get(int id);
        Task Save(Project list);
        Task Delete(int id);
    }
}
