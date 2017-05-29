using System.Composition;
using Microsoft.EntityFrameworkCore;
using Store.Core.EntityLayer.HumanResources;

namespace Store.Core.DataLayer.Mapping.HumanResources
{
    [Export(typeof(IEntityMap))]
    public class EmployeeMap : IEntityMap
    {
        public void Map(ModelBuilder modelBuilder)
        {
            var entity = modelBuilder.Entity<Employee>();

            entity.ToTable("Employee", "HumanResources");

            entity.HasKey(p => p.EmployeeID);

            entity.Property(p => p.EmployeeID).UseSqlServerIdentityColumn();

            entity.Property(p => p.Timestamp).ValueGeneratedOnAddOrUpdate().IsConcurrencyToken();
        }
    }
}
