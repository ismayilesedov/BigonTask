using BigonTask.Areas.Admin.Models.Entities.Commons;

namespace BigonTask.Areas.Admin.Models.Entities
{
    public class Brand : BaseEntity<int>
    {
        public string Name { get; set; }
    }
}
