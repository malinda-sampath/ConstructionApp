
---

### Database Setup and Configuration: MySQL with XAMPP

To successfully run this project with a MySQL database using XAMPP, please follow the steps outlined below:

---

#### **1. Importing the Database**
   
   Ensure that the database is correctly set up by importing the provided `.sql` file. The SQL file is located within the `repository` folder of this solution. Follow these steps:
   
   1. Launch **phpMyAdmin** via XAMPP.
   2. Create a new database (or select an existing one).
   3. Import the SQL file:
      - Go to the **Import** tab.
      - Choose the `.sql` file from the `repository` folder.
      - Click **Go** to execute the import.

#### **2. Exporting the Database after Changes**

   If you make any changes to the database schema or data, be sure to export the updated database and commit the changes to GitHub:
   
   1. In **phpMyAdmin**, select your database.
   2. Navigate to the **Export** tab.
   3. Choose the export method (**Quick** or **Custom**, as needed) and format (**SQL**).
   4. Save the `.sql` file and replace the existing one in the `repository` folder.
   5. Commit and push the updated `.sql` file to your GitHub repository to ensure the latest database schema is tracked.

---

#### **3. Troubleshooting Database Connection Issues**

   If you encounter any issues connecting to the database, consider the following steps to resolve them:

   - **Ensure the MySQL Dependency is Installed:**
     - Verify that the `MySql.Data` NuGet package is installed in your solution. If not, install it via the **NuGet Package Manager**:
       1. Open Visual Studio.
       2. Go to **Tools** > **NuGet Package Manager** > **Manage NuGet Packages for Solution**.
       3. Search for `MySql.Data` and install the package.
   
   - **Verify the Connection String in App.config:**
     - Double-check that the connection string in the `App.config` file is correctly configured for your environment. Ensure it matches your local MySQL setup

---

By following these guidelines, you will ensure that the project’s database is properly configured, any changes are tracked, and common issues can be quickly resolved. If you encounter further issues, refer to the official documentation for [MySQL](https://dev.mysql.com/doc/) or [XAMPP](https://www.apachefriends.org/index.html).

---

