﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AplicatieProiectMobil.Models;


namespace AplicatieProiectMobil.Services
{
    public class CategoryService
    {


        private IEnumerable<Category> _categories;
        public async ValueTask<IEnumerable<Category>> GetCategoriesAsync()
        {
            if (_categories is null)
            {
                var categories = new List<Category>();

                var nunta = new List<Category>
        {
            new Category(1, "Nunta", 0, "nunta.jpg", "Photo by <a href=\"https://www.pngwing.com/\">"),
            new Category(2, "Nunta la castel", 1, "sungarden.jpg", "Photo by <a href=\"https://sungardenresort.ro/\">")
        };

                categories.AddRange(nunta);

                var botez = new List<Category>
        {
            new Category(3, "Botez", 0, "botez.jpg", "Photo by <a href=\"https://www.pngegg.com/\">"),
            new Category(4, "Botez de vis", 1, "wonderland.jpg", "Photo by <a href=\"https://wonderland.ro/\">")
        };

                categories.AddRange(botez);
                _categories = categories;
            }
            return _categories;
        }


        //aici avem nevoie sa afiseze categoria principala
        public async ValueTask<IEnumerable<Category>> GetMainCategoriesAsync() =>
            (await GetCategoriesAsync())
            .Where(c => c.ParentId == 0);
    }
}
