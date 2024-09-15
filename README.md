

# ConstructionApp

This project uses **MySQL** with **XAMPP** as the database management system, as it is more familiar to all contributors. If you're switching from the previous database system to MySQL, follow these steps to set up the project with MySQL:

### Steps to Switch to MySQL:
1. **Set Up XAMPP**:
   - Install and run XAMPP to manage your MySQL database server locally.

2. **Create the Database**:
   - Open **phpMyAdmin** (included with XAMPP) or use the MySQL command line to create a new database named `construction_app`:
     ```sql
     CREATE DATABASE construction_app;
     ```

3. **Create the Tables**:
   - Use the provided SQL scripts (or manually create the required tables) to set up the necessary tables within the `construction_app` database. The SQL syntax has already been adapted to MySQL.

4. **Code Changes**:
   - All necessary changes to the code have been made to support MySQL. This includes:
     - Updating SQL syntax to match MySQL conventions.
     - Switching to the **`MySql.Data.MySqlClient`** package for database operations.
     - Updating the connection string to work with MySQL in the XAMPP environment.

### Database Connection:
Ensure that your connection string is configured to point to your local MySQL instance. By default, the connection string in the project is as follows:

```csharp
string connectionString = "Server=localhost;Database=construction_app;User=root;Password=;SslMode=None;";
```
**Note:** this was already done in app.config file,you no need to consider this.
- **Server**: Set to `localhost` for XAMPP.
- **Database**: Ensure this is `construction_app`.
- **User**: The default MySQL user is `root`, and no password is set by default in XAMPP.
- **Password**: Leave this empty unless you've set a password for the `root` user.
- **SslMode**: Set to `None` for local development environments.

### Dependencies:
Make sure to install the **`MySql.Data`** package in your project to handle MySQL operations. This package is already referenced in the project, but if you need to install it manually, use:

```bash
Install-Package MySql.Data
```

By following these steps, you can seamlessly switch to MySQL and continue working with the ConstructionApp project. For further reference visit : https://ourcodeworld.com/articles/read/218/how-to-connect-to-mysql-with-c-sharp-winforms-and-xampp#:~:text=Add%20the%20reference%20to%20the%20MySQL%20connector%20to,reference%20to%20the%20MySQL%20connector%20to%20the%20project
