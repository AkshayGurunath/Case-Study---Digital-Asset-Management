# Case-Study---Digital-Asset-Management
Overview
The Digital Asset Management System is a software solution designed to manage digital assets, including allocating assets to employees, performing maintenance, managing reservations, and tracking asset history. This system helps ensure that the assets are efficiently tracked and managed throughout their lifecycle.

Features
Asset Allocation: Allocate assets to employees with detailed records.
Maintenance Tracking: Log maintenance records for each asset, including the cost and date of maintenance.
Reservation Management: Reserve assets for specific employees for future use.
Error Handling: Handle situations where an employee or asset is not found in the database.
Return Management: Record return dates for allocated assets.
Project Structure
The project is divided into the following main parts:

Main Application: The main functionality of the Digital Asset Management System, including asset allocation, maintenance, and reservations.
Unit Testing: Automated tests to ensure the correctness and reliability of the system using NUnit.
Folder Structure
scss
Copy code
/DigitalAssetManagement
│
├── /DigitalAssetManagement 
│   ├── dao
│   ├── Entity
│   └── Exception
|   └── util
|   └── main
│
├── /DigitalAssetManagement.Tests 
│   ├── AssetTests.cs
│   ├── MaintenanceTests.cs
│   ├── ReservationTests.cs
│   
│
└── README.md
Prerequisites
Visual Studio 2022 (or later)
.NET 4.8
SQL Server 
NUnit 
