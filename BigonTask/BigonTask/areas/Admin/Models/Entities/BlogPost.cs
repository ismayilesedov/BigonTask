using BigonTask.Areas.Admin.Models.Entities.Commons;

namespace BigonTask.Areas.Admin.Models.Entities
{
    public class BlogPost
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public string ImagePath { get; set; }
        public string Slug { get; set; }
        public int CategoryId { get; set; }
        public DateTime? PublishedAt { get; set; }
    }
}
