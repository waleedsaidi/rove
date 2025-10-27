# Rova Application Architecture

## Overview
The Rova application is a cross-platform solution designed for a car workshop, providing both mobile and web interfaces. It aims to streamline operations, enhance customer experience, and facilitate management tasks through a modern and responsive design.

## Technology Stack
- **Mobile Application**: .NET MAUI
- **Web Application**: Blazor
- **Backend Services**: ASP.NET Core
- **Database**: SQL Server (or any suitable database)
- **Authentication**: JWT (JSON Web Tokens)

## Architecture Components

### 1. Mobile Application (Rova.Mobile)
- **Structure**: Follows the MVVM (Model-View-ViewModel) pattern.
- **Pages**:
  - HomePage: Displays the Rova logo and modern UI.
  - ServicesPage: Lists car modification options.
  - BookingPage: Allows users to select services, dates, and times.
  - LoginPage: Provides login functionality for merchants and workers.
  - Merchant Dashboard: Contains various reports and performance tracking.
  - AttendancePage: Integrates biometric login for attendance tracking.
  - InventoryPage: Manages car parts inventory.
  - DebtsPage: Tracks customer debts.
  - CustomersPage: Displays client details and service history.
  - General Dashboard: Shows statistics and key performance indicators.

### 2. Web Application (Rova.Web)
- **Structure**: Utilizes Razor components for a responsive web interface.
- **Pages**:
  - Index: Home page with Rova branding.
  - Services: Displays available services.
  - Booking: Facilitates service booking.
  - Login: Authentication page for users.
  - Merchant Dashboard: Overview of merchant activities and reports.
  - Attendance: Manages attendance records.
  - Inventory: Displays and manages inventory items.
  - Debts: Shows customer debt information.
  - Customers: Lists customer details and service history.
  - Dashboard: General statistics and insights.

### 3. Shared Library (Rova.Shared)
- **Models**: Contains data transfer objects (DTOs) for users, services, bookings, and reports.
- **Enums**: Defines user roles (Merchant, Worker) for access control.

### 4. Core Services (Rova.Core)
- **Interfaces**: Defines contracts for authentication, booking, inventory, and reporting services.
- **Implementations**: Contains the actual logic for the defined services.

### 5. Testing (Rova.Tests)
- **Unit Tests**: Ensures the reliability of core services through unit testing.

## Design Considerations
- **Color Palette**: The application uses a black, red, and white color scheme to create a modern and professional look.
- **Dark Mode**: Supports dark mode for enhanced user experience in low-light environments.
- **Responsiveness**: The UI is designed to be responsive, ensuring usability across mobile and desktop platforms.

## Conclusion
The Rova application architecture is designed to provide a comprehensive solution for car workshop management, focusing on user experience, performance tracking, and operational efficiency. The use of modern technologies and design patterns ensures a scalable and maintainable application.