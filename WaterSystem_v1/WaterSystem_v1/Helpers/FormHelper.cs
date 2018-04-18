using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaterSystem_v1.Helpers
{
    public static class FormHelper
    {
        public static void OpenForm(Control container, Form form)
        {
            try
            {
                Logs.Logger.Info(string.Format("Opening form {0} start.", form.Name));
                bool alreadyOpen = false;
                foreach (var appForm in Application.OpenForms)
                {
                   var a = Application.OpenForms.GetEnumerator();
                 
                    if (appForm.GetType().Name == form.Name)
                    {
                        alreadyOpen = true;
                        break;
                    }
                }
                if (true)
                {
                    form.TopLevel = false;
                    container.Controls.Clear();
                    container.Controls.Add(form);
                    form.Dock = DockStyle.Fill;
                    Logs.Logger.Info(string.Format("Opening form {0} success.", form.Name));
                    form.Show();
                }
            }
            catch (Exception ex)
            {
                Logs.Logger.Error(string.Format("Error in opening form {0}.", form.Name), ex);
                    throw ex;
            }
        }

        public static void OpenForm(Form form)
        {
            if (!(Application.OpenForms.OfType<Form>().Count() == 1))
            {
                form.Show();
            }
        }

        public static void OpenForm(Form form, Point location)
        {
            if (!(Application.OpenForms.OfType<Form>().Count() == 1))
            {
                location.X +=  5;
                location.Y += 5;
                form.Location = location;
                form.Show();
            }
        }
    }
}
