namespace _02_GUI.WinForms
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
            this.btnBlocking = new System.Windows.Forms.Button();
            this.btnNonBlocking = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBlocking
            // 
            this.btnBlocking.Location = new System.Drawing.Point(227, 45);
            this.btnBlocking.Name = "btnBlocking";
            this.btnBlocking.Size = new System.Drawing.Size(348, 81);
            this.btnBlocking.TabIndex = 0;
            this.btnBlocking.Text = "Blocking Code";
            this.btnBlocking.UseVisualStyleBackColor = true;
            this.btnBlocking.Click += new System.EventHandler(this.btnBlocking_Click);
            // 
            // btnNonBlocking
            // 
            this.btnNonBlocking.Location = new System.Drawing.Point(227, 156);
            this.btnNonBlocking.Name = "btnNonBlocking";
            this.btnNonBlocking.Size = new System.Drawing.Size(348, 81);
            this.btnNonBlocking.TabIndex = 1;
            this.btnNonBlocking.Text = "Non-Blocking Code";
            this.btnNonBlocking.UseVisualStyleBackColor = true;
            this.btnNonBlocking.Click += new System.EventHandler(this.btnNonBlocking_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.Location = new System.Drawing.Point(151, 320);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(500, 32);
            this.labelStatus.TabIndex = 2;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.btnNonBlocking);
            this.Controls.Add(this.btnBlocking);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBlocking;
        private Button btnNonBlocking;
        private Label labelStatus;
    }
}