using Carvajal.CORE.Entities.Base;

namespace Carvajal.CORE.Entities
{
    public partial class Cards : BaseEntity
    {
        public int Cardid { get; set; }
        public string Description { get; set; }
    }
}
