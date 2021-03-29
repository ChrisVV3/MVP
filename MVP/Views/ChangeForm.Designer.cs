namespace MVP.Views
{
    partial class ChangeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeForm));
            this.lbl = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblSite = new System.Windows.Forms.Label();
            this.lblURL = new System.Windows.Forms.Label();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.lblGap = new System.Windows.Forms.Label();
            this.txtGap = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(12, 13);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(95, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Введите ID сайта";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(174, 10);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(139, 20);
            this.txtID.TabIndex = 1;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.4F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl1.Location = new System.Drawing.Point(12, 53);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(296, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Введите данные, которые  хотите изменить:";
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(174, 99);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(139, 20);
            this.txtSite.TabIndex = 3;
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(12, 99);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(89, 13);
            this.lblSite.TabIndex = 4;
            this.lblSite.Text = "Название сайта";
            // 
            // lblURL
            // 
            this.lblURL.AutoSize = true;
            this.lblURL.Location = new System.Drawing.Point(12, 141);
            this.lblURL.Name = "lblURL";
            this.lblURL.Size = new System.Drawing.Size(61, 13);
            this.lblURL.TabIndex = 6;
            this.lblURL.Text = "URL сайта";
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(174, 141);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(139, 20);
            this.txtURL.TabIndex = 5;
            // 
            // lblGap
            // 
            this.lblGap.AutoSize = true;
            this.lblGap.Location = new System.Drawing.Point(12, 182);
            this.lblGap.Name = "lblGap";
            this.lblGap.Size = new System.Drawing.Size(107, 13);
            this.lblGap.TabIndex = 8;
            this.lblGap.Text = "Интервал проверки";
            // 
            // txtGap
            // 
            this.txtGap.Location = new System.Drawing.Point(174, 182);
            this.txtGap.Name = "txtGap";
            this.txtGap.Size = new System.Drawing.Size(139, 20);
            this.txtGap.TabIndex = 7;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(231, 225);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(82, 25);
            this.btnChange.TabIndex = 9;
            this.btnChange.Text = "Сохранить";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // ChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 267);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblGap);
            this.Controls.Add(this.txtGap);
            this.Controls.Add(this.lblURL);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChangeForm";
            this.Text = "Редактирование";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Label lblURL;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblGap;
        private System.Windows.Forms.TextBox txtGap;
        private System.Windows.Forms.Button btnChange;
    }
}