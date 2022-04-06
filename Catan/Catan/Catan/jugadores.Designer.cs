namespace Catan
{
    partial class jugadores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(jugadores));
            this.buttonj1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonj1
            // 
            this.buttonj1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonj1.BackgroundImage")));
            this.buttonj1.Image = ((System.Drawing.Image)(resources.GetObject("buttonj1.Image")));
            this.buttonj1.Location = new System.Drawing.Point(276, 339);
            this.buttonj1.Name = "buttonj1";
            this.buttonj1.Size = new System.Drawing.Size(86, 32);
            this.buttonj1.TabIndex = 0;
            this.buttonj1.Text = "Empezar ";
            this.buttonj1.UseVisualStyleBackColor = true;
            this.buttonj1.Click += new System.EventHandler(this.buttonj1_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(276, 400);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 32);
            this.button3.TabIndex = 2;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // jugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(637, 508);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonj1);
            this.Name = "jugadores";
            this.Text = "jugadores";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonj1;
        private System.Windows.Forms.Button button3;
    }
}