using AutoMapper;
using Microsoft.EntityFrameworkCore;
using PepsiCoProjectTimeline.Server.Data;
using PepsiCoProjectTimeline.Server.Data.Entities;
using PepsiCoProjectTimeline.Shared.Models;

namespace PepsiCoProjectTimeline.Server.Repositories
{
    public class ProjectTimelineRepository
    {
        private readonly ProjectTimelineContext _dbContext;
        private readonly IMapper _mapper;

        public ProjectTimelineRepository(ProjectTimelineContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<ProjectTimelineModel>> GetAllProjectTasks()
        {
            var tasks = await _dbContext.Set<ProjectTimeline>().AsNoTracking().ToListAsync();

            return _mapper.Map<List<ProjectTimelineModel>>(tasks);
        }

        public async Task UpdateProjectTimeline(int projectTimelineId, ProjectTimelineModel projectTimelineModel)
        {
            var updateModel = await _dbContext.FindAsync<ProjectTimeline>(projectTimelineId);

            if (updateModel is null) return;

            _mapper.Map(projectTimelineModel, updateModel);

            await _dbContext.SaveChangesAsync();
        }
    }
}