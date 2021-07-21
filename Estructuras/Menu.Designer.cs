namespace Estructuras
{
    partial class Menu
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
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.CloseApp = new System.Windows.Forms.Button();
            this.ArreglosBoton = new System.Windows.Forms.Button();
            this.StackButton = new System.Windows.Forms.Button();
            this.QueuesButton = new System.Windows.Forms.Button();
            this.StructButton = new System.Windows.Forms.Button();
            this.Datos = new System.Windows.Forms.PictureBox();
            this.HashTablesButton = new System.Windows.Forms.Button();
            this.DatosLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("MingLiU-ExtB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.WelcomeLabel.Location = new System.Drawing.Point(45, 51);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(495, 32);
            this.WelcomeLabel.TabIndex = 1;
            this.WelcomeLabel.Text = "Estructuras de datos aplicadas";
            // 
            // CloseApp
            // 
            this.CloseApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CloseApp.Font = new System.Drawing.Font("Mongolian Baiti", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseApp.ForeColor = System.Drawing.Color.DeepPink;
            this.CloseApp.Location = new System.Drawing.Point(181, 435);
            this.CloseApp.Name = "CloseApp";
            this.CloseApp.Size = new System.Drawing.Size(224, 59);
            this.CloseApp.TabIndex = 2;
            this.CloseApp.Text = "Salir";
            this.CloseApp.UseVisualStyleBackColor = true;
            this.CloseApp.Click += new System.EventHandler(this.CloseApp_Click);
            // 
            // ArreglosBoton
            // 
            this.ArreglosBoton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ArreglosBoton.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ArreglosBoton.ForeColor = System.Drawing.Color.DeepPink;
            this.ArreglosBoton.Location = new System.Drawing.Point(181, 110);
            this.ArreglosBoton.Name = "ArreglosBoton";
            this.ArreglosBoton.Size = new System.Drawing.Size(224, 59);
            this.ArreglosBoton.TabIndex = 3;
            this.ArreglosBoton.Text = "Arrays";
            this.ArreglosBoton.UseVisualStyleBackColor = true;
            this.ArreglosBoton.Click += new System.EventHandler(this.ArreglosBoton_Click);
            // 
            // StackButton
            // 
            this.StackButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StackButton.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StackButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.StackButton.Location = new System.Drawing.Point(181, 175);
            this.StackButton.Name = "StackButton";
            this.StackButton.Size = new System.Drawing.Size(224, 59);
            this.StackButton.TabIndex = 4;
            this.StackButton.Text = "Stacks";
            this.StackButton.UseVisualStyleBackColor = true;
            this.StackButton.Click += new System.EventHandler(this.StackButton_Click);
            // 
            // QueuesButton
            // 
            this.QueuesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.QueuesButton.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueuesButton.ForeColor = System.Drawing.Color.Crimson;
            this.QueuesButton.Location = new System.Drawing.Point(181, 240);
            this.QueuesButton.Name = "QueuesButton";
            this.QueuesButton.Size = new System.Drawing.Size(224, 59);
            this.QueuesButton.TabIndex = 5;
            this.QueuesButton.Text = "Queues";
            this.QueuesButton.UseVisualStyleBackColor = true;
            this.QueuesButton.Click += new System.EventHandler(this.QueuesButton_Click);
            // 
            // StructButton
            // 
            this.StructButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.StructButton.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StructButton.ForeColor = System.Drawing.Color.LawnGreen;
            this.StructButton.Location = new System.Drawing.Point(181, 305);
            this.StructButton.Name = "StructButton";
            this.StructButton.Size = new System.Drawing.Size(224, 59);
            this.StructButton.TabIndex = 6;
            this.StructButton.Text = "Structs";
            this.StructButton.UseVisualStyleBackColor = true;
            this.StructButton.Click += new System.EventHandler(this.StructButton_Click);
            // 
            // Datos
            // 
            this.Datos.Image = global::Estructuras.Properties.Resources.TICSUTLD;
            this.Datos.Location = new System.Drawing.Point(181, 450);
            this.Datos.Name = "Datos";
            this.Datos.Size = new System.Drawing.Size(224, 224);
            this.Datos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Datos.TabIndex = 0;
            this.Datos.TabStop = false;
            this.Datos.Click += new System.EventHandler(this.Datos_Click);
            // 
            // HashTablesButton
            // 
            this.HashTablesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.HashTablesButton.Font = new System.Drawing.Font("Century", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashTablesButton.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.HashTablesButton.Location = new System.Drawing.Point(181, 370);
            this.HashTablesButton.Name = "HashTablesButton";
            this.HashTablesButton.Size = new System.Drawing.Size(224, 59);
            this.HashTablesButton.TabIndex = 7;
            this.HashTablesButton.Text = "Hash";
            this.HashTablesButton.UseVisualStyleBackColor = true;
            this.HashTablesButton.Click += new System.EventHandler(this.HashTablesButton_Click);
            // 
            // DatosLabel
            // 
            this.DatosLabel.AutoSize = true;
            this.DatosLabel.Font = new System.Drawing.Font("MingLiU-ExtB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatosLabel.ForeColor = System.Drawing.Color.White;
            this.DatosLabel.Location = new System.Drawing.Point(129, 640);
            this.DatosLabel.Name = "DatosLabel";
            this.DatosLabel.Size = new System.Drawing.Size(329, 19);
            this.DatosLabel.TabIndex = 8;
            this.DatosLabel.Text = "Zahúl Guadalupe Domínguez Chávez";
            this.DatosLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DatosLabel.Visible = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(594, 739);
            this.Controls.Add(this.DatosLabel);
            this.Controls.Add(this.HashTablesButton);
            this.Controls.Add(this.StructButton);
            this.Controls.Add(this.QueuesButton);
            this.Controls.Add(this.StackButton);
            this.Controls.Add(this.ArreglosBoton);
            this.Controls.Add(this.CloseApp);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.Datos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Datos;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Button CloseApp;
        private System.Windows.Forms.Button ArreglosBoton;
        private System.Windows.Forms.Button StackButton;
        private System.Windows.Forms.Button QueuesButton;
        private System.Windows.Forms.Button StructButton;
        private System.Windows.Forms.Button HashTablesButton;
        private System.Windows.Forms.Label DatosLabel;
    }
}

