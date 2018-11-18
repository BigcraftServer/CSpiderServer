using System;
using System.Collections.Generic;
using System.Text;

namespace CSpiderServer.Models.ResponseModels
{
    public class SpiderItem
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Script { get; set; }
        public static explicit operator SpiderItem(Entities.SpiderItem item)
        {
            return new SpiderItem()
            {
                Id = item.Id,
                Name = item.Name,
                Script = item.Script
            };
        }
    }
}
