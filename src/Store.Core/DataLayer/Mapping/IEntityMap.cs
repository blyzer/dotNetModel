using Microsoft.EntityFrameworkCore;

namespace Store.Core.DataLayer.Mapping
{
	public interface IEntityMap
	{
		void Map(ModelBuilder modelBuilder);
	}
}
