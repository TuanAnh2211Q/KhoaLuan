﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Cart
{
    public int CartID { get; set; }
    public Nullable<int> ProductID { get; set; }
    public Nullable<int> Quantity { get; set; }
    public Nullable<int> UserID { get; set; }

    public virtual Product Product { get; set; }
    public virtual User User { get; set; }
}

public partial class Category
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Category()
    {
        this.Products = new HashSet<Product>();
    }

    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
    public string ImageUrl { get; set; }
    public Nullable<bool> IsActive { get; set; }
    public Nullable<System.DateTime> CreateDate { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Product> Products { get; set; }
}

public partial class Contact
{
    public int ContactID { get; set; }
    public string ContactName { get; set; }
    public string Email { get; set; }
    public string Subjects { get; set; }
    public string Messagess { get; set; }
    public Nullable<System.DateTime> CreateDate { get; set; }
}

public partial class Order
{
    public int OrderDetailsID { get; set; }
    public string OrderNo { get; set; }
    public Nullable<int> ProductID { get; set; }
    public Nullable<int> Quantity { get; set; }
    public Nullable<int> UserID { get; set; }
    public string Statuss { get; set; }
    public Nullable<int> PaymentID { get; set; }
    public Nullable<System.DateTime> OrderDate { get; set; }

    public virtual Payment Payment { get; set; }
    public virtual Product Product { get; set; }
    public virtual User User { get; set; }
}

public partial class Payment
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Payment()
    {
        this.Orders = new HashSet<Order>();
    }

    public int PaymentID { get; set; }
    public string PaymentName { get; set; }
    public string CardNo { get; set; }
    public string ExpiryDate { get; set; }
    public Nullable<int> CvvNo { get; set; }
    public string Address { get; set; }
    public string PaymentMode { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Order> Orders { get; set; }
}

public partial class Product
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Product()
    {
        this.Carts = new HashSet<Cart>();
        this.Orders = new HashSet<Order>();
    }

    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public string Descriptions { get; set; }
    public Nullable<decimal> Price { get; set; }
    public Nullable<int> Quantity { get; set; }
    public string ImageUrl { get; set; }
    public Nullable<int> CategoryID { get; set; }
    public Nullable<bool> IsActive { get; set; }
    public Nullable<System.DateTime> CreateDate { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Cart> Carts { get; set; }
    public virtual Category Category { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Order> Orders { get; set; }
}

public partial class User
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public User()
    {
        this.Carts = new HashSet<Cart>();
        this.Orders = new HashSet<Order>();
    }

    public int UserID { get; set; }
    public string FullName { get; set; }
    public string UserName { get; set; }
    public string Mobile { get; set; }
    public string Email { get; set; }
    public string UserAddress { get; set; }
    public string PostCode { get; set; }
    public string Passwords { get; set; }
    public string ImageUrl { get; set; }
    public Nullable<System.DateTime> CreateDate { get; set; }
    public Nullable<bool> IsAdmin { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Cart> Carts { get; set; }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
    public virtual ICollection<Order> Orders { get; set; }
}