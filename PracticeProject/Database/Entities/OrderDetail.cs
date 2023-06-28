using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(OrderDetailsTable.TableName)]
    [Index(OrderDetailsTable.ColumnId, OrderDetailsTable.OrderIdIndex)]
    [Index(OrderDetailsTable.ColumnId, OrderDetailsTable.OrdersOrder_DetailsIndex)]
    [Index(OrderDetailsTable.ColumnProductId, OrderDetailsTable.ProductIdIndex)]
    [Index(OrderDetailsTable.ColumnProductId, OrderDetailsTable.ProductsOrder_DetailsIndex)]
    public class OrderDetail
    {
        [Key, Column(OrderDetailsTable.ColumnId, TypeName = "int")]
        public int Id { get; set; }

        [Required, Column(OrderDetailsTable.ColumnProductId, TypeName = "int")]
        public int ProductId { get; set; }

        [Required, Column(OrderDetailsTable.ColumnUnitPrice, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Required, Column(OrderDetailsTable.ColumnQuantity, TypeName = "smallint")]
        public short Quantity { get; set; }

        [Required, Column(OrderDetailsTable.ColumnDiscount, TypeName = "real")]
        public decimal Discount { get; set; }

        [ForeignKey(OrderDetailsTable.ColumnId)]
        [InverseProperty(nameof(OrderDetailsTable.TableName))]
        public virtual Order? Order { get; set; }

        [ForeignKey(OrderDetailsTable.ColumnProductId)]
        [InverseProperty(nameof(OrderDetailsTable.TableName))]
        public virtual Product? Product { get; set; }
    }
}
