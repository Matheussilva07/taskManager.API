using Microsoft.AspNetCore.Mvc;
using taskManager.Communication.Requests;
using taskManager.Communication.Responses;
using taskManager_Application.useCases.CreateTask;
using taskManager_Application.useCases.DeleteTask;
using taskManager_Application.useCases.GetAllTasks;
using taskManager_Application.useCases.GetTaskById;
using taskManager_Application.useCases.UpdateTask;

namespace Gerenciador_de_tarefas_API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TasksController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult CreateTask([FromBody]RequestCreateTaskJson request)
    {
        var useCase = new CreateTaskUseCase();

        var response = useCase.Execute(request);

        return Ok(response);
    }

    [HttpGet]
    [ProducesResponseType(typeof(ResponseAllTasksJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAllTasks()
    {
        var response = new GetAllTasksUseCase().Execute();

        if (response.Tasks.Any())
        {
            return Ok(response);
        }
        return NoContent();
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(ResponseCreatedTaskJson), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult GetTaskById([FromRoute]int id)
    {
        var response = new GetTaskByIdUseCase().Execute(id);

        return Ok(response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseErrorsJson), StatusCodes.Status400BadRequest)]
    public IActionResult UpdateTask([FromRoute]int id, [FromBody] RequestUpdateTaskJson request)
    {
        var useCase = new UpdateTaskUseCase();

        useCase.Execute(id, request);

        return NoContent();
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(List<ResponseErrorsJson>), StatusCodes.Status400BadRequest)]
    public IActionResult DeleteTaskById(int id)
    {
        var useCase = new DeleteTaskByIdUseCase();
        
        useCase.Execute(id);

        return NoContent();
    }
}
