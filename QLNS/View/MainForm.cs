using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;

namespace QLNS.View
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnThem_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void btnDSDVT_ItemClick(object sender, ItemClickEventArgs e)
        {
            ListDVT listDvt = new ListDVT();
            AddTabControl(listDvt, "Danh Sách ĐVT");
        }

        public void AddTabControl(UserControl userControl, string itemTabName)
        {
            bool isExists = false;
            foreach (XtraTabPage tabItem in xtraTabControl1.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExists = true;
                    xtraTabControl1.SelectedTabPage = tabItem;
                }
            }
            if (!isExists)
            {
                AddTab addtab = new AddTab();
                addtab.AddTabControl(xtraTabControl1, itemTabName, userControl);
            }
        }
    }
}