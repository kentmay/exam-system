//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ExaminationSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ES_Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ES_Role()
        {
            this.ES_Role_Permission = new HashSet<ES_Role_Permission>();
            this.ES_User = new HashSet<ES_User>();
        }
    
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public string RoleDescribe { get; set; }
        public bool IsDel { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ES_Role_Permission> ES_Role_Permission { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ES_User> ES_User { get; set; }
    }
}
