﻿namespace Practica3
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
			this.lstGenerada = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtTabla = new System.Windows.Forms.TextBox();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstGenerada
			// 
			this.lstGenerada.FormattingEnabled = true;
			this.lstGenerada.Location = new System.Drawing.Point(33, 66);
			this.lstGenerada.Name = "lstGenerada";
			this.lstGenerada.Size = new System.Drawing.Size(120, 199);
			this.lstGenerada.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(96, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Numero de la tabla";
			// 
			// txtTabla
			// 
			this.txtTabla.Location = new System.Drawing.Point(33, 40);
			this.txtTabla.Name = "txtTabla";
			this.txtTabla.Size = new System.Drawing.Size(120, 20);
			this.txtTabla.TabIndex = 2;
			// 
			// btnGenerar
			// 
			this.btnGenerar.Location = new System.Drawing.Point(57, 271);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(75, 23);
			this.btnGenerar.TabIndex = 3;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(196, 343);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.txtTabla);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstGenerada);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lstGenerada;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtTabla;
		private System.Windows.Forms.Button btnGenerar;
	}
}

