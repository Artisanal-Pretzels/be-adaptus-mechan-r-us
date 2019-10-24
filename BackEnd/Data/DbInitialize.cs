using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Data
{
  public class DbInitialize
  {

    public DbInitialize (AmruDbContext context)
    {
      ApplyMigrations (context);
    }

    public void ApplyMigrations (AmruDbContext context)
    {

      if (context.Database.GetPendingMigrations ().Any ())
      {
        context.Database.Migrate ();
      }

    }
  }
}