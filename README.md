# Mango-Microservices
Web app for shopping products and placing orders with web api microservices, mvc project consuming services and displaying them, identity, service bus messaging and Ocelote API gateway. Itegrated Stripe to pay for orders and checking out.

# MVC Web
Mango.Web is a ASP.NET MVC App which consumes the microservices and provides the client-side. We display the functionalities through razor pages, controllers, models and views.

# Services
Contains the ASP.NET Web APIs for our microservices that the front-end uses to display functionalities. Has Authentication&Authorization with ASP.NET Identity, Email service, regular services for the app, enpoints for implementation and connection to databases.

# Integration
Contains a .NET Class library Mango.MessageBus, where it connects to Azure Service Bus for messagin using queues and topics to process emails sent to customers for creating, updating or deleting orders.

# Gateway
Add Ocelote project to act as an API gateway and bring everything together.

# Stripe
Use stripe checkout for collecting payments of orders. After checkout it redirects user to stripe checkout page where they fill information to complete the purchase.

# Startup
Set the connection strings for the databases in the APIs at appsettings.json(Optionally setup azure connection strings as well). Run update-database in console to init databases.
Set visual studio to mulltiple startup project and select the ones that need to be ran.
Start the projects from visual studio adn you are done.
