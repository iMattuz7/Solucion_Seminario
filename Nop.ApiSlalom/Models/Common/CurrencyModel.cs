using Nop.Web.Framework.Mvc;

namespace Nop.ApiSlalom.Models.Common
{
    public partial class CurrencyModel : BaseNopEntityModel
    {
        public string Name { get; set; }

        public string CurrencySymbol { get; set; }
    }
}