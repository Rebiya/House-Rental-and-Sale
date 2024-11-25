namespace WindowsFormsApp1
{
    partial class view
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
            this.viewPanel1 = new System.Windows.Forms.Panel();
            this.viewPanel2 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.rentalView = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.purchaseView = new System.Windows.Forms.Button();
            this.viewPanel1.SuspendLayout();
            this.viewPanel2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewPanel1
            // 
            this.viewPanel1.Controls.Add(this.panel1);
            this.viewPanel1.Controls.Add(this.label1);
            this.viewPanel1.Controls.Add(this.panel2);
            this.viewPanel1.Controls.Add(this.viewPanel2);
            this.viewPanel1.Location = new System.Drawing.Point(0, 0);
            this.viewPanel1.Name = "viewPanel1";
            this.viewPanel1.Size = new System.Drawing.Size(802, 451);
            this.viewPanel1.TabIndex = 0;
            // 
            // viewPanel2
            // 
            this.viewPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.viewPanel2.Controls.Add(this.rentalView);
            this.viewPanel2.Controls.Add(this.label2);
            this.viewPanel2.Location = new System.Drawing.Point(81, 102);
            this.viewPanel2.Name = "viewPanel2";
            this.viewPanel2.Size = new System.Drawing.Size(251, 256);
            this.viewPanel2.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.purchaseView);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(457, 102);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 256);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(291, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Get Started Now";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Location = new System.Drawing.Point(81, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 40);
            this.panel1.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkViolet;
            this.panel3.Location = new System.Drawing.Point(-1, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 40);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AccessibleDescription = "";
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "List of booked rental houses ";
            // 
            // rentalView
            // 
            this.rentalView.BackColor = System.Drawing.Color.DodgerBlue;
            this.rentalView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalView.ForeColor = System.Drawing.Color.Snow;
            this.rentalView.Location = new System.Drawing.Point(62, 138);
            this.rentalView.Name = "rentalView";
            this.rentalView.Size = new System.Drawing.Size(113, 63);
            this.rentalView.TabIndex = 1;
            this.rentalView.Text = "VIEW";
            this.rentalView.UseVisualStyleBackColor = false;
            this.rentalView.Click += new System.EventHandler(this.rentalView_Click);
            // 
            // label3
            // 
            this.label3.AccessibleDescription = "";
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 69);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(268, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "List of houses booked for purchase ";
            // 
            // purchaseView
            // 
            this.purchaseView.BackColor = System.Drawing.Color.DarkViolet;
            this.purchaseView.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchaseView.ForeColor = System.Drawing.Color.Snow;
            this.purchaseView.Location = new System.Drawing.Point(73, 138);
            this.purchaseView.Name = "purchaseView";
            this.purchaseView.Size = new System.Drawing.Size(113, 63);
            this.purchaseView.TabIndex = 5;
            this.purchaseView.Text = "VIEW";
            this.purchaseView.UseVisualStyleBackColor = false;
            this.purchaseView.Click += new System.EventHandler(this.purchaseView_Click);
            // 
            // view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewPanel1);
            this.Name = "view";
            this.Text = "view";
            this.Load += new System.EventHandler(this.view_Load);
            this.viewPanel1.ResumeLayout(false);
            this.viewPanel1.PerformLayout();
            this.viewPanel2.ResumeLayout(false);
            this.viewPanel2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel viewPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel viewPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button rentalView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button purchaseView;
    }
}