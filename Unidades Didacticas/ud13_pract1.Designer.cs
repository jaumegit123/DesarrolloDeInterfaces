namespace Unidades_Didacticas {
    partial class ud13_pract1 {
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
            this.relojDigital1 = new Unidades_Didacticas.RelojDigital();
            this.relojAnalogico1 = new RelojAnalogico.RelojAnalogico();
            this.SuspendLayout();
            // 
            // relojDigital1
            // 
            this.relojDigital1.BackColor = System.Drawing.Color.Transparent;
            this.relojDigital1.InnerColor = System.Drawing.Color.Transparent;
            this.relojDigital1.Location = new System.Drawing.Point(449, 50);
            this.relojDigital1.Name = "relojDigital1";
            this.relojDigital1.Size = new System.Drawing.Size(350, 350);
            this.relojDigital1.TabIndex = 1;
            // 
            // relojAnalogico1
            // 
            this.relojAnalogico1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.relojAnalogico1.Enabled = false;
            this.relojAnalogico1.HandColor = System.Drawing.Color.Black;
            this.relojAnalogico1.InnerColor = System.Drawing.Color.SkyBlue;
            this.relojAnalogico1.Location = new System.Drawing.Point(40, 50);
            this.relojAnalogico1.MinimumSize = new System.Drawing.Size(50, 50);
            this.relojAnalogico1.Name = "relojAnalogico1";
            this.relojAnalogico1.OuterColor = System.Drawing.Color.SteelBlue;
            this.relojAnalogico1.SecondHandColor = System.Drawing.Color.Red;
            this.relojAnalogico1.Size = new System.Drawing.Size(350, 350);
            this.relojAnalogico1.TabIndex = 0;
            this.relojAnalogico1.TextColor = System.Drawing.Color.Black;
            this.relojAnalogico1.TickColor = System.Drawing.Color.Black;
            // 
            // ud13_pract1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(43)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(842, 436);
            this.Controls.Add(this.relojDigital1);
            this.Controls.Add(this.relojAnalogico1);
            this.Name = "ud13_pract1";
            this.Text = "UD13 - Práctica 1";
            this.ResumeLayout(false);

        }

        #endregion

        private RelojAnalogico.RelojAnalogico relojAnalogico1;
        private RelojDigital relojDigital1;
    }
}