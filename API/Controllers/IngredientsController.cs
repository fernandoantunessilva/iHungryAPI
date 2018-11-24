using HungryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HungryAPI.Controllers
{
    [Route("api/ingredients")]
    public class IngredientsController : Controller
    {       
        [HttpGet]
        public IActionResult Get()
        {
            var ingredients = new List<IngredientModel>
            {
                new IngredientModel
                {
                    Id = 1,
                    Name = "Alface",
                    Price = 0.40m
                },
                new IngredientModel
                {
                    Id = 2,
                    Name = "Bacon",
                    Price = 2
                },
                new IngredientModel
                {
                    Id = 3,
                    Name = "Hambúrguer de carne",
                    Price = 3
                },
                new IngredientModel
                {
                    Id = 4,
                    Name = "Ovo",
                    Price = 0.80m
                },
                new IngredientModel
                {
                    Id = 5,
                    Name = "Queijo",
                    Price = 1.50m
                }
            };

            return Ok(ingredients);
        }       
    }
}