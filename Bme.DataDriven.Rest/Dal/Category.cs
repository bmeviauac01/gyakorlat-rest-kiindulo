﻿namespace Bme.DataDriven.Rest.Dal;

public partial class Category
{
    public Category()
    {
        InverseParentCategory = new HashSet<Category>();
        Products = new HashSet<Product>();
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public int? ParentCategoryId { get; set; }

    public Category ParentCategory { get; set; }
    public ICollection<Category> InverseParentCategory { get; set; }
    public ICollection<Product> Products { get; set; }
}
