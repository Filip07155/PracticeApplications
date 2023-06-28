namespace Database.Tables
{
    internal class OrderDetailsTable
    {
        public const string TableName = "OrderDetails";

        public const string OrderIdIndex = "OrderId";
        public const string OrdersOrder_DetailsIndex = "OrdersOrder_Details";
        public const string ProductIdIndex = "ProductId";
        public const string ProductsOrder_DetailsIndex = "ProductsOrder_Details";

        public const string ColumnId = "OrderId";
        public const string ColumnProductId = "ProductId";
        public const string ColumnUnitPrice = "UnitPrice";
        public const string ColumnQuantity = "Quantity";
        public const string ColumnDiscount = "Discount";
    }
}
