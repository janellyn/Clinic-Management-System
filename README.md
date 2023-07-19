# Clinic-Management-System
App-database 'Clinic Management System' using C# and SQL Server

## Description

Clinic Management System is an application developed using C# and SQL Server to manage a clinic. It provides a user-friendly Windows platform interface using Windows Forms to interact with the database, which stores data about clinic patients, doctors, analysis tests, prescriptions, and receptionists. The application also includes a login/logout window with username and password authentication and separate windows for each clinic staff member with specific access buttons.

## Key Features

The **"Clinic Management System"** application offers the following functionalities:

1. **Authentication**
   - Users must log in to the system using their unique username and password.
   - Different access levels are defined based on the roles of clinic staff members.

2. **Data Management**
   - Addition, viewing, updating, and deletion of patient, doctor, analysis test, and prescription information.

3. **Separate Windows for Each Staff Member**
   - Patients can view and edit their personal information, medical history, and test results.
   - Doctors can view and manage patient appointments and test results.
   - Receptionists have access to patient records and appointment schedules.

4. **User-Friendly Interface**
   - The application provides an intuitive and easy-to-use interface.

## Requirements

To run the application, you need the following:

- Windows operating system.
- Installed .NET Framework to support Windows Forms.
- Installed SQL Server or access to an existing SQL Server to create and manage the database.

## Installation and Setup

1. Clone the repository from GitHub:

git clone https://github.com/janellyn/Clinic-Management-System.git

2. Open the project in Visual Studio or any other supported C# development environment.

3. Create a database named **"clinic_management"** in SQL Server and execute the script from the `database.sql` file to create the required tables and relationships.

4. Update the connection string to the database in the `app.config` file:

```xml
<connectionStrings>
  <add name="ClinicDB" connectionString="Data Source=DESKTOP-1DQOJH6;Initial Catalog=clinic_management;Integrated Security=True;" providerName="System.Data.SqlClient" />
</connectionStrings>
```

5. Compile and run the application.

## Conclusion

Congratulations! Now you have installed and set up the "Clinic Management System" application. You can start managing clinic data, including patients, doctors, tests, prescriptions and receptionists.

If you have any questions or encounter any issues, please create an Issue on GitHub, and we will do our best to assist you in resolving them.

Enjoy using the application!
