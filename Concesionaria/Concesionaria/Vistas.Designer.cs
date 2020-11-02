namespace Concesionaria
{
    partial class Vistas
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
            this.grillaAutos = new System.Windows.Forms.DataGridView();
            this.btnVista = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAutos)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaAutos
            // 
            this.grillaAutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAutos.Location = new System.Drawing.Point(218, 24);
            this.grillaAutos.Name = "grillaAutos";
            this.grillaAutos.Size = new System.Drawing.Size(442, 150);
            this.grillaAutos.TabIndex = 6;
            // 
            // btnVista
            // 
            this.btnVista.Location = new System.Drawing.Point(33, 58);
            this.btnVista.Name = "btnVista";
            this.btnVista.Size = new System.Drawing.Size(142, 41);
            this.btnVista.TabIndex = 5;
            this.btnVista.Text = "VER MODELOS MÁS VENDIDOS";
            this.btnVista.UseVisualStyleBackColor = true;
            this.btnVista.Click += new System.EventHandler(this.btnVista_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "(año actual)";
            // 
            // Vistas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaAutos);
            this.Controls.Add(this.btnVista);
            this.Name = "Vistas";
            this.Text = "Vistas";
            ((System.ComponentModel.ISupportInitialize)(this.grillaAutos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaAutos;
        private System.Windows.Forms.Button btnVista;
        private System.Windows.Forms.Label label1;
    }
}