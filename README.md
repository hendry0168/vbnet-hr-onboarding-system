# VB.NET HR Onboarding & Offboarding System

This is a VB.NET desktop application designed to manage the full employee lifecycle, from onboarding to offboarding. It is backed by a SQL Server database and includes data entry forms and reporting tools.

## ✨ Features

- **Master Data Management**  
  Manage lookup values such as education, gender, employment type, level, and status.

- **Employee Onboarding**  
  Insert new employees into the system, saving their data into `person` and `personnel` tables.

- **Employee Offboarding**  
  Update employee records upon resignation or termination, including setting resignation date and status (resigned/banned).

- **Reports**  
  - Onboarding Report  
  - Offboarding Report  
  - Employee Report with filters (hire date, gender, status, etc.)

## 🛠️ Built With

- **VB.NET (Windows Forms)**
- **SQL Server (SSMS)**

## 📂 Folder Structure

- `/Forms` - All VB.NET forms (UI)
- `/Reports` - Report generation files
- `/SQL` - Sample SQL scripts for table creation and testing

## 📌 Note

🔐 The database connection string has been replaced with placeholders for security. Please update it with your own SQL Server details.

---

## 👨‍💻 Author

Created by [Your Name].  
Feel free to fork, improve, or use this for learning and demonstration purposes.
