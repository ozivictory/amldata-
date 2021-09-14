using amldata.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace amldata.Data
{
    public class DestinationDbContext : DbContext
    {
        public DestinationDbContext(DbContextOptions<DestinationDbContext> options)
            : base(options)
        {
        }

        public  DbSet<ctrdesc> CTR{ get; set; }

    }
}
