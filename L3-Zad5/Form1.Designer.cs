namespace NET_L3_Zad5_v2
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

        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(866, 257);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(221, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(463, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "SINUSOIDA";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(868, 311);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
    }
}
