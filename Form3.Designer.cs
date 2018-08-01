namespace Expenditure_Management
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.labelName = new System.Windows.Forms.Label();
            this.Notelb = new System.Windows.Forms.Label();
            this.Datelb = new System.Windows.Forms.Label();
            this.noteTxt = new System.Windows.Forms.TextBox();
            this.dateTxt = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.Apply = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CashTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            resources.ApplyResources(this.labelName, "labelName");
            this.labelName.ForeColor = System.Drawing.Color.Green;
            this.labelName.Name = "labelName";
            // 
            // Notelb
            // 
            resources.ApplyResources(this.Notelb, "Notelb");
            this.Notelb.Name = "Notelb";
            // 
            // Datelb
            // 
            resources.ApplyResources(this.Datelb, "Datelb");
            this.Datelb.Name = "Datelb";
            // 
            // noteTxt
            // 
            resources.ApplyResources(this.noteTxt, "noteTxt");
            this.noteTxt.Name = "noteTxt";
            this.noteTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.noteTxt_KeyDown);
            // 
            // dateTxt
            // 
            resources.ApplyResources(this.dateTxt, "dateTxt");
            this.dateTxt.Name = "dateTxt";
            this.dateTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTxt_KeyDown);
            // 
            // Cancel
            // 
            resources.ApplyResources(this.Cancel, "Cancel");
            this.Cancel.BackColor = System.Drawing.Color.SlateBlue;
            this.Cancel.ForeColor = System.Drawing.Color.LightYellow;
            this.Cancel.Name = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Apply
            // 
            resources.ApplyResources(this.Apply, "Apply");
            this.Apply.BackColor = System.Drawing.Color.SlateBlue;
            this.Apply.ForeColor = System.Drawing.Color.LightYellow;
            this.Apply.Name = "Apply";
            this.Apply.UseVisualStyleBackColor = false;
            this.Apply.Click += new System.EventHandler(this.Apply_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // CashTxt
            // 
            resources.ApplyResources(this.CashTxt, "CashTxt");
            this.CashTxt.Name = "CashTxt";
            this.CashTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CashTxt_KeyDown);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // NameTxt
            // 
            resources.ApplyResources(this.NameTxt, "NameTxt");
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NameTxt_KeyDown);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            this.AcceptButton = this.Apply;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.Notelb);
            this.Controls.Add(this.Datelb);
            this.Controls.Add(this.noteTxt);
            this.Controls.Add(this.dateTxt);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Apply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CashTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NameTxt);
            this.MaximizeBox = false;
            this.Name = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label Notelb;
        private System.Windows.Forms.Label Datelb;
        private System.Windows.Forms.TextBox noteTxt;
        private System.Windows.Forms.TextBox dateTxt;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Apply;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox CashTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxt;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}