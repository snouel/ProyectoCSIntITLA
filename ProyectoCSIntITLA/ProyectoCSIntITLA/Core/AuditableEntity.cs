
namespace DBBoletoBus.Domain.Core
{
    public abstract class AuditableEntity
    {
        protected AuditableEntity()
        {
            this.CreationDate = DateTime.Now;
            this.Deleted = false;
        }

        public int CreationUser { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime? ModifyDate { get; set; }

        public int? UserMod { get; set; }

        public int? UserDeleted { get; set; }

        public DateTime? DeletedDate { get; set; }

        public bool Deleted { get; set; }

    }
}
