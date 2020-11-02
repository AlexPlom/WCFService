﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference2
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Todo", Namespace="http://schemas.datacontract.org/2004/07/WCFService")]
    public partial class Todo : object
    {
        
        private string DescriptionField;
        
        private string IdField;
        
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description
        {
            get
            {
                return this.DescriptionField;
            }
            set
            {
                this.DescriptionField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Id
        {
            get
            {
                return this.IdField;
            }
            set
            {
                this.IdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name
        {
            get
            {
                return this.NameField;
            }
            set
            {
                this.NameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.ICrudService")]
    public interface ICrudService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudService/CreateTodo", ReplyAction="http://tempuri.org/ICrudService/CreateTodoResponse")]
        System.Threading.Tasks.Task CreateTodoAsync(ServiceReference2.Todo todo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudService/UpdateTodo", ReplyAction="http://tempuri.org/ICrudService/UpdateTodoResponse")]
        System.Threading.Tasks.Task UpdateTodoAsync(ServiceReference2.Todo todo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudService/DeleteTodo", ReplyAction="http://tempuri.org/ICrudService/DeleteTodoResponse")]
        System.Threading.Tasks.Task DeleteTodoAsync(string todoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudService/GetTodo", ReplyAction="http://tempuri.org/ICrudService/GetTodoResponse")]
        System.Threading.Tasks.Task<ServiceReference2.Todo> GetTodoAsync(string todoId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICrudService/GetTodos", ReplyAction="http://tempuri.org/ICrudService/GetTodosResponse")]
        System.Threading.Tasks.Task<ServiceReference2.Todo[]> GetTodosAsync(int take);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface ICrudServiceChannel : ServiceReference2.ICrudService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class CrudServiceClient : System.ServiceModel.ClientBase<ServiceReference2.ICrudService>, ServiceReference2.ICrudService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public CrudServiceClient() : 
                base(CrudServiceClient.GetDefaultBinding(), CrudServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_ICrudService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(CrudServiceClient.GetBindingForEndpoint(endpointConfiguration), CrudServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(CrudServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(CrudServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public CrudServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.Threading.Tasks.Task CreateTodoAsync(ServiceReference2.Todo todo)
        {
            return base.Channel.CreateTodoAsync(todo);
        }
        
        public System.Threading.Tasks.Task UpdateTodoAsync(ServiceReference2.Todo todo)
        {
            return base.Channel.UpdateTodoAsync(todo);
        }
        
        public System.Threading.Tasks.Task DeleteTodoAsync(string todoId)
        {
            return base.Channel.DeleteTodoAsync(todoId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.Todo> GetTodoAsync(string todoId)
        {
            return base.Channel.GetTodoAsync(todoId);
        }
        
        public System.Threading.Tasks.Task<ServiceReference2.Todo[]> GetTodosAsync(int take)
        {
            return base.Channel.GetTodosAsync(take);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICrudService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_ICrudService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:50142/CrudService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return CrudServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_ICrudService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return CrudServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_ICrudService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_ICrudService,
        }
    }
}
