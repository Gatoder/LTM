namespace API
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ND = new System.Windows.Forms.TextBox();
            this.nhietdo = new System.Windows.Forms.Label();
            this.doam = new System.Windows.Forms.Label();
            this.DA = new System.Windows.Forms.TextBox();
            this.PT = new System.Windows.Forms.TextBox();
            this.phantram = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(357, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(277, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "TP Hồ Chí Minh";
            // 
            // ND
            // 
            this.ND.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ND.Location = new System.Drawing.Point(524, 147);
            this.ND.Name = "ND";
            this.ND.Size = new System.Drawing.Size(178, 26);
            this.ND.TabIndex = 2;
            // 
            // nhietdo
            // 
            this.nhietdo.AutoSize = true;
            this.nhietdo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nhietdo.Location = new System.Drawing.Point(219, 150);
            this.nhietdo.Name = "nhietdo";
            this.nhietdo.Size = new System.Drawing.Size(62, 19);
            this.nhietdo.TabIndex = 3;
            this.nhietdo.Text = "Nhiệt độ";
            // 
            // doam
            // 
            this.doam.AutoSize = true;
            this.doam.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doam.Location = new System.Drawing.Point(231, 253);
            this.doam.Name = "doam";
            this.doam.Size = new System.Drawing.Size(50, 19);
            this.doam.TabIndex = 4;
            this.doam.Text = "Độ ẩm";
            this.doam.Click += new System.EventHandler(this.label3_Click);
            // 
            // DA
            // 
            this.DA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DA.Location = new System.Drawing.Point(524, 253);
            this.DA.Name = "DA";
            this.DA.Size = new System.Drawing.Size(178, 26);
            this.DA.TabIndex = 5;
            this.DA.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // PT
            // 
            this.PT.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PT.Location = new System.Drawing.Point(524, 360);
            this.PT.Name = "PT";
            this.PT.Size = new System.Drawing.Size(178, 26);
            this.PT.TabIndex = 6;
            // 
            // phantram
            // 
            this.phantram.AutoSize = true;
            this.phantram.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.phantram.Location = new System.Drawing.Point(219, 360);
            this.phantram.Name = "phantram";
            this.phantram.Size = new System.Drawing.Size(105, 19);
            this.phantram.TabIndex = 7;
            this.phantram.Text = "Phần Trăm mưa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.phantram);
            this.Controls.Add(this.PT);
            this.Controls.Add(this.DA);
            this.Controls.Add(this.doam);
            this.Controls.Add(this.nhietdo);
            this.Controls.Add(this.ND);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox ND;
        private Label nhietdo;
        private Label doam;
        private TextBox DA;
        private TextBox PT;
        private Label phantram;
    }
}