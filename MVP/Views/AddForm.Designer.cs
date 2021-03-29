namespace MVP.Views
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.txtSite = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtGap = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.lblGap = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(151, 23);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(145, 20);
            this.txtSite.TabIndex = 0;
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(151, 62);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(145, 20);
            this.txtURL.TabIndex = 1;
            // 
            // txtGap
            // 
            this.txtGap.Location = new System.Drawing.Point(151, 103);
            this.txtGap.Name = "txtGap";
            this.txtGap.Size = new System.Drawing.Size(145, 20);
            this.txtGap.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(204, 153);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 30);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Сохранить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(12, 30);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(89, 13);
            this.lblSite.TabIndex = 4;
            this.lblSite.Text = "Название сайта";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 69);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(61, 13);
            this.lblURL.TabIndex = 5;
            this.lblURL.Text = "URL сайта";
            // 
            // lblGap
            // 
            this.lblGap.AutoSize = true;
            this.lblGap.Location = new System.Drawing.Point(12, 110);
            this.lblGap.Name = "lblGap";
            this.lblGap.Size = new System.Drawing.Size(107, 13);
            this.lblGap.TabIndex = 6;
            this.lblGap.Text = "Интервал проверки";
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 211);
            this.Controls.Add(this.lblGap);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGap);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.txtSite);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.Text = "Добавление";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtGap;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.Label lblGap;
    }
}