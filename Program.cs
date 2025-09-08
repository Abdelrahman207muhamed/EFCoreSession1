using EFCoreSession1.Contexts;
using Microsoft.EntityFrameworkCore;

namespace EFCoreSession1
{
    internal class Program
    {
        static void Main()
        {

            AppDbContext context=new AppDbContext();
           // context.Database.Migrate();
        }
    }
}
