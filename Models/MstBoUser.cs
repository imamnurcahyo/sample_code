using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("mst_bo_user")]
    public class MstBoUser
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Column("username")]
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Column("password")]
        [Required]
        public string Password { get; set; }

        [Column("email")]
        [StringLength(100)]
        public string? Email { get; set; }

        [Column("full_name")]
        [StringLength(100)]
        public string? FullName { get; set; }

        [Column("role_id")]
        public int RoleId { get; set; }

        [Column("is_active")]
        public bool IsActive { get; set; }

        [Column("created_date")]
        public DateTime CreatedDate { get; set; }

        [Column("created_by")]
        [StringLength(50)]
        public string CreatedBy { get; set; }

        [Column("modified_date")]
        public DateTime? ModifiedDate { get; set; }

        [Column("modified_by")]
        [StringLength(50)]
        public string? ModifiedBy { get; set; }

        [ForeignKey("RoleId")]
        public virtual MstBoRoleAccess Role { get; set; }
    }
}
