using taskManager.Communication.Responses;

namespace taskManager_Application.useCases.GetAllTasks;
public class GetAllTasksUseCase
{
    public ResponseAllTasksJson Execute()
    {
        return new ResponseAllTasksJson
        {
            Tasks = new List<ResponseShortAllTasksJson>
            {
                new ResponseShortAllTasksJson{Id = 1,Name = "Lavar", Description = "Lavar pratos" },
                new ResponseShortAllTasksJson{Id = 2,Name = "Pintar parede", Description =" Pintar a parede do quarto" }          

            } 
        };
    }

}
