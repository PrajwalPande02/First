using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//prasad bhamare

using OMRWebApp.Models;
using System.Data.Entity;
using MySql.Data.EntityFramework;
// this a emp class
//new comment
namespace OMRWebApp.DAL
{ // comment by onkar
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class EmployeeDALOMR: DbContext
    {
        public DbSet<EmployeeBOL> emp { get; set; }
        public DbSet<EmployeeBOL> emp { get; set; }
        public EmployeeDALOMR() : base("WebDataCon")
        {
        }
    }
}
