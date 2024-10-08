namespace CodeFirstBasic.Entities
{
    public class BaseEntity
    {
        public BaseEntity() 
        {
            CreatedTime = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
