﻿using Microsoft.EntityFrameworkCore;

namespace FlutterApi.Models

{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions option) :base(option) 
        {

        }

        public DbSet<Users> users {  get; set; }
        
    }
}
