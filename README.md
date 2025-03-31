# 📊 Transaction Record App

An ASP.NET Core MVC web application for managing stock transactions with secure user authentication and role-based authorization using **ASP.NET Core Identity**.

---

## ✅ Features

- User **Registration** & **Login**
- Role-based **Authorization**
  - Regular users: Add/Edit transactions
  - Admin users: Add/Edit/Delete transactions
- SQL Server integration via **Entity Framework Core**
- **Seeded Admin Account**
- Secure password handling with Identity
- Responsive UI using Bootstrap

---
## 🛠️ Technologies Used

- ASP.NET Core MVC (.NET 8.0)
- Entity Framework Core
- SQL Server / LocalDB
- Identity Framework (Authentication & Authorization)
- Bootstrap
  
---

## 🚀 Getting Started

### 🔧 Prerequisites

- .NET 8 SDK
- SQL Server (Express or full version)
- Visual Studio 2022 or newer
- Optional: SQL Server Management Studio (SSMS)

---

### ⚙️ Setup Instructions

1. **Clone the repository**

```bash
git clone https://github.com/Drasti24/TransactionRecordApp.git
cd TransactionRecordApp
```
2. **Open the solution in Visual Studio**

   - Open `TransactionRecordApp.sln` using Visual Studio 2022 or newer.
   - Make sure your build target is set to **.NET 8.0**.
   - Ensure that **NuGet packages** are restored (Visual Studio will usually do this automatically).

3. **Update the database connection string**

   Open `appsettings.json` and verify the connection string:

   ```json
   "ConnectionStrings": {
     "TransactionsDb": "Server=localhost;Database=TransactionRecord123456;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=true"
   }
   ```
   Then apply the migrations
   ```
   dotnet ef database update
   ```
   This will:
   - Create database specified in appsettings.json
   - Apply all pending migrations
   - Add required Identity tables
   - Seed the admin user automatically.

4. **▶️ Run the Application**
   Start the application using either of these methods:
   
   **In Visual Studio:**
   - Click the green "Start" button (with IIS Express or Kestrel)
  
   **From Terminal**
   ```
   dotnet run
   ```
   Once running, open your browser and go to:
   ```
   https://localhost:{PORT}
   ```
   Replace {PORT} with the project's HTTPS port number (e.g., 44342).

---

## 🧩 Feature Walkthrough

| Feature                 | Description                                      |
|------------------------|--------------------------------------------------|
| Registration/Login     | Users can register and login using Identity      |
| Authenticated Add/Edit | Only logged-in users can add or edit transactions|
| Admin Delete Access    | Only admin can delete transactions               |
| Hashed Passwords       | Passwords are securely stored via Identity       |

---

## 📦 NuGet Packages Used

- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.AspNetCore.Authentication.Cookies

---

## 🧪 Test Accounts

| Role  | Username | Password     |
|-------|----------|--------------|
| Admin | admin    | Sesame123#   |
| User  | Register using form     |

---

## 👤 Author

- **Name:** Drasti Patel  
- **GitHub:** https://github.com/Drasti24
- **Email:** drasti.patel2402@gmail.com

---

## 📝 License

This project was developed as part of an academic assignment and is intended for educational use only.
