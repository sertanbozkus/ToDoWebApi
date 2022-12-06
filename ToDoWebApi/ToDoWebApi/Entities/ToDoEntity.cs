namespace ToDoWebApi.Entities
{
    public class ToDoEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsDone { get; set; }

    }
}
