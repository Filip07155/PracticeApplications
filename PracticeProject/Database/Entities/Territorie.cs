using Database.Tables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(TerritoriesTable.TableName)]
    internal class Territorie
    {
        [Key, Column(TerritoriesTable.ColumnTerritoryId, TypeName = "nvarchar (20)")]
        [StringLength(20)]
        public string? TerritoryId { get; set; }

        [Required, Column(TerritoriesTable.ColumnTerritoryDescription, TypeName = "nchar (50)")]
        [StringLength(50)]
        public string? TerritoryDescription { get; set; }

        [Required, Column(TerritoriesTable.ColumnRegionId, TypeName = "int")]
        public int RegionId { get; set; }
    }
}
