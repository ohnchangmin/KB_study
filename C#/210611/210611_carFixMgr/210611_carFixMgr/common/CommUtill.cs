﻿using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _210611_carFixMgr.common
{
    class CommUtill
    {
        public static void initTheme(Form form)
        {
            var mgr = MaterialSkinManager.Instance;
            mgr.AddFormToManage(form as MaterialForm);
            mgr.Theme = MaterialSkinManager.Themes.LIGHT;
            mgr.ColorScheme = new ColorScheme(Primary.Grey700, Primary.Grey700, Primary.Indigo700
                , Accent.Indigo700, TextShade.WHITE);
        }

        public static void setRowColor(ListView list, Color even, Color odd)
        {
            foreach (ListViewItem item in list.Items)
            {
                if (item.Index % 2 == 0)
                {
                    item.BackColor = even;
                }
                else
                {
                    item.BackColor = odd;
                }
            }
        }

        public static void colorListViewHeader(ref ListView list, Color backColor, Color foreColor)
        {
            list.OwnerDraw = true;
            list.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler
                (
                (sender, e) => headerDraw(sender, e, backColor, foreColor)
                );
            list.DrawItem += new DrawListViewItemEventHandler(bodyDraw);
        }

        private static void headerDraw(object sender, DrawListViewColumnHeaderEventArgs e, Color backColor, Color foreColor)
        {
            using (SolidBrush backBrush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(backBrush, e.Bounds);
            }
            using (SolidBrush foreBrush = new SolidBrush(foreColor))
            {
                e.Graphics.DrawString(e.Header.Text, e.Font, foreBrush, e.Bounds);
            }
        }

        private static void bodyDraw(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;

        }
    }
}
