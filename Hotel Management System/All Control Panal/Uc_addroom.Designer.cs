namespace Hotel_Management_System.All_Control_Panal
{
    partial class Uc_addroom
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Uc_addroom));
            this.label1 = new System.Windows.Forms.Label();
            this.Datagridview1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtroomty = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtbed = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnaddroom = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txtroomnum = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Room";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Datagridview1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Datagridview1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Datagridview1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Datagridview1.BackgroundColor = System.Drawing.Color.White;
            this.Datagridview1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Datagridview1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagridview1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Datagridview1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Datagridview1.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Datagridview1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Datagridview1.EnableHeadersVisualStyles = false;
            this.Datagridview1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagridview1.Location = new System.Drawing.Point(7, 55);
            this.Datagridview1.Margin = new System.Windows.Forms.Padding(2);
            this.Datagridview1.Name = "Datagridview1";
            this.Datagridview1.RowHeadersVisible = false;
            this.Datagridview1.RowHeadersWidth = 51;
            this.Datagridview1.RowTemplate.Height = 24;
            this.Datagridview1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Datagridview1.Size = new System.Drawing.Size(297, 300);
            this.Datagridview1.TabIndex = 2;
            this.Datagridview1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Datagridview1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagridview1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Datagridview1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Datagridview1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Datagridview1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Datagridview1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Datagridview1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagridview1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Datagridview1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Datagridview1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagridview1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.Datagridview1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Datagridview1.ThemeStyle.HeaderStyle.Height = 4;
            this.Datagridview1.ThemeStyle.ReadOnly = false;
            this.Datagridview1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Datagridview1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Datagridview1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Datagridview1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.Datagridview1.ThemeStyle.RowsStyle.Height = 24;
            this.Datagridview1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Datagridview1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Datagridview1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datagridview1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightGray;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(338, 45);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Room Number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.LightGray;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(337, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.LightGray;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(338, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Bed";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(338, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Price";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtprice
            // 
            this.txtprice.Animated = true;
            this.txtprice.AutoRoundedCorners = true;
            this.txtprice.BorderColor = System.Drawing.Color.Navy;
            this.txtprice.BorderRadius = 11;
            this.txtprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtprice.DefaultText = "";
            this.txtprice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtprice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtprice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.DisabledState.Parent = this.txtprice;
            this.txtprice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtprice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.FocusedState.Parent = this.txtprice;
            this.txtprice.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtprice.ForeColor = System.Drawing.Color.Black;
            this.txtprice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtprice.HoverState.Parent = this.txtprice;
            this.txtprice.Location = new System.Drawing.Point(341, 259);
            this.txtprice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtprice.Name = "txtprice";
            this.txtprice.PasswordChar = '\0';
            this.txtprice.PlaceholderText = "Price";
            this.txtprice.SelectedText = "";
            this.txtprice.ShadowDecoration.Parent = this.txtprice;
            this.txtprice.Size = new System.Drawing.Size(249, 24);
            this.txtprice.TabIndex = 8;
            this.txtprice.TextChanged += new System.EventHandler(this.txtprice_TextChanged);
            // 
            // txtroomty
            // 
            this.txtroomty.Animated = true;
            this.txtroomty.AutoRoundedCorners = true;
            this.txtroomty.BackColor = System.Drawing.Color.Transparent;
            this.txtroomty.BorderColor = System.Drawing.Color.Navy;
            this.txtroomty.BorderRadius = 17;
            this.txtroomty.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtroomty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtroomty.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomty.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomty.FocusedState.Parent = this.txtroomty;
            this.txtroomty.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtroomty.ForeColor = System.Drawing.Color.Black;
            this.txtroomty.HoverState.Parent = this.txtroomty;
            this.txtroomty.ItemHeight = 30;
            this.txtroomty.Items.AddRange(new object[] {
            "Ac",
            "Non-Ac"});
            this.txtroomty.ItemsAppearance.Parent = this.txtroomty;
            this.txtroomty.Location = new System.Drawing.Point(341, 128);
            this.txtroomty.Margin = new System.Windows.Forms.Padding(2);
            this.txtroomty.Name = "txtroomty";
            this.txtroomty.ShadowDecoration.Parent = this.txtroomty;
            this.txtroomty.Size = new System.Drawing.Size(249, 36);
            this.txtroomty.TabIndex = 9;
            this.txtroomty.SelectedIndexChanged += new System.EventHandler(this.txtroomty_SelectedIndexChanged);
            // 
            // txtbed
            // 
            this.txtbed.Animated = true;
            this.txtbed.AutoRoundedCorners = true;
            this.txtbed.BackColor = System.Drawing.Color.Transparent;
            this.txtbed.BorderColor = System.Drawing.Color.Navy;
            this.txtbed.BorderRadius = 17;
            this.txtbed.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtbed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtbed.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbed.FocusedState.Parent = this.txtbed;
            this.txtbed.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtbed.ForeColor = System.Drawing.Color.Black;
            this.txtbed.HoverState.Parent = this.txtbed;
            this.txtbed.ItemHeight = 30;
            this.txtbed.Items.AddRange(new object[] {
            "Single",
            "Double",
            "Dormetory",
            "Honeymoon Suit"});
            this.txtbed.ItemsAppearance.Parent = this.txtbed;
            this.txtbed.Location = new System.Drawing.Point(342, 194);
            this.txtbed.Margin = new System.Windows.Forms.Padding(2);
            this.txtbed.Name = "txtbed";
            this.txtbed.ShadowDecoration.Parent = this.txtbed;
            this.txtbed.Size = new System.Drawing.Size(249, 36);
            this.txtbed.TabIndex = 10;
            this.txtbed.SelectedIndexChanged += new System.EventHandler(this.txtbed_SelectedIndexChanged);
            // 
            // btnaddroom
            // 
            this.btnaddroom.BackColor = System.Drawing.Color.Transparent;
            this.btnaddroom.BorderRadius = 20;
            this.btnaddroom.CheckedState.Parent = this.btnaddroom;
            this.btnaddroom.CustomImages.Parent = this.btnaddroom;
            this.btnaddroom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(8)))), ((int)(((byte)(204)))));
            this.btnaddroom.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(103)))), ((int)(((byte)(240)))));
            this.btnaddroom.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold);
            this.btnaddroom.ForeColor = System.Drawing.Color.Black;
            this.btnaddroom.HoverState.Parent = this.btnaddroom;
            this.btnaddroom.Location = new System.Drawing.Point(455, 307);
            this.btnaddroom.Margin = new System.Windows.Forms.Padding(2);
            this.btnaddroom.Name = "btnaddroom";
            this.btnaddroom.ShadowDecoration.Parent = this.btnaddroom;
            this.btnaddroom.Size = new System.Drawing.Size(123, 37);
            this.btnaddroom.TabIndex = 11;
            this.btnaddroom.Text = "Add Room";
            this.btnaddroom.UseTransparentBackground = true;
            this.btnaddroom.Click += new System.EventHandler(this.btnaddroom_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txtroomnum
            // 
            this.txtroomnum.Animated = true;
            this.txtroomnum.AutoRoundedCorners = true;
            this.txtroomnum.BorderColor = System.Drawing.Color.Navy;
            this.txtroomnum.BorderRadius = 12;
            this.txtroomnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtroomnum.DefaultText = "";
            this.txtroomnum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtroomnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtroomnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroomnum.DisabledState.Parent = this.txtroomnum;
            this.txtroomnum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtroomnum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomnum.FocusedState.Parent = this.txtroomnum;
            this.txtroomnum.Font = new System.Drawing.Font("Times New Roman", 10.8F);
            this.txtroomnum.ForeColor = System.Drawing.Color.Black;
            this.txtroomnum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtroomnum.HoverState.Parent = this.txtroomnum;
            this.txtroomnum.Location = new System.Drawing.Point(341, 68);
            this.txtroomnum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtroomnum.Name = "txtroomnum";
            this.txtroomnum.PasswordChar = '\0';
            this.txtroomnum.PlaceholderText = "Room Number";
            this.txtroomnum.SelectedText = "";
            this.txtroomnum.ShadowDecoration.Parent = this.txtroomnum;
            this.txtroomnum.Size = new System.Drawing.Size(249, 26);
            this.txtroomnum.TabIndex = 7;
            this.txtroomnum.TextChanged += new System.EventHandler(this.txtroomnum_TextChanged);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(-9, 0);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(83, 38);
            this.guna2Button1.TabIndex = 41;
            // 
            // Uc_addroom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.btnaddroom);
            this.Controls.Add(this.txtbed);
            this.Controls.Add(this.txtroomty);
            this.Controls.Add(this.txtprice);
            this.Controls.Add(this.txtroomnum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Datagridview1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Uc_addroom";
            this.Size = new System.Drawing.Size(652, 402);
            this.Load += new System.EventHandler(this.Uc_addroom_Load);
            this.Enter += new System.EventHandler(this.Uc_addroom_Enter);
            this.Leave += new System.EventHandler(this.Uc_addroom_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.Datagridview1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView Datagridview1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtprice;
        private Guna.UI2.WinForms.Guna2ComboBox txtroomty;
        private Guna.UI2.WinForms.Guna2ComboBox txtbed;
        private Guna.UI2.WinForms.Guna2GradientButton btnaddroom;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtroomnum;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}
