namespace ThirdDemo.Models
{
    public class Entity<T>
    {
        public T Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
        public bool IsVisable { get; set; }

    }
}
