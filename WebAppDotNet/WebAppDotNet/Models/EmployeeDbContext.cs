using Microsoft.EntityFrameworkCore;

namespace WebAppDotNet.Models
{
    // ***************************DbContext***************************
    
    // 1. DbContext Class is an integral part of Entity Framework
    // 2. This is the class that we use our application code to interact with the underlying database.
    // 3. It is this class that manages the database connection and is
    //    used to retrieve and save data in database.
    // 4. An Instace of DbContext represents a session with the database which can be used to query and save instances of you entities to a databse.
    // 5. DbContext is a combination of the unit of work and reposistory patterns.
    // 6. DbCotnext can be used to define the database context class after creating a model class.
    // 7. DbContext co-ordinates with Entity Framework and allows you to query and save the data in the database.
    // 8. Uses the DbSet<T> type to define one or more properties where, T represents the type of an object that needs to be stored in the database.
    // 9. The DbContextOptions instances carries configuration information such as the connection string, database provider to use etc.
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<EmployeeModel> Employees {  get; set; } 
    }
}
