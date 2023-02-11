using backend.Data;
using backend.Models;
using chaperone.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectController : Controller
    {
        private readonly UsersAPIDbContext dbContext;
        public ProjectController(UsersAPIDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {

            return Ok(await dbContext.Users.ToListAsync());

        }

        [HttpPost]
        public async Task<IActionResult> AddUser(AddUserRequest addUserRequest)
        {
            var user = new Users()
            {
                ID = Guid.NewGuid(),
                Name = addUserRequest.Name,
                ProjectID = addUserRequest.ProjectID,
                AddedDate = addUserRequest.AddedDate
            };

            await dbContext.Users.AddAsync(user);
            await dbContext.SaveChangesAsync();

            return Ok(user);
        }

        [HttpPut]
        [Route("{id:guid}")]
        public async Task<IActionResult> UpdateUser([FromRoute] Guid id, UpdateUserRequest updateUserRequest)
        {
            var user = await dbContext.Users.FindAsync(id);

            if (user != null)
            {
                user.Name = updateUserRequest.Name;
                user.ProjectID = updateUserRequest.ProjectID;
                user.AddedDate = updateUserRequest.AddedDate;

                await dbContext.SaveChangesAsync();

                return Ok();
            }

            return NotFound();

        }
    }
}
