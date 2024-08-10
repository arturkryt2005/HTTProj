﻿using HTTProj.Application.Interfaces;

namespace HTTProj.Application
{
    public class Product : IHaveId
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Categories? Category { get; set; }
    }
}
