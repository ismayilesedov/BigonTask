using BigonTask.Areas.Admin.Models.Entities.Commons;

namespace BigonTask.Areas.Admin.Models.Entities
{
    public class Size:BaseEntity<int>
    {
        public string Name { get; set; }
        public string SmallName { get; set; }
    }
}
