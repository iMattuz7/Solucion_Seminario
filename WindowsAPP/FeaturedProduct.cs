using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAPP
{
    public class FeaturedProduct
    {
        public FeaturedProduct()
        {
            DefaultPictureModels = new List<DefaultPictureModel>();
        }
        public String Name { get; set; }
        public String ShortDescription { get; set; }
        public List<DefaultPictureModel> DefaultPictureModels { get; set; }
    }
}
