//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfService5
{
    using System;
    using System.Collections.Generic;
    
    public partial class mark
    {
        public int id { get; set; }
        public int test_id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string sch_colg { get; set; }
        public int obtained_marks { get; set; }
    
        public virtual testData testData { get; set; }
    }
}
