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
    
    public partial class userdata
    {
        public userdata()
        {
            this.testDatas = new HashSet<testData>();
        }
    
        public int user_id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string passwor { get; set; }
        public string about { get; set; }
    
        public virtual ICollection<testData> testDatas { get; set; }
    }
}
