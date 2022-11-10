using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStore
{
    internal class PageList<a>: List<a>
    {
        public int Index { get; set; }
        public int PageCount { get; set; }
        
        public PageList(List<a> item, int count, int index , int pageSize)
        {
            Index = index;
            PageCount = (int) Math.Ceiling((double) count/(double) pageSize);
            this.AddRange(item);
        }

        public bool Previous
        {
            get { return Index > 1; }
        }
        public bool Next
        {
            get { return Index < PageCount; }
        }
        public static PageList<a> Create(IQueryable<a> ique, int index , int pageSixe)
        {
            int count = ique.Count();
            var item = ique.Skip((index - 1) * pageSixe).Take(pageSixe).ToList();
            return new PageList<a>(item, count, index , pageSixe);
        }
    }
}
