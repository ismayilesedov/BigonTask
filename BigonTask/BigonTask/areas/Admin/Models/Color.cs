using BigonTask.Areas.Admin.Models.Entities.Commons;

namespace BigonTask.areas.Admin.Models
{
    public class Color:BaseEntity<byte>
    {
        public string Name { get; set; }
        public string HexCode { get; set; }
    }
}
