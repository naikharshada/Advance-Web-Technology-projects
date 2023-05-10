using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZomatoApp
{
    public partial class FrmMain : Form
    {
        String[] columns = { "Name", "Category", "Rating", "Location" };
        Restaurant[] restList;
        public FrmMain()
        {
            restList = new Restaurant[3];
            restList[0] = new Domino_s();
            restList[1] = new LuckyRestaurant();
            restList[2] = new BarbaqueNation();
            InitializeComponent();
        }

        private void Context_click(object sender, EventArgs e)
        {
            ToolStripMenuItem temp = (ToolStripMenuItem)sender;
            switch(temp.Text)
            {
                case "Large Icon":
                    lstDisplay.View = View.LargeIcon;
                    break;

                case "Small Icon":
                    lstDisplay.View = View.SmallIcon;
                    break;

                case "Tile":
                    lstDisplay.View = View.Tile;
                    break;

                case "Details":
                    lstDisplay.View = View.Details;
                    break;

                case "List":
                    lstDisplay.View = View.List;
                    break;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            foreach (string s in columns)
            {
                lstDisplay.Columns.Add(s);
            }
            for (int i = 0; i < restList.Length; i++)
            {
                ListViewItem l1 = new ListViewItem(restList[i].GetName());
                l1.SubItems.Add(restList[i].GetCategory());
                l1.SubItems.Add(restList[i].GetRating().ToString());
                l1.SubItems.Add(restList[i].GetAddress());
                l1.ImageIndex = i;
                lstDisplay.Items.Add(l1);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            lstDisplay.Items.Clear();

            string searchString = txtSearch.Text.ToLower();
            for(int i = 0; i < restList.Length; i++)
            {
                if(restList[i].GetName().ToLower().Contains(searchString))
                {
                    ListViewItem l1 = new ListViewItem(restList[i].GetName());
                    l1.SubItems.Add(restList[i].GetCategory());
                    l1.SubItems.Add(restList[i].GetRating().ToString());
                    l1.SubItems.Add(restList[i].GetAddress());
                    l1.ImageIndex = i;
                    lstDisplay.Items.Add(l1);
                }
            }
        }
    }
}
