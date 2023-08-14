# Invoice Approval System

Welcome to the Invoice Approval System, a web application designed to streamline the invoice management process. This project showcases the power of ASP.NET Core, Entity Framework, and Razor Pages in creating user-friendly system.

## Features

### User Role - User

- **Invoice CRUD Operations:** Users have the ability to perform Create, Read, Update, and Delete operations on invoices, providing them with control over their invoicing processes.
- **Data Persistence:** Invoices are securely stored in a SQL Server database using Entity Framework, ensuring data integrity and availability.

### User Role - Manager

- **Comprehensive Invoice Review:** Managers have the privilege of reviewing all invoices, enabling them to make informed decisions about approval or disapproval.
- **Efficient Approval Workflow:** Managers can efficiently manage the approval process, enhancing operational efficiency and minimizing delays.
- **Graphical Insights:** Managers can also access a dynamic graph that visually represents the monthly figures of submitted, rejected, and approved invoice amounts, providing a clear overview of the organization's financial dynamics.

### User Role - Admin

- **Full System Control:** Administrators hold the keys to the entire system. They can perform all of the actions listed above.
- **Graphical Insights:** Admins, like managers, have access to the graphical representation of monthly submitted, rejected, and approved invoice amounts, offering valuable insights into financial trends.

## Getting Started

To experience the Invoice Approval System:

1. Visit [https://invoicesystem.azurewebsites.net](https://invoicesystem.azurewebsites.net) in your web browser.
2. Sign up as a User or log in as a Manager
3. Explore the intuitive interface, perform CRUD operations on invoices, review and approve/disapprove invoices, and access graphical insights.

## Data Insights Graph

Both Admins and Managers have access to a dynamic graph that visually represents the monthly figures of submitted, rejected, and approved invoice amounts. This feature provides valuable insights into your organization's financial dynamics.

## Technologies Used

- ASP.NET Core
- Entity Framework
- Razor Pages
- SQL Server
- Javascript
- HTML
- CSS
- `AspNetCore.Authorization`
- `AspNetCore.Identity`

## Installation

To run the Invoice Approval System locally:

1. Clone this repository.
2. Open the solution in your preferred development environment.
3. Configure your SQL Server connection string in `appsettings.json`.
4. Build and run the application.

## Contributing

Contributions to enhance the Invoice Approval System are welcome. To contribute, please follow the guidelines mentioned in the [CONTRIBUTING.md](CONTRIBUTING.md) file.


## License

This project is licensed under the [MIT License](https://github.com/AlexCKHO/InvoiceSystem/blob/main/LICENSE).

---

Thank you for exploring the Invoice Approval System.
