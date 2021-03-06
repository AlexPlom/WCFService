﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceReference1
{
    using System.Runtime.Serialization;


    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "User", Namespace = "http://schemas.datacontract.org/2004/07/WCFService")]
    public partial class User : object
    {

        private string FirstNameField;

        private int IdField;

        private string LastNameField;

        private string PasswordField;

        private string UsernameField;

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName
        {
            get
            {
                return this.FirstNameField;
            }
            set
            {
                this.FirstNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id
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
        public string LastName
        {
            get
            {
                return this.LastNameField;
            }
            set
            {
                this.LastNameField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password
        {
            get
            {
                return this.PasswordField;
            }
            set
            {
                this.PasswordField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Username
        {
            get
            {
                return this.UsernameField;
            }
            set
            {
                this.UsernameField = value;
            }
        }
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName = "ServiceReference1.IUserService")]
    public interface IUserService
    {

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserService/ValidateCredentials", ReplyAction = "http://tempuri.org/IUserService/ValidateCredentialsResponse")]
        System.Threading.Tasks.Task<ServiceReference1.User> ValidateCredentialsAsync(string username, string password);

        [System.ServiceModel.OperationContractAttribute(Action = "http://tempuri.org/IUserService/GetById", ReplyAction = "http://tempuri.org/IUserService/GetByIdResponse")]
        System.Threading.Tasks.Task<ServiceReference1.User> GetByIdAsync(int id);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public interface IUserServiceChannel : ServiceReference1.IUserService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.0.2")]
    public partial class UserServiceClient : System.ServiceModel.ClientBase<ServiceReference1.IUserService>, ServiceReference1.IUserService
    {

        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);

        public UserServiceClient() :
                base(UserServiceClient.GetDefaultBinding(), UserServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUserService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public UserServiceClient(EndpointConfiguration endpointConfiguration) :
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), UserServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public UserServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) :
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public UserServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) :
                base(UserServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }

        public UserServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) :
                base(binding, remoteAddress)
        {
        }

        public System.Threading.Tasks.Task<ServiceReference1.User> ValidateCredentialsAsync(string username, string password)
        {
            return base.Channel.ValidateCredentialsAsync(username, password);
        }

        public System.Threading.Tasks.Task<ServiceReference1.User> GetByIdAsync(int id)
        {
            return base.Channel.GetByIdAsync(id);
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUserService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:50142/UserService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }

        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UserServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUserService);
        }

        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UserServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUserService);
        }

        public enum EndpointConfiguration
        {

            BasicHttpBinding_IUserService,
        }
    }
}
