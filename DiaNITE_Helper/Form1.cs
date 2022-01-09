using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DiaNITE_Helper
{
    public partial class MainWindow : Form
    {
        //598; 481 SIZE GROUPBOX
        //264; 12 POSITION GROUPBOX

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private Point mouseOffset;
        private bool isMouseDown = false;
        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 75, 75));

            _gb_info.Location = new Point(264, 12);
            _gb_add_in.Location = new Point(264, 12);
            _gb_add_new.Location = new Point(264, 12);
            _gb_sub.Location = new Point(264, 12);

            _gb_info.Size = new Size(598, 481);
            _gb_add_in.Size = new Size(598, 481);
            _gb_add_new.Size = new Size(598, 481);
            _gb_sub.Size = new Size(598, 481);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }

        private void _bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void _bt_openinfo_Click(object sender, EventArgs e)
        {
            _gb_info.Visible = true;
            _gb_add_in.Visible = false;
            _gb_add_new.Visible = false;
            _gb_sub.Visible = false;
        }

        private void _bt_addnewpos_Click(object sender, EventArgs e)
        {
            _gb_info.Visible = false;
            _gb_add_in.Visible = false;
            _gb_add_new.Visible = true;
            _gb_sub.Visible = false;
        }

        private void _bt_sub_Click(object sender, EventArgs e)
        {
            _gb_info.Visible = false;
            _gb_add_in.Visible = false;
            _gb_add_new.Visible = false;
            _gb_sub.Visible = true;
        }

        private void _bt_add_Click(object sender, EventArgs e)
        {
            _gb_info.Visible = false;
            _gb_add_in.Visible = true;
            _gb_add_new.Visible = false;
            _gb_sub.Visible = false;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
