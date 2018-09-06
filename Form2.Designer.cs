namespace Expenditure_Management
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Notelb = new System.Windows.Forms.Label();
            this.NoteBox = new System.Windows.Forms.TextBox();
            this.Datelb = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Addbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CashBox = new System.Windows.Forms.TextBox();
            this.ItemNameBox = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.dateInstr = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Notelb
            // 
            this.Notelb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Notelb.AutoSize = true;
            this.Notelb.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Notelb.ForeColor = System.Drawing.Color.Blue;
            this.Notelb.Location = new System.Drawing.Point(183, 128);
            this.Notelb.Name = "Notelb";
            this.Notelb.Size = new System.Drawing.Size(45, 20);
            this.Notelb.TabIndex = 22;
            this.Notelb.Text = "Note:";
            this.Notelb.Click += new System.EventHandler(this.Notelb_Click);
            // 
            // NoteBox
            // 
            this.NoteBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NoteBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoteBox.Location = new System.Drawing.Point(234, 125);
            this.NoteBox.Multiline = true;
            this.NoteBox.Name = "NoteBox";
            this.NoteBox.Size = new System.Drawing.Size(93, 71);
            this.NoteBox.TabIndex = 3;
            this.NoteBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NoteBox_KeyDown);
            // 
            // Datelb
            // 
            this.Datelb.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Datelb.AutoSize = true;
            this.Datelb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelb.ForeColor = System.Drawing.Color.Blue;
            this.Datelb.Location = new System.Drawing.Point(23, 169);
            this.Datelb.Name = "Datelb";
            this.Datelb.Size = new System.Drawing.Size(73, 21);
            this.Datelb.TabIndex = 20;
            this.Datelb.Text = "LastDate:";
            this.Datelb.Click += new System.EventHandler(this.Datelb_Click);
            // 
            // DateBox
            // 
            this.DateBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.DateBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.Location = new System.Drawing.Point(102, 169);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(75, 27);
            this.DateBox.TabIndex = 2;
            this.DateBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DateBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DateBox_KeyDown);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Cancel.AutoSize = true;
            this.Cancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel.ForeColor = System.Drawing.Color.DeepPink;
            this.Cancel.Location = new System.Drawing.Point(239, 244);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(88, 30);
            this.Cancel.TabIndex = 6;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Addbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Addbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.DeepPink;
            this.Addbtn.Location = new System.Drawing.Point(50, 244);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(89, 30);
            this.Addbtn.TabIndex = 4;
            this.Addbtn.Text = "OK";
            this.Addbtn.UseVisualStyleBackColor = false;
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(35, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Earned:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(44, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Week:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CashBox
            // 
            this.CashBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashBox.Location = new System.Drawing.Point(102, 126);
            this.CashBox.Name = "CashBox";
            this.CashBox.Size = new System.Drawing.Size(75, 27);
            this.CashBox.TabIndex = 1;
            this.CashBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashBox_KeyDown);
            // 
            // ItemNameBox
            // 
            this.ItemNameBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemNameBox.Location = new System.Drawing.Point(102, 81);
            this.ItemNameBox.Name = "ItemNameBox";
            this.ItemNameBox.Size = new System.Drawing.Size(199, 27);
            this.ItemNameBox.TabIndex = 0;
            this.ItemNameBox.TextChanged += new System.EventHandler(this.ItemNameBox_TextChanged);
            this.ItemNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ItemNameBox_KeyDown);
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.Red;
            this.labelName.Location = new System.Drawing.Point(125, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(113, 53);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Add ";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Clearbtn.AutoSize = true;
            this.Clearbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clearbtn.ForeColor = System.Drawing.Color.DeepPink;
            this.Clearbtn.Location = new System.Drawing.Point(145, 244);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(88, 30);
            this.Clearbtn.TabIndex = 5;
            this.Clearbtn.Text = "Clear";
            this.Clearbtn.UseVisualStyleBackColor = false;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // dateInstr
            // 
            this.dateInstr.AutoSize = true;
            this.dateInstr.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateInstr.Location = new System.Drawing.Point(56, 203);
            this.dateInstr.Name = "dateInstr";
            this.dateInstr.Size = new System.Drawing.Size(121, 14);
            this.dateInstr.TabIndex = 23;
            this.dateInstr.Text = "(Leave empty for today)";
            this.dateInstr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.dateInstr.Click += new System.EventHandler(this.dateInstr_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(29, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.Addbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(250)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(360, 300);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateInstr);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Notelb);
            this.Controls.Add(this.NoteBox);
            this.Controls.Add(this.Datelb);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CashBox);
            this.Controls.Add(this.ItemNameBox);
            this.Controls.Add(this.labelName);
            this.Location = new System.Drawing.Point(650, 90);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Add Cash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Notelb;
        private System.Windows.Forms.TextBox NoteBox;
        private System.Windows.Forms.Label Datelb;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Addbtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CashBox;
        private System.Windows.Forms.TextBox ItemNameBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button Clearbtn;
        private System.Windows.Forms.Label dateInstr;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}