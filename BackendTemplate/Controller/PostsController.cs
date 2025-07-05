namespace BackendTemplate.Controller
{
    using Microsoft.AspNetCore.Mvc;
    using BackendTemplate.Models;
    using System.Collections.Generic;
    using Microsoft.EntityFrameworkCore;
    using BackendTemplate.Data;

    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Post>>> GetAllPosts()
        {
            // NEW: Query all posts from database
            var posts = await _context.Posts.ToListAsync();
            return Ok(posts);
        }
       
    }
}