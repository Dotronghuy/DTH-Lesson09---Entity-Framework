//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lesson07___Entity_Framework.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class dthKhoa
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dthKhoa()
        {
            this.dthSV = new HashSet<dthSV>();
        }
    
        public string ĐthID { get; set; }
        public string ĐthTenKh { get; set; }
        public string ĐthTrangthai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dthSV> dthSV { get; set; }
    }
}
