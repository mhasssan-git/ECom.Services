using System.ComponentModel.DataAnnotations;

namespace Common.Core
{
    public class Entity<T>
    {
        [Key]
        public T Id { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
    }
}
