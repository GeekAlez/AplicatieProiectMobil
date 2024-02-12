using AplicatieProiectMobil.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieProiectMobil.ViewModels
{
    public partial class PachetViewModel : ObservableObject
    {
        private readonly CategoryService _categoryService;


        public PachetViewModel(CategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public ObservableCollection<AplicatieProiectMobil.Models.Category> Categories { get; set; } = new ObservableCollection<AplicatieProiectMobil.Models.Category>();

        public async Task InitializeAsync()
        {
            try
            {
                foreach(var category in await _categoryService.GetMainCategoriesAsync()) 
                {
                    Categories.Add(category);
                }
            }catch(Exception ex)
            {
                Console.WriteLine($"Eroare în timpul inițializării: {ex.Message}");
            }
            
        }
    }
}
