# Mango-Microservices
Web app for shopping products and placing orders with web api microservices, mvc project consuming services and displaying them, identity and service bus messaging.

# MVC Web
Mango.Web is a ASP.NET MVC APP which consumes the microservices and provides the client-side. We display the functionalities through razor pages, controllers, models and views.

# Services
Contains the ASP.NET Web APIs for out microservices that the front-end uses to display functionalities. Has Authentication&Authorization with ASP.NET Identity, Email service, regular services for the app, enpoints for implementation and connection to databases.

# Integration
Contains a .NET Class library Mango.MessageBus, where it connects to Azure Service Bus for messagin using queues and topics to process emails sent to customers for creating, updating or deleting orders.
