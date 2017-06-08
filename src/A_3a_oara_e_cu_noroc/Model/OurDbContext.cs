using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace A_3a_oara_e_cu_noroc.Model
{
    public class OurDbContext : DbContext
    {
        

        public DbSet<UserPw> UseriParole
        {
            get;
            set;

        }
        public DbSet<Iteme> ElementeLista
        {
            get;
            set;

        }


        public OurDbContext(DbContextOptions<OurDbContext> options) : base(options)
        {

        }
        public OurDbContext() { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (optionsBuilder.IsConfigured) return;

            //Called by parameterless ctor Usually Migrations
            var environmentName = Environment.GetEnvironmentVariable("EnvironmentName") ?? "local";

            optionsBuilder.UseSqlServer(
                new ConfigurationBuilder()
                    .SetBasePath(Path.GetDirectoryName(GetType().GetTypeInfo().Assembly.Location))
                    .AddJsonFile($"appsettings.{environmentName}.json", optional: false, reloadOnChange: false)
                    .Build()
                    .GetConnectionString("OurDbContext")
            );
        }




    }
}
