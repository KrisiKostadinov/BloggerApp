namespace BloggerApp.Services.Data
{
    using System.Linq;
    using System.Threading.Tasks;

    using BloggerApp.Data.Models;

    public interface IPostService
    {
        Task<Post> AddAsync(string title, string content);

        IQueryable<Post> All();
    }
}
