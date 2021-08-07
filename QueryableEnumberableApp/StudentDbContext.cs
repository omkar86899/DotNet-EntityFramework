﻿using QueryableEnumberableApp.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryableEnumberableApp
{
    public class StudentDbContext: DbContext
    {
        public DbSet<Student> Students
        {
            get;
            set;
        }
    }
}
