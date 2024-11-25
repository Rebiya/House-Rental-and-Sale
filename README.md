# House Rental and Sale Brokerage System

## Overview

The **House Rental and Sale Brokerage System** is a Windows Forms Application designed to streamline the management of properties for rent or sale. It enables administrators and clients to perform essential tasks efficiently through an intuitive desktop application.

The application features a **Home Page** with options to either **Sign In** or **Sign Up**. Users can log in as either an **Admin** or a **Client**, with different functionalities based on their roles.

---

## Features

### General
- **Sign In/Sign Up**: 
  - Users can create a new account or log in using their credentials.
  - Role-based access: **Admin** or **Client**.
- **User-Friendly Interface**: Simple and intuitive navigation built with Windows Forms.

### Admin Features
- Manage property listings (add, edit, delete).
- View and manage all registered users.
- Approve or reject client-submitted property listings.
- Access system reports and transaction history.

### Client Features
- Browse available properties for rent or sale.
- Add and manage personal property listings.
- View personal transaction history and manage profile details.

---

## Technologies Used

- **Programming Language**: C#
- **Framework**: .NET Framework
- **Development Environment**: Visual Studio
- **Database**: SQL Server for data storage and management
- **Authentication**: Custom role-based login system for security.

---

## How to Run the Application

1. **Clone the Repository**  
   ```bash
   git clone https://github.com/your-repository/house-rental-brokerage.git
   ```

2. **Open the Project in Visual Studio**  
   Open the solution file (`.sln`) in Visual Studio.

3. **Restore Dependencies**  
   Ensure all required NuGet packages are installed. Use the **NuGet Package Manager** in Visual Studio if needed.

4. **Configure the Database**  
   - Update the connection string in the application's configuration file (`App.config` or `Settings.settings`) to match your SQL Server setup.
   - Run any SQL scripts provided to set up the database schema.

5. **Build and Run the Application**  
   - Build the solution (`Ctrl + Shift + B`).
   - Run the application by pressing `F5`.

6. **Access the Application**  
   - Start the application and navigate through the **Home Page** to sign in or sign up.

---

## Usage Instructions

1. **Home Page**:
   - Click **Sign In** to log into your account.
   - Click **Sign Up** to create a new account.

2. **Admin Login**:
   - Log in with admin credentials to manage properties, users, and transactions.

3. **Client Login**:
   - Browse or list properties as a client after signing in.

---

## Future Enhancements

- Implement search filters for property browsing.
- Add a notification system for property updates.
- Introduce analytics and charts for admins to view trends.

---

## Contributors

*Developer*
-Rebiya Musema
-Wubrist Alemu

---
