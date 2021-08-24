using System;
using System.ComponentModel.DataAnnotations;

namespace ts3AutoUpdeteServer.DataModel
{
    public class Server
    {
        [Required]
        [Key]
        public int ServerId { get; set; }

        [Required]
        [MaxLength(500)]
        public string Login { get; set; }

        [Required]
        [MaxLength(500)]
        public string Password { get; set; }

        [Required]
        [MaxLength(500)]
        public string ServerIp { get; set; }

        [Required]
        [MaxLength(500)]
        public string Name1 { get; set; }

        [Required]
        [MaxLength(500)]
        public string Name2 { get; set; }

        public DateTime DateUpdate { get; set; }

    }
}
