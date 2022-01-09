
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
            this._list_dateSub = new System.Windows.Forms.ListBox();
            this._lb_sum_stuff = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this._lb_sub_stuff = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this._lb_buy_stuff = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this._cb_nameSuff = new System.Windows.Forms.ComboBox();
            this._gb_sub = new System.Windows.Forms.GroupBox();
            this._gb_add_new = new System.Windows.Forms.GroupBox();
            this._gb_add_in = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this._gb_info.SuspendLayout();
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
            this.label3.Location = new System.Drawing.Point(147, 522);
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
            this._bt_exit.Location = new System.Drawing.Point(38, 457);
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
            this._gb_info.Controls.Add(this._list_dateSub);
            this._gb_info.Controls.Add(this._lb_sum_stuff);
            this._gb_info.Controls.Add(this.label9);
            this._gb_info.Controls.Add(this.label8);
            this._gb_info.Controls.Add(this._lb_sub_stuff);
            this._gb_info.Controls.Add(this.label7);
            this._gb_info.Controls.Add(this._lb_buy_stuff);
            this._gb_info.Controls.Add(this.label6);
            this._gb_info.Controls.Add(this.label5);
            this._gb_info.Controls.Add(this._cb_nameSuff);
            this._gb_info.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gb_info.Location = new System.Drawing.Point(264, 12);
            this._gb_info.Name = "_gb_info";
            this._gb_info.Size = new System.Drawing.Size(598, 481);
            this._gb_info.TabIndex = 1;
            this._gb_info.TabStop = false;
            this._gb_info.Text = "INFO";
            this._gb_info.Visible = false;
            // 
            // _list_dateSub
            // 
            this._list_dateSub.FormattingEnabled = true;
            this._list_dateSub.ItemHeight = 21;
            this._list_dateSub.Location = new System.Drawing.Point(218, 238);
            this._list_dateSub.Name = "_list_dateSub";
            this._list_dateSub.Size = new System.Drawing.Size(169, 235);
            this._list_dateSub.TabIndex = 2;
            // 
            // _lb_sum_stuff
            // 
            this._lb_sum_stuff.AutoSize = true;
            this._lb_sum_stuff.Location = new System.Drawing.Point(214, 203);
            this._lb_sum_stuff.Name = "_lb_sum_stuff";
            this._lb_sum_stuff.Size = new System.Drawing.Size(45, 21);
            this._lb_sum_stuff.TabIndex = 1;
            this._lb_sum_stuff.Text = "NULL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 21);
            this.label9.TabIndex = 1;
            this.label9.Text = "Даты убытка товара :";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 21);
            this.label8.TabIndex = 1;
            this.label8.Text = "Итоговое кол-во товара :";
            // 
            // _lb_sub_stuff
            // 
            this._lb_sub_stuff.AutoSize = true;
            this._lb_sub_stuff.Location = new System.Drawing.Point(214, 182);
            this._lb_sub_stuff.Name = "_lb_sub_stuff";
            this._lb_sub_stuff.Size = new System.Drawing.Size(45, 21);
            this._lb_sub_stuff.TabIndex = 1;
            this._lb_sub_stuff.Text = "NULL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Расход товара :";
            // 
            // _lb_buy_stuff
            // 
            this._lb_buy_stuff.AutoSize = true;
            this._lb_buy_stuff.Location = new System.Drawing.Point(214, 161);
            this._lb_buy_stuff.Name = "_lb_buy_stuff";
            this._lb_buy_stuff.Size = new System.Drawing.Size(45, 21);
            this._lb_buy_stuff.TabIndex = 1;
            this._lb_buy_stuff.Text = "NULL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "Закуплено товара :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Наименование товара :";
            // 
            // _cb_nameSuff
            // 
            this._cb_nameSuff.FormattingEnabled = true;
            this._cb_nameSuff.Items.AddRange(new object[] {
            "NULL"});
            this._cb_nameSuff.Location = new System.Drawing.Point(10, 69);
            this._cb_nameSuff.Name = "_cb_nameSuff";
            this._cb_nameSuff.Size = new System.Drawing.Size(582, 29);
            this._cb_nameSuff.TabIndex = 0;
            // 
            // _gb_sub
            // 
            this._gb_sub.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gb_sub.Location = new System.Drawing.Point(668, 321);
            this._gb_sub.Name = "_gb_sub";
            this._gb_sub.Size = new System.Drawing.Size(200, 100);
            this._gb_sub.TabIndex = 1;
            this._gb_sub.TabStop = false;
            this._gb_sub.Text = "SUB";
            this._gb_sub.Visible = false;
            // 
            // _gb_add_new
            // 
            this._gb_add_new.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gb_add_new.Location = new System.Drawing.Point(668, 215);
            this._gb_add_new.Name = "_gb_add_new";
            this._gb_add_new.Size = new System.Drawing.Size(200, 100);
            this._gb_add_new.TabIndex = 1;
            this._gb_add_new.TabStop = false;
            this._gb_add_new.Text = "ADD_NEW";
            this._gb_add_new.Visible = false;
            // 
            // _gb_add_in
            // 
            this._gb_add_in.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._gb_add_in.Location = new System.Drawing.Point(668, 427);
            this._gb_add_in.Name = "_gb_add_in";
            this._gb_add_in.Size = new System.Drawing.Size(200, 100);
            this._gb_add_in.TabIndex = 1;
            this._gb_add_in.TabStop = false;
            this._gb_add_in.Text = "ADD_INS";
            this._gb_add_in.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(264, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Copyright © ForgeFuckTeam 2022 ";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 539);
            this.Controls.Add(this.label4);
            this.Controls.Add(this._gb_add_in);
            this.Controls.Add(this._gb_add_new);
            this.Controls.Add(this._gb_sub);
            this.Controls.Add(this._gb_info);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dianite | Manager helper | ver.1.1.3";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this._gb_info.ResumeLayout(false);
            this._gb_info.PerformLayout();
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox _list_dateSub;
    }
}

