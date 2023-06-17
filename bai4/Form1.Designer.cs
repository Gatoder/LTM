namespace bai4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.Label();
            this.R = new System.Windows.Forms.Label();
            this.L = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.TextBox();
            this.P = new System.Windows.Forms.TextBox();
            this.listmail = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(105, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(105, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // T
            // 
            this.T.AutoSize = true;
            this.T.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.T.Location = new System.Drawing.Point(105, 185);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(48, 21);
            this.T.TabIndex = 2;
            this.T.Text = "Total";
            // 
            // R
            // 
            this.R.AutoSize = true;
            this.R.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.R.Location = new System.Drawing.Point(324, 185);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(62, 21);
            this.R.TabIndex = 3;
            this.R.Text = "Recent";
            // 
            // L
            // 
            this.L.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.L.Location = new System.Drawing.Point(574, 79);
            this.L.Name = "L";
            this.L.Size = new System.Drawing.Size(164, 32);
            this.L.TabIndex = 4;
            this.L.Text = "Login";
            this.L.UseVisualStyleBackColor = true;
            this.L.Click += new System.EventHandler(this.L_Click);
            // 
            // E
            // 
            this.E.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.E.Location = new System.Drawing.Point(193, 47);
            this.E.Multiline = true;
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(288, 33);
            this.E.TabIndex = 6;
            // 
            // P
            // 
            this.P.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.P.Location = new System.Drawing.Point(193, 112);
            this.P.Multiline = true;
            this.P.Name = "P";
            this.P.Size = new System.Drawing.Size(288, 30);
            this.P.TabIndex = 7;
            // 
            // listmail
            // 
            this.listmail.Location = new System.Drawing.Point(79, 234);
            this.listmail.Name = "listmail";
            this.listmail.Size = new System.Drawing.Size(649, 204);
            this.listmail.TabIndex = 8;
            this.listmail.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listmail);
            this.Controls.Add(this.P);
            this.Controls.Add(this.E);
            this.Controls.Add(this.L);
            this.Controls.Add(this.R);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label T;
        private Label R;
        private Button L;
        private TextBox E;
        private TextBox P;
        private ListView listmail;
    }
}