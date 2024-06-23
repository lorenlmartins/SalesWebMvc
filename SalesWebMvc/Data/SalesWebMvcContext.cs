﻿using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Models;

public class SalesWebMvcContext(DbContextOptions<SalesWebMvcContext> options) : DbContext(options)
{
    public DbSet<Department> Department { get; set; } = default!;
    public DbSet<Seller> Seller { get; set; } = default!;
    public DbSet<SalesRecord> SalesRecord { get; set; } = default!;
}
