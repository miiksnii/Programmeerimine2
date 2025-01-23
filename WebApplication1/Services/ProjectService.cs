using WebApplication1.Properties.Data;
using WebApplication1.Search;

namespace WebApplication1.Services
{
    public class ProjectService : IProjectService
    {
        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Project> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<Project>> List(int page, int pageSize, ProjectSearch search = null)
        {
            throw new NotImplementedException();
        }

        public Task Save(Project list)
        {
            throw new NotImplementedException();
        }
    }
}
