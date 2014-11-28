using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAPP
{
    public class Category
    {
        public Category()
        {
            FeatureProducts = new List<FeaturedProduct>();
        }
        //[JsonProperty("id")]
        public String Name { get; set; }
        public List<FeaturedProduct> FeatureProducts { get; set; }

    }
}
