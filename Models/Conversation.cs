namespace ChatPusher.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Conversation")]
    public partial class Conversation
    {
        [Column(TypeName = "numeric")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public decimal id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? group_id { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? sender_id { get; set; }

        [StringLength(254)]
        public string message { get; set; }

        public DateTime? created { get; set; }

        public int? status { get; set; }

        [StringLength(254)]
        public string duree { get; set; }

        public bool? archived { get; set; }

        public DateTime? archived_date { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? receiver_id { get; set; }

        public virtual Group Group { get; set; }

        public virtual User User { get; set; }

        public virtual User User1 { get; set; }
    }
}
