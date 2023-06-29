using Database.Tables;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(EmployeeTerritoriesTable.TableName)]
    internal class EmployeeTerritorie
    {
        [Key, Column(EmployeeTerritoriesTable.ColumnEmployeeId, TypeName = "int")]
        public int EmployeeId { get; set; }

        [Required, Column(EmployeeTerritoriesTable.ColumnTerritoryId, TypeName = "nvarchar (20)")]
        [StringLength(20)]
        public string? TerritoryId { get; set; }
    }
}
