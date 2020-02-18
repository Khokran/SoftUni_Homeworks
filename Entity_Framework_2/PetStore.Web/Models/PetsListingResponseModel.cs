﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Web.Models
{
    public class PetsListingResponseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public decimal Price { get; set; }
    }
}
