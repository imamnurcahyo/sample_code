using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("mst_bo_menu")]
    public class MstBoMenu
    {
        [Key]
        [Column("menu_id")]
        public int MenuId { get; set; }

        [Column("menu_name")]
        [Required]
        [StringLength(50)]
        public string MenuName { get; set; }

        [Column("menu_url")]
        [StringLength(200)]
        public string? MenuUrl { get; set; }

        [Column("menu_icon")]
        [StringLength(50)]
        public string? MenuIcon { get; set; }

        [Column("parent_id")]
        public int? ParentId { get; set; }

        [Column("menu_order")]
        public int MenuOrder { get; set; }

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

        public virtual ICollection<MstBoRoleMenuAccess> RoleMenuAccesses { get; set; }
    }
}
