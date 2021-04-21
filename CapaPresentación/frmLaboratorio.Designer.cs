
namespace CapaPresentación
{
    partial class frmLaboratorio
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.txtAforo = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnInvestigar = new System.Windows.Forms.Button();
            this.btnExperimentar = new System.Windows.Forms.Button();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.txtInstrumento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de laboratorio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Instrumento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Aforo:";
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(212, 40);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.Size = new System.Drawing.Size(100, 20);
            this.txtTipo.TabIndex = 3;
            // 
            // txtAforo
            // 
            this.txtAforo.Location = new System.Drawing.Point(212, 142);
            this.txtAforo.Name = "txtAforo";
            this.txtAforo.Size = new System.Drawing.Size(100, 20);
            this.txtAforo.TabIndex = 5;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(404, 63);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 8;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(404, 116);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 9;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnInvestigar
            // 
            this.btnInvestigar.Location = new System.Drawing.Point(112, 262);
            this.btnInvestigar.Name = "btnInvestigar";
            this.btnInvestigar.Size = new System.Drawing.Size(75, 23);
            this.btnInvestigar.TabIndex = 10;
            this.btnInvestigar.Text = "Investigar";
            this.btnInvestigar.UseVisualStyleBackColor = true;
            this.btnInvestigar.Click += new System.EventHandler(this.btnInvestigar_Click);
            // 
            // btnExperimentar
            // 
            this.btnExperimentar.Location = new System.Drawing.Point(232, 262);
            this.btnExperimentar.Name = "btnExperimentar";
            this.btnExperimentar.Size = new System.Drawing.Size(80, 23);
            this.btnExperimentar.TabIndex = 11;
            this.btnExperimentar.Text = "Experimentar";
            this.btnExperimentar.UseVisualStyleBackColor = true;
            this.btnExperimentar.Click += new System.EventHandler(this.btnExperimentar_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Location = new System.Drawing.Point(374, 262);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalizar.TabIndex = 12;
            this.btnAnalizar.Text = "Analizar";
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // txtInstrumento
            // 
            this.txtInstrumento.Location = new System.Drawing.Point(212, 87);
            this.txtInstrumento.Name = "txtInstrumento";
            this.txtInstrumento.Size = new System.Drawing.Size(100, 20);
            this.txtInstrumento.TabIndex = 13;
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 327);
            this.Controls.Add(this.txtInstrumento);
            this.Controls.Add(this.btnAnalizar);
            this.Controls.Add(this.btnExperimentar);
            this.Controls.Add(this.btnInvestigar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtAforo);
            this.Controls.Add(this.txtTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLaboratorio";
            this.Text = "Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtAforo;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnInvestigar;
        private System.Windows.Forms.Button btnExperimentar;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.TextBox txtInstrumento;
    }
}