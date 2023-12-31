namespace LCTFControlPersonal
{
    partial class M
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(M));
            this.button1 = new System.Windows.Forms.Button();
            this.Borrar = new System.Windows.Forms.Button();
            this.lista_empleado = new System.Windows.Forms.ListView();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(355, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 89);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Borrar
            // 
            this.Borrar.BackgroundImage = global::LCTFControlPersonal.Properties.Resources.delete_symbol;
            this.Borrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Borrar.Location = new System.Drawing.Point(37, 373);
            this.Borrar.Name = "Borrar";
            this.Borrar.Size = new System.Drawing.Size(90, 89);
            this.Borrar.TabIndex = 1;
            this.Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Borrar.UseVisualStyleBackColor = true;
            this.Borrar.Click += new System.EventHandler(this.Borrar_Click);
            // 
            // lista_empleado
            // 
            this.lista_empleado.HideSelection = false;
            this.lista_empleado.Location = new System.Drawing.Point(37, 12);
            this.lista_empleado.Name = "lista_empleado";
            this.lista_empleado.Size = new System.Drawing.Size(242, 327);
            this.lista_empleado.TabIndex = 2;
            this.lista_empleado.UseCompatibleStateImageBehavior = false;
            this.lista_empleado.View = System.Windows.Forms.View.List;
            // 
            // Nombre
            // 
            this.Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(313, 57);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(195, 31);
            this.Nombre.TabIndex = 3;
            // 
            // Apellido
            // 
            this.Apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apellido.Location = new System.Drawing.Point(313, 150);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(195, 31);
            this.Apellido.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Apellido";
            // 
            // M
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(585, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.lista_empleado);
            this.Controls.Add(this.Borrar);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "M";
            this.Text = "Empleados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.M_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Borrar;
        private System.Windows.Forms.ListView lista_empleado;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}