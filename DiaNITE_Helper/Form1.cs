using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DiaNITE_Helper
{
    public partial class MainWindow : Form
    {
        //604; 346 SIZE GROUPBOX
        //264; 12 POSITION GROUPBOX

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn (int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        private Point mouseOffset;
        private bool isMouseDown = false;

        public int subItogExport;
        public int subAddExport;
        public int subSubExport;
        public int subAddMath;

        public int summItogExport;
        public int summAddExport;
        public int summSubExport;
        public int summAddMath;

        public MainWindow()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 75, 75));

            _gb_info.Location = new Point(264, 12);
            _gb_add_in.Location = new Point(264, 12);
            _gb_add_new.Location = new Point(264, 12);
            _gb_sub.Location = new Point(264, 12);

            _gb_info.Size = new Size(381, 346);
            _gb_add_in.Size = new Size(381, 346);
            _gb_add_new.Size = new Size(381, 346);
            _gb_sub.Size = new Size(381, 346);

            _db_Main db = new _db_Main();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM _tb_stuff", db.getConnection());
            db.openConnection();


            db.closeConnection();
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

            _db_Main db = new _db_Main();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM _tb_stuff", db.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            _cb_nameSuff.DataSource = table;
            _cb_nameSuff.DisplayMember = "nameStuff";
            db.closeConnection();
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

            _db_Main db = new _db_Main();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM _tb_stuff", db.getConnection());

            adapter.SelectCommand = command1;
            adapter.Fill(table);

            _cb_nameStuff_subGB.DataSource = table;
            _cb_nameStuff_subGB.DisplayMember = "nameStuff";
            db.closeConnection();
        }

        private void _bt_add_Click(object sender, EventArgs e)
        {
            _gb_info.Visible = false;
            _gb_add_in.Visible = true;
            _gb_add_new.Visible = false;
            _gb_sub.Visible = false;

            _db_Main db = new _db_Main();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command1 = new MySqlCommand("SELECT * FROM _tb_stuff", db.getConnection());

            adapter.SelectCommand = command1;
            adapter.Fill(table);

            _cb_addGb.DataSource = table;
            _cb_addGb.DisplayMember = "nameStuff";
            db.closeConnection();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void _cb_nameSuff_SelectedIndexChanged(object sender, EventArgs e)
        {
            string _nm_St;
            _db_Main db = new _db_Main();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT addStuff, subStuff, sumStuff FROM _tb_stuff WHERE nameStuff = @nameSt", db.getConnection());
            db.openConnection();
            _nm_St = _cb_nameSuff.Text;
            command.Parameters.AddWithValue("@nameSt", _nm_St);

            using (var reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int addStInf = reader.GetInt32("addStuff");
                        int subStInf = reader.GetInt32("subStuff");
                        int sumStInf = addStInf - subStInf;
                        _lb_buy_stuff.Text = reader.GetInt32("addStuff").ToString() + " гр.";
                        _lb_sub_stuff.Text = reader.GetInt32("subStuff").ToString() + " гр.";
                        _lb_sum_stuff.Text = sumStInf + " гр.";
                    }
                }
            }
            db.closeConnection();     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _db_Main db = new _db_Main();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("INSERT INTO _tb_stuff (nameStuff,addStuff,subStuff,sumStuff) VALUES (@insNameST,@addSt,@subSt,@sumSt);", db.getConnection());
            
            int addST = Convert.ToInt32(_tb_addStuff.Text);
            int subST = Convert.ToInt32(_tb_subStuff.Text);

            command.Parameters.Add("@insNameST", MySqlDbType.VarChar).Value = _tb_nameStuff.Text;
            command.Parameters.Add("@addSt", MySqlDbType.Int32).Value = addST;
            command.Parameters.Add("@subSt", MySqlDbType.Int32).Value = subST;
            command.Parameters.Add("@sumSt", MySqlDbType.Int32).Value = addST - subST;

            db.openConnection();

            if (_tb_addStuff.Text != "" && _tb_nameStuff.Text != "" && _tb_subStuff.Text != "")
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Товар добавлен успешно!");
                }
                else
                {
                    MessageBox.Show("Товар не был добавлен!!!");
                }
            }
            else {
                MessageBox.Show("Укажите корректные данные!");
            }

            db.closeConnection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _db_Main db = new _db_Main();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand readSub = new MySqlCommand("SELECT addStuff, subStuff, sumStuff FROM _tb_stuff WHERE nameStuff = @nameSt1", db.getConnection());

            readSub.Parameters.Add("@nameST1", MySqlDbType.VarChar).Value = _cb_nameStuff_subGB.Text;

            db.openConnection();
            using (var reader = readSub.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        subAddExport = reader.GetInt32("addStuff");
                        subSubExport = reader.GetInt32("subStuff");
                        subAddMath = Convert.ToInt32(_tb_subGB_sub.Text) + subSubExport;

                        subItogExport = subAddExport - subAddMath;

                    }
                }
            }
            db.closeConnection();

            MySqlCommand command = new MySqlCommand("UPDATE _tb_stuff SET subStuff = @subST WHERE nameStuff = @nameST1", db.getConnection());
            command.Parameters.Add("@subST", MySqlDbType.Int32).Value = subAddMath;
            command.Parameters.Add("@nameST1", MySqlDbType.VarChar).Value = _cb_nameStuff_subGB.Text;
            db.openConnection();
            if (_tb_subGB_sub.Text != "")
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Убытки внесены успешно!");
                }
                else { MessageBox.Show("Убытки не были внесены!"); }
            }
            else
            {
                MessageBox.Show("Введите корректные данные");
            }
            db.closeConnection();


            MySqlCommand comUPD2 = new MySqlCommand("UPDATE _tb_stuff SET sumStuff = @sumST WHERE nameStuff = @nameST3", db.getConnection());
            comUPD2.Parameters.Add("@sumST", MySqlDbType.Int32).Value = subItogExport;
            comUPD2.Parameters.Add("@nameST3", MySqlDbType.VarChar).Value = _cb_nameStuff_subGB.Text;
            db.openConnection();
            if (_tb_addGB.Text != "")
            {
                if (comUPD2.ExecuteNonQuery() == 1)
                {

                }
                else { }
            }
            else
            {

            }
            db.closeConnection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _db_Main db = new _db_Main();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand readSub = new MySqlCommand("SELECT addStuff, subStuff, sumStuff FROM _tb_stuff WHERE nameStuff = @nameSt1", db.getConnection());

            readSub.Parameters.Add("@nameST1", MySqlDbType.VarChar).Value = _cb_addGb.Text;

            db.openConnection();
            using (var reader = readSub.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        summAddExport = reader.GetInt32("addStuff");
                        summSubExport = reader.GetInt32("subStuff");
                        summAddMath = Convert.ToInt32(_tb_addGB.Text) + summAddExport;

                        summItogExport = summAddMath - summSubExport; 
                    }
                }
            }
            db.closeConnection();

            MySqlCommand comUPD = new MySqlCommand("UPDATE _tb_stuff SET addStuff = @addST WHERE nameStuff = @nameST2", db.getConnection());
            comUPD.Parameters.Add("@addST", MySqlDbType.Int32).Value = summAddMath;
            comUPD.Parameters.Add("@nameST2", MySqlDbType.VarChar).Value = _cb_addGb.Text;
            db.openConnection();
            if (_tb_addGB.Text != "")
            {
                if (comUPD.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Убытки внесены успешно!");
                }
                else { MessageBox.Show("Убытки не были внесены!"); }
            }
            else
            {
                MessageBox.Show("Введите корректные данные");
            }
            db.closeConnection();

            MySqlCommand comUPD2 = new MySqlCommand("UPDATE _tb_stuff SET sumStuff = @sumST WHERE nameStuff = @nameST3", db.getConnection());
            comUPD2.Parameters.Add("@sumST", MySqlDbType.Int32).Value = summItogExport;
            comUPD2.Parameters.Add("@nameST3", MySqlDbType.VarChar).Value = _cb_addGb.Text;
            db.openConnection();
            if (_tb_addGB.Text != "")
            {
                if (comUPD2.ExecuteNonQuery() == 1)
                {
                   
                }
                else {  }
            }
            else
            {
                
            }
            db.closeConnection();
        }
    }
}
