using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entities
{
    public class Note
    {

        public int id { get; set; }
        public string name { get; set; }
        public int idTeacher { get; set; }
        public int idStudent { get; set; }

        [ForeignKey("idTeacher")]
        public virtual Teacher teacher { get; set; }
        [ForeignKey("idStudent")]
        public virtual Student student { get; set; }
    }
}
