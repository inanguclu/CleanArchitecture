﻿using CleanArchitecture.Domain.Abstractions;
using CleanArchitecture.Domain.Entities;
using GenericRepository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Persistance.Context;

public sealed class AppDbContext : IdentityDbContext<User,IdentityRole,string>, IUnitOfWork
{
    public AppDbContext(DbContextOptions options) : base(options) { }


    protected override void OnModelCreating(ModelBuilder modelBuilder) =>
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);


    public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        var entires = ChangeTracker.Entries<Entity>();
        foreach (var entry in entires)
        {
            if (entry.State == EntityState.Added)
                entry.Property(p=>p.CreatedDate)
                    .CurrentValue=DateTime.Now;

            if (entry.State == EntityState.Modified)
                entry.Property(p => p.UpdatedDate)
                    .CurrentValue = DateTime.Now;
        }
        return base.SaveChangesAsync(cancellationToken);
    }

}
