using System;
using System.ComponentModel.DataAnnotations;


namespace ts3AutoUpdeteServer.DataModel
{
    public class Settings
    {

        [Required]
        [Key]
        public int Id { get; set; }

        [Required]
        public int TimeAutoUpdate { get; set; }

        [Required]
        public DateTime LastTimeUpdate { get; set; }


    }

}