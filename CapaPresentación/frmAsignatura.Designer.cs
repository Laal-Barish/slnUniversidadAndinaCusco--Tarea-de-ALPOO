
namespace CapaPresentación
{
    partial class frmAsignatura
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtAula = new System.Windows.Forms.TextBox();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnExponer = new System.Windows.Forms.Button();
            this.btnDebatir = new System.Windows.Forms.Button();
            this.btnInvestigar = new System.Windows.Forms.Button();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la asignatura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(164, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Aula:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Horas de clase:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(234, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // txtAula
            // 
            this.txtAula.Location = new System.Drawing.Point(234, 73);
            this.txtAula.Name = "txtAula";
            this.txtAula.Size = new System.Drawing.Size(100, 20);
            this.txtAula.TabIndex = 4;
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(234, 123);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(100, 20);
            this.txtHoras.TabIndex = 5;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(436, 47);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 6;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(436, 100);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 7;
            this.btnEscribir.Text = "Escribir";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnExponer
            // 
            this.btnExponer.Location = new System.Drawing.Point(59, 223);
            this.btnExponer.Name = "btnExponer";
            this.btnExponer.Size = new System.Drawing.Size(75, 23);
            this.btnExponer.TabIndex = 8;
            this.btnExponer.Text = "Exponer";
            this.btnExponer.UseVisualStyleBackColor = true;
            this.btnExponer.Click += new System.EventHandler(this.btnExponer_Click);
            // 
            // btnDebatir
            // 
            this.btnDebatir.Location = new System.Drawing.Point(218, 223);
            this.btnDebatir.Name = "btnDebatir";
            this.btnDebatir.Size = new System.Drawing.Size(75, 23);
            this.btnDebatir.TabIndex = 9;
            this.btnDebatir.Text = "Debatir";
            this.btnDebatir.UseVisualStyleBackColor = true;
            this.btnDebatir.Click += new System.EventHandler(this.btnDebatir_Click);
            // 
            // btnInvestigar
            // 
            this.btnInvestigar.Location = new System.Drawing.Point(369, 223);
            this.btnInvestigar.Name = "btnInvestigar";
            this.btnInvestigar.Size = new System.Drawing.Size(75, 23);
            this.btnInvestigar.TabIndex = 10;
            this.btnInvestigar.Text = "Investigar";
            this.btnInvestigar.UseVisualStyleBackColor = true;
            this.btnInvestigar.Click += new System.EventHandler(this.btnInvestigar_Click);
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(494, 223);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiar.TabIndex = 11;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.btnEstudiar_Click);
            // 
            // frmAsignatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 286);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.btnInvestigar);
            this.Controls.Add(this.btnDebatir);
            this.Controls.Add(this.btnExponer);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.txtAula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAsignatura";
            this.Text = "Asignatura";
            this.Load += new System.EventHandler(this.frmAsignatura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtAula;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnExponer;
        private System.Windows.Forms.Button btnDebatir;
        private System.Windows.Forms.Button btnInvestigar;
        private System.Windows.Forms.Button btnEstudiar;
    }
}