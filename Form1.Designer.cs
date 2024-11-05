namespace examenpractico
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
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFecha = new System.Windows.Forms.TextBox();
            this.btEncender = new System.Windows.Forms.Button();
            this.btApagar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCel = new System.Windows.Forms.Label();
            this.lbFar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(186, 79);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(154, 20);
            this.tbNombre.TabIndex = 0;
            this.tbNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // tbFecha
            // 
            this.tbFecha.Location = new System.Drawing.Point(186, 137);
            this.tbFecha.Name = "tbFecha";
            this.tbFecha.Size = new System.Drawing.Size(154, 20);
            this.tbFecha.TabIndex = 3;
            // 
            // btEncender
            // 
            this.btEncender.Location = new System.Drawing.Point(57, 286);
            this.btEncender.Name = "btEncender";
            this.btEncender.Size = new System.Drawing.Size(81, 41);
            this.btEncender.TabIndex = 4;
            this.btEncender.Text = "Encender";
            this.btEncender.UseVisualStyleBackColor = true;
            this.btEncender.Click += new System.EventHandler(this.btEncender_Click);
            // 
            // btApagar
            // 
            this.btApagar.Location = new System.Drawing.Point(186, 290);
            this.btApagar.Name = "btApagar";
            this.btApagar.Size = new System.Drawing.Size(88, 37);
            this.btApagar.TabIndex = 5;
            this.btApagar.Text = "Apagar";
            this.btApagar.UseVisualStyleBackColor = true;
            this.btApagar.Click += new System.EventHandler(this.btApagar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(398, 111);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 6;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Celsius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fahrenheit";
            // 
            // lbCel
            // 
            this.lbCel.AutoSize = true;
            this.lbCel.Location = new System.Drawing.Point(80, 232);
            this.lbCel.Name = "lbCel";
            this.lbCel.Size = new System.Drawing.Size(22, 13);
            this.lbCel.TabIndex = 9;
            this.lbCel.Text = "0.0";
            // 
            // lbFar
            // 
            this.lbFar.AutoSize = true;
            this.lbFar.Location = new System.Drawing.Point(199, 232);
            this.lbFar.Name = "lbFar";
            this.lbFar.Size = new System.Drawing.Size(22, 13);
            this.lbFar.TabIndex = 10;
            this.lbFar.Text = "0.0";
            this.lbFar.Click += new System.EventHandler(this.lbFar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 362);
            this.Controls.Add(this.lbFar);
            this.Controls.Add(this.lbCel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btApagar);
            this.Controls.Add(this.btEncender);
            this.Controls.Add(this.tbFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFecha;
        private System.Windows.Forms.Button btEncender;
        private System.Windows.Forms.Button btApagar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCel;
        private System.Windows.Forms.Label lbFar;
    }
}

