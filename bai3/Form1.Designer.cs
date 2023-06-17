namespace bai3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.S = new System.Windows.Forms.Button();
            this.P = new System.Windows.Forms.TextBox();
            this.F = new System.Windows.Forms.TextBox();
            this.T = new System.Windows.Forms.TextBox();
            this.SU = new System.Windows.Forms.TextBox();
            this.BO = new System.Windows.Forms.RichTextBox();
            this.l1 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l4 = new System.Windows.Forms.Label();
            this.l5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // S
            // 
            this.S.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.S.Location = new System.Drawing.Point(90, 66);
            this.S.Margin = new System.Windows.Forms.Padding(4);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(127, 45);
            this.S.TabIndex = 0;
            this.S.Text = "SEND";
            this.S.UseVisualStyleBackColor = true;
            this.S.Click += new System.EventHandler(this.S_Click);
            // 
            // P
            // 
            this.P.Location = new System.Drawing.Point(859, 46);
            this.P.Margin = new System.Windows.Forms.Padding(4);
            this.P.Multiline = true;
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(280, 38);
            this.P.TabIndex = 1;
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(353, 43);
            this.F.Margin = new System.Windows.Forms.Padding(4);
            this.F.Multiline = true;
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(367, 39);
            this.F.TabIndex = 2;
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(353, 92);
            this.T.Margin = new System.Windows.Forms.Padding(4);
            this.T.Multiline = true;
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(367, 50);
            this.T.TabIndex = 3;
            // 
            // SU
            // 
            this.SU.Location = new System.Drawing.Point(276, 214);
            this.SU.Margin = new System.Windows.Forms.Padding(4);
            this.SU.Multiline = true;
            this.SU.Name = "SU";
            this.SU.Size = new System.Drawing.Size(788, 60);
            this.SU.TabIndex = 4;
            // 
            // BO
            // 
            this.BO.Location = new System.Drawing.Point(276, 284);
            this.BO.Margin = new System.Windows.Forms.Padding(4);
            this.BO.Name = "BO";
            this.BO.Size = new System.Drawing.Size(788, 327);
            this.BO.TabIndex = 5;
            this.BO.Text = "";
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l1.Location = new System.Drawing.Point(290, 52);
            this.l1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(64, 21);
            this.l1.TabIndex = 6;
            this.l1.Text = "FROM";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l3.Location = new System.Drawing.Point(290, 112);
            this.l3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(36, 21);
            this.l3.TabIndex = 7;
            this.l3.Text = "TO";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l2.Location = new System.Drawing.Point(739, 63);
            this.l2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(112, 21);
            this.l2.TabIndex = 8;
            this.l2.Text = "PASSWORD";
            // 
            // l4
            // 
            this.l4.AutoSize = true;
            this.l4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l4.Location = new System.Drawing.Point(143, 214);
            this.l4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(89, 21);
            this.l4.TabIndex = 9;
            this.l4.Text = "SUBJECT";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l5.Location = new System.Drawing.Point(143, 322);
            this.l5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(62, 21);
            this.l5.TabIndex = 10;
            this.l5.Text = "BODY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1217, 682);
            this.Controls.Add(this.l5);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.l2);
            this.Controls.Add(this.l3);
            this.Controls.Add(this.l1);
            this.Controls.Add(this.BO);
            this.Controls.Add(this.SU);
            this.Controls.Add(this.T);
            this.Controls.Add(this.F);
            this.Controls.Add(this.P);
            this.Controls.Add(this.S);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button S;
        private TextBox P;
        private TextBox F;
        private TextBox T;
        private TextBox SU;
        private RichTextBox BO;
        private Label l1;
        private Label l3;
        private Label l2;
        private Label l4;
        private Label l5;
    }
}