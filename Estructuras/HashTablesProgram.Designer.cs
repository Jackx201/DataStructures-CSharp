namespace Estructuras
{
    partial class HashTables
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
            this.AddButton = new System.Windows.Forms.Button();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.DisplayButton = new System.Windows.Forms.Button();
            this.ValueTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdLabel = new System.Windows.Forms.Label();
            this.UsuarioLabel = new System.Windows.Forms.Label();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DatosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AddButton.Font = new System.Drawing.Font("NSimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.Cyan;
            this.AddButton.Location = new System.Drawing.Point(12, 136);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(258, 90);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Agregar";
            this.AddButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.AutoSize = true;
            this.DisplayLabel.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLabel.ForeColor = System.Drawing.Color.White;
            this.DisplayLabel.Location = new System.Drawing.Point(397, 127);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(0, 24);
            this.DisplayLabel.TabIndex = 1;
            // 
            // DisplayButton
            // 
            this.DisplayButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DisplayButton.Font = new System.Drawing.Font("NSimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayButton.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.DisplayButton.Location = new System.Drawing.Point(12, 232);
            this.DisplayButton.Name = "DisplayButton";
            this.DisplayButton.Size = new System.Drawing.Size(258, 90);
            this.DisplayButton.TabIndex = 2;
            this.DisplayButton.Text = "Consultar";
            this.DisplayButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DisplayButton.UseVisualStyleBackColor = true;
            this.DisplayButton.Click += new System.EventHandler(this.DisplayButton_Click);
            // 
            // ValueTextBox
            // 
            this.ValueTextBox.BackColor = System.Drawing.Color.White;
            this.ValueTextBox.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueTextBox.Location = new System.Drawing.Point(105, 61);
            this.ValueTextBox.Name = "ValueTextBox";
            this.ValueTextBox.Size = new System.Drawing.Size(251, 38);
            this.ValueTextBox.TabIndex = 3;
            this.ValueTextBox.Text = "Jackx201";
            // 
            // IdTextBox
            // 
            this.IdTextBox.BackColor = System.Drawing.Color.White;
            this.IdTextBox.Font = new System.Drawing.Font("SimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTextBox.Location = new System.Drawing.Point(12, 61);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(78, 38);
            this.IdTextBox.TabIndex = 4;
            this.IdTextBox.Text = "1";
            this.IdTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdLabel.ForeColor = System.Drawing.Color.White;
            this.IdLabel.Location = new System.Drawing.Point(12, 23);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(46, 24);
            this.IdLabel.TabIndex = 5;
            this.IdLabel.Text = "ID:";
            // 
            // UsuarioLabel
            // 
            this.UsuarioLabel.AutoSize = true;
            this.UsuarioLabel.Font = new System.Drawing.Font("NSimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLabel.ForeColor = System.Drawing.Color.White;
            this.UsuarioLabel.Location = new System.Drawing.Point(101, 23);
            this.UsuarioLabel.Name = "UsuarioLabel";
            this.UsuarioLabel.Size = new System.Drawing.Size(106, 24);
            this.UsuarioLabel.TabIndex = 6;
            this.UsuarioLabel.Text = "Usuario:";
            // 
            // RemoveButton
            // 
            this.RemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RemoveButton.Font = new System.Drawing.Font("NSimSun", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveButton.ForeColor = System.Drawing.Color.Orchid;
            this.RemoveButton.Location = new System.Drawing.Point(16, 328);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(258, 90);
            this.RemoveButton.TabIndex = 7;
            this.RemoveButton.Text = "Eliminar";
            this.RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(491, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 37);
            this.label1.TabIndex = 8;
            this.label1.Text = "Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estructuras.Properties.Resources.TICSUTLD;
            this.pictureBox1.Location = new System.Drawing.Point(12, 424);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DatosLabel
            // 
            this.DatosLabel.AutoSize = true;
            this.DatosLabel.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosLabel.ForeColor = System.Drawing.Color.White;
            this.DatosLabel.Location = new System.Drawing.Point(266, 498);
            this.DatosLabel.Name = "DatosLabel";
            this.DatosLabel.Size = new System.Drawing.Size(394, 24);
            this.DatosLabel.TabIndex = 10;
            this.DatosLabel.Text = "Zahúl Guadalupe Domínguez Chávez";
            // 
            // HashTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 671);
            this.Controls.Add(this.DatosLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.UsuarioLabel);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.ValueTextBox);
            this.Controls.Add(this.DisplayButton);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.AddButton);
            this.Name = "HashTables";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tablas Hash";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label DisplayLabel;
        private System.Windows.Forms.Button DisplayButton;
        private System.Windows.Forms.TextBox ValueTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label UsuarioLabel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label DatosLabel;
    }
}

