using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;
using System.Reflection;
using DevExpress.XtraNavBar.ViewInfo;

namespace ScrollGroups {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            const int GroupCount = 7;
            const int ItemCount = 10;

            navBarControl1.Groups.Clear();
            for(int i = 0; i < GroupCount; i++) {
                NavBarGroup group = navBarControl1.Groups.Add();
                group.Caption = "Group " + i.ToString();
                group.Expanded = true;
                for(int j = 0; j < ItemCount; j++) {
                    NavBarItemLink link = group.AddItem();
                    link.Item.Caption = "Item " + j.ToString();
                }
            }
        }

        NavBarViewInfo GetNavBarView(NavBarControl navBar) {
            PropertyInfo pi = typeof(NavBarControl).GetProperty("ViewInfo", BindingFlags.Instance | BindingFlags.NonPublic);
            return pi.GetValue(navBar, null) as NavBarViewInfo;
        }

        ExplorerBarNavBarViewInfo GetExplorerNavBarView(NavBarControl navBar) {
            return (ExplorerBarNavBarViewInfo)GetNavBarView(navBar);
        }

        const int ScrollStep = 20;

        private void btnScrollUp_Click(object sender, EventArgs e) {
            ExplorerBarNavBarViewInfo view = GetExplorerNavBarView(navBarControl1);
            view.TopY -= ScrollStep;
        }

        private void btnScrollDown_Click(object sender, EventArgs e) {
            ExplorerBarNavBarViewInfo view = GetExplorerNavBarView(navBarControl1);
            view.TopY += ScrollStep;
        }

        private void btnScrollToGroup_Click(object sender, EventArgs e) {
            ExplorerBarNavBarViewInfo view = GetExplorerNavBarView(navBarControl1);
            NavBarGroup group3 = navBarControl1.Groups[3];
            view.TopY += view.GetGroupInfo(group3).Bounds.Top - view.UpButtonBounds.Bottom;
        }
    }
}