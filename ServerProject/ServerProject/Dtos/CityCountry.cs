using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ServerProject.Dtos
{
    public class CityCountry
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int Population { get; set; }

        public string CountryName { get; set; } = null!;

    }
}
