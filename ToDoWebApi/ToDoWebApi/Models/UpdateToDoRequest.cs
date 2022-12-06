namespace ToDoWebApi.Models
{
    public class UpdateToDoRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsDone { get; set; }

    }
}
