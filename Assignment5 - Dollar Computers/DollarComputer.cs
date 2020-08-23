namespace Assignment5___Dollar_Computers
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DollarComputer : DbContext
    {
        /*The Author's name: Jiyeon Jeon
      Author's student number: #301103064
      Date last Modified: August 20, 2020
      Program description: Dollar Computers
      Revision History: 1.0 created August 20, 2020 Jiyeon 
      */
        public DollarComputer()
            : base("name=DollarComputerConnection")
        {
        }

        public virtual DbSet<Product> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}
