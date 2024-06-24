﻿using Microsoft.EntityFrameworkCore;

namespace DesignPattens.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Employee> Employees { get; set; }
    }
}