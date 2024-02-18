namespace Store.Models
{
    public class Pagination
    {
        public int TotalItmes { get; set; }
        public int ItemPerPage { get; set; }
        public int CurrenPage { get; set; }
        public int TotalPage => 
            (int)Math.Ceiling((decimal)TotalItmes / ItemPerPage);
    }
}
