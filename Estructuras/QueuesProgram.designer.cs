namespace Estructuras
{
    partial class Queues
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
            this.Enqueuebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DequeueButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.QueuedUsersTextBox = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enqueuebutton
            // 
            this.Enqueuebutton.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.Enqueuebutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enqueuebutton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enqueuebutton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Enqueuebutton.Location = new System.Drawing.Point(18, 150);
            this.Enqueuebutton.Name = "Enqueuebutton";
            this.Enqueuebutton.Size = new System.Drawing.Size(197, 57);
            this.Enqueuebutton.TabIndex = 0;
            this.Enqueuebutton.Text = "UNIRSE A LA FILA";
            this.Enqueuebutton.UseVisualStyleBackColor = false;
            this.Enqueuebutton.Click += new System.EventHandler(this.Enqueuebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("NSimSun", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(18, 84);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(250, 28);
            this.username.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(18, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 57);
            this.button1.TabIndex = 3;
            this.button1.Text = "CONSULTAR FILA";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.PeekButton_Click);
            // 
            // DequeueButton
            // 
            this.DequeueButton.BackColor = System.Drawing.Color.Gold;
            this.DequeueButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DequeueButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DequeueButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DequeueButton.Location = new System.Drawing.Point(18, 317);
            this.DequeueButton.Name = "DequeueButton";
            this.DequeueButton.Size = new System.Drawing.Size(197, 57);
            this.DequeueButton.TabIndex = 4;
            this.DequeueButton.Text = "UNIRSE AL JUEGO";
            this.DequeueButton.UseVisualStyleBackColor = false;
            this.DequeueButton.Click += new System.EventHandler(this.DequeueButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.Crimson;
            this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ClearButton.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClearButton.Location = new System.Drawing.Point(18, 398);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(197, 57);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "NUKE";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // QueuedUsersTextBox
            // 
            this.QueuedUsersTextBox.AutoSize = true;
            this.QueuedUsersTextBox.Font = new System.Drawing.Font("MS PGothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueuedUsersTextBox.Location = new System.Drawing.Point(335, 150);
            this.QueuedUsersTextBox.Name = "QueuedUsersTextBox";
            this.QueuedUsersTextBox.Size = new System.Drawing.Size(239, 19);
            this.QueuedUsersTextBox.TabIndex = 6;
            this.QueuedUsersTextBox.Text = "-----------------------";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Estructuras.Properties.Resources.TICSUTLD;
            this.pictureBox2.Location = new System.Drawing.Point(12, 432);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(224, 224);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Estructuras.Properties.Resources.CyberPUNK;
            this.pictureBox1.Location = new System.Drawing.Point(274, -48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(502, 244);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("MS Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(9, 641);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(271, 15);
            this.Nombre.TabIndex = 9;
            this.Nombre.Text = "©Zahúl Guadalupe Domínguez Chávez";
            // 
            // Queues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(768, 736);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.QueuedUsersTextBox);
            this.Controls.Add(this.DequeueButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Enqueuebutton);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Queues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queues";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enqueuebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button DequeueButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label QueuedUsersTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label Nombre;
    }
}

