using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace checkCSV
{
    static class ABI
    {
        public static string hasDashAtEnd(string path)
        {
            if (path.EndsWith(@"\"))
            {
                path = path.Remove(path.Length - 1);
            }
            return path;
        }

        public static Color colorOfField(ElementData part)
        {
            if (part.status == 1)
            {
                return Color.LimeGreen;
            }
            else if (part.status == 2)
            {
                return Color.Red;
            }
            else if (part.status == 3)
            {
                return Color.Yellow;
            }
            else
            {
                return Color.Cyan;
            }
        }


        //private void rb_status_0_CheckedChanged(object sender, EventArgs e)
        //{
        //    rb_set_value();
        //    status_list_update();
        //}

        //private void rb_status_1_CheckedChanged(object sender, EventArgs e)
        //{
        //    rb_set_value();
        //    status_list_update();
        //}

        //private void rb_status_2_CheckedChanged(object sender, EventArgs e)
        //{
        //    rb_set_value();
        //    status_list_update();
        //}

        //private void rb_status_3_CheckedChanged(object sender, EventArgs e)
        //{
        //    rb_set_value();
        //    status_list_update();
        //}

        //private void rb_status_4_CheckedChanged(object sender, EventArgs e)
        //{
        //    rb_set_value();
        //    status_list_update();
        //}

        //private void rb_enable_buttons()
        //{
        //    rb_update_text();

        //    if (_reportData.total > 0)
        //    {
        //        rb_status_0.Enabled = true;
        //        rb_status_1.Enabled = true;
        //        rb_status_1.BackColor = Color.Lime;
        //        rb_status_2.Enabled = true;
        //        rb_status_2.BackColor = Color.Red;
        //        rb_status_3.Enabled = true;
        //        rb_status_3.BackColor = Color.Yellow;
        //        rb_status_4.Enabled = true;
        //        rb_status_4.BackColor = Color.Cyan;
        //    }
        //}

        //private void rb_disable_buttons()
        //{
        //    rb_update_text();

        //    rb_status_0.Enabled = false;
        //    rb_status_1.Enabled = false;
        //    rb_status_1.BackColor = Color.Transparent;
        //    rb_status_2.Enabled = false;
        //    rb_status_2.BackColor = Color.Transparent;
        //    rb_status_3.Enabled = false;
        //    rb_status_3.BackColor = Color.Transparent;
        //    rb_status_4.Enabled = false;
        //    rb_status_4.BackColor = Color.Transparent;
        //}

        //private void rb_update_text()
        //{
        //    rb_status_0.Text = "Total (" + _reportData.total.ToString() + ")";
        //    rb_status_1.Text = "OK (" + _reportData.status_ok + ")";
        //    rb_status_2.Text = "Missing (" + _reportData.status_missing + ")";
        //    rb_status_3.Text = "Not Set (" + _reportData.status_not_set + ")";
        //    rb_status_4.Text = "Not Set - has drawing (" + _reportData.status_not_set_has_drawing + ")";
        //}

        //private void rb_set_value()
        //{
        //    if (rb_status_0.Checked)
        //    {
        //        _rb_filter = 0;
        //    }
        //    else if (rb_status_1.Checked)
        //    {
        //        _rb_filter = 1;
        //    }

        //    else if (rb_status_2.Checked)
        //    {
        //        _rb_filter = 2;
        //    }

        //    else if (rb_status_3.Checked)
        //    {
        //        _rb_filter = 3;
        //    }

        //    else if (rb_status_4.Checked)
        //    {
        //        _rb_filter = 4;
        //    }
        //}

    }
}
