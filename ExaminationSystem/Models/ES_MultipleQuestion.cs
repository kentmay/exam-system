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
    
    public partial class ES_MultipleQuestion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ES_MultipleQuestion()
        {
            this.ES_MultipleAnswer = new HashSet<ES_MultipleAnswer>();
        }
    
        public int MQId { get; set; }
        public string MQTitle { get; set; }
        public string MQAns1 { get; set; }
        public string MQAns2 { get; set; }
        public string MQAns3 { get; set; }
        public string MQAns4 { get; set; }
        public string MQAns5 { get; set; }
        public string MQAns6 { get; set; }
        public string MQAns7 { get; set; }
        public int MQScore { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ES_MultipleAnswer> ES_MultipleAnswer { get; set; }
    }
}