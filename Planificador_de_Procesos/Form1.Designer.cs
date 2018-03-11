namespace Planificador_de_Procesos
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
            this.txtProcess = new System.Windows.Forms.TextBox();
            this.txtMaxtime = new System.Windows.Forms.TextBox();
            this.btnFCFS = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.txtTet = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(47, 49);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(100, 20);
            this.txtProcess.TabIndex = 0;
            // 
            // txtMaxtime
            // 
            this.txtMaxtime.Location = new System.Drawing.Point(235, 49);
            this.txtMaxtime.Name = "txtMaxtime";
            this.txtMaxtime.Size = new System.Drawing.Size(100, 20);
            this.txtMaxtime.TabIndex = 1;
            // 
            // btnFCFS
            // 
            this.btnFCFS.Location = new System.Drawing.Point(259, 111);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.Size = new System.Drawing.Size(75, 23);
            this.btnFCFS.TabIndex = 2;
            this.btnFCFS.Text = "button1";
            this.btnFCFS.UseVisualStyleBackColor = true;
            this.btnFCFS.Click += new System.EventHandler(this.btnFCFS_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(47, 90);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(169, 135);
            this.txtShow.TabIndex = 3;
            // 
            // txtTet
            // 
            this.txtTet.Location = new System.Drawing.Point(244, 153);
            this.txtTet.Name = "txtTet";
            this.txtTet.Size = new System.Drawing.Size(100, 20);
            this.txtTet.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 386);
            this.Controls.Add(this.txtTet);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnFCFS);
            this.Controls.Add(this.txtMaxtime);
            this.Controls.Add(this.txtProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.TextBox txtMaxtime;
        private System.Windows.Forms.Button btnFCFS;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.TextBox txtTet;
    }
}

