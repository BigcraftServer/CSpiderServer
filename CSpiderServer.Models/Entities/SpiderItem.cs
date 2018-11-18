using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CSpiderServer.Models.Entities
{
    public class SpiderItem : EntityBase
    {
        public string Name { get; set; }
        [Column("user_id")]
        public string UserId { get; set; }
        public string Script { get; set; }
        [Column("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}
