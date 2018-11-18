using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSpiderServer.DAL.Entities
{
    public class UserToken : EntityBase
    {
        [Column("user_id")]
        public string UserId { get; set; }
        [Column("expire_at")]
        public DateTime ExpireAt { get; set; }
        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
