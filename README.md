# Salon Landing Page & Management System

A professional salon website and content management system built using **ASP.NET MVC 5**, **Entity Framework 6**, and **SQL Server**.

The project provides a modern public-facing salon website while allowing an administrator to manage the salon's content, including services, gallery images, about information, and customer contact enquiries.

---

## 📌 Project Overview

The **Salon Landing Page & Management System** was developed as a portfolio project to demonstrate practical skills in **web application development, database management, authentication, CRUD operations, and responsive user interface design**.

The application has two main areas:

### 🌐 Public Website

Visitors can access the salon website without logging in and view:

* Salon information
* About section
* Services offered
* Gallery
* Contact information
* Contact/enquiry form
* Salon location and other relevant information

### 🔐 Administration Area

Authorized administrators can log in and manage the content displayed on the website.

Administrators can:

* Log in securely
* Access an administration dashboard
* Manage salon information
* Add, edit, and delete services
* Manage gallery content
* View customer enquiries
* Update website content
* Log out securely

---

# ✨ Features

## 🏠 Public Landing Page

The landing page provides visitors with an attractive introduction to the salon.

It includes sections such as:

* Hero section
* About the salon
* Services
* Gallery
* Contact section
* Call-to-action areas

The website is designed to provide visitors with the information they need before contacting or visiting the salon.

---

## 💇 Services Management

The administrator can manage the services displayed on the website.

### Admin capabilities

* Add a new service
* View existing services
* Edit service information
* Delete services

Each service can contain information such as:

* Service name
* Description
* Price
* Other relevant details

Changes made through the administration area are reflected on the public website.

---

## 🖼️ Gallery Management

The gallery allows the salon to showcase its work and environment.

Administrators can manage gallery content through the administration section.

This demonstrates the use of **CRUD functionality** and database-driven content.

---

## ℹ️ About Section

The salon's About information can be managed by the administrator.

This allows the business to update information about:

* The salon
* Its services
* Its values
* Its professional approach
* Other business information

The content is stored in the database rather than being hard-coded into the website.

---

## 📩 Contact / Enquiry System

Visitors can use the contact section to send enquiries to the salon.

The system can capture information such as:

* Name
* Email address
* Message

Administrators can access submitted enquiries from the administration area.

---

## 🔐 Administrator Authentication

The application includes an administrator login system.

The administration area is protected so that website management functionality is not publicly accessible.

Authentication allows the application to demonstrate:

* Login functionality
* Authorization
* Protected admin pages
* Session management
* Logout functionality

---

# 🛠️ Technologies Used

| Technology                     | Purpose                             |
| ------------------------------ | ----------------------------------- |
| **C#**                         | Application programming language    |
| **ASP.NET MVC 5**              | Web application framework           |
| **.NET Framework 4.7.2 / 4.8** | Application framework               |
| **Entity Framework 6**         | Database access / ORM               |
| **SQL Server / LocalDB**       | Database                            |
| **Razor Views**                | Dynamic HTML rendering              |
| **HTML5**                      | Website structure                   |
| **CSS3**                       | Styling and layout                  |
| **JavaScript**                 | Client-side functionality           |
| **Bootstrap**                  | Responsive UI                       |
| **Visual Studio**              | Development environment             |
| **Git & GitHub**               | Version control and project hosting |

---

# 🏗️ Application Architecture

The application follows the **ASP.NET MVC architecture**.

```text
SalonWebsite
│
├── Controllers
│   ├── HomeController
│   ├── AdminController
│   ├── ServicesController
│   ├── GalleryController
│   └── ContactController
│
├── Models
│   ├── Service
│   ├── Gallery
│   ├── About
│   └── Contact
│
├── Views
│   ├── Home
│   ├── Admin
│   ├── Services
│   ├── Gallery
│   └── Contact
│
├── Content
│   └── CSS / Images
│
├── Scripts
│   └── JavaScript
│
├── App_Start
│   └── Application configuration
│
├── App_Data
│   └── Local database files (if applicable)
│
└── Web.config
```

> The exact folder structure may differ slightly depending on the current version of the project.

---

# 🗄️ Database

The application uses **Entity Framework 6 Code First** for database interaction.

The database context used by the application is:

```text
SalonDbContext
```

The database contains the information required to dynamically manage the salon website.

Typical entities include:

```text
Services
Gallery
About
Contact / Enquiries
Users / Administration
```

Entity Framework is responsible for communicating between the MVC application and the SQL database.

---

# 🔄 How the Application Works

The basic application flow is:

```text
                    ┌──────────────────┐
                    │      Visitor     │
                    └────────┬─────────┘
                             │
                             ▼
                    ┌──────────────────┐
                    │  Public Website  │
                    └────────┬─────────┘
                             │
              ┌──────────────┼──────────────┐
              ▼              ▼              ▼
           Services        Gallery        Contact
              │              │              │
              └──────────────┼──────────────┘
                             ▼
                       SQL Database


                    ┌──────────────────┐
                    │     Admin        │
                    └────────┬─────────┘
                             │
                             ▼
                       Admin Login
                             │
                             ▼
                    ┌──────────────────┐
                    │ Admin Dashboard  │
                    └────────┬─────────┘
                             │
              ┌──────────────┼──────────────┐
              ▼              ▼              ▼
          Services        Gallery        Content
          Management      Management      Management
                             │
                             ▼
                       SQL Database
```

---

# 📋 CRUD Operations

A major part of this project is implementing CRUD operations.

CRUD stands for:

* **Create**
* **Read**
* **Update**
* **Delete**

For example, an administrator can manage salon services:

```text
Create
   ↓
Add new service

Read
   ↓
View services

Update
   ↓
Edit service

Delete
   ↓
Remove service
```

This demonstrates practical database-driven application development.

---

# 🔒 Security

The application uses authentication and authorization to protect the administration functionality.

Important security concepts demonstrated include:

* Administrator authentication
* Authorization
* Protected controller actions
* Password-based login
* Anti-forgery protection
* Server-side validation
* Model validation

Sensitive configuration information such as production database credentials should **not** be committed to GitHub.

---

# 📱 Responsive Design

The website is designed to work across different screen sizes, including:

* Desktop computers
* Laptops
* Tablets
* Mobile devices

Responsive design techniques are used to ensure that the website remains usable on different devices.

---

# 🚀 Getting Started

Follow these steps to run the project locally.

## 1. Clone the Repository

Open a terminal or Git Bash and run:

```bash
git clone https://github.com/Zingelwayo22/SalonWebsite.git
```

Then move into the project directory:

```bash
cd SalonWebsite
```

---

## 2. Open the Project

Open the solution file:

```text
SalonWebsite.sln
```

using **Visual Studio**.

---

## 3. Restore NuGet Packages

In Visual Studio:

```text
Tools
    ↓
NuGet Package Manager
    ↓
Package Manager Settings
```

Restore the required packages if Visual Studio does not restore them automatically.

---

## 4. Configure the Database

The application uses Entity Framework 6 and the `SalonDbContext`.

Check the connection string in:

```text
Web.config
```

Example:

```xml
<connectionStrings>
    <add name="SalonDbContext"
         connectionString="Data Source=(LocalDb)\MSSQLLocalDB;Initial Catalog=SalonWebsiteDB;Integrated Security=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

Your connection string may differ depending on your local SQL Server configuration.

---

## 5. Run Entity Framework Migrations

Open:

```text
Tools
    ↓
NuGet Package Manager
    ↓
Package Manager Console
```

Then run:

```powershell
Update-Database
```

This creates or updates the database based on the Entity Framework migrations.

---

## 6. Build the Application

In Visual Studio:

```text
Build
    ↓
Build Solution
```

or press:

```text
Ctrl + Shift + B
```

Make sure the project builds successfully.

---

## 7. Run the Application

Press:

```text
F5
```

or:

```text
Ctrl + F5
```

Visual Studio will launch the application using IIS Express.

---

# 🔑 Administration

The administrator can access the administration section through:

```text
/Admin
```

The exact login route depends on the authentication configuration in the project.

After successful authentication, the administrator can access the dashboard and manage the salon website.

---




# 🧪 Validation & Error Handling

The application uses validation to help ensure that users submit valid information.

Examples include:

* Required field validation
* Email validation
* Server-side model validation
* Error messages
* Database validation
* Authentication validation

This helps prevent invalid information from being stored in the database.

---

# 🎯 Project Objectives

The main objectives of this project were to:

* Build a real-world web application
* Apply the MVC design pattern
* Work with C# and ASP.NET MVC
* Implement Entity Framework Code First
* Work with relational databases
* Implement CRUD functionality
* Implement authentication and authorization
* Create responsive web pages
* Separate application logic using MVC
* Practice Git and GitHub
* Develop a portfolio-ready application

---

# 🧠 What I Learned

Through this project, I gained practical experience with:

### ASP.NET MVC

Understanding how:

```text
Model → Controller → View
```

works together to create a web application.

### Entity Framework

I learned how to:

* Create models
* Create a database context
* Use migrations
* Create database tables
* Retrieve database records
* Insert records
* Update records
* Delete records

### Authentication

I gained experience implementing:

* User login
* Administrator access
* Authorization
* Logout functionality

### Database Development

The project helped me understand how an application communicates with a SQL database and how database information can be displayed dynamically on a website.

### GitHub

The project also provided practical experience with:

* Git
* GitHub repositories
* Commits
* Branches
* README documentation
* Project presentation

---

# 🔮 Future Improvements

Possible future improvements include:

* Online appointment booking
* Customer registration and accounts
* Online payments
* Staff management
* Appointment management
* Automated email notifications
* SMS notifications
* Customer reviews
* Service categories
* Staff profiles
* Advanced admin dashboard
* Appointment calendar
* Reporting and analytics
* Image upload functionality
* Cloud deployment
* Improved role-based authorization

---

# ☁️ Deployment

The application can be deployed to a hosting environment that supports **ASP.NET MVC 5 / .NET Framework**.

Possible deployment options include:

* IIS
* Azure App Service
* Windows-based hosting providers

For production deployment, database credentials and other sensitive configuration values should be stored securely and should not be committed to the repository.

---

# 📚 Project Type

**Portfolio Project**

This project was created to demonstrate practical skills in:

```text
C#
ASP.NET MVC
Entity Framework 6
SQL Server
HTML
CSS
JavaScript
Bootstrap
Authentication
CRUD
Database Development
Git & GitHub
```

---

# 👨‍💻 Developer

**Andile Ndlovu**

Diploma in Information and Communication Technology in Applications Development
Durban University of Technology

### Skills Demonstrated

* C#
* ASP.NET MVC
* Entity Framework
* SQL Server
* HTML5
* CSS3
* JavaScript
* Bootstrap
* Git & GitHub
* Database Development
* Web Application Development
* Authentication & Authorization

---

# 📫 Contact

If you would like to learn more about this project or discuss potential opportunities, feel free to connect with me on LinkedIn.

**GitHub:**
https://github.com/Zingelwayo22

**LinkedIn:**
https://www.linkedin.com/in/andile-ndlovu-244359392/

---

# ⭐ Final Note

This project represents my practical experience in developing a database-driven web application using the **ASP.NET MVC framework**.

The goal was not only to create a visually appealing salon website, but also to demonstrate how a real business could manage its website content through an administrative system backed by a relational database.

If you find this project useful or interesting, feel free to explore the repository.
