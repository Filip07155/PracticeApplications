using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(SuppliersTable.TableName)]
    [Index(SuppliersTable.ColumnPostalCode, SuppliersTable.PostalCodeIndex)]
    [Index(SuppliersTable.ColumnCompanyName, SuppliersTable.CompanyNameIndex)]
    public class Supplier
    {
        [Key, Column(SuppliersTable.ColumnSupplierId), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Column(SuppliersTable.ColumnCompanyName, TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string? CompanyName { get; set; }

        [Column(SuppliersTable.ColumnContactName, TypeName = "nvarchar (30)")]
        [StringLength(30)]
        public string? ContactName { get; set; }

        [Column(SuppliersTable.ColumnContactTitle, TypeName = "nvarchar (30)")]
        [StringLength(30)]
        public string? ContactTitle { get; set; }

        [Column(SuppliersTable.ColumnAddress, TypeName = "nvarchar (60)")]
        [StringLength(60)]
        public string? Address { get; set; }

        [Column(SuppliersTable.ColumnCity, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? City { get; set; }

        [Column(SuppliersTable.ColumnRegion, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? Region { get; set; }

        [Column(SuppliersTable.ColumnPostalCode, TypeName = "nvarchar (10)")]
        [StringLength(10)]
        public string? PostalCode { get; set; }

        [Column(SuppliersTable.ColumnCountry, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? Country { get; set; }

        [Column(SuppliersTable.ColumnPhone, TypeName = "nvarchar (24)")]
        [StringLength(24)]
        public string? Phone { get; set; }

        [Column(SuppliersTable.ColumnFax, TypeName = "nvarchar (24)")]
        [StringLength(24)]
        public string? Fax { get; set; }

        [Column(SuppliersTable.ColumnHomePage, TypeName = "ntext")]
        public string? HomePage { get; set; }

        [InverseProperty(nameof(Product.Supplier))]
        public virtual ICollection<Product> Products { get; set; }

        public Supplier()
        {
            Products = new HashSet<Product>();
        }
    }
}
