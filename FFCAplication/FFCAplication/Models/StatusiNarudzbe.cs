using FFCAplication.Helper;

namespace FFCAplication.Models
{
    public class StatusiNarudzbe:IEntity
    {
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public string Naziv { get; set; }
    }
}