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

## 🗄️ Database

The SQL Server (SSMS) dataset required for this application is stored in a **separate GitHub repository**.

🔗 Download or clone it from:  
[https://github.com/hendry0168/shared-HR-dataset](https://github.com/hendry0168/shared-HR-dataset)

> Please restore the provided `.bak` file in that repository to your local SQL Server instance and update the connection string in the code accordingly.

## 📂 Folder Structure

- `/Forms` – VB.NET form UI files
- `/Reports` – Report generation logic
- `/SQL` – Sample or reference SQL scripts
- `/README.md` – Project documentation

## 📌 Note

🔐 The database connection string in the code uses placeholders for security.  
Make sure to update it with your actual SQL Server instance, database name, and credentials.

## 👨‍💻 Author

Created by Hendry.

Feel free to fork, improve, or use this project for learning and demonstration purposes.
