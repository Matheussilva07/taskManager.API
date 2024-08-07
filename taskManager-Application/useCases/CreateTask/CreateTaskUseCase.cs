using taskManager.Communication.Enums;
using taskManager.Communication.Requests;
using taskManager.Communication.Responses;

namespace taskManager_Application.useCases.CreateTask;
public class CreateTaskUseCase
{
    public ResponseCreatedTaskJson Execute(RequestCreateTaskJson request)
    {
        return new ResponseCreatedTaskJson
        {
            Id = request.Id,
            Name = request.Name,
            Description = request.Description,
            Priority = request.Priority,
            DeadLine = request.DeadLine,
            Status = StatusTask.Completed
        };
    }
}
