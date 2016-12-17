namespace projet
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.bt_Ent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.bt_Per = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Ent
            // 
            this.bt_Ent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bt_Ent.BackgroundImage")));
            this.bt_Ent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Ent.Location = new System.Drawing.Point(12, 62);
            this.bt_Ent.Name = "bt_Ent";
            this.bt_Ent.Size = new System.Drawing.Size(216, 158);
            this.bt_Ent.TabIndex = 0;
            this.bt_Ent.UseVisualStyleBackColor = true;
            this.bt_Ent.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Location = new System.Drawing.Point(422, 71);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(211, 158);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(22, 243);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(74, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Entreprise";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // bt_Per
            // 
            this.bt_Per.AutoSize = true;
            this.bt_Per.Location = new System.Drawing.Point(132, 243);
            this.bt_Per.Name = "bt_Per";
            this.bt_Per.Size = new System.Drawing.Size(70, 17);
            this.bt_Per.TabIndex = 4;
            this.bt_Per.TabStop = true;
            this.bt_Per.Text = "Personne";
            this.bt_Per.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Envoye de marchandises";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 373);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Per);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_Ent);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form4_FormClosed);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Ent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton bt_Per;
        private System.Windows.Forms.Label label1;
    }
}