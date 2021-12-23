namespace WebECom.ViewModel
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PhotoPath { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
