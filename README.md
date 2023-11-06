# Todo-App-Using-Entity-Framework-Core-and-Repository-Pattern
Description
The To-Do Application is a basic task management tool that allows users to create and manage their to-do lists. It provides a simple and intuitive interface to add and mark tasks as completed. This application is designed with a focus on performance, utilizing asynchronous programming for heavy-duty operations, and storing task data in a Microsoft SQL Server database using ADO.NET.

Technologies Used
C#: The core programming language used to build the application.
ASP.NET Core API: Used to create the web API for handling task management operations.
Microsoft SQL Server: The relational database used for storing task data.
ADO.NET: The data access technology used to interact with the SQL Server database.
Features
Create, edit, and delete tasks.
Mark tasks as completed or incomplete.
List tasks based on their completion status.
Store tasks in a Microsoft SQL Server database for data persistence.
Efficiently handle heavy-duty operations using asynchronous programming.

Database Setup
Create a new database in your SQL Server instance.
Execute the SQL script provided in the database_setup.sql file to set up the necessary tables and schema.
Update the connection string in the appsettings.json file to match your database configuration.
