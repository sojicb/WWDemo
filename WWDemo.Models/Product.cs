﻿namespace WWDemo.Models
{
	public class Product
	{
        public Guid Id { get; set; }
        public string? SerialNumber { get; set; }
        public string? Name { get; set; }
        public string? Price { get; set; }
        public string? Category { get; set; }
    }
}
