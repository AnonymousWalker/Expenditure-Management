namespace Expenditure_Management
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.RemainedCash = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.Label();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.FilterByMonthTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.InitialTxt = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.FilterByDateTxt = new System.Windows.Forms.TextBox();
            this.SumTxt = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NameFilterTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RemainedCash
            // 
            this.RemainedCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RemainedCash.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RemainedCash.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RemainedCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainedCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemainedCash.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemainedCash.Location = new System.Drawing.Point(589, 423);
            this.RemainedCash.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RemainedCash.Name = "RemainedCash";
            this.RemainedCash.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RemainedCash.Size = new System.Drawing.Size(94, 28);
            this.RemainedCash.TabIndex = 14;
            this.RemainedCash.Text = "0";
            this.RemainedCash.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemainedCash.Click += new System.EventHandler(this.RemainedCash_Click);
            // 
            // Total
            // 
            this.Total.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Total.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Total.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total.ForeColor = System.Drawing.Color.DarkRed;
            this.Total.Location = new System.Drawing.Point(583, 397);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(101, 25);
            this.Total.TabIndex = 13;
            this.Total.Text = "$ Remained:";
            this.Total.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Total.Click += new System.EventHandler(this.Total_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveBtn.AutoSize = true;
            this.RemoveBtn.BackColor = System.Drawing.Color.Moccasin;
            this.RemoveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.BackgroundImage")));
            this.RemoveBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.ForeColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.Location = new System.Drawing.Point(610, 199);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(50, 50);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.UseVisualStyleBackColor = false;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // Add
            // 
            this.Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Add.BackColor = System.Drawing.Color.Transparent;
            this.Add.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Add.BackgroundImage")));
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.Transparent;
            this.Add.Location = new System.Drawing.Point(600, 19);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 72);
            this.Add.TabIndex = 0;
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(580, 430);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefreshBtn.AutoSize = true;
            this.RefreshBtn.BackColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.BackgroundImage")));
            this.RefreshBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.Location = new System.Drawing.Point(550, 430);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(30, 30);
            this.RefreshBtn.TabIndex = 16;
            this.RefreshBtn.UseVisualStyleBackColor = false;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // FilterByMonthTxt
            // 
            this.FilterByMonthTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterByMonthTxt.BackColor = System.Drawing.Color.LavenderBlush;
            this.FilterByMonthTxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.FilterByMonthTxt.Location = new System.Drawing.Point(115, 432);
            this.FilterByMonthTxt.Name = "FilterByMonthTxt";
            this.FilterByMonthTxt.Size = new System.Drawing.Size(24, 26);
            this.FilterByMonthTxt.TabIndex = 4;
            this.FilterByMonthTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FilterByMonthTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterByMonthTxt_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.BackColor = System.Drawing.Color.LavenderBlush;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(9, 433);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "Month Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(587, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "$ Initial:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // InitialTxt
            // 
            this.InitialTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.InitialTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.InitialTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitialTxt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.InitialTxt.Location = new System.Drawing.Point(592, 296);
            this.InitialTxt.Name = "InitialTxt";
            this.InitialTxt.Size = new System.Drawing.Size(89, 24);
            this.InitialTxt.TabIndex = 3;
            this.InitialTxt.Text = "0";
            this.InitialTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.InitialTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InitialTxt_KeyDown);
            // 
            // Edit
            // 
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Edit.AutoSize = true;
            this.Edit.BackColor = System.Drawing.Color.Transparent;
            this.Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit.BackgroundImage")));
            this.Edit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.Transparent;
            this.Edit.Location = new System.Drawing.Point(600, 97);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(75, 74);
            this.Edit.TabIndex = 1;
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(589, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 24);
            this.label3.TabIndex = 24;
            this.label3.Text = "$ Sum";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.BackColor = System.Drawing.Color.LavenderBlush;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(149, 434);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 26;
            this.label4.Text = "Date Filter";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FilterByDateTxt
            // 
            this.FilterByDateTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterByDateTxt.BackColor = System.Drawing.Color.LavenderBlush;
            this.FilterByDateTxt.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.FilterByDateTxt.Location = new System.Drawing.Point(245, 433);
            this.FilterByDateTxt.Name = "FilterByDateTxt";
            this.FilterByDateTxt.Size = new System.Drawing.Size(78, 26);
            this.FilterByDateTxt.TabIndex = 5;
            this.FilterByDateTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FilterByDateTxt.TextChanged += new System.EventHandler(this.FilterByDateTxt_TextChanged);
            this.FilterByDateTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FilterByDateTxt_KeyDown);
            // 
            // SumTxt
            // 
            this.SumTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SumTxt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.SumTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SumTxt.ForeColor = System.Drawing.Color.Black;
            this.SumTxt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SumTxt.Location = new System.Drawing.Point(590, 359);
            this.SumTxt.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.SumTxt.Name = "SumTxt";
            this.SumTxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SumTxt.Size = new System.Drawing.Size(94, 24);
            this.SumTxt.TabIndex = 27;
            this.SumTxt.Text = "0";
            this.SumTxt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.BackColor = System.Drawing.Color.LavenderBlush;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(334, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 28;
            this.label5.Text = "Name Filter";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NameFilterTxt
            // 
            this.NameFilterTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NameFilterTxt.BackColor = System.Drawing.Color.LavenderBlush;
            this.NameFilterTxt.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameFilterTxt.Location = new System.Drawing.Point(439, 432);
            this.NameFilterTxt.Name = "NameFilterTxt";
            this.NameFilterTxt.Size = new System.Drawing.Size(94, 26);
            this.NameFilterTxt.TabIndex = 29;
            this.NameFilterTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameFilterTxt_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(690, 461);
            this.Controls.Add(this.NameFilterTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.SumTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.FilterByDateTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InitialTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterByMonthTxt);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.RemainedCash);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Add);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(200, 50);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "My Expenditure";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RemainedCash;
        private System.Windows.Forms.Label Total;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.TextBox FilterByMonthTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InitialTxt;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FilterByDateTxt;
        private System.Windows.Forms.Label SumTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NameFilterTxt;
    }
}

