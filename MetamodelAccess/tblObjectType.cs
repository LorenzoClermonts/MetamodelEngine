//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MetamodelAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblObjectType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblObjectType()
        {
            this.tblAttribute = new HashSet<tblAttribute>();
            this.tblPredicator = new HashSet<tblPredicator>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Conc_ID { get; set; }
        public string Cnst_ID { get; set; }
        public string ModelID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblAttribute> tblAttribute { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblPredicator> tblPredicator { get; set; }
    }
}
