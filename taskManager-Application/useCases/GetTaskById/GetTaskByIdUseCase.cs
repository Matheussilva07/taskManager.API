using taskManager.Communication.Enums;
using taskManager.Communication.Requests;
using taskManager.Communication.Responses;

namespace taskManager_Application.useCases.GetTaskById;
public class GetTaskByIdUseCase
{
    public ResponseCreatedTaskJson Execute(int id)
    {
        return new ResponseCreatedTaskJson
        {
            Id = id,
            Name = "lavar",
            Description = "Lavar os pratos",
            DeadLine = new DateTime(2024,09,02),
            Priority = PriorityTask.high,
            Status = StatusTask.inProgress
        };
    }
}
