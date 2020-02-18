using System.Collections.Generic;
using PetStore.Web.Models;

namespace PetStore.Web.Controllers
{
    internal interface IPetService
    {
        IEnumerable<PetsListingResponseModel> All();
    }
}