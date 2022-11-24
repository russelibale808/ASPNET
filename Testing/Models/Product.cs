﻿namespace Testing.Models
{
    public class Product
    {
        public Product()
        {
        }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryID { get; set; }
        public bool OnSale { get; set; }
        public string StockLevel { get; set; }
    }
}
