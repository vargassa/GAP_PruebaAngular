namespace Prueba_GAP_1
{
    partial class Form1
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
            this.txtTexto1 = new System.Windows.Forms.TextBox();
            this.txtTexto2 = new System.Windows.Forms.TextBox();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.btnMerge = new System.Windows.Forms.Button();
            this.txtMerge = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTexto1
            // 
            this.txtTexto1.Location = new System.Drawing.Point(64, 29);
            this.txtTexto1.Name = "txtTexto1";
            this.txtTexto1.Size = new System.Drawing.Size(352, 20);
            this.txtTexto1.TabIndex = 0;
            // 
            // txtTexto2
            // 
            this.txtTexto2.Location = new System.Drawing.Point(64, 91);
            this.txtTexto2.Name = "txtTexto2";
            this.txtTexto2.Size = new System.Drawing.Size(352, 20);
            this.txtTexto2.TabIndex = 1;
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(61, 13);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(71, 13);
            this.lblText1.TabIndex = 2;
            this.lblText1.Text = "Write first text";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(61, 75);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(108, 13);
            this.lblText2.TabIndex = 3;
            this.lblText2.Text = "Write the second text";
            // 
            // btnMerge
            // 
            this.btnMerge.Location = new System.Drawing.Point(131, 117);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.Size = new System.Drawing.Size(75, 23);
            this.btnMerge.TabIndex = 4;
            this.btnMerge.Text = "MERGE";
            this.btnMerge.UseVisualStyleBackColor = true;
            this.btnMerge.Click += new System.EventHandler(this.ClicMerge);
            // 
            // txtMerge
            // 
            this.txtMerge.Location = new System.Drawing.Point(64, 165);
            this.txtMerge.Multiline = true;
            this.txtMerge.Name = "txtMerge";
            this.txtMerge.Size = new System.Drawing.Size(352, 70);
            this.txtMerge.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(237, 117);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clean Text";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 256);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtMerge);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.txtTexto2);
            this.Controls.Add(this.txtTexto1);
            this.Name = "Form1";
            this.Text = "Prueba GAP 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTexto1;
        private System.Windows.Forms.TextBox txtTexto2;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.Button btnMerge;
        private System.Windows.Forms.TextBox txtMerge;
        private System.Windows.Forms.Button btnClear;
    }
}

