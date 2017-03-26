# Asynchronous Generic Repository using Entity Framework
An asynchronous Generic Repository Pattern for MVC with Service Layer and Dependency Injection[Constructor Injection].

# Environment & Tools
- Visual Studio 2013 Community+
- Entity Framework
- Unity Dependancy Injection Container

# Architecture
**Project Name:** Core <br />
**Project Type:** Class Library <br />
**Description:** All the Entities, View Models, DbContext, CommonHelper and generic Repository will be present  here. Generic repository is designed using Entity framework. Generic repository has Interface and its implementation and our service layer will consume this generic repository.Generic repository have only basic CRUD operations.


**Project Name:** Service <br />
**Project Type:** Class Library <br />
**Description:** All the functions related to entities/table will be written here e.g, CRUD operations, joins result view models, transactions. This layer consuming the repository for database operations. This is abstraction between controller and data access layer (repository layer). Controller actually consumes service layer. Each service class has its interface and we using it controller, we possibly trying our system is depends on abstraction not on implementations. 


**Project Name:** ef-generic-repository <br />
**Project Type:** MVC Web Project <br />
**Description:** This is our MVC project which consuming above both projects. We are creating instance of services by using Unity Dependency Injection container. The constructor injection is used on controllers. I written simple CRUD operations for employee class. It will give basic idea how to use the architecture. All calls are async supports

# Note:
If you find some improvement needed to make it more effective and scalable. Please feel free to contribute on it. Your help is much appreciated for the .NET world.
