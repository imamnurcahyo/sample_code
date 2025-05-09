using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("mst_bo_role_access")]
    public class MstBoRoleAccess
    {
        [Key]
        [Column("role_id")]
        public int RoleId { get; set; }

        [Column("role_name")]
        [Required]
        [StringLength(50)]
        public string RoleName { get; set; }

        [Column("role_description")]
        [StringLength(200)]
        public string? RoleDescription { get; set; }

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

        public virtual ICollection<MstBoUser> Users { get; set; }
        public virtual ICollection<MstBoRoleMenuAccess> RoleMenuAccesses { get; set; }
    }
}
