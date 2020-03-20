namespace BloggerApp.Web.ViewModels.Posts
{
    using System;

    using BloggerApp.Data.Models;
    using BloggerApp.Services.Mapping;

    public class PostViewModel : IMapFrom<Post>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
