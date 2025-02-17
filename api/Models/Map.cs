namespace api.Models
{
    public class Map
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? DepartamentId { get; set; }
        public string[] UrlImages { get; set; }
        public string? UrlSource { get; set; }
        public virtual Department Departament { get; set; }
    }
}
