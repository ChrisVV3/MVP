namespace MVP.DomainModel
{
    using System.ComponentModel.DataAnnotations;

    public class Website
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Site { get; set; }

        [Required]
        [StringLength(50)]
        public string URL { get; set; }

        public int Gap { get; set; }
    }
}
