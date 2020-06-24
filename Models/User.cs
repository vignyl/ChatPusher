namespace ChatPusher.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Conversation = new HashSet<Conversation>();
            Conversation1 = new HashSet<Conversation>();
            User1 = new HashSet<User>();
            User2 = new HashSet<User>();
            Group = new HashSet<Group>();
        }

        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [StringLength(254)]
        public string name { get; set; }

        [StringLength(254)]
        public string Surname { get; set; }

        [StringLength(254)]
        public string phone { get; set; }

        [StringLength(254)]
        public string email { get; set; }

        [StringLength(254)]
        public string password { get; set; }

        [StringLength(254)]
        public string cofirmation_token { get; set; }

        public DateTime? cofirmation_date { get; set; }

        public DateTime? created { get; set; }

        public DateTime? modified { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conversation> Conversation { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Conversation> Conversation1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> User2 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Group> Group { get; set; }
    }
}
