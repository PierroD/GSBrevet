using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI.WinForms;


namespace FrontEndGSBrevet.Utils
{
    class SelectMenu
    {

        #region getAll Control
        public IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                                      .Concat(controls)
                                      .Where(c => c.GetType() == type);
        }
        #endregion

        #region set menu color
        private static GunaButton menu_old_btn;
        private static Image menu_old_image;
        public void menuColor(Control ctrl, GunaButton btn, Image imgOn, Image imgOff)
        {
            foreach (GunaButton b in GetAll(ctrl, typeof(GunaButton)))
            {
                Color customColor = Color.FromArgb(209, 113, 255);

                if (b == menu_old_btn)
                {
                    b.BaseColor = Color.White;
                    b.Image = menu_old_image;
                }
                if (b == btn)
                {
                    btn.BaseColor = customColor;
                    btn.Image = imgOn;
                }
            }
            menu_old_btn = btn;
            menu_old_image = imgOff;
        }

        #endregion

        #region set submenu color
        private static GunaButton submenu_old_btn;
        private static Image submenu_old_image;
        public void submenuColor(Control ctrl, GunaButton btn, Image imgOn, Image imgOff)
        {
            foreach (GunaButton b in GetAll(ctrl, typeof(GunaButton)))
            {
                Color customColor = Color.FromArgb(193, 74, 255);

                if (b == submenu_old_btn)
                {
                    b.BaseColor = Color.White;
                    b.Image = submenu_old_image;
                }
                if (b == btn)
                {
                    btn.BaseColor = customColor;
                    btn.Image = imgOn;
                }
            }
            submenu_old_btn = btn;
            submenu_old_image = imgOff;
        }

        #endregion
    }
}
