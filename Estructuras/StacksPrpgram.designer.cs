namespace Estructuras
{
    partial class Stacks
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
            this.button1 = new System.Windows.Forms.Button();
            this.nombreperiodico = new System.Windows.Forms.TextBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.Comprar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(246)))), ((int)(((byte)(216)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(186, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 68);
            this.button1.TabIndex = 0;
            this.button1.Text = "CONSULTAR PERIÓDICO";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nombreperiodico
            // 
            this.nombreperiodico.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreperiodico.Location = new System.Drawing.Point(186, 107);
            this.nombreperiodico.Name = "nombreperiodico";
            this.nombreperiodico.Size = new System.Drawing.Size(456, 29);
            this.nombreperiodico.TabIndex = 1;
            // 
            // Guardar
            // 
            this.Guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(246)))), ((int)(((byte)(216)))));
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Guardar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(340, 151);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(148, 68);
            this.Guardar.TabIndex = 2;
            this.Guardar.Text = "GUARDAR PERIÓDICO";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Comprar
            // 
            this.Comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(246)))), ((int)(((byte)(216)))));
            this.Comprar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Comprar.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Comprar.Location = new System.Drawing.Point(494, 151);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(148, 68);
            this.Comprar.TabIndex = 3;
            this.Comprar.Text = "COMPRAR PERIÓDICO";
            this.Comprar.UseVisualStyleBackColor = false;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(561, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "NOMBRE DEL PERIÓDICO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 673);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(390, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autor: Zahúl Guadalupe Domínguez Chávez";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 719);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(512, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Editorial: Universidad Tecnológica de la Laguna Durango";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 696);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(398, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Distribuidor: ING. David Rodríguez Ceballos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 650);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha de publicación: 12/04/2021";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Estructuras.Properties.Resources.Render;
            this.pictureBox2.Location = new System.Drawing.Point(626, 594);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(257, 206);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Estructuras.Properties.Resources.Newspaper1;
            this.pictureBox1.Location = new System.Drawing.Point(186, 236);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(456, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Stacks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(208)))), ((int)(((byte)(183)))));
            this.ClientSize = new System.Drawing.Size(839, 759);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Comprar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.nombreperiodico);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Stacks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stack";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nombreperiodico;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Comprar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

