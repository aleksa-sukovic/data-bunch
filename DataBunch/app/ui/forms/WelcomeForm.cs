using System;
using System.Drawing;
using System.Windows.Forms;
using DataBunch.app.foundation.utils;
using DataBunch.app.sessions.services;

namespace DataBunch.app.ui.forms
{
    public partial class WelcomeForm : Form
    {
        private Point lastPoint;

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void onLoad(object sender, EventArgs e)
        {
            ConsoleManager.Show();
            Auth.init();
        }

        private void onMouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void onMouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void onMinimiseClick(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void onExitClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}
