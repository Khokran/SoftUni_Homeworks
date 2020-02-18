using System;
using System.Linq;
using PetStore.Web.Models;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace PetStore.Web.Controllers
{
    public class PetsController : Controller
    {
        private readonly IPetService pets;

        public PetsController(IPetService pets)
           => this.pets = pets;
        public IEnumerable<PetsListingServiceModel> All()
                =>this.pets.All();
        public IActionResult All()
        {
            var AllPets = this.pets.All();
        }
    }
}
