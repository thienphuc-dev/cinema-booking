//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASP_MVCProject_NguyenVuongThienPhuc
{
    using System;
    using System.Collections.Generic;
    
    public partial class seat
    {
        public int seatID { get; set; }
        public string seatName { get; set; }
        public int roomName { get; set; }
        public bool isAvailable { get; set; }
    
        public virtual room room { get; set; }
    }
}
