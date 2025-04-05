# Blazor Finance Tracker

A simple personal finance tracker built with **Blazor Web App (.NET 8)**, **Entity Framework Core**, and **SQL Server**.  
This project demonstrates full CRUD functionality for managing transactions, such as expenses and income.

---

## Features

- Add, edit, and delete financial transactions
- Categorize transactions as **Income** or **Expense**
- Group transactions by date and category
- Data is stored in **Microsoft SQL Server** using **Entity Framework Core**
- Clean and modular Blazor components structure

---

## Tech Stack

- **Frontend & Backend:** [Blazor Web App](https://dotnet.microsoft.com/en-us/apps/aspnet/web-apps/blazor) (Server-side, .NET 8)
- **Database:** Microsoft SQL Server
- **ORM:** Entity Framework Core
- **UI:** Razor Components

---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/)
- (Optional) Visual Studio 2022+ or VS Code

---

### 1. Clone the Repository

```bash
git clone https://github.com/your-username/blazor-finance-tracker.git
cd blazor-finance-tracker
```

### 2. Configure the Connection String

Update `appsettings.json` with your SQL Server configuration:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=FinanceTrackerDb;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

### 3. Run Migrations & Create Database

```bash
dotnet ef migrations add InitialCreate
dotnet ef database update
```

---

### 4. Run the App

```bash
dotnet run
```

Then open your browser to `https://localhost:5001` (or whatever port shows up in the terminal).

---

## To-Do / Ideas

- [ ] Filter by category or date range
- [ ] Monthly summary reports
- [ ] Add authentication
- [ ] Export to CSV