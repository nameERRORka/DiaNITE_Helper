
namespace DiaNITE_Helper
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this._bt_add = new System.Windows.Forms.Button();
            this._bt_sub = new System.Windows.Forms.Button();
            this._bt_addnewpos = new System.Windows.Forms.Button();
            this._bt_openinfo = new System.Windows.Forms.Button();
            this._bt_exit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._gb_info = new System.Windows.Forms.GroupBox();
            this._lb_sum_stuff = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._lb_sub_stuff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._lb_buy_stuff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._cb_nameSuff = new System.Windows.Forms.ComboBox();
            this._gb_sub = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this._tb_subGB_sub = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this._cb_nameStuff_subGB = new System.Windows.Forms.ComboBox();
            this._gb_add_new = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this._tb_subStuff = new System.Windows.Forms.TextBox();
            this._tb_addStuff = new System.Windows.Forms.TextBox();
            this._tb_nameStuff = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._gb_add_in = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this._tb_addGB = new System.Windows.Forms.TextBox();
            this._cb_addGb = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._gb_info.SuspendLayout();
            this._gb_sub.SuspendLayout();
            this._gb_add_new.SuspendLayout();
            this._gb_add_in.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._bt_add);
            this.panel1.Controls.Add(this._bt_sub);
            this.panel1.Controls.Add(this._bt_addnewpos);
            this.panel1.Controls.Add(this._bt_openinfo);
            this.panel1.Controls.Add(this._bt_exit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-10, -8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 557);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Location = new System.Drawing.Point(147, 371);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Made by FCORE_Code";
            // 
            // _bt_add
            // 
            this._bt_add.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bt_add.Location = new System.Drawing.Point(38, 247);
            this._bt_add.Name = "_bt_add";
            this._bt_add.Size = new System.Drawing.Size(207, 44);
            this._bt_add.TabIndex = 3;
            this._bt_add.Text = "Внести приход";
            this._bt_add.UseVisualStyleBackColor = true;
            this._bt_add.Click += new System.EventHandler(this._bt_add_Click);
            // 
            // _bt_sub
            // 
            this._bt_sub.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bt_sub.Location = new System.Drawing.Point(38, 197);
            this._bt_sub.Name = "_bt_sub";
            this._bt_sub.Size = new System.Drawing.Size(207, 44);
            this._bt_sub.TabIndex = 3;
            this._bt_sub.Text = "Внести убыток";
            this._bt_sub.UseVisualStyleBackColor = true;
            this._bt_sub.Click += new System.EventHandler(this._bt_sub_Click);
            // 
            // _bt_addnewpos
            // 
            this._bt_addnewpos.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bt_addnewpos.Location = new System.Drawing.Point(38, 147);
            this._bt_addnewpos.Name = "_bt_addnewpos";
            this._bt_addnewpos.Size = new System.Drawing.Size(207, 44);
            this._bt_addnewpos.TabIndex = 3;
            this._bt_addnewpos.Text = "Добавить новый товар";
            this._bt_addnewpos.UseVisualStyleBackColor = true;
            this._bt_addnewpos.Click += new System.EventHandler(this._bt_addnewpos_Click);
            // 
            // _bt_openinfo
            // 
            this._bt_openinfo.Font = new System.Drawing.Font("Segoe UI Semilight", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bt_openinfo.Location = new System.Drawing.Point(38, 97);
            this._bt_openinfo.Name = "_bt_openinfo";
            this._bt_openinfo.Size = new System.Drawing.Size(207, 44);
            this._bt_openinfo.TabIndex = 3;
            this._bt_openinfo.Text = "Открыть информацию";
            this._bt_openinfo.UseVisualStyleBackColor = true;
            this._bt_openinfo.Click += new System.EventHandler(this._bt_openinfo_Click);
            // 
            // _bt_exit
            // 
            this._bt_exit.Font = new System.Drawing.Font("Segoe UI Semilight", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._bt_exit.Location = new System.Drawing.Point(38, 324);
            this._bt_exit.Name = "_bt_exit";
            this._bt_exit.Size = new System.Drawing.Size(207, 44);
            this._bt_exit.TabIndex = 3;
            this._bt_exit.Text = "Выход";
            this._bt_exit.UseVisualStyleBackColor = true;
            this._bt_exit.Click += new System.EventHandler(this._bt_exit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semilight", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(99, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = "Manager helper";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(93, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Dianite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // _gb_info
            // 
            this._gb_info.Controls.Add(this._lb_sum_stuff);
            this._gb_info.Controls.Add(this.label8);
            this._gb_info.Controls.Add(this._lb_sub_stuff);
            this._gb_info.Controls.Add(this.label7);
            this._gb_info.Controls.Add(this._lb_buy_stuff);
            this._gb_info.Controls.Add(this.label6);
            this._gb_info.Controls.Add(this.label5);
            this._gb_info.Controls.Add(this._cb_nameSuff);
            this._gb_info.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gb_info.Location = new System.Drawing.Point(264, 44);
            this._gb_info.Name = "_gb_info";
            this._gb_info.Size = new System.Drawing.Size(389, 26);
            this._gb_info.TabIndex = 1;
            this._gb_info.TabStop = false;
            this._gb_info.Text = "Общая информация о товаре";
            this._gb_info.Visible = false;
            // 
            // _lb_sum_stuff
            // 
            this._lb_sum_stuff.AutoSize = true;
            this._lb_sum_stuff.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lb_sum_stuff.Location = new System.Drawing.Point(202, 231);
            this._lb_sum_stuff.Name = "_lb_sum_stuff";
            this._lb_sum_stuff.Size = new System.Drawing.Size(77, 37);
            this._lb_sum_stuff.TabIndex = 1;
            this._lb_sum_stuff.Text = "NULL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Итоговое кол-во товара :";
            // 
            // _lb_sub_stuff
            // 
            this._lb_sub_stuff.AutoSize = true;
            this._lb_sub_stuff.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lb_sub_stuff.Location = new System.Drawing.Point(202, 175);
            this._lb_sub_stuff.Name = "_lb_sub_stuff";
            this._lb_sub_stuff.Size = new System.Drawing.Size(77, 37);
            this._lb_sub_stuff.TabIndex = 1;
            this._lb_sub_stuff.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Расход товара :";
            // 
            // _lb_buy_stuff
            // 
            this._lb_buy_stuff.AutoSize = true;
            this._lb_buy_stuff.Font = new System.Drawing.Font("Segoe UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._lb_buy_stuff.Location = new System.Drawing.Point(202, 118);
            this._lb_buy_stuff.Name = "_lb_buy_stuff";
            this._lb_buy_stuff.Size = new System.Drawing.Size(77, 37);
            this._lb_buy_stuff.TabIndex = 1;
            this._lb_buy_stuff.Text = "NULL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Закуплено товара :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Наименование товара :";
            // 
            // _cb_nameSuff
            // 
            this._cb_nameSuff.FormattingEnabled = true;
            this._cb_nameSuff.Location = new System.Drawing.Point(6, 84);
            this._cb_nameSuff.Name = "_cb_nameSuff";
            this._cb_nameSuff.Size = new System.Drawing.Size(365, 29);
            this._cb_nameSuff.TabIndex = 0;
            this._cb_nameSuff.SelectedIndexChanged += new System.EventHandler(this._cb_nameSuff_SelectedIndexChanged);
            // 
            // _gb_sub
            // 
            this._gb_sub.Controls.Add(this.button2);
            this._gb_sub.Controls.Add(this._tb_subGB_sub);
            this._gb_sub.Controls.Add(this.label16);
            this._gb_sub.Controls.Add(this.label15);
            this._gb_sub.Controls.Add(this.label9);
            this._gb_sub.Controls.Add(this._cb_nameStuff_subGB);
            this._gb_sub.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gb_sub.Location = new System.Drawing.Point(264, 72);
            this._gb_sub.Name = "_gb_sub";
            this._gb_sub.Size = new System.Drawing.Size(398, 50);
            this._gb_sub.TabIndex = 1;
            this._gb_sub.TabStop = false;
            this._gb_sub.Text = "Затраты товара";
            this._gb_sub.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(362, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "Внести убыток";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _tb_subGB_sub
            // 
            this._tb_subGB_sub.Location = new System.Drawing.Point(136, 135);
            this._tb_subGB_sub.Name = "_tb_subGB_sub";
            this._tb_subGB_sub.Size = new System.Drawing.Size(198, 29);
            this._tb_subGB_sub.TabIndex = 3;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(340, 138);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 21);
            this.label16.TabIndex = 2;
            this.label16.Text = "гр.";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 138);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(121, 21);
            this.label15.TabIndex = 2;
            this.label15.Text = "Убыток товара :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Наименование товара :";
            // 
            // _cb_nameStuff_subGB
            // 
            this._cb_nameStuff_subGB.FormattingEnabled = true;
            this._cb_nameStuff_subGB.Location = new System.Drawing.Point(6, 85);
            this._cb_nameStuff_subGB.Name = "_cb_nameStuff_subGB";
            this._cb_nameStuff_subGB.Size = new System.Drawing.Size(358, 29);
            this._cb_nameStuff_subGB.TabIndex = 0;
            this._cb_nameStuff_subGB.SelectedIndexChanged += new System.EventHandler(this._cb_nameSuff_SelectedIndexChanged);
            // 
            // _gb_add_new
            // 
            this._gb_add_new.Controls.Add(this.button1);
            this._gb_add_new.Controls.Add(this._tb_subStuff);
            this._gb_add_new.Controls.Add(this._tb_addStuff);
            this._gb_add_new.Controls.Add(this._tb_nameStuff);
            this._gb_add_new.Controls.Add(this.label12);
            this._gb_add_new.Controls.Add(this.label14);
            this._gb_add_new.Controls.Add(this.label13);
            this._gb_add_new.Controls.Add(this.label11);
            this._gb_add_new.Controls.Add(this.label10);
            this._gb_add_new.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gb_add_new.Location = new System.Drawing.Point(264, 12);
            this._gb_add_new.Name = "_gb_add_new";
            this._gb_add_new.Size = new System.Drawing.Size(373, 27);
            this._gb_add_new.TabIndex = 1;
            this._gb_add_new.TabStop = false;
            this._gb_add_new.Text = "Добавление новых поступлений";
            this._gb_add_new.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 93);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // _tb_subStuff
            // 
            this._tb_subStuff.Location = new System.Drawing.Point(6, 212);
            this._tb_subStuff.Name = "_tb_subStuff";
            this._tb_subStuff.Size = new System.Drawing.Size(245, 29);
            this._tb_subStuff.TabIndex = 1;
            // 
            // _tb_addStuff
            // 
            this._tb_addStuff.Location = new System.Drawing.Point(6, 151);
            this._tb_addStuff.Name = "_tb_addStuff";
            this._tb_addStuff.Size = new System.Drawing.Size(245, 29);
            this._tb_addStuff.TabIndex = 1;
            // 
            // _tb_nameStuff
            // 
            this._tb_nameStuff.Location = new System.Drawing.Point(6, 85);
            this._tb_nameStuff.Name = "_tb_nameStuff";
            this._tb_nameStuff.Size = new System.Drawing.Size(369, 29);
            this._tb_nameStuff.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 188);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(235, 21);
            this.label12.TabIndex = 0;
            this.label12.Text = "Затраченое количество товара :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(257, 215);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 21);
            this.label14.TabIndex = 0;
            this.label14.Text = "гр.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(257, 154);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(28, 21);
            this.label13.TabIndex = 0;
            this.label13.Text = "гр.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(249, 21);
            this.label11.TabIndex = 0;
            this.label11.Text = "Количество закупленного товара :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 21);
            this.label10.TabIndex = 0;
            this.label10.Text = "Наименование товара :";
            // 
            // _gb_add_in
            // 
            this._gb_add_in.Controls.Add(this.button3);
            this._gb_add_in.Controls.Add(this.label17);
            this._gb_add_in.Controls.Add(this._tb_addGB);
            this._gb_add_in.Controls.Add(this._cb_addGb);
            this._gb_add_in.Controls.Add(this.label19);
            this._gb_add_in.Controls.Add(this.label18);
            this._gb_add_in.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gb_add_in.Location = new System.Drawing.Point(264, 129);
            this._gb_add_in.Name = "_gb_add_in";
            this._gb_add_in.Size = new System.Drawing.Size(381, 197);
            this._gb_add_in.TabIndex = 1;
            this._gb_add_in.TabStop = false;
            this._gb_add_in.Text = "Пополнение товара";
            this._gb_add_in.Visible = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(369, 73);
            this.button3.TabIndex = 4;
            this.button3.Text = "Внести приход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(176, 21);
            this.label17.TabIndex = 1;
            this.label17.Text = "Наименование товара :";
            // 
            // _tb_addGB
            // 
            this._tb_addGB.Location = new System.Drawing.Point(6, 158);
            this._tb_addGB.Name = "_tb_addGB";
            this._tb_addGB.Size = new System.Drawing.Size(227, 29);
            this._tb_addGB.TabIndex = 3;
            // 
            // _cb_addGb
            // 
            this._cb_addGb.FormattingEnabled = true;
            this._cb_addGb.Location = new System.Drawing.Point(6, 85);
            this._cb_addGb.Name = "_cb_addGb";
            this._cb_addGb.Size = new System.Drawing.Size(369, 29);
            this._cb_addGb.TabIndex = 0;
            this._cb_addGb.SelectedIndexChanged += new System.EventHandler(this._cb_nameSuff_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(6, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(155, 21);
            this.label18.TabIndex = 2;
            this.label18.Text = "Пополнение товара:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(261, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Copyright © ForgeFuckTeam 2022 ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(239, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(28, 21);
            this.label19.TabIndex = 2;
            this.label19.Text = "гр.";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 383);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._gb_add_in);
            this.Controls.Add(this._gb_add_new);
            this.Controls.Add(this._gb_sub);
            this.Controls.Add(this._gb_info);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dianite | Manager helper | ver.1.1.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._gb_info.ResumeLayout(false);
            this._gb_info.PerformLayout();
            this._gb_sub.ResumeLayout(false);
            this._gb_sub.PerformLayout();
            this._gb_add_new.ResumeLayout(false);
            this._gb_add_new.PerformLayout();
            this._gb_add_in.ResumeLayout(false);
            this._gb_add_in.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _bt_add;
        private System.Windows.Forms.Button _bt_sub;
        private System.Windows.Forms.Button _bt_addnewpos;
        private System.Windows.Forms.Button _bt_openinfo;
        private System.Windows.Forms.Button _bt_exit;
        private System.Windows.Forms.GroupBox _gb_info;
        private System.Windows.Forms.GroupBox _gb_sub;
        private System.Windows.Forms.GroupBox _gb_add_new;
        private System.Windows.Forms.GroupBox _gb_add_in;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox _cb_nameSuff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label _lb_sum_stuff;
        private System.Windows.Forms.Label _lb_sub_stuff;
        private System.Windows.Forms.Label _lb_buy_stuff;
        private System.Windows.Forms.TextBox _tb_nameStuff;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox _tb_addStuff;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox _tb_subStuff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox _cb_nameStuff_subGB;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox _tb_subGB_sub;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox _tb_addGB;
        private System.Windows.Forms.ComboBox _cb_addGb;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}

