using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(CategoriesTable.TableName)]
    [Index(nameof(CategoryName), Name = CategoriesTable.CategoryNameIndex)]
    public class Category
    {
        [Key, Column(CategoriesTable.ColumnCategoryId), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryId { get; set; }

        [Required, Column(CategoriesTable.ColumnCategoryName, TypeName = "nvarchar (15)")]
        public string? CategoryName { get; set; }

        [Column(CategoriesTable.ColumnDescription, TypeName = "ntext")]
        public string? Description { get; set; }

        [InverseProperty(nameof(Product.Category))]
        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {
            Products = new HashSet<Product>();
        }
    }
}
