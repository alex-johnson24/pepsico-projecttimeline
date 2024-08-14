using Microsoft.AspNetCore.Mvc;
using PepsiCoProjectTimeline.Server.Repositories;
using PepsiCoProjectTimeline.Shared.Models;

namespace PepsiCoProjectTimeline.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectTimelineController
    {
        private readonly ProjectTimelineRepository _projectRepository;
        public ProjectTimelineController(ProjectTimelineRepository projectRepository)
        {
            _projectRepository = projectRepository;
        }

        [HttpGet]
        [Route("all-tasks")]
        public async Task<List<ProjectTimelineModel>> GetAllProjectTasks()
        {
            return await _projectRepository.GetAllProjectTasks();
        }

        [HttpPut]
        [Route("update/{projectTimelineId}")]
        public async Task UpdateProjectTimeline(int projectTimelineId, ProjectTimelineModel projectTimelineModel)
        {
            await _projectRepository.UpdateProjectTimeline(projectTimelineId, projectTimelineModel);
        }
    }
}