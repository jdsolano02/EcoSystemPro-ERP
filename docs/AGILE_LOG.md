# 📈 Agile Development Log

**Developer:** Jose Daniel Solano  
**Role:** Full-Stack Engineer  
**Sprint Duration:** 1 Week

---

## 📅 Sprint 1: Foundation & Architecture
**Project:** EcoSystem Pro (ERP)  
**Dates:** Feb 7 - Feb 14, 2026

### Day 1: Full-Stack Foundation & Core Architecture 🏗️

**Date:** February 7, 2026
**Status:** ✅ Completed (Double Session)

#### 🌅 Session 1: Environment Setup & Scaffolding (Early Morning)

**Focus:** Project Initialization, Frontend/Backend Separation & Tooling.

- **Repository Initialization:** Established the Git repository with a `.gitignore` tailored for Visual Studio and Node environments.

- **Clean Architecture Scaffolding:**
    - Refactored the project structure into a `/src` directory to strictly separate the **Domain**, **Application**, **Infrastructure**, and **API** layers.
    - Applied **SoC (Separation of Concerns)** by isolating the UI (`/client`) from the Business Logic.
    
- **Frontend Integration:**
    - Initialized a **React + TypeScript** client using Vite 7.
    - Integrated **Tailwind CSS v4**, migrating from v3 configuration standards (using `@tailwindcss/postcss`).
    
- **Environment Optimization:**
    - Diagnosed and resolved a Node.js engine incompatibility (Vite 7 requires Node v22+).
    - Upgraded local environment to Node LTS (v22.12.0) to ensure long-term stability.

#### 🔗 Traceability
* **Commit:**
    * `feat(setup): initialize full-stack clean architecture ecosystem`



#### ☀️ Session 2: Domain Logic & Database Persistence (Afternoon)

### 🚀 Key Achievements

- **Architecture Logic:**
  - Completed reading of *Clean Architecture* Ch. 22.
  - Applied the "Dependency Rule": Domain layer has zero external dependencies.
  - Understood the distinction between Database (External Agency) and SQL Configurations (Infrastructure Adapter).
  
- **Domain Layer (🟡):**
  - Refactored `Product` entity to remove data annotations (`[Table]`, `[Column]`).
  - Implemented 5 core entities: `Product`, `Supplier`, `User`, `Sale`, `SaleDetail`.
  - Established 1:N relations using pure C# navigation properties (`virtual ICollection`, `Guid Id`).
  - Added specific validations (e.g., `Price` decimal range, `PhoneNumber` as string).
  
- **Infrastructure Layer (🔵):**
  - Implemented `IEntityTypeConfiguration<T>` for all entities using **Fluent API**.
  - Enforced SQL constraints via code: `decimal(18,2)` for money, `HasMaxLength`, and `IsUnique` indexes for Email/Username.
  - Configured `ApplicationDbContext` to dynamically apply configurations from assembly.
  
- **Database & API (🟢/🗄️):**
  - Fixed NuGet dependency issues (`Microsoft.EntityFrameworkCore.SqlServer`, `Swashbuckle`).
  - Configured SQL Server connection string in `appsettings.json`.
  - Executed first successful migration: `InitialSchema`.
  - Verified database creation in SQL Server Management Studio (SSMS).

### 🚧 Blockers & Resolutions

- **Blocker:** Missing NuGet packages caused 29+ build errors in Infrastructure.
  - *Resolution:* Manually installed `Microsoft.EntityFrameworkCore.SqlServer` and `Design` packages.
  
- **Blocker:** Confusion between `Supplier` and `Sale` configurations (Copy/Paste error).
  - *Resolution:* Fixed class names and property mappings in `SupplierConfiguration.cs`.
  
- **Blocker:** `Program.cs` service registration order caused migration failure.
  - *Resolution:* Moved `AddDbContext` before `builder.Build()`.

#### 🔗 Traceability

* **Commit:**
    * `feat: implement domain entities and infrastructure persistence layer`

#### 🔮 Next Steps

* Create the Repository Pattern implementation (Generic Repository).
* Implement the "Unit of Work" pattern.