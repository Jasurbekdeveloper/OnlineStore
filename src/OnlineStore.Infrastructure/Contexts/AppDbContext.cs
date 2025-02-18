﻿using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace OnlineStore.Infrastructure.Contexts;

public class AppDbContext : DbContext
{
	public AppDbContext(DbContextOptions options)
		: base(options)
	{
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
