using CarCompany.Entites;
using System.Configuration;
using System.Data.Entity;

namespace CarCompany.DataContext
{
    public class DataContext : DbContext
    {
        static DataContext()
        {
            Database.SetInitializer(new DatabaseInitializer());
        }

        public DataContext(string connectionString)
            : base(connectionString)
        {
        }

        public DataContext()
            : this(ConnectionString)
        {
        }

        public static string ConnectionString
        {
            get
            {
                var temp = ConfigurationManager.ConnectionStrings["CarCompanyConnectionString"];
                if (temp != null)
                {
                    return ConfigurationManager.ConnectionStrings["CarCompanyConnectionString"].ConnectionString;
                }
                return "CarCompanyConnectionString";
            }
        }

        public DbSet<Car> Cars { get; set; }
    }
}