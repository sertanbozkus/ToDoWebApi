namespace ToDoWebApi.Models
{

    // MVC'deki viewModel'e benzetilebilir.
    public class AddToDoRequest
    {
        public string Title { get; set; }
        public string Content { get; set; }

    }
}
