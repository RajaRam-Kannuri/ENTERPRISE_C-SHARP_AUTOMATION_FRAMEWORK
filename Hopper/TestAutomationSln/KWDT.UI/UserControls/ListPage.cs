using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace KWDT.UI.UserControls
{
    public class ListPage : BaseUserControl
    {
        //private List<object> lstChildren { get; set; }

        //public ListPage()
        //{
        //    lstChildren = new List<object>();
        //}

        //public void UpdateLists()
        //{
        //    var listOfLists = LogicalTreeHelper.GetChildren(this);

        //    GetChildControls(this, 9);

        //    lstChildren.OfType<ListView>().ToList().ForEach(lst => lst.Items.Refresh());
        //}

        //private void GetChildControls(Visual p_vParent, int p_nLevel)
        //{

        //    int nChildCount = VisualTreeHelper.GetChildrenCount(p_vParent);

        //    for (int i = 0; i <= nChildCount - 1; i++)
        //    {
        //        Visual v = (Visual)VisualTreeHelper.GetChild(p_vParent, i);

        //        lstChildren.Add((object)v);

        //        if (VisualTreeHelper.GetChildrenCount(v) > 0)
        //        {
        //            GetChildControls(v, p_nLevel + 1);
        //        }
        //    }
        //}
    }
}
