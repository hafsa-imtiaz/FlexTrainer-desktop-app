# Flex Trainer – Gym & Fitness Management System

**Flex Trainer** is a comprehensive desktop application developed to streamline gym and fitness center operations. It supports multiple user roles, including members, trainers, gym owners, and administrators, each with tailored interfaces to manage workout plans, diet plans, appointments, and performance reports.

This project was implemented as part of the **CS2005: Database Systems** course (Spring 2024, at NUCES, Islamabad) and focuses on effective database design, data integrity, and multi-role access with a fully normalized schema.

---

## Project Overview

Flex Trainer enables users to register, create customized workout and diet plans, track fitness goals, and interact with trainers. Gym owners can monitor trainer performance and member activity, while administrators manage gym registrations and system-wide analytics.

The system supports advanced filtering, nutritional and allergen metadata, and provides over 40 analytical reports to evaluate usage patterns, plan effectiveness, and gym performance metrics.

---

## 🧑‍💻 Interfaces & Features

### 👤 Member
- Register/Login
- Create & explore workout plans
- Create & explore diet plans with allergen/nutrient tracking
- Book personal training sessions
- View plan reports (shared, curated, personal)
- Submit feedback for trainers

### 🧑‍🏫 Trainer
- Register/Login (approval required by gym owners)
- Manage appointments with clients
- Design and share workout & diet plans
- View progress reports of members
- Filter and analyze client plans and ratings

### 🏢 Gym Owner
- Register/Login (admin approval)
- Manage trainer onboarding
- View trainer & member reports (by gym, rating, feedback)
- Generate comparative growth reports
- Add/remove user accounts

### 🛠️ Admin
- Secure login
- Approve/reject gym registration requests
- Revoke gym memberships
- Analyze and compare gym performance

---

## Reports

Over **40 analytical reports** were implemented, covering:

- Members of a specific gym under a specific trainer
- Diet or workout plan usage across gyms
- Equipment demand forecasting
- Nutritional summaries and allergen filtering
- Membership trends across months and gyms
- Comparative analytics for gym performance

These reports were designed using SQL queries optimized over a **fully normalized relational schema**, ensuring accuracy and scalability.

---

## Tech Stack

**Frontend:** Windows Forms 
**Backend:** C#  
**Database:** Microsoft SQL Server

---

## License

This repository is part of an academic submission for the **Database Systems** course (Spring 2024) at the **National University of Computer and Emerging Sciences, Islamabad**. It is intended strictly for educational purposes and non-commercial use.
