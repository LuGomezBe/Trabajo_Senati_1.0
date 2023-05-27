namespace ProyectoSen
{
    partial class InicioAdmin
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
            this.btnTareas = new System.Windows.Forms.Button();
            this.btnRegistrarT = new System.Windows.Forms.Button();
            this.btnRegistrarC = new System.Windows.Forms.Button();
            this.btnRegistrarE = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTareas
            // 
            this.btnTareas.Location = new System.Drawing.Point(54, 84);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(175, 54);
            this.btnTareas.TabIndex = 1;
            this.btnTareas.Text = "TAREAS";
            this.btnTareas.UseVisualStyleBackColor = true;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnRegistrarT
            // 
            this.btnRegistrarT.Location = new System.Drawing.Point(16, 96);
            this.btnRegistrarT.Name = "btnRegistrarT";
            this.btnRegistrarT.Size = new System.Drawing.Size(175, 54);
            this.btnRegistrarT.TabIndex = 2;
            this.btnRegistrarT.Text = "REGISTRAR / BORRAR TECNICO";
            this.btnRegistrarT.UseVisualStyleBackColor = true;
            this.btnRegistrarT.Click += new System.EventHandler(this.btnRegistrarT_Click);
            // 
            // btnRegistrarC
            // 
            this.btnRegistrarC.Location = new System.Drawing.Point(16, 176);
            this.btnRegistrarC.Name = "btnRegistrarC";
            this.btnRegistrarC.Size = new System.Drawing.Size(175, 54);
            this.btnRegistrarC.TabIndex = 3;
            this.btnRegistrarC.Text = "REGISTRAR CLIENTE";
            this.btnRegistrarC.UseVisualStyleBackColor = true;
            this.btnRegistrarC.Click += new System.EventHandler(this.btnRegistrarC_Click);
            // 
            // btnRegistrarE
            // 
            this.btnRegistrarE.Location = new System.Drawing.Point(16, 266);
            this.btnRegistrarE.Name = "btnRegistrarE";
            this.btnRegistrarE.Size = new System.Drawing.Size(175, 54);
            this.btnRegistrarE.TabIndex = 4;
            this.btnRegistrarE.Text = "REGISTRAR EQUIPO";
            this.btnRegistrarE.UseVisualStyleBackColor = true;
            this.btnRegistrarE.Click += new System.EventHandler(this.btnRegistrarE_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRegistrarC);
            this.panel1.Controls.Add(this.btnRegistrarT);
            this.panel1.Controls.Add(this.btnRegistrarE);
            this.panel1.Location = new System.Drawing.Point(38, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 346);
            this.panel1.TabIndex = 5;
            // 
            // InicioAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 465);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.panel1);
            this.Name = "InicioAdmin";
            this.Text = "InicioAdmin";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTareas;
        private System.Windows.Forms.Button btnRegistrarT;
        private System.Windows.Forms.Button btnRegistrarC;
        private System.Windows.Forms.Button btnRegistrarE;
        private System.Windows.Forms.Panel panel1;
    }
}