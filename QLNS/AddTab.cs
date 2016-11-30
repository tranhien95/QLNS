using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraTab;
using System.Windows.Forms;
using System.Drawing;

namespace QLNS
{
    class AddTab
    {
        public void AddTabControl(XtraTabControl xtraTabParent, string xtraItemName, UserControl userControl)
        {
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Name = "test";
            xtraTabPage.Text = xtraItemName;
            //traTabPage.Image = Bitmap.FromFile(@"..\..\Resources\" + icon);
            xtraTabPage.Controls.Add(userControl);
            xtraTabPage.Controls[0].Dock = DockStyle.Fill;
            xtraTabParent.TabPages.Add(xtraTabPage);
        }
        public void AddTabControl(XtraTabControl xtraTabParent, string xtraItemName, UserControl userControl, string name)
        {
            XtraTabPage xtraTabPage = new XtraTabPage();
            xtraTabPage.Name = name;
            xtraTabPage.Text = xtraItemName;
            //traTabPage.Image = Bitmap.FromFile(@"..\..\Resources\" + icon);
            xtraTabPage.Controls.Add(userControl);
            xtraTabPage.Controls[0].Dock = DockStyle.Fill;
            xtraTabParent.TabPages.Add(xtraTabPage);
        }
    }
}
