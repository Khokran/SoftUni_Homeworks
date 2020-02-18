using System.Collections.Generic;

namespace ViceCity
{
    public class GunRepository : Player
    {
        private List<IGun> models;
        private IGun Count;

        public GunRepository()
            : base()
        {
        }
        public void Add(IGun model)
        {
            if (!models.Contains(Count))
            {
                this.models.Add(model);
            }
        }
        public bool Remove(IGun model)
        {
            if (models.Contains(Count))
            {
                this.models.Remove(model);
            }
        }
    }
}
