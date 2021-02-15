using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Watch_manager.Models;

namespace Watch_manager.ViewModels
{
    public class GenreViewModel
    {
        public List<Movie> Movies { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
        public string SearchString { get; set; }
    }
}
