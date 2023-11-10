using Microsoft.AspNetCore.Mvc;
using ToDoList.Domain.ViewModel.Task;

namespace to_do_list.Controllers;

public class TaskController : Controller
{
    private readonly ILogger<TaskController> _logger;

    public TaskController(ILogger<TaskController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(CreateTaskViewModel model)
    {
        //var response = await _taskService.Create(model);
        //if (response.StatusCode == Domain.Enum.StatusCode.OK)
        //{
        //    return Ok(new { description = response.Description });
        //}
        //return BadRequest(new { description = response.Description });
        return Ok();
    }
   
}
