using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TodoApp.Model
{
    public class TodoItem
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DueDate { get; set; }

        [DefaultValue(false)]
        public bool IsCompleted { get; set; }
    }
}
