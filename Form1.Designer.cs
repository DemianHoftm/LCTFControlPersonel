namespace LCTFControlPersonal
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.reporte = new System.Windows.Forms.Button();
            this.Boton_empleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // fecha
            // 
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(162, 12);
            this.fecha.MinDate = new System.DateTime(2023, 12, 1, 0, 0, 0, 0);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 1;
            // 
            // reporte
            // 
            this.reporte.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reporte.BackgroundImage")));
            this.reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reporte.Location = new System.Drawing.Point(386, 12);
            this.reporte.Name = "reporte";
            this.reporte.Size = new System.Drawing.Size(89, 86);
            this.reporte.TabIndex = 2;
            this.reporte.UseVisualStyleBackColor = true;
            this.reporte.Click += new System.EventHandler(this.reporte_Click);
            // 
            // Boton_empleados
            // 
            this.Boton_empleados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Boton_empleados.BackgroundImage")));
            this.Boton_empleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Boton_empleados.Location = new System.Drawing.Point(12, 12);
            this.Boton_empleados.Name = "Boton_empleados";
            this.Boton_empleados.Size = new System.Drawing.Size(70, 68);
            this.Boton_empleados.TabIndex = 0;
            this.Boton_empleados.UseVisualStyleBackColor = true;
            this.Boton_empleados.Click += new System.EventHandler(this.Boton_empleados_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 130);
            this.Controls.Add(this.reporte);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.Boton_empleados);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Boton_empleados;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button reporte;
    }
}

