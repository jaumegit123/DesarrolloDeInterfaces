namespace Unidades_Didacticas.Examen1 {
    partial class Form4 {
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox128 = new System.Windows.Forms.TextBox();
            this.textBox64 = new System.Windows.Forms.TextBox();
            this.textBox32 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelHex = new System.Windows.Forms.Label();
            this.labelDec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número binario:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 27);
            this.button1.TabIndex = 1;
            this.button1.Text = "Conversión a Hex y Dec";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox128
            // 
            this.textBox128.Location = new System.Drawing.Point(148, 91);
            this.textBox128.Name = "textBox128";
            this.textBox128.Size = new System.Drawing.Size(22, 20);
            this.textBox128.TabIndex = 2;
            // 
            // textBox64
            // 
            this.textBox64.Location = new System.Drawing.Point(176, 91);
            this.textBox64.Name = "textBox64";
            this.textBox64.Size = new System.Drawing.Size(22, 20);
            this.textBox64.TabIndex = 3;
            // 
            // textBox32
            // 
            this.textBox32.Location = new System.Drawing.Point(204, 91);
            this.textBox32.Name = "textBox32";
            this.textBox32.Size = new System.Drawing.Size(22, 20);
            this.textBox32.TabIndex = 4;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(232, 91);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(22, 20);
            this.textBox16.TabIndex = 5;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(260, 91);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(22, 20);
            this.textBox8.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(288, 91);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(22, 20);
            this.textBox4.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(22, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(344, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(22, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Número hexadecimal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número decimal:";
            // 
            // labelHex
            // 
            this.labelHex.AutoSize = true;
            this.labelHex.Location = new System.Drawing.Point(173, 134);
            this.labelHex.Name = "labelHex";
            this.labelHex.Size = new System.Drawing.Size(0, 13);
            this.labelHex.TabIndex = 12;
            // 
            // labelDec
            // 
            this.labelDec.AutoSize = true;
            this.labelDec.Location = new System.Drawing.Point(173, 179);
            this.labelDec.Name = "labelDec";
            this.labelDec.Size = new System.Drawing.Size(0, 13);
            this.labelDec.TabIndex = 13;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 261);
            this.Controls.Add(this.labelDec);
            this.Controls.Add(this.labelHex);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox32);
            this.Controls.Add(this.textBox64);
            this.Controls.Add(this.textBox128);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox128;
        private System.Windows.Forms.TextBox textBox64;
        private System.Windows.Forms.TextBox textBox32;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelHex;
        private System.Windows.Forms.Label labelDec;
    }
}