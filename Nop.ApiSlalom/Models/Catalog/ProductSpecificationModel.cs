using Nop.Web.Framework.Mvc;

namespace Nop.ApiSlalom.Models.Catalog
{
    public partial class ProductSpecificationModel : BaseNopModel
    {
        public int SpecificationAttributeId { get; set; }

        public string SpecificationAttributeName { get; set; }

        public string SpecificationAttributeOption { get; set; }
    }
}