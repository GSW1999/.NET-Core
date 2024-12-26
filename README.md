# .NET-Core
This project is .NET core tutorial. This file is used for notes purpose only.

## Routing
There are two types of routing in .NET Core
1. Attribute-Based Routing
2. Convensional Routing

### Attribute-Based Routing
1. In Attribute-Based Routing, [Route] attribute is used to define the routes.
2. In Attribute-Based Routing, the route is determined based on the attributes which are configured either at the controller level or at the action method level.
3. We can use both Convensional Routing and Attribute-Based Routing in a single application.
4. Changing the controller or action name does not require the route template to be changes.
5. Token for controller is [controller]
6. Token for action method is [action]
7. We can use both tokens together [controller]/[action]
