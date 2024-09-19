
### Database Setup and Configuration: MySQL with XAMPP

To run this project with a MySQL database using XAMPP, follow the instructions below:

---

#### **1. Importing the Database**

Ensure the database is set up by importing the provided `.sql` file located in the `repository` folder. Follow these steps:

1. Launch **phpMyAdmin** via XAMPP.
2. Create a new database or select an existing one.
3. Import the `.sql` file:
   - Go to the **Import** tab.
   - Choose the `.sql` file from the `repository` folder.
   - Click **Go** to execute the import.

---

#### **2. Exporting the Database after Changes**

If any changes are made to the database schema or data, export the updated database and commit the changes to GitHub:

1. In **phpMyAdmin**, select your database.
2. Navigate to the **Export** tab.
3. Choose the export method (**Quick** or **Custom**) and format (**SQL**).
4. Save the `.sql` file and replace the existing one in the `repository` folder.
5. Commit and push the updated `.sql` file to your GitHub repository to ensure the latest schema is tracked.

---

#### **3. Setting Up the Database Connection with the Proxy**

In this version of the project, the `DbManager` is accessed via a proxy to enhance logging and control access. Here’s how to modify your code to use the new implementation:

1. **Ensure the MySQL Dependency is Installed:**
   - Verify that the `MySql.Data` NuGet package is installed:
     - Open Visual Studio.
     - Go to **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**.
     - Search for `MySql.Data` and install the package if needed.

2. **Configure the Connection String in App.config:**
   - Update the connection string in your `App.config` file to match your MySQL setup.
   - Example connection string:
     ```xml
     <connectionStrings>
         <add name="ConstructionAppConnectionString" connectionString="Server=localhost;Database=your_database_name;Uid=your_username;Pwd=your_password;" providerName="MySql.Data.MySqlClient"/>
     </connectionStrings>
     ```

3. **Using the Proxy for Database Access:**
   - The project now implements the **Proxy Design Pattern** for managing database connections. Replace any instances of direct `DbManager` access with the new proxy setup.
   - Instead of:
     ```csharp
     DbManager dbManager = DbManager.Instance;
     ```
     You will now use:
     ```csharp
     IDbManager dbManager = new DbManagerProxy();
     ```

   - The `DbManagerProxy` controls access to `DbManager`, ensuring thread safety, logging, and controlling database connections.

   - Both `DbManager` and `DbManagerProxy` implement the `IDbManager` interface, so any database operation should go through the `DbManagerProxy`.

---

#### **4. Troubleshooting Database Connection Issues**

If you encounter any connection problems, follow these steps:

- **Verify MySQL Setup:**
  - Ensure MySQL is running via XAMPP.
  - Confirm your credentials and database details in the `App.config` connection string.

- **Check for Missing Dependencies:**
  - Ensure `MySql.Data` is installed via **NuGet Package Manager**.

- **Logging**:
  - The proxy now handles logging. Check your logs to trace database connection attempts and errors.

---

by lakmal
