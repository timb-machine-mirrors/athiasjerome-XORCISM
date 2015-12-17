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
    
    public partial class ACTION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ACTION()
        {
            this.ACTIONACTION = new HashSet<ACTIONACTION>();
            this.ACTIONACTION1 = new HashSet<ACTIONACTION>();
            this.ACTIONACTIONARGUMENTNAME = new HashSet<ACTIONACTIONARGUMENTNAME>();
            this.ACTIONACTIONNAME = new HashSet<ACTIONACTIONNAME>();
            this.ACTIONACTIONTYPE = new HashSet<ACTIONACTIONTYPE>();
            this.ACTIONALIAS = new HashSet<ACTIONALIAS>();
            this.ACTIONDESCRIPTION1 = new HashSet<ACTIONDESCRIPTION>();
            this.ACTIONDISCOVERYMETHOD = new HashSet<ACTIONDISCOVERYMETHOD>();
        }
    
        public int ActionID { get; set; }
        public string ActionGUID { get; set; }
        public string ActionREFID { get; set; }
        public Nullable<int> ActionStatusID { get; set; }
        public string ActionStatusName { get; set; }
        public Nullable<int> ordinal_position { get; set; }
        public Nullable<int> ActionContextID { get; set; }
        public string ActionContextName { get; set; }
        public Nullable<System.DateTimeOffset> ActionTimestamp { get; set; }
        public Nullable<System.DateTimeOffset> CreatedDate { get; set; }
        public Nullable<int> CreationObjectID { get; set; }
        public Nullable<System.DateTimeOffset> timestamp { get; set; }
        public string ActionDescription { get; set; }
        public Nullable<bool> isEncrypted { get; set; }
        public Nullable<bool> isSuspicious { get; set; }
        public Nullable<int> VocabularyID { get; set; }
        public Nullable<System.DateTimeOffset> ValidFromDate { get; set; }
        public Nullable<System.DateTimeOffset> ValidUntilDate { get; set; }
    
        public virtual ACTIONCONTEXT ACTIONCONTEXT { get; set; }
        public virtual ACTIONSTATUS ACTIONSTATUS { get; set; }
        public virtual CREATIONOBJECT CREATIONOBJECT { get; set; }
        public virtual VOCABULARY VOCABULARY { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIONACTION> ACTIONACTION { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIONACTION> ACTIONACTION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIONACTIONARGUMENTNAME> ACTIONACTIONARGUMENTNAME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIONACTIONNAME> ACTIONACTIONNAME { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIONACTIONTYPE> ACTIONACTIONTYPE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIONALIAS> ACTIONALIAS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIONDESCRIPTION> ACTIONDESCRIPTION1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACTIONDISCOVERYMETHOD> ACTIONDISCOVERYMETHOD { get; set; }
    }
}