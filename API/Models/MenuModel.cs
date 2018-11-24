﻿using System.Collections.Generic;

namespace HungryAPI.Models
{
    public class MenuModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<IngredientModel> Ingredients { get; set; }
    }
}
