namespace projet
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
            this.lbllogin = new System.Windows.Forms.Label();
            this.labeluser = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpas = new System.Windows.Forms.TextBox();
            this.txtlog = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblpas = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.ForeColor = System.Drawing.Color.Red;
            this.lbllogin.Location = new System.Drawing.Point(591, 248);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(0, 13);
            this.lbllogin.TabIndex = 6;
            // 
            // labeluser
            // 
            this.labeluser.AutoSize = true;
            this.labeluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeluser.ForeColor = System.Drawing.Color.Red;
            this.labeluser.Location = new System.Drawing.Point(627, 405);
            this.labeluser.Name = "labeluser";
            this.labeluser.Size = new System.Drawing.Size(0, 20);
            this.labeluser.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(612, 222);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(148, 46);
            this.label1.TabIndex = 22;
            this.label1.Text = "LOGIN";
            // 
            // txtpas
            // 
            this.txtpas.Location = new System.Drawing.Point(694, 356);
            this.txtpas.Name = "txtpas";
            this.txtpas.PasswordChar = '*';
            this.txtpas.Size = new System.Drawing.Size(167, 20);
            this.txtpas.TabIndex = 21;
            // 
            // txtlog
            // 
            this.txtlog.Location = new System.Drawing.Point(694, 287);
            this.txtlog.Name = "txtlog";
            this.txtlog.Size = new System.Drawing.Size(167, 20);
            this.txtlog.TabIndex = 20;
            // 
            // btnlogin
            // 
            this.btnlogin.Location = new System.Drawing.Point(648, 390);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(112, 35);
            this.btnlogin.TabIndex = 18;
            this.btnlogin.Text = "login up";
            this.btnlogin.UseVisualStyleBackColor = true;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(558, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 25);
            this.label3.TabIndex = 23;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(558, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "password";
            // 
            // lblpas
            // 
            this.lblpas.AutoSize = true;
            this.lblpas.ForeColor = System.Drawing.Color.Red;
            this.lblpas.Location = new System.Drawing.Point(591, 333);
            this.lblpas.Name = "lblpas";
            this.lblpas.Size = new System.Drawing.Size(0, 13);
            this.lblpas.TabIndex = 7;
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(569, 313);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(0, 13);
            this.lbluser.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet.Properties.Resources.IMG_20161209_WA0001;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(877, 444);
            this.Controls.Add(this.labeluser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.txtpas);
            this.Controls.Add(this.txtlog);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpas);
            this.Controls.Add(this.lbllogin);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label labeluser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpas;
        private System.Windows.Forms.TextBox txtlog;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblpas;
        private System.Windows.Forms.Label lbluser;
    }
}

