
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace BookStore.Model
{

using System;
    using System.Collections.Generic;
    
public partial class BAOCAOCONGNO
{

    public int MaKhachHang { get; set; }

    public int Thang { get; set; }

    public int Nam { get; set; }

    public int NoDau { get; set; }

    public int NoCuoi { get; set; }

    public Nullable<int> PhatSinh { get; set; }



    public virtual KHACHHANG KHACHHANG { get; set; }

}

}
