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
            this.txtRet = new System.Windows.Forms.TextBox();
            this.btnSjfs = new System.Windows.Forms.Button();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnLjf = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTabla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtQuatum = new System.Windows.Forms.TextBox();
            this.btnRR = new System.Windows.Forms.Button();
            this.lblCmax = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtProcess
            // 
            this.txtProcess.Location = new System.Drawing.Point(125, 12);
            this.txtProcess.Name = "txtProcess";
            this.txtProcess.Size = new System.Drawing.Size(100, 20);
            this.txtProcess.TabIndex = 0;
            // 
            // txtMaxtime
            // 
            this.txtMaxtime.Location = new System.Drawing.Point(125, 38);
            this.txtMaxtime.Name = "txtMaxtime";
            this.txtMaxtime.Size = new System.Drawing.Size(100, 20);
            this.txtMaxtime.TabIndex = 1;
            // 
            // btnFCFS
            // 
            this.btnFCFS.Location = new System.Drawing.Point(138, 82);
            this.btnFCFS.Name = "btnFCFS";
            this.btnFCFS.Size = new System.Drawing.Size(75, 23);
            this.btnFCFS.TabIndex = 2;
            this.btnFCFS.Text = "FCFS";
            this.btnFCFS.UseVisualStyleBackColor = true;
            this.btnFCFS.Click += new System.EventHandler(this.btnFCFS_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(22, 84);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.Size = new System.Drawing.Size(110, 135);
            this.txtShow.TabIndex = 3;
            // 
            // txtTet
            // 
            this.txtTet.Location = new System.Drawing.Point(244, 153);
            this.txtTet.Name = "txtTet";
            this.txtTet.Size = new System.Drawing.Size(100, 20);
            this.txtTet.TabIndex = 4;
            // 
            // txtRet
            // 
            this.txtRet.Location = new System.Drawing.Point(244, 179);
            this.txtRet.Name = "txtRet";
            this.txtRet.Size = new System.Drawing.Size(100, 20);
            this.txtRet.TabIndex = 5;
            // 
            // btnSjfs
            // 
            this.btnSjfs.Location = new System.Drawing.Point(219, 82);
            this.btnSjfs.Name = "btnSjfs";
            this.btnSjfs.Size = new System.Drawing.Size(75, 23);
            this.btnSjfs.TabIndex = 6;
            this.btnSjfs.Text = "SJF";
            this.btnSjfs.UseVisualStyleBackColor = true;
            this.btnSjfs.Click += new System.EventHandler(this.btnSjfs_Click);
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(244, 26);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(117, 23);
            this.btnGenerar.TabIndex = 7;
            this.btnGenerar.Text = "Generar procesos";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnLjf
            // 
            this.btnLjf.Location = new System.Drawing.Point(300, 82);
            this.btnLjf.Name = "btnLjf";
            this.btnLjf.Size = new System.Drawing.Size(75, 23);
            this.btnLjf.TabIndex = 8;
            this.btnLjf.Text = "LJF";
            this.btnLjf.UseVisualStyleBackColor = true;
            this.btnLjf.Click += new System.EventHandler(this.btnLjf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Numero de procesos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tiempo maximo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tiempo de espera";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(135, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tiempo de respuesta";
            // 
            // txtTabla
            // 
            this.txtTabla.Location = new System.Drawing.Point(22, 249);
            this.txtTabla.Multiline = true;
            this.txtTabla.Name = "txtTabla";
            this.txtTabla.Size = new System.Drawing.Size(359, 99);
            this.txtTabla.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Quantum";
            // 
            // txtQuatum
            // 
            this.txtQuatum.Location = new System.Drawing.Point(286, 111);
            this.txtQuatum.Name = "txtQuatum";
            this.txtQuatum.Size = new System.Drawing.Size(100, 20);
            this.txtQuatum.TabIndex = 17;
            // 
            // btnRR
            // 
            this.btnRR.Location = new System.Drawing.Point(138, 108);
            this.btnRR.Name = "btnRR";
            this.btnRR.Size = new System.Drawing.Size(75, 23);
            this.btnRR.TabIndex = 16;
            this.btnRR.Text = "Round Robin";
            this.btnRR.UseVisualStyleBackColor = true;
            this.btnRR.Click += new System.EventHandler(this.btnRR_Click);
            // 
            // lblCmax
            // 
            this.lblCmax.AutoSize = true;
            this.lblCmax.Location = new System.Drawing.Point(244, 230);
            this.lblCmax.Name = "lblCmax";
            this.lblCmax.Size = new System.Drawing.Size(0, 13);
            this.lblCmax.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(263, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Promedios";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 386);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblCmax);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuatum);
            this.Controls.Add(this.btnRR);
            this.Controls.Add(this.txtTabla);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLjf);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.btnSjfs);
            this.Controls.Add(this.txtRet);
            this.Controls.Add(this.txtTet);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnFCFS);
            this.Controls.Add(this.txtMaxtime);
            this.Controls.Add(this.txtProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtProcess;
        private System.Windows.Forms.TextBox txtMaxtime;
        private System.Windows.Forms.Button btnFCFS;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.TextBox txtTet;
        private System.Windows.Forms.TextBox txtRet;
        private System.Windows.Forms.Button btnSjfs;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnLjf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTabla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtQuatum;
        private System.Windows.Forms.Button btnRR;
        private System.Windows.Forms.Label lblCmax;
        private System.Windows.Forms.Label label6;
    }
}

