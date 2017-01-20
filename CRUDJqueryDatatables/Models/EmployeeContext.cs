using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUDJqueryDatatables.Models
{
    public class EmployeeContext: DbContext
    {
        public EmployeeContext() : base("CRUD")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}