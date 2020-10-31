namespace Killports
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.p = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.wPort = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wPort)).BeginInit();
            this.SuspendLayout();
            // 
            // p
            // 
            this.p.FormattingEnabled = true;
            this.p.ItemHeight = 16;
            this.p.Location = new System.Drawing.Point(1, -2);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(571, 452);
            this.p.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(707, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(627, 109);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Kill selected task";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // wPort
            // 
            this.wPort.Location = new System.Drawing.Point(578, 64);
            this.wPort.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.wPort.Name = "wPort";
            this.wPort.Size = new System.Drawing.Size(120, 22);
            this.wPort.TabIndex = 5;
            this.wPort.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
          
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Port to search";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wPort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.p);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Killports";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox p;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown wPort;
        private System.Windows.Forms.Label label1;
    }
}

