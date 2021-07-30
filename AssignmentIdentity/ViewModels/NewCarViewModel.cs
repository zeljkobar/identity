using AssignmentIdentity.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentIdentity.ViewModels
{
    public class NewCarViewModel
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Godiste { get; set; }
        public int ZapreminaMotora { get; set; }
        public int Snaga { get; set; }
        public string Gorivo { get; set; }
        public string Karoserija { get; set; }
        public IFormFile Photo { get; set; }
        public string Opis { get; set; }
        public int Cijena { get; set; }

        public string Kontakt { get; set; }

    }
}
