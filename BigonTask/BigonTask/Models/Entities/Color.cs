using BigonTask.Models.Entities.Commons;

namespace BigonTask.Models.Entities
{
    public class Color:BaseEntity<byte>
    {
        public string Name { get; set; }
    }
}
