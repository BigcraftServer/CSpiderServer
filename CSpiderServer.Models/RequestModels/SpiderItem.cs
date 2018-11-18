using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.Models.RequestModels
{
    public class SpiderItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string Script { get; set; }

        public static implicit operator Entities.SpiderItem(SpiderItem item)
        {
            return new Entities.SpiderItem()
            {
                Id = item.Id,
                Name = item.Name,
                UserId = item.UserId,
                Script = item.Script
            };
        }
    }
}
