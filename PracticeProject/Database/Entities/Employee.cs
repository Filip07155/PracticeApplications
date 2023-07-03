using Database.Tables;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Entities
{
    [Table(EmployeesTable.TableName)]
    [Index(nameof(LastName), Name = EmployeesTable.LastNameIndex)]
    [Index(nameof(PostalCode), Name = EmployeesTable.PostalCodeEmployeesIndex)]
    public class Employee
    {
        [Key, Column(EmployeesTable.ColumnEmployeeId)]
        public int EmployeeId { get; set; }

        [Required, Column(EmployeesTable.ColumnLastName, TypeName = "nvarchar (20)")]
        [StringLength(20)]
        public string? LastName { get; set; }

        [Required, Column(EmployeesTable.ColumnFirstName, TypeName = "nvarchar (10)")]
        [StringLength(10)]
        public string? FirstName { get; set; }

        [Column(EmployeesTable.ColumnTitle, TypeName = "nvarchar (30)")]
        [StringLength(30)]
        public string? Title { get; set; }

        [Column(EmployeesTable.ColumnTitleOfCourtesy, TypeName = "nvarchar (25)")]
        [StringLength(25)]
        public string? TitleOfCourtesy { get; set; }

        [Column(EmployeesTable.ColumnBirthDate, TypeName = "datetime")]
        public DateTime? BirthDate { get; set; }

        [Column(EmployeesTable.ColumnHireDate, TypeName = "datetime")]
        public DateTime? HireDate { get; set; }

        [Column(EmployeesTable.ColumnAddress, TypeName = "nvarchar (60)")]
        [StringLength(60)]
        public string? Address { get; set; }

        [Column(EmployeesTable.ColumnCity, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? City { get; set; }

        [Column(EmployeesTable.ColumnRegion, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? Region { get; set; }

        [Column(EmployeesTable.ColumnPostalCode, TypeName = "nvarchar (10)")]
        [StringLength(10)]
        public string? PostalCode { get; set; }

        [Column(EmployeesTable.ColumnCountry, TypeName = "nvarchar (15)")]
        [StringLength(15)]
        public string? Country { get; set; }

        [Column(EmployeesTable.ColumnHomePhone, TypeName = "nvarchar (24)")]
        [StringLength(24)]
        public string? HomePhone { get; set; }

        [Column(EmployeesTable.ColumnExtension, TypeName = "nvarchar (4)")]
        [StringLength(4)]
        public string? Extension { get; set; }

        [Column(EmployeesTable.ColumnPhoto, TypeName = "image")]
        public byte[]? Photo { get; set; }

        [Column(EmployeesTable.ColumnNotes, TypeName = "ntext")]
        public string? Notes { get; set; }

        [Column(EmployeesTable.ColumnReportsTo, TypeName = "int")]
        public int? ReportsTo { get; set; }

        [Column(EmployeesTable.ColumnPhotoPath, TypeName = "nvarchar (255)")]
        [StringLength(255)]
        public string? PhotoPath { get; set; }

        [InverseProperty(nameof(Order.Employee))]
        public virtual ICollection<Order> Orders { get; set; }

        public Employee()
        {
            Orders = new HashSet<Order>();
        }
    }
}
