# 🎓 Course Management CRUD App (ASP.NET Core Razor Pages)

A simple CRUD (Create, Read, Update, Delete) web application built with **ASP.NET Core Razor Pages** and **Entity Framework Core**.  
This project is part of my learning journey in **ASP.NET Core**, focusing on data relationships, model binding, and clean Razor Page structures.

[![.NET 8.0](https://img.shields.io/badge/.NET-8.0-blue.svg)](https://dotnet.microsoft.com/)
[![Entity Framework Core](https://img.shields.io/badge/EF%20Core-8.0-green.svg)](https://learn.microsoft.com/en-us/ef/core/)
[![SQL Server](https://img.shields.io/badge/SQL%20Server-2022-red.svg)](https://www.microsoft.com/sql-server)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)

A practice project built to explore **Entity Framework Core** and **Razor Pages** fundamentals by implementing a small course management system.



## 🚀 Features

- 👨‍🏫 **Instructor Management**
  - Register, edit, delete, and view instructors.
- 🎓 **Student Management**
  - Register and manage students in the system.
- 📚 **Course Management**
  - Create, edit, delete, and display courses.
  - Courses are displayed in clean, card-style layouts.
- 🔗 **Relationships**
  - Each course can be linked to an instructor.
- ⚙️ **Database Integration**
  - Fully integrated with **Entity Framework Core (Code-First + Migrations)**.



## 🛠️ Technologies

- **ASP.NET Core 8.0** (Razor Pages)
- **Entity Framework Core 8.0**
- **SQL Server 2022 (Local DB)**
- **Bootstrap 5** for UI styling



## 📸 Screenshots (Coming Soon)

- Course list page
<img width="1343" height="1545" alt="main-page" src="https://github.com/user-attachments/assets/13a59c67-2283-425f-89c9-936f6791e230" />

- Course details page

<img width="1343" height="2141" alt="course-info-page" src="https://github.com/user-attachments/assets/17a01804-cc24-4bb8-a46b-9d9bd97d2ee6" />

- Create Course
  
<img width="1343" height="1182" alt="create-course" src="https://github.com/user-attachments/assets/833226d1-d775-4c20-aaea-c2fd87680b44" />

- Delete Course
  
<img width="1343" height="1277" alt="delete-course" src="https://github.com/user-attachments/assets/5033fa63-caa2-47e4-9222-f59820f6e271" />

- Course management interface
  
<img width="1343" height="769" alt="course-managment-page" src="https://github.com/user-attachments/assets/0510aa57-ee56-470b-a3a8-a58c044380de" />

- Instructor management interface
  
<img width="1343" height="825" alt="instructors-managment-page" src="https://github.com/user-attachments/assets/d35e6a8e-b237-4c16-98f9-4fcf8eadd499" />

- Edit instructor information

<img width="1343" height="825" alt="edit-instructor" src="https://github.com/user-attachments/assets/7eab55e1-cab8-461a-a955-40aea92e58f0" />


## ⚙️ Installation & Setup

1. **Clone the repository**
   ```bash
   git clone https://github.com/Alireza-Jafari-tech/Course-managment-CRUD-app.git
   cd Course-managment-CRUD-app
  

2. **Update your connection string** in `appsettings.json`:

   ```json
   "ConnectionStrings": {
     "DefaultConnection": "Server=localhost;Database=CoursePlatformDb;Trusted_Connection=True;TrustServerCertificate=True"
   }
   ```

3. **Apply migrations & update database**

   ```bash
   dotnet ef database update
   ```

4. **Run the application**

   ```bash
   dotnet run
   ```

   Then open your browser at [http://localhost:7000](http://localhost:7000)

---

## 📂 Project Structure

```plaintext
📦 Course-managment-CRUD-app
 ┣ 📂 Data
 ┃ ┗ 📜 ApplicationDbContext.cs           # EF Core database context
 ┣ 📂 Models
 ┃ ┣ 📜 Course.cs                         # Course entity
 ┃ ┣ 📜 Instructor.cs                     # Instructor entity
 ┃ ┣ 📜 Comment.cs                        # Comment entity
 ┃ ┗ 📜 Student.cs                        # Student entity
 ┣ 📂 Pages
 ┃ ┣ 📂 Courses
 ┃ ┃ ┣ 📜 Create.cshtml / .cs
 ┃ ┃ ┣ 📜 Delete.cshtml / .cs
 ┃ ┃ ┣ 📜 Edit.cshtml / .cs
 ┃ ┃ ┣ 📜 Index.cshtml / .cs
 ┃ ┃ ┗ 📜 Read.cshtml / .cs
 ┃ ┣ 📂 Instructors
 ┃ ┃ ┣ 📜 Create.cshtml / .cs
 ┃ ┃ ┣ 📜 Delete.cshtml / .cs
 ┃ ┃ ┣ 📜 Edit.cshtml / .cs
 ┃ ┃ ┣ 📜 Index.cshtml / .cs
 ┃ ┃ ┗ 📜 Read.cshtml / .cs
 ┃ ┣ 📂 Students
 ┃ ┃ ┣ 📜 Create.cshtml / .cs
 ┃ ┃ ┣ 📜 Delete.cshtml / .cs
 ┃ ┃ ┣ 📜 Edit.cshtml / .cs
 ┃ ┃ ┣ 📜 Index.cshtml / .cs
 ┃ ┃ ┗ 📜 Read.cshtml / .cs
 ┃ ┣ 📜 Index.cshtml / .cs
 ┃ ┣ 📜 _ViewImports.cshtml
 ┃ ┗ 📜 _ViewStart.cshtml                                           
 ┗ 📜 README.md
```

---

## 🎯 Learning Goals

* Understand Razor Pages architecture
* Learn EF Core Code-First workflow and migrations
* Implement CRUD operations with validation
* Work with one-to-many relationships
* Build a clean, responsive Razor UI



## 🧑‍💻 Usage

* Use the **Courses** section to add, edit, or delete courses.
* Manage **Instructors** and **Students** from their respective pages.
* View course information in a card-based layout for easy navigation.




## 📝 License

This project is licensed under the **MIT License**.
See the [LICENSE](LICENSE) file for details.




## 🤝 Contributing

This project is for learning purposes, but contributions are welcome!
Feel free to fork, open issues, or submit pull requests to improve it.

