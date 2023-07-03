using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Keyless]
    [Table(EmployeeTerritoriesTable.TableName)]
    public class EmployeeTerritorie
    {
        [Column(EmployeeTerritoriesTable.ColumnEmployeeId, TypeName = "int")]
        public int EmployeeId { get; set; }

        [Required, Column(EmployeeTerritoriesTable.ColumnTerritoryId, TypeName = "nvarchar (20)")]
        [StringLength(20)]
        public string? TerritoryId { get; set; }
    }
}
