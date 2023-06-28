using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(OrdersTable.TableName)]
    [Index(OrdersTable.ColumnCustomerId, OrdersTable.CustomerIdIndex)]
    [Index(OrdersTable.ColumnCustomerId, OrdersTable.CustomersOrdersIndex)]
    [Index(OrdersTable.ColumnEmployeeId, OrdersTable.EmployeeIdIndex)]
    [Index(OrdersTable.ColumnEmployeeId, OrdersTable.EmployeesOrdersIndex)]
    [Index(OrdersTable.ColumnOrderDate, OrdersTable.OrderDateIndex)]
    [Index(OrdersTable.ColumnShippedDate, OrdersTable.ShippedDateIndex)]
    [Index(OrdersTable.ColumnShipVia, OrdersTable.ShippersOrdersIndex)]
    [Index(OrdersTable.ColumnShipPostalCode, OrdersTable.ShipPostalCodeIndex)]
    public class Order
    {

        [Key, Column(OrdersTable.ColumnOrderId)]
        public int Id { get; set; }

        [Column(OrdersTable.ColumnCustomerId, TypeName = "nchar (5)")]
        [StringLength(5)]
        public string? CustomerId { get; set; }

        [Column(OrdersTable.ColumnEmployeeId, TypeName = "int")]
        public int EmployeeId { get; set; }

        [Column(OrdersTable.ColumnOrderDate, TypeName = "datetime")]
        public DateTime? OrderDate { get; set; }

        [Column(OrdersTable.ColumnRequiredDate, TypeName = "datetime")]
        public DateTime? RequiredDate { get; set; }

        [Column(OrdersTable.ColumnShippedDate, TypeName = "datetime")]
        public DateTime? ShippedDate { get; set; }

        [Column(OrdersTable.ColumnShipVia, TypeName = "int")]
        public int ShipVia { get; set; }

        [Column(OrdersTable.ColumnFreight, TypeName = "money")]
        public decimal Freight { get; set; }

        [Column(OrdersTable.ColumnShipName, TypeName = "nvarchar (40)")]
        [StringLength(40)]
        public string? ShipName { get; set; }

        [Column(OrdersTable.ColumnShipAddress, TypeName = "nvarchar (60)")]
        [StringLength(60)]
        public string? ShipAddress { get; set; }

        [Column(OrdersTable.ColumnShipCity, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? ShipCity { get; set; }

        [Column(OrdersTable.ColumnShipRegion, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? ShipRegion { get; set; }

        [Column(OrdersTable.ColumnShipPostalCode, TypeName = "nvarchar (10)")]
        [StringLength(10)]
        public string? ShipPostalCode { get; set; }

        [Column(OrdersTable.ColumnShipCountry, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? ShipCountry { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [InverseProperty(nameof(OrdersTable.TableName))]
        public virtual Customer? Customer { get; set; }

        [ForeignKey(nameof(EmployeeId))]
        [InverseProperty(nameof(OrdersTable.TableName))]
        public virtual Employee? Employee { get; set; }

        [ForeignKey(nameof(ShipVia))]
        [InverseProperty(nameof(OrdersTable.TableName))]
        public virtual Shipper? ShipViaNavigation { get; set; }

        [InverseProperty(nameof(OrderDetail.Order))]
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        public Order()
        {
            OrderDetails = new HashSet<OrderDetail>();
        }
    }
}
