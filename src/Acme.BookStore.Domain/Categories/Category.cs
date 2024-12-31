using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Categories
{
    public class Category:FullAuditedEntity<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescroptionAr { get; set; }
        public string DescroptionEn { get; set; }
    }
}
