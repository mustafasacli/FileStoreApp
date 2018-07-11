namespace FileStoreApp.Source.Model
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("UserType")]
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string TypeName { get; set; }

        public bool IsActive { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}