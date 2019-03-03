namespace TourCalifornia.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AuthorizedApp
    {
        public int AuthorizedAppId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(32)]
        public string AppToken { get; set; }

        [Required]
        [StringLength(32)]
        public string AppSecret { get; set; }

        public DateTime TokenExpiration { get; set; }
    }
}
