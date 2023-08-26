using BigonTask.Areas.Admin.Models.Entities.Commons;

namespace BigonTask.Areas.Admin.Models.Entities
{
    public class ProductImage:BaseEntity<int>
    {
        public string Name { get; set; }
        public bool IsMain { get; set; }
        public int ProductId { get; set; }
    }
}
