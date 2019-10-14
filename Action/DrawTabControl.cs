using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 仓库管理系统
{
    public class DrawTabControl
    {
        TabControl mainTabControl = null;
        public Font Font { get; private set; }

        public DrawTabControl(TabControl tabcontrol, Font fo)
        {
            mainTabControl = tabcontrol;
            Font = fo;
            this.mainTabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            this.mainTabControl.DrawItem += new DrawItemEventHandler(this.mainTabControl_DrawItem);
            this.mainTabControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainTabControl_MouseDown);
        }

        public void Add_TabPage(string str, Form myForm)
        {
            str += "  ";
            if (tabControlCheckHave(this.mainTabControl, str))
            {
                return;
            }
            else
            {
                mainTabControl.TabPages.Add(str);
                mainTabControl.SelectTab(mainTabControl.TabPages.Count - 1);
                myForm.FormBorderStyle = FormBorderStyle.None;
                myForm.Dock = DockStyle.Fill;
                myForm.TopLevel = false;
                myForm.Show();
                myForm.Parent = mainTabControl.SelectedTab;
            }
            if (mainTabControl.TabPages.Count > 0)
            {
                mainTabControl.Show();
            }
        }
        public bool tabControlCheckHave(System.Windows.Forms.TabControl tab, String tabName)
        {
            for (int i = 0; i < tab.TabCount; i++)
            {
                if (tab.TabPages[i].Text == tabName)
                {
                    tab.SelectedIndex = i;
                    return true;
                }
            }
            return false;
        }

        private void mainTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*如果将 DrawMode 属性设置为 OwnerDrawFixed， 
           则每当 TabControl 需要绘制它的一个选项卡时，它就会引发 DrawItem 事件*/
            try
            {
                this.mainTabControl.TabPages[e.Index].BackColor = Color.Red;
                Color color = (e.State == DrawItemState.Selected) ? Color.LightBlue : Color.White;
                Rectangle backgroundRec = this.mainTabControl.GetTabRect(e.Index);
                using(Pen pen = new Pen(color))
                {
                    backgroundRec.Offset(0, 0);
                    
                }
                using(Brush brush = new SolidBrush(color))
                {
                    e.Graphics.FillRectangle(brush, backgroundRec);
                }

                Rectangle tabRect = this.mainTabControl.GetTabRect(e.Index);
                e.Graphics.DrawString(this.mainTabControl.TabPages[e.Index].Text, this.Font, SystemBrushes.ControlText, (float)(tabRect.X + 2), (float)(tabRect.Y + 2));
                using (Pen pen = new Pen(Color.White))
                {
                    tabRect.Offset(tabRect.Width - 15, 2);
                    tabRect.Width = 15;
                    tabRect.Height = 15;
                    //e.Graphics.DrawRectangle(pen, tabRect);
                }
                //using (Brush brush = new SolidBrush(color))
                //{
                //    e.Graphics.FillRectangle(brush, tabRect);
                //}
                using (Pen pen2 = new Pen(Color.Black))
                {
                    Point point = new Point(tabRect.X + 3, tabRect.Y + 3);
                    Point point2 = new Point((tabRect.X + tabRect.Width) - 3, (tabRect.Y + tabRect.Height) - 3);
                    e.Graphics.DrawLine(pen2, point, point2);
                    Point point3 = new Point(tabRect.X + 3, (tabRect.Y + tabRect.Height) - 3);
                    Point point4 = new Point((tabRect.X + tabRect.Width) - 3, tabRect.Y + 3);
                    e.Graphics.DrawLine(pen2, point3, point4);
                }
                e.Graphics.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mainTabControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                int x = e.X;
                int y = e.Y;

                Rectangle tabRect = this.mainTabControl.GetTabRect(this.mainTabControl.SelectedIndex);
                tabRect.Offset(tabRect.Width - 0x12, 2);
                tabRect.Width = 15;
                tabRect.Height = 15;
                if ((((x > tabRect.X) && (x < tabRect.Right)) && (y > tabRect.Y)) && (y < tabRect.Bottom))
                {
                    this.mainTabControl.TabPages.Remove(this.mainTabControl.SelectedTab);
                }
                if (mainTabControl.TabPages.Count <= 0)
                {
                    mainTabControl.Hide();
                }
            }
        }
    }

}

        

