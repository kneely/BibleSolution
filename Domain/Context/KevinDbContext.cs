using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;

namespace Domain.Context
{
    public class KevinDbContext : DbContext  
    {  
        public DbSet<User> ObjRegisterUser { get; set; } // Here User is the class
    }  
}
