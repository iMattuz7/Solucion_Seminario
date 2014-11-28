using Nop.Web.Framework.Mvc;

namespace Nop.ApiSlalom.Models.Common
{
    public partial class LanguageModel : BaseNopEntityModel
    {
        public string Name { get; set; }

        public string FlagImageFileName { get; set; }

    }
}