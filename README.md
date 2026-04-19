# Student Management API

ASP.NET Core Web API project developed for **Zest India IT Pvt Ltd Technical Assessment**.

## 📌 Project Overview

This project is a **Student Management System** built using ASP.NET Core Web API with clean layered architecture.

It provides secure CRUD operations for managing student records.

---

##  Features

* Get All Students
* Get Student By Id
* Add New Student
* Update Student Details
* Delete Student
* JWT Authentication
* Swagger API Documentation
* Global Exception Handling Middleware
* Repository Pattern
* Service Layer Architecture
* SQL Server Database Integration

---

##  Technologies Used

* ASP.NET Core Web API
* C#
* Entity Framework Core
* SQL Server
* JWT Authentication
* Swagger / OpenAPI
* xUnit Testing
* Moq

---

##  Project Structure

StudentManagementAPI
├── Controllers
├── Models
├── Data
├── Repository
├── Services
├── Middleware
├── DTOs

StudentManagementAPI.Tests

---

##  Authentication

Use below credentials to generate JWT token:

* Username: `admin`
* Password: `123`

Use `/api/auth/login`

After login, click **Authorize** in Swagger and enter:

Bearer YOUR_TOKEN

---

##  Database Setup

Create database:

`StudentDb`

Student Table:

* Id
* Name
* Email
* Age
* Course
* CreatedDate

Update connection string in:

`appsettings.json`

---

##  How to Run Project

1. Open solution in Visual Studio
2. Restore NuGet packages
3. Update SQL Server connection string
4. Run project
5. Swagger will open automatically
6. Test Login and Student APIs

---

##  Unit Testing (Bonus)

Included unit test project using **xUnit + Moq**

Tested:

* Invalid Age should throw exception

---

##  API Endpoints

### Auth

POST `/api/auth/login`

### Student

GET `/api/student`
GET `/api/student/{id}`
POST `/api/student`
PUT `/api/student`
DELETE `/api/student/{id}`

## Future Improvements:
- Frontend UI using Angular/React
- More unit tests
- Role-based authorization
---

##  Developed By
Developed by Hemant Pawar as part of the Zest India IT assessment.
Focused on secure APIs, layered architecture, and clean code practices.
