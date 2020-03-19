namespace BloggerApp.Data.Models
{
    using System;

    using BloggerApp.Data.Common.Models;

    public class Post : BaseModel<int>, IDeletableEntity
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }
    }
}
