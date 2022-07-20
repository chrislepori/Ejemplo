namespace Ejercicio_Datos_Personales
{
    partial class DatosPersonales
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
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbResultado = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.textDireccion = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Location = new System.Drawing.Point(76, 25);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(71, 16);
            this.lbApellido.TabIndex = 0;
            this.lbApellido.Text = "APELLIDO";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(76, 63);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(66, 16);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "NOMBRE";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Location = new System.Drawing.Point(76, 106);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(45, 16);
            this.lbEdad.TabIndex = 2;
            this.lbEdad.Text = "EDAD";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Location = new System.Drawing.Point(76, 148);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(80, 16);
            this.lbDireccion.TabIndex = 3;
            this.lbDireccion.Text = "DIRECCION";
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Location = new System.Drawing.Point(76, 194);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(90, 16);
            this.lbResultado.TabIndex = 4;
            this.lbResultado.Text = "RESULTADO";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(231, 25);
            this.textApellido.MaxLength = 20;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(413, 22);
            this.textApellido.TabIndex = 5;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(231, 63);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(413, 22);
            this.textNombre.TabIndex = 6;
            // 
            // textEdad
            // 
            this.textEdad.Location = new System.Drawing.Point(231, 100);
            this.textEdad.MaxLength = 3;
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(57, 22);
            this.textEdad.TabIndex = 7;
            this.textEdad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdad_KeyPress);
            // 
            // textDireccion
            // 
            this.textDireccion.Location = new System.Drawing.Point(231, 148);
            this.textDireccion.Name = "textDireccion";
            this.textDireccion.Size = new System.Drawing.Size(413, 22);
            this.textDireccion.TabIndex = 8;
            // 
            // btAceptar
            // 
            this.btAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(205, 395);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(114, 23);
            this.btAceptar.TabIndex = 10;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = true;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(435, 395);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(114, 23);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "CANCELAR";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(231, 194);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(413, 157);
            this.textResultado.TabIndex = 12;
            this.textResultado.Text = "\r\n";
            // 
            // DatosPersonales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.textDireccion);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbApellido);
            this.MaximizeBox = false;
            this.Name = "DatosPersonales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Datos Personales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.TextBox textDireccion;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.TextBox textResultado;
    }
}

