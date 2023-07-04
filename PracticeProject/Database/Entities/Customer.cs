using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(CustomersTable.TableName)]
    [Index(nameof(CompanyName), Name = CustomersTable.CompanyNameCustomersIndex)]
    [Index(nameof(PostalCode), Name = CustomersTable.PostalCodeCustomersIndex)]
    [Index(nameof(Region), Name = CustomersTable.RegionIndex)]
    public class Customer
    {
        [Key, Column(CustomersTable.ColumnCustomerId, TypeName = "nchar (5)")]
        [StringLength(5), RegularExpression("[A-Z]{5}")]
        public string? CustomerId { get; set; }

        [Required, Column(CustomersTable.ColumnCompanyName, TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string? CompanyName { get; set; }

        [Column(CustomersTable.ColumnContactName, TypeName = "nvarchar (30)")]
        [StringLength(30)]
        public string? ContactName { get; set; }

        [Column(CustomersTable.ColumnContactTitle, TypeName = "nvarchar (30)")]
        [StringLength(30)]
        public string? ContactTitle { get; set; }

        [Column(CustomersTable.ColumnAddress, TypeName = "nvarchar (60)")]
        [StringLength(60)]
        public string? Address { get; set; }

        [Column(CustomersTable.ColumnCity, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? City { get; set; }

        [Column(CustomersTable.ColumnRegion, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? Region { get; set; }

        [Column(CustomersTable.ColumnPostalCode, TypeName = "nvarchar (10)")]
        [StringLength(10)]
        public string? PostalCode { get; set; }

        [Column(CustomersTable.ColumnCountry, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? Country { get; set; }

        [Column(CustomersTable.ColumnPhone, TypeName = "nvarchar (24)")]
        [StringLength(24)]
        public string? Phone { get; set; }

        [Column(CustomersTable.ColumnFax, TypeName = "nvarchar (24)")]
        [StringLength(24)]
        public string? Fax { get; set; }

        [InverseProperty(nameof(Order.Customer))]
        public virtual ICollection<Order> Orders { get; set; }

        public Customer()
        {
            Orders = new HashSet<Order>();
        }
    }
}
