namespace Pronia.Models.Base
{
    public abstract  class BasEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CraetedAt { get; set; }

    }
}
