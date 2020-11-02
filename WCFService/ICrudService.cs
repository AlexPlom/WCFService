using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFService
{
    [ServiceContract]
    public interface ICrudService
    {
        [OperationContract]
        void CreateTodo(Todo todo);

        [OperationContract]
        void UpdateTodo(Todo todo);

        [OperationContract]
        void DeleteTodo(string todoId);

        [OperationContract]
        Todo GetTodo(string todoId);

        [OperationContract]
        IEnumerable<Todo> GetTodos(int take = 100);
    }

    [DataContract]
    public class Todo
    {
        public Todo(string id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        [DataMember]
        public string Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string Description { get; set; }
    }
}
