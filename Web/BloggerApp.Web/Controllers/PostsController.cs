namespace BloggerApp.Web.Controllers
{
    using System.Linq;

    using BloggerApp.Services.Data;
    using BloggerApp.Services.Mapping;
    using BloggerApp.Web.ViewModels.Posts;
    using Microsoft.AspNetCore.Mvc;

    public class PostsController : Controller
    {
        private readonly IPostService postService;

        public PostsController(IPostService postService)
        {
            this.postService = postService;
        }

        public IActionResult All()
        {
            var posts = this.postService.All().To<PostViewModel>().ToList();
            return this.View(posts);
        }
    }
}
