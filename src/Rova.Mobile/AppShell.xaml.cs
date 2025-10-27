using System;
using Microsoft.Maui.Controls;

namespace Rova.Mobile
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            // Register routes for navigation
            Routing.RegisterRoute(nameof(ServicesPage), typeof(ServicesPage));
            Routing.RegisterRoute(nameof(BookingPage), typeof(BookingPage));
            Routing.RegisterRoute(nameof(LoginPage), typeof(LoginPage));
            Routing.RegisterRoute(nameof(MerchantDashboardPage), typeof(MerchantDashboardPage));
            Routing.RegisterRoute(nameof(AttendanceReportsPage), typeof(AttendanceReportsPage));
            Routing.RegisterRoute(nameof(PerformancePage), typeof(PerformancePage));
            Routing.RegisterRoute(nameof(DailyReportPage), typeof(DailyReportPage));
            Routing.RegisterRoute(nameof(WeeklyReportPage), typeof(WeeklyReportPage));
            Routing.RegisterRoute(nameof(AttendancePage), typeof(AttendancePage));
            Routing.RegisterRoute(nameof(InventoryPage), typeof(InventoryPage));
            Routing.RegisterRoute(nameof(DebtsPage), typeof(DebtsPage));
            Routing.RegisterRoute(nameof(CustomersPage), typeof(CustomersPage));
            Routing.RegisterRoute(nameof(DashboardPage), typeof(DashboardPage));
        }
    }
}