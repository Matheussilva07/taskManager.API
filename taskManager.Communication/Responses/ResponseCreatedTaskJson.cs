using taskManager.Communication.Enums;

namespace taskManager.Communication.Responses;
public class ResponseCreatedTaskJson
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityTask Priority { get; set; }
    public DateTime DeadLine { get; set; }
    public StatusTask Status { get; set; }
}
