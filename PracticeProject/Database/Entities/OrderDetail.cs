using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(OrderDetailsTable.TableName)]
    [Index(nameof(OrderId), Name = OrderDetailsTable.OrderIdIndex)]
    [Index(nameof(OrderId), Name = OrderDetailsTable.OrdersOrder_DetailsIndex)]
    [Index(nameof(ProductId), Name = OrderDetailsTable.ProductIdIndex)]
    [Index(nameof(ProductId), Name = OrderDetailsTable.ProductsOrder_DetailsIndex)]
    public class OrderDetail
    {
        [Key, Column(OrderDetailsTable.ColumnOrderId, TypeName = "int")]
        public int OrderId { get; set; }

        [Required, Column(OrderDetailsTable.ColumnProductId, TypeName = "int")]
        public int ProductId { get; set; }

        [Required, Column(OrderDetailsTable.ColumnUnitPrice, TypeName = "money")]
        public decimal UnitPrice { get; set; }

        [Required, Column(OrderDetailsTable.ColumnQuantity, TypeName = "smallint")]
        public short Quantity { get; set; }

        [Required, Column(OrderDetailsTable.ColumnDiscount, TypeName = "real")]
        public decimal Discount { get; set; }

        [ForeignKey(OrderDetailsTable.ColumnOrderId)]
        [InverseProperty(nameof(Entities.Order.OrderDetails))]
        public virtual Order? Order { get; set; }

        [ForeignKey(OrderDetailsTable.ColumnProductId)]
        [InverseProperty(nameof(Entities.Product.OrderDetails))]
        public virtual Product? Product { get; set; }
    }
}
