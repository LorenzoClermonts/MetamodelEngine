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
    
    public partial class tblPredicator
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Nullable<int> FactTypeID { get; set; }
        public Nullable<int> ObjectTypeID { get; set; }
        public string Multiplicity { get; set; }
        public string Verb { get; set; }
    
        public virtual tblFactType tblFactType { get; set; }
        public virtual tblObjectType tblObjectType { get; set; }
    }
}
