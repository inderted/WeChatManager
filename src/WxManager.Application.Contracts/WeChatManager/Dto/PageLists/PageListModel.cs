using System.Collections.Generic;
using System.Linq;

namespace WxManager.Application.Contracts.WeChatManager.PageLists
{
    public class PageListModel<T>
    {
        public PageListModel()
        {

        }

        public PageListModel(IList<T> source, int pageIndex, int pageSize, int totalCount)
        {
            TotalCount = totalCount;
            TotalPages = TotalCount / pageSize;

            if (TotalCount % pageSize > 0)
                TotalPages++;

            this.PageSize = pageSize;
            this.PageIndex = pageIndex;
            this.Items = source.Skip(pageIndex * pageSize).Take(pageSize).ToList();
        }

        public IList<T> Items { get; set; }

        public int PageIndex { get; set; }
        public int PageSize { get; set; }
        public int TotalCount { get; set; }
        public int TotalPages { get; set; }

        public bool HasPreviousPage
        {
            get { return (PageIndex > 0); }
        }
        public bool HasNextPage
        {
            get { return (PageIndex + 1 < TotalPages); }
        }
    }
}
