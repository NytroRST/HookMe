using System;
using System.Collections;
using System.Windows.Forms;

namespace FOCA.Search
{
    public class ListViewColumnSorter : IComparer
    {
        public int SortColumn { set; get; }
        public SortOrder Order { set; get; }
        private CaseInsensitiveComparer ObjectCompare;

        public ListViewColumnSorter()
        {
            SortColumn = 0;
            Order = SortOrder.None;
            ObjectCompare = new CaseInsensitiveComparer();
        }

        public int Compare(object x, object y)
        {
            return 0;
        }
    }
}
