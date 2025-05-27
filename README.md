# Hello World in ASP.NET



## Routing

## Controller

## View

## Model

## API

## 2025-05-27 To Do List 

- [ ] Create Model class
- [ ] Create data repository class
- [ ] connect database (MS SQL / MySQL)
- [ ] Controller 
- [ ] Views
- [ ] Test
- [ ] API 

## 2025-05-28 Authorization

- [ ] Web Authorization
- [ ] API Authorization


## Check MSSQL is running 

```bash
sqlcmd -S localhost -Q "SELECT @@VERSION"
```



```bash
Sqlcmd: Error: Microsoft ODBC Driver 17 for SQL Server : Login failed for user 'root'..

C:\Users\aungk>sqlcmd -S localhost -E
1>
2>
3>
4>
5>
6>
7>
8>
9> ^X
Sqlcmd: Warning: The last operation was terminated because the user pressed CTRL+C.

C:\Users\aungk>sqlcmd -S localhost -E
1> 1
2> ^X
Sqlcmd: Warning: The last operation was terminated because the user pressed CTRL+C.

C:\Users\aungk>sqlcmd -S localhost -E
1> CREATE DATABASE ToDoListDB;
2> USE ToDoListDB;
3> GO
Msg 911, Level 16, State 1, Server MEBCBS-2-285, Line 2
Database 'ToDoListDB' does not exist. Make sure that the name is entered correctly.
1> CREATE DATABASE ToDoListDB;
2> GO;
3> USE ToDoListDB;
4> CREATE TABLE TaskModel (
5>     Id INT IDENTITY(1,1) PRIMARY KEY,
6>     Title NVARCHAR(100) NOT NULL,
7>     Description NVARCHAR(500),
8>     DueDate DATE,
9>     IsCompleted BIT NOT NULL DEFAULT 0,
10>     CreatedAt DATETIME NOT NULL DEFAULT GETUTCDATE(),
11>     UpdatedAt DATETIME NULL
12> );
13> GO;
14> sqlcmd -S localhost -d ToDoListDB -E
15>
16> INSERT INTO TaskModel (Title, Description, DueDate, IsCompleted, CreatedAt)
17> VALUES ('Finish unit testing', 'Complete all unit tests for project', '2025-06-01', 0, GETUTCDATE());
18> GO;
19> SELECT * FROM TaskModel;
20> GO;
21> SELECT * FROM TaskModel;
22> GO;
23> Go
Msg 911, Level 16, State 1, Server MEBCBS-2-285, Line 3
Database 'ToDoListDB' does not exist. Make sure that the name is entered correctly.
Msg 102, Level 15, State 1, Server MEBCBS-2-285, Line 2
Incorrect syntax near 'GO'.
1> exit;
2> Go
Msg 156, Level 15, State 1, Server MEBCBS-2-285, Line 1
Incorrect syntax near the keyword 'exit'.
1> CREATE DATABASE ToDoListDB;
2> Go
1> use ToDoListDB;
2> Go
Changed database context to 'ToDoListDB'.
1> CREATE TABLE TaskModel (
2>     Id INT IDENTITY(1,1) PRIMARY KEY,
3>     Title NVARCHAR(100) NOT NULL,
4>     Description NVARCHAR(500),
5>     DueDate DATE,
6>     IsCompleted BIT NOT NULL DEFAULT 0,
7>     CreatedAt DATETIME NOT NULL DEFAULT GETUTCDATE(),
8>     UpdatedAt DATETIME NULL
9> );
10> Go
1> INSERT INTO TaskModel (Title, Description, DueDate, IsCompleted, CreatedAt)
2> VALUES ('Finish unit testing', 'Complete all unit tests for project', '2025-06-01', 0, GETUTCDATE());
3> Go

(1 rows affected)
1> SELECT * FROM TaskModel;
2> Go
Id          Title                                                                                                Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          DueDate          IsCompleted CreatedAt               UpdatedAt
----------- ---------------------------------------------------------------------------------------------------- -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- ---------------- ----------- ----------------------- -----------------------
          1 Finish unit testing                                                                                  Complete all unit tests for project                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        2025-06-01           0 2025-05-27 05:40:07.867                    NULL

(1 rows affected)
1>
```

