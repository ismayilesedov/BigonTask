using BigonTask.Areas.Admin.Models.Entities.Commons;

namespace BigonTask.Areas.Admin.Models.Entities
{
    public class Category:BaseEntity<int>
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }
}
