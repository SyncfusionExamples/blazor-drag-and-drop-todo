namespace Blazor_WASM_Drag_and_Drop.Models
{
    public class TaskModel
    {
        public int Id { get; set; }
        public TaskStatuses Status { get; set; }
        public string Summary { get; set; } = String.Empty;
        public DateTime Timeline { get; set; }
    }

    public enum TaskStatuses
    {
        Todo,
        Completed
    }

}
