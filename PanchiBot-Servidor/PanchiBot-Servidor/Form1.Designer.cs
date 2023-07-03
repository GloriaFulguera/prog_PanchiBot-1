
namespace PanchiBot_Servidor
{
    partial class Server
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            this.btnPermitirConexiones = new System.Windows.Forms.Button();
            this.panelFondo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnPermitirConexiones
            // 
            this.btnPermitirConexiones.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnPermitirConexiones.FlatAppearance.BorderSize = 0;
            this.btnPermitirConexiones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkCyan;
            this.btnPermitirConexiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermitirConexiones.Font = new System.Drawing.Font("Tw Cen MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermitirConexiones.ForeColor = System.Drawing.Color.White;
            this.btnPermitirConexiones.Location = new System.Drawing.Point(650, 28);
            this.btnPermitirConexiones.Name = "btnPermitirConexiones";
            this.btnPermitirConexiones.Size = new System.Drawing.Size(138, 32);
            this.btnPermitirConexiones.TabIndex = 0;
            this.btnPermitirConexiones.Text = "ABRIR CONEXIONES";
            this.btnPermitirConexiones.UseVisualStyleBackColor = false;
            this.btnPermitirConexiones.Click += new System.EventHandler(this.btnPermitirConexiones_Click);
            // 
            // panelFondo
            // 
            this.panelFondo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelFondo.BackgroundImage")));
            this.panelFondo.Location = new System.Drawing.Point(0, 0);
            this.panelFondo.Name = "panelFondo";
            this.panelFondo.Size = new System.Drawing.Size(644, 451);
            this.panelFondo.TabIndex = 1;
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelFondo);
            this.Controls.Add(this.btnPermitirConexiones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Server";
            this.Text = "SERVER";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPermitirConexiones;
        private System.Windows.Forms.Panel panelFondo;
    }
}

