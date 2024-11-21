using ClinicaDesktop.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaDesktop.Class
{
    public static class ShowInActivity
    {
        static ShowInActivityView showInActivityView;
        public static void Show()
        {
            if (showInActivityView == null)
                showInActivityView = new ShowInActivityView();
            if (!showInActivityView.Visible)
            {
                showInActivityView.Show();
            }
        }
        public static void Hide()
        {
            showInActivityView.Hide();
        }
    }
}
