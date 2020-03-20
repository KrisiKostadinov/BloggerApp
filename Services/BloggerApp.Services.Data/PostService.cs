namespace BloggerApp.Services.Data
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using BloggerApp.Data.Common.Repositories;
    using BloggerApp.Data.Models;

    public class PostService : IPostService
    {
        private readonly IDeletableEntityRepository<Post> postsRepository;

        public PostService(IDeletableEntityRepository<Post> postsRepository)
        {
            this.postsRepository = postsRepository;
        }

        public async Task<Post> AddAsync(string title, string content)
        {
            var post = new Post
            {
                Title = title,
                Content = content,
            };

            await this.postsRepository.AddAsync(post);
            await this.postsRepository.SaveChangesAsync();
            return post;
        }

        public IQueryable<Post> All()
        {
            var posts = this.postsRepository.All();
            return posts;
        }
    }
}
