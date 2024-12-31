using Acme.BookStore.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Acme.BookStore.Products
{
    public class Product: FullAuditedEntity<int>
    {
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string DescroptionAr { get; set; }
        public string DescroptionEn { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

    }
}
