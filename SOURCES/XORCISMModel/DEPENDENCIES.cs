//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace XORCISMModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class DEPENDENCIES
    {
        public int DependenciesID { get; set; }
        public string DependenciesGUID { get; set; }
        public int DependencyID { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
    
        public virtual DEPENDENCY DEPENDENCY { get; set; }
    }
}