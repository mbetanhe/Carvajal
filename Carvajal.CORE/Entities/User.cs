using Carvajal.CORE.Entities.Base;

namespace Carvajal.CORE.Entities
{
    public partial class User : BaseEntity
    {
        public string Name { get; set; }
        public string Lastname { get; set; }
        public int Cardid { get; set; }
        public string Id { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }
}
