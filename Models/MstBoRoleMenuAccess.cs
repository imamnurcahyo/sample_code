using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api.Models
{
    [Table("mst_bo_role_menu_access")]
    public class MstBoRoleMenuAccess
    {
        [Key]
        [Column("role_menu_id")]
        public int RoleMenuId { get; set; }

        [Column("role_id")]
        public int RoleId { get; set; }

        [Column("menu_id")]
        public int MenuId { get; set; }

        [Column("can_view")]
        public bool CanView { get; set; }

        [Column("can_add")]
        public bool CanAdd { get; set; }

        [Column("can_edit")]
        public bool CanEdit { get; set; }

        [Column("can_delete")]
        public bool CanDelete { get; set; }

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

        [ForeignKey("MenuId")]
        public virtual MstBoMenu Menu { get; set; }
    }
}
