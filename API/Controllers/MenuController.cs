using HungryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HungryAPI.Controllers
{
    [Route("api/menu")]
    public class MenuController : Controller
    {
        public List<MenuModel> MenuModel { get; set; }

        public MenuController()
        {
            MenuModel = BuildMenu();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var menu = new List<MenuModel>
            {
                new MenuModel
                {
                    Id = 1,
                    Name = "X-Bacon",
                    Price = 6.50m,
                    Ingredients = new List<IngredientModel>
                    {
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
                            Id = 5,
                            Name = "Queijo",
                            Price = 1.50m
                        }
                    }
                },
                new MenuModel
                {
                    Id = 2,
                    Name = "X-Burger",
                    Price = 4.50m,
                    Ingredients = new List<IngredientModel>
                    {
                        new IngredientModel
                        {
                            Id = 3,
                            Name = "Hambúrguer de carne",
                            Price = 3
                        },
                        new IngredientModel
                        {
                            Id = 5,
                            Name = "Queijo",
                            Price = 1.50m
                        }
                    }
                },
                new MenuModel
                {
                    Id = 3,
                    Name = "X-Egg",
                    Price = 5.30m,
                    Ingredients = new List<IngredientModel>
                    {
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
                    }
                },
                new MenuModel
                {
                    Id = 4,
                    Name = "X-Egg Bacon",
                    Price = 7.30m,
                    Ingredients = new List<IngredientModel>
                    {
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
                    }
                }
            };

            return Ok(menu);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            var item = MenuModel.FirstOrDefault(x => x.Id == id);

            return Ok(item);
        }

        private List<MenuModel> BuildMenu()
        {
            return new List<MenuModel>
            {
                new MenuModel
                {
                    Id = 1,
                    Name = "X-Bacon",
                    Price = 6.50m,
                    Ingredients = new List<IngredientModel>
                    {
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
                            Id = 5,
                            Name = "Queijo",
                            Price = 1.50m
                        }
                    }
                },
                new MenuModel
                {
                    Id = 2,
                    Name = "X-Burger",
                    Price = 4.50m,
                    Ingredients = new List<IngredientModel>
                    {
                        new IngredientModel
                        {
                            Id = 3,
                            Name = "Hambúrguer de carne",
                            Price = 3
                        },
                        new IngredientModel
                        {
                            Id = 5,
                            Name = "Queijo",
                            Price = 1.50m
                        }
                    }
                },
                new MenuModel
                {
                    Id = 3,
                    Name = "X-Egg",
                    Price = 5.30m,
                    Ingredients = new List<IngredientModel>
                    {
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
                    }
                },
                new MenuModel
                {
                    Id = 4,
                    Name = "X-Egg Bacon",
                    Price = 7.30m,
                    Ingredients = new List<IngredientModel>
                    {
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
                    }
                }
            };
        }
    }
}