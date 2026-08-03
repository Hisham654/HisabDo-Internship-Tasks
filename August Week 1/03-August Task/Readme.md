* Project Description:

This is a Student Management Web API project implemented through ASP.NET Core WebAPI. This project showcases CRUD operations for adding, updating, searching and deleting student information.

* How to run the project:

Go into the project folder by typing the command: cd  StudentManagementWebAPI
Then type: dotnet run

The project will build and give u a listening URL where u can see the API response.
Open the Swagger UI, where you can test POST, PUT, GET and DELETE requests.

* API endpoints

the project has following API Endpoints,
GET  ->  api/Students
GET  ->  api/Students/{id}
POST ->  api/Students
PUT -> api/Students/{id}
DELETE ->  api/Students/{id}

Image showing Swagger UI:
![image showing Swagger UI](../../images/Swagger%20API%20Endpoint.png)

Image showing retrieving all students:
![image showing getting all students](../../images/Get%20All%20Students.png)

Image showing getting Students from ID:
![image showing getting Students from ID](../../images/Get%20Student%20From%20ID.png)

Image showing posting Student information:
![image showing posting Student information](../../images/Posting%20SudentInformation.png)

Image showing Updating student information:
![image showing Updating student information](../../images/Updating%20StudentInformation.png)

image showing Deleting Student Information:
![image showing Deleting Student Information](../../images/Delete%20StudentInformation.png)