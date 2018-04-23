using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace WindowsApplication1
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItem1.Links[0].Focus();
            (barEditItem1.Links[0] as BarEditItemLink).ShowEditor();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            barEditItem2.Links[0].Focus();
            (barEditItem2.Links[0] as BarEditItemLink).ShowEditor();
        }
    }
}