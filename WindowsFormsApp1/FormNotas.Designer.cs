﻿namespace WindowsFormsApp1
{
    partial class FormNotas
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
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(90, 52);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(91, 16);
            this.lblNota1.TabIndex = 0;
            this.lblNota1.Text = "Ingrese nota 1";
            this.lblNota1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(90, 100);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(94, 16);
            this.lblNota2.TabIndex = 1;
            this.lblNota2.Text = "Ingrese Nota 2";
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(90, 146);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(94, 16);
            this.lblNota3.TabIndex = 2;
            this.lblNota3.Text = "Ingrese Nota 3";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(93, 192);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(91, 16);
            this.lblNota4.TabIndex = 3;
            this.lblNota4.Text = "Ingrese nota 4";
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(253, 52);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(100, 22);
            this.txtNota1.TabIndex = 4;
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(253, 100);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(100, 22);
            this.txtNota2.TabIndex = 5;
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(253, 146);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(100, 22);
            this.txtNota3.TabIndex = 6;
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(253, 192);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(100, 22);
            this.txtNota4.TabIndex = 7;
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(253, 266);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(75, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // FormNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtNota4);
            this.Controls.Add(this.txtNota3);
            this.Controls.Add(this.txtNota2);
            this.Controls.Add(this.txtNota1);
            this.Controls.Add(this.lblNota4);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.lblNota1);
            this.Name = "FormNotas";
            this.Text = "FormNotas";
            this.Load += new System.EventHandler(this.FormNotas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.Button btnMostrar;
    }
}