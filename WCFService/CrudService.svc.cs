using System;
using System.Collections.Generic;
using System.Linq;

namespace WCFService
{
    public class CrudService : ICrudService
    {
        private readonly List<Todo> todos;

        public CrudService()
        {
            todos = new List<Todo>()
            {
                new Todo("1", "Todo-1", "Todo Description-1"),
                new Todo("2", "Todo-2", "Todo Description-2"),
                new Todo("3", "Todo-3", "Todo Description-3"),
                new Todo("4", "Todo-4", "Todo Description-4")
            };
        }

        public void CreateTodo(Todo todo)
        {
            if (todos.Any(x => x.Id.Equals(todo.Id)))
                return;

            todos.Add(todo);
        }

        public void DeleteTodo(string todoId)
        {
            var todo = todos.FirstOrDefault(x => x.Id.Equals(todoId));
            if (ReferenceEquals(null, todo))
                return;

            todos.Remove(todo);
        }

        public Todo GetTodo(string todoId)
        {
            var todo = todos.FirstOrDefault(x => x.Id.Equals(todoId));
            return todo;
        }

        public IEnumerable<Todo> GetTodos(int take = 100)
        {
            return todos.Skip(0).Take(100);
        }

        public void UpdateTodo(Todo todo)
        {
            var dbTodo = todos.FirstOrDefault(x => x.Id.Equals(todo.Id));
            if (ReferenceEquals(null, dbTodo))
                throw new NotImplementedException();

            dbTodo = todo;
        }
    }
}
