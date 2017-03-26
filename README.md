# Asynchronous Generic Repository using Entity Framework
An asynchronous Generic Repository Pattern for MVC with Service Layer and Dependancy Injection[Constructor Injection].

# Architecture
**Project Name:** Core <br />
**Project Type:** Class Library <br />
**Description:** All the Entities, ViewModels, DbContext, CommonHelper and generic Repository will be presnet here. Generic repository is designed using Entity framework. Generic repository has Interface and its implementation and our service layer will consume this generic repository.Generic repository have only basic CRUD operations.


**Project Name:** Service <br />
**Project Type:** Class Library <br />
**Description:** All the functions related to entities/table will be written here e.g, CRUD operations, joins result viewmodels, transactions. This layer consuming the repository for database operations. This is abstraction between controller and data access layer (repository layer). Controller actually consumes service layer.  
