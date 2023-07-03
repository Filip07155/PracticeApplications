using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Index(nameof(CategoryId), Name = ProductsTable.CategoriesIdIndex)]
    [Index(nameof(CategoryId), Name = ProductsTable.CategoriesProductsIndex)]
    [Index(nameof(ProductName), Name = ProductsTable.ProductNameIndex)]
    [Index(nameof(SupplierId), Name = ProductsTable.SupplierIdIndex)]
    [Index(nameof(SupplierId), Name = ProductsTable.SuppliersProductsIndex)]
    public class Product
    {
        [Key, Column(ProductsTable.ColumnProductId), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [Required, Column(ProductsTable.ColumnProductName, TypeName = "nvarchar (40)")]
        public string? ProductName { get; set; }

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
