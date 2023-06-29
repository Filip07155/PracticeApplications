using Database.Tables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(ShippersTable.TableName)]
    public class Shipper
    {
        [Key, Column(ShippersTable.ColumnShipperId)]
        public int ShipperId { get; set; }

        [Required, Column(ShippersTable.ColumnCompanyName, TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string? CompanyName { get; set; }

        [Column(ShippersTable.ColumnPhone, TypeName = "nvarchar (24)")]
        [StringLength(24)]
        public string? Phone { get; set; }
    }
}
