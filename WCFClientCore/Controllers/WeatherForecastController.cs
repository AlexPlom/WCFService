using Microsoft.AspNetCore.Mvc;

namespace WCFClientCore.Controllers
{
    [Route("todo"), Authorize]
    public class WeatherForecastController : ApiControllerBase
    {
        ServiceReference2.CrudServiceClient client = new ServiceReference2.CrudServiceClient();

        [Route("get-todos")]
        public IActionResult GetTodos()
        {
            var zz = client.GetTodosAsync(100).GetAwaiter().GetResult();

            return new OkObjectResult(zz);
        }

        [Route("update-todo")]
        public IActionResult UpdateTodo(ServiceReference2.Todo todo)
        {
            client.UpdateTodoAsync(todo).GetAwaiter().GetResult();

            return Ok();
        }

        [Route("create-todo")]
        public IActionResult CreateTodo(ServiceReference2.Todo todo)
        {
            client.CreateTodoAsync(todo).GetAwaiter().GetResult();

            return Ok();
        }

        [Route("delete-todo")]
        public IActionResult DeleteTodo(string todoId)
        {
            client.DeleteTodoAsync(todoId).GetAwaiter().GetResult();

            return Ok();
        }

        [Route("get-todo")]
        public IActionResult GetTodo(string todoId)
        {
            var result = client.GetTodoAsync(todoId).GetAwaiter().GetResult();

            return Ok(result);
        }
    }
}
