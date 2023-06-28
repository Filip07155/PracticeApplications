using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(CategoriesTable.TableName)]
    [Index(CategoriesTable.ColumnName, CategoriesTable.CategoryNameIndex)]
    public class Category
    {
        [Key, Column(CategoriesTable.ColumnId), DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required, Column(CategoriesTable.ColumnName, TypeName = "nvarchar (15)")]
        public string? Name { get; set; }

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
