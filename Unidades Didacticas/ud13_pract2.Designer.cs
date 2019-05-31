namespace Unidades_Didacticas {
    partial class ud13_pract2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ud13_pract2));
            this.listViewXML1 = new Unidades_Didacticas.ListViewXML();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listViewXML1
            // 
            this.listViewXML1.BackColor = System.Drawing.Color.Transparent;
            this.listViewXML1.Location = new System.Drawing.Point(22, 50);
            this.listViewXML1.Manual = true;
            this.listViewXML1.Name = "listViewXML1";
            this.listViewXML1.NombreFichXML = "usuarios.xml";
            this.listViewXML1.NumeroCampos = 4;
            this.listViewXML1.NumeroItems = 2;
            this.listViewXML1.Size = new System.Drawing.Size(1055, 377);
            this.listViewXML1.TabIndex = 0;
            this.listViewXML1.TituloCampos = ((System.Collections.Generic.List<string>)(resources.GetObject("listViewXML1.TituloCampos")));
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Componente ListView modificado";
            // 
            // ud13_pract2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1105, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewXML1);
            this.Name = "ud13_pract2";
            this.Text = "UD13 - Práctica 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListViewXML listViewXML1;
        private System.Windows.Forms.Label label1;
    }
}