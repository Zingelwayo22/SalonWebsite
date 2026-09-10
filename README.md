.Salon Website & Management System(Landing page)

svg

A modern and responsive salon website built using ASP.NET MVC 5, C#, Entity Framework, and SQL Server. The application provides a professional online presence for a salon while allowing salon staff to manage website content such as services, information, and images.

The project was developed as part of my software development portfolio to demonstrate my ability to design, develop, and manage a full-stack web application using Microsoft's .NET framework.

Project Overview

svg

The Salon Website is designed to provide customers with an attractive and informative online experience while giving salon administrators the ability to manage important website content.

The website allows customers to view information about the salon, browse available services, and find contact information.

An administrative side of the system allows authorized users to manage content without needing to modify the source code directly.

Project Objectives

svg

The main objectives of this project were to:

Build a professional salon website.
Create a responsive and user-friendly interface.
Allow salon administrators to manage website content.
Store salon information and services in a database.
Implement CRUD functionality using Entity Framework.
Follow the MVC software architecture.
Practice connecting a web application to SQL Server.
Develop a project suitable for a professional software development portfolio.
Features

svg

Home Page

svg

The home page provides visitors with an overview of the salon and highlights important information.

Features include:

Salon introduction
Featured services
Professional presentation
Navigation to other sections of the website
Responsive layout
Services

svg

Customers can view the services offered by the salon.

Each service can contain information such as:

Service name
Description
Price
Service image
Other relevant information

Administrators can add, edit, and delete services through the management functionality.

Gallery

svg

The website can display images to showcase the salon, its environment, and its work.

Gallery functionality provides the salon with a way to visually demonstrate its services to potential customers.

About Section

svg

The website contains information about the salon, allowing visitors to learn more about the business.

The section can include:

Salon description
Mission/information
Business information
Professional presentation
Contact Information

svg

Customers can access important contact information for the salon.

This can include:

Phone number
Email address
Physical location
Business information
Social media/contact details
Administration

svg

The management functionality allows authorized users to manage website information.

Administrators can manage areas such as:

Services
Website information
Images
Contact information

This reduces the need to manually edit website source code whenever salon information changes.

Technologies Used

svg

Frontend

svg

HTML5
CSS3
JavaScript
Bootstrap
Razor Views
Backend

svg

C#
ASP.NET MVC 5
.NET Framework
Entity Framework 6
Database

svg

Microsoft SQL Server
Entity Framework Code First
Development Tools

svg

Microsoft Visual Studio
SQL Server Management Studio (SSMS)
Git
GitHub
Architecture

svg

The application follows the Model-View-Controller (MVC) architectural pattern.

Model

svg

Models represent the application's data and database entities.

Examples include:

Service
WebsiteSettings
Other website-related entities
View

svg

Razor views are responsible for displaying information to the user.

Examples include:

Home page
Services page
About page
Contact page
Administrative pages
Controller

svg

Controllers handle application requests and business logic.

They are responsible for:

Receiving requests
Retrieving data
Updating database records
Passing data to views
Performing CRUD operations
Database

svg

The application uses Microsoft SQL Server as its database.

Entity Framework 6 is used to communicate between the ASP.NET MVC application and SQL Server.

The project uses the Code First approach, allowing database tables to be generated from the application's models.

Typical data managed by the application includes:

Services
Website Settings
Gallery / Images
Salon Information
Contact Information


svg

CRUD Operations

svg

The project demonstrates complete CRUD functionality.

Create

svg

Administrators can add new services and website information.

Read

svg

Website visitors can view services and salon information.

Update

svg

Administrators can modify existing records.

Delete

svg

Administrators can remove outdated services or information.

Project Structure

svg

A simplified structure of the application is:

SalonWebsite/
│
├── App_Start/
│
├── Controllers/
│   ├── HomeController.cs
│   ├── ServicesController.cs
│   └── ...
│
├── Models/
│   ├── Service.cs
│   ├── WebsiteSettings.cs
│   └── ...
│
├── Views/
│   ├── Home/
│   ├── Services/
│   ├── Shared/
│   └── ...
│
├── Content/
│   ├── CSS/
│   └── Images/
│
├── Scripts/
│
├── App_Data/
│
├── Web.config
│
└── Global.asax


svg

Installation & Setup

svg

Follow these steps to run the project locally.

1. Clone the Repository

svg

Clone the repository using Git:

git clone https://github.com/YOUR-USERNAME/YOUR-REPOSITORY.git

svg

Or clone it using GitHub Desktop.

Open the Project

svg

Open the solution file in:

Microsoft Visual Studio

The project was developed using ASP.NET MVC 5 and the .NET Framework.

Restore NuGet Packages

svg

Restore the required NuGet packages through Visual Studio.

You can also use:

Update-Package -reinstall

svg

from the Package Manager Console if necessary.

Configure the Database

svg

Update the connection string in:

Web.config


svg

Example:

<connectionStrings>
    <add name="SalonDbContext"
         connectionString="YOUR_CONNECTION_STRING"
         providerName="System.Data.SqlClient" />
</connectionStrings>

svg

Replace the connection string with your local SQL Server configuration.

Create the Database

svg

If Code First Migrations are being used, run:

Update-Database

svg

from the Visual Studio Package Manager Console.

This will create/update the database according to the Entity Framework migrations.

Build the Application

svg

In Visual Studio:

Build → Build Solution


svg

Make sure the solution builds successfully.

Run the Application

svg

Press:

Ctrl + F5


svg

or select:

IIS Express


svg

The application should open in your browser.

Configuration

svg

Before running the application, make sure the following are correctly configured:

SQL Server connection string
Database name
Entity Framework configuration
Required NuGet packages
Image/file paths where applicable

Sensitive information such as database passwords should not be committed to GitHub.

Security Considerations

svg

The project is designed with basic application security considerations in mind.

Important practices include:

Administrative functionality should be protected from unauthorized access.
Database credentials should not be stored publicly.
Connection strings containing passwords should not be committed to the repository.
User input should be validated.
Production applications should use HTTPS.
Authentication and authorization should be configured before deploying the application publicly.
Responsive Design

svg

The website was designed to provide a usable experience across different screen sizes.

The interface supports:

Desktop computers
Laptops
Tablets
Mobile devices

Bootstrap and responsive CSS techniques are used to help maintain a consistent layout across devices.

Testing

svg

The application was tested during development to verify:

Pages load correctly.
Services can be displayed.
Services can be added.
Existing services can be edited.
Services can be deleted.
Database operations work correctly.
Images display correctly.
Navigation works between pages.
The application builds successfully.
Future Improvements

svg

Possible future improvements include:

Online appointment booking
Customer accounts
Staff accounts
Role-based authorization
Appointment management
Email notifications
SMS appointment reminders
Online payments
Customer reviews
Advanced image gallery management
Admin dashboard with statistics
Service availability management
Deployment to a cloud hosting platform
Screenshots

svg

Screenshots of the application can be added here.

Example:

docs/
├── home-page.png
├── services-page.png
├── about-page.png
├── gallery-page.png
└── admin-dashboard.png


svg

Then display them in the README:

![Home Page](docs/home-page.png)

![Services Page](docs/services-page.png)

![Admin Dashboard](docs/admin-dashboard.png)

svg

Adding screenshots is highly recommended for your GitHub portfolio, because recruiters can immediately see what you built without having to run the project.

What I Learned

svg

Through this project, I gained practical experience with:

ASP.NET MVC development
C# programming
Entity Framework
SQL Server database development
MVC architecture
CRUD operations
Razor views
HTML and CSS
Bootstrap
Database migrations
Debugging ASP.NET applications
Git and GitHub
Structuring a real-world web application

I also gained experience troubleshooting issues involving models, views, layouts, database connections, and runtime errors.

Developer

svg

Andile Ndlovu

Diploma in Information and Communication Technology Applications Development

Skills demonstrated in this project include:

C#
ASP.NET MVC
.NET Framework
Entity Framework
SQL Server
HTML
CSS
JavaScript
Bootstrap
Git
GitHub
Visual Studio
License

svg

This project was developed for educational, portfolio, and demonstration purposes.

🚀 Project Status

svg

Status: Completed / Portfolio Project
