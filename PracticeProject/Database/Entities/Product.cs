using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Index(ProductsTable.ColumnCategoryId, ProductsTable.CategoriesProductsIndex)]
    [Index(ProductsTable.ColumnCategoryId, ProductsTable.CategoriesIdIndex)]
    [Index(ProductsTable.ColumnId, ProductsTable.ProductNameIndex)]
    [Index(ProductsTable.ColumnSupplierId, ProductsTable.SupplierIdIndex)]
    [Index(ProductsTable.ColumnSupplierId, ProductsTable.SuppliersProductsIndex)]
    public class Product
    {
        [Key, Column(ProductsTable.ColumnId), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Column(ProductsTable.ColumnName, TypeName = "nvarchar (40)")]
        public string? Name { get; set; }

        [Column(ProductsTable.ColumnSupplierId)]
        public int? SupplierId { get; set; }

        [Column(ProductsTable.ColumnCategoryId)]
        public int? CategoryId { get; set; }

        [Column(ProductsTable.ColumnQuantityPerUnit, TypeName = "nvarchar (20)")]
        public string? QuantityPerUnit { get; set; }

        [Column(ProductsTable.ColumnUnitPrice, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Column(ProductsTable.ColumnUnitsInStock)]
        public short UnitsInStock { get; set; }

        [Column(ProductsTable.ColumnUnitsOnOrder)]
        public short UnitsOnOrder { get; set; }

        [Column(ProductsTable.ColumnReorderLevel)]
        public short ReorderLevel { get; set; }

        [Column(ProductsTable.ColumnDiscontinued)]
        public bool Discontinued { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty(ProductsTable.TableName)]
        public virtual Category? Category { get; set; }

        [ForeignKey(nameof(SupplierId))]
        [InverseProperty(ProductsTable.TableName)]
        public virtual Supplier? Supplier { get; set; }

        [InverseProperty(nameof(OrderDetail.Product))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Product()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
