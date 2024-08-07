using taskManager.Communication.Enums;

namespace taskManager.Communication.Requests;
public class RequestUpdateTaskJson
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public PriorityTask Priority { get; set; }
    public DateTime DeadLine { get; set; }
    public StatusTask Status { get; set; }
}
