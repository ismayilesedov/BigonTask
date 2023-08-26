namespace BigonTask.Areas.Admin.Models.Entities
{
    public class ContactPost
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public string Answer { get; set; }
        public int? AnswerBy { get; set; }
        public DateTime? AnswerAt { get; set; }
    }
}
