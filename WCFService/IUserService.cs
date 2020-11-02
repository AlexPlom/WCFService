using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFService
{
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        User ValidateCredentials(string username, string password);

        [OperationContract]
        User GetById(int id);
    }

    [DataContract]
    public class User
    {
        public User(int id, string firstName, string lastName, string username, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Username = username;
            Password = password;
        }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Username { get; set; }

        [DataMember]
        public string Password { get; set; }
    }
}
