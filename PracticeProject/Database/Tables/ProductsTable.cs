namespace Database.Tables
{
    public class ProductsTable
    {
        public const string TableName = "Products";

        public const string CategoriesProductsIndex = "CategoriesProducts";
        public const string CategoriesIdIndex = "CategoryId";
        public const string ProductNameIndex = "ProductName";
        public const string SupplierIdIndex = "SupplierId";
        public const string SuppliersProductsIndex = "SuppliersProducts";

        public const string ColumnProductId = "ProductId";
        public const string ColumnName = "ProductName";
        public const string ColumnSupplierId = "SupplierId";
        public const string ColumnCategoryId = "CategoryId";
        public const string ColumnQuantityPerUnit = "QuantityPerUnit";
        public const string ColumnUnitPrice = "UnitPrice";
        public const string ColumnUnitsInStock = "UnitsInStock";
        public const string ColumnUnitsOnOrder = "UnitsOnOrder";
        public const string ColumnReorderLevel = "ReorderLevel";
        public const string ColumnDiscontinued = "Discontinued";
    }
}
