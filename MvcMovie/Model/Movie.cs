using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Phone]
        public string Tele { get; set; }
        public string Country { get; set; }
        [NotMapped]
        public List<SelectListItem> countries { get; } = new List<SelectListItem>
        {
            new SelectListItem(){ Selected = true, Value="UA",Text="American" },
            new SelectListItem(){Value="RU",Text="Russian" },
            new SelectListItem(){Value="CH",Text="China" },
            new SelectListItem(){Value="EN",Text="England"},
            new SelectListItem(){Value="FR",Text="Franch"},
            new SelectListItem(){Value="GR",Text="German"},
            new SelectListItem(){Value="JA",Text="Japenese"},
        };
    }
}
