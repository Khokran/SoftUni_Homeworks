using System;

namespace PetStore.Data.Models
{
    internal class MaxLengthAttribute : Attribute
    {
        private int nameMaxLength;

        public MaxLengthAttribute(int nameMaxLength)
        {
            this.nameMaxLength = nameMaxLength;
        }
    }
}