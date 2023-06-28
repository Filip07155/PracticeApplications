namespace Database.Tables
{
    internal class OrdersTable
    {
        public const string TableName = "Orders";

        public const string CustomerIdIndex = "CustomerId";
        public const string CustomersOrdersIndex = "CustomersOrders";
        public const string EmployeeIdIndex = "EmployeeId";
        public const string EmployeesOrdersIndex = "EmployeesOrders";
        public const string OrderDateIndex = "OrderDate";
        public const string ShippedDateIndex = "ShippedDate";
        public const string ShippersOrdersIndex = "ShippersOrders";
        public const string ShipPostalCodeIndex = "ShipPostalCode";

        public const string ColumnOrderId = "OrderId";
        public const string ColumnCustomerId = "CustomerId";
        public const string ColumnEmployeeId = "EmployeeId";
        public const string ColumnOrderDate = "OrderDate";
        public const string ColumnRequiredDate = "RequiredDate";
        public const string ColumnShippedDate = "ShippedDate";
        public const string ColumnShipVia = "ShipVia";
        public const string ColumnFreight = "Freight";
        public const string ColumnShipName = "ShipName";
        public const string ColumnShipAddress = "ShipAddress";
        public const string ColumnShipCity = "ShipCity";
        public const string ColumnShipRegion = "ShipRegion";
        public const string ColumnShipPostalCode = "ShipPostalCode";
        public const string ColumnShipCountry = "ShipCountry";
    }
}
