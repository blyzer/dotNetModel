using System;
using System.Collections.ObjectModel;

namespace Store.Core.EntityLayer.Production
{
    public class Product : IAuditEntity
    {
        public Product()
        {
        }

        public Product(Int32 productID)
        {
            ProductID = productID;
        }

        public Int32? ProductID { get; set; }

        public String ProductName { get; set; }

        public Int32? ProductCategoryID { get; set; }

        public Decimal? UnitPrice { get; set; }

        public String Description { get; set; }

        public Boolean? Discontinued { get; set; }

        public String CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public String LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public Byte[] Timestamp { get; set; }

        public virtual ProductCategory ProductCategoryFk { get; set; }

        public virtual Collection<ProductInventory> ProductInventories { get; set; }
    }
}
