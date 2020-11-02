# WCFService

### A simple project which consists of the following:

- WCFService
  - CrudService: Used for random crud operations
  - UserService: Used to validate users
- WCFClientCore
  - TodoController: Exposes the crud operations of the service, but is protected via an Authorize attribute
  - TokenController: Exposes a way to get a jwt token by providing a username and password

### The project accomplishes the following:

- Create a project which exposes it's services via the Windows Communications Foundation (WCF).
- Create a Client project which references the services from the WCF project
- Add [`JWT`](https://tools.ietf.org/html/rfc7519) token authorization support to protect the API endpoints. The user authorization is checked by the WCF service in order to authenticate the user attempting to get a token.
