using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSpiderServer.DAL.Entities
{
    public class User : EntityBase
    {
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        [Column("is_blocked")]
        public bool IsBlocked { get; set; }
    }
}
