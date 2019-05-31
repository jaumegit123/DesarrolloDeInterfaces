namespace Examen2 {
    partial class FormAct1 {
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
            this.btnProcedimiento1 = new System.Windows.Forms.Button();
            this.btnProcedimiento2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnProcedimiento1
            // 
            this.btnProcedimiento1.Location = new System.Drawing.Point(266, 42);
            this.btnProcedimiento1.Name = "btnProcedimiento1";
            this.btnProcedimiento1.Size = new System.Drawing.Size(96, 23);
            this.btnProcedimiento1.TabIndex = 1;
            this.btnProcedimiento1.Text = "Procedimiento 1";
            this.btnProcedimiento1.UseVisualStyleBackColor = true;
            this.btnProcedimiento1.Click += new System.EventHandler(this.btnProcedimiento1_Click);
            // 
            // btnProcedimiento2
            // 
            this.btnProcedimiento2.Location = new System.Drawing.Point(266, 101);
            this.btnProcedimiento2.Name = "btnProcedimiento2";
            this.btnProcedimiento2.Size = new System.Drawing.Size(96, 23);
            this.btnProcedimiento2.TabIndex = 2;
            this.btnProcedimiento2.Text = "Procedimiento 2";
            this.btnProcedimiento2.UseVisualStyleBackColor = true;
            this.btnProcedimiento2.Click += new System.EventHandler(this.btnProcedimiento2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(40, 42);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(182, 82);
            this.listBox1.TabIndex = 3;
            // 
            // FormAct1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 161);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnProcedimiento2);
            this.Controls.Add(this.btnProcedimiento1);
            this.Name = "FormAct1";
            this.Text = "FormAct1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcedimiento1;
        private System.Windows.Forms.Button btnProcedimiento2;
        private System.Windows.Forms.ListBox listBox1;
    }
}