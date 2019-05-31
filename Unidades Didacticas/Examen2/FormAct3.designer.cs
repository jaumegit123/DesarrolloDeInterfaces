namespace Examen2 {
    partial class FormAct3 {
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
            this.compCronometro1 = new Examen2.compCronometro();
            this.SuspendLayout();
            // 
            // compCronometro1
            // 
            this.compCronometro1.Location = new System.Drawing.Point(58, 33);
            this.compCronometro1.Name = "compCronometro1";
            this.compCronometro1.Periodo = 2;
            this.compCronometro1.Reset = false;
            this.compCronometro1.Size = new System.Drawing.Size(150, 150);
            this.compCronometro1.TabIndex = 0;
            // 
            // FormAct3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 217);
            this.Controls.Add(this.compCronometro1);
            this.Name = "FormAct3";
            this.Text = "FormAct3";
            this.ResumeLayout(false);

        }

        #endregion

        private compCronometro compCronometro1;
    }
}