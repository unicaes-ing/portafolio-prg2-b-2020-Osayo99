namespace Practica4
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
			this.label1 = new System.Windows.Forms.Label();
			this.txtN1 = new System.Windows.Forms.TextBox();
			this.txtN3 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtN2 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtN4 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnSumar = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.lblSumatoria = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(57, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Numero 1:";
			// 
			// txtN1
			// 
			this.txtN1.Location = new System.Drawing.Point(129, 18);
			this.txtN1.Name = "txtN1";
			this.txtN1.Size = new System.Drawing.Size(100, 20);
			this.txtN1.TabIndex = 1;
			// 
			// txtN3
			// 
			this.txtN3.Location = new System.Drawing.Point(129, 76);
			this.txtN3.Name = "txtN3";
			this.txtN3.Size = new System.Drawing.Size(100, 20);
			this.txtN3.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(57, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Numero 2:";
			// 
			// txtN2
			// 
			this.txtN2.Location = new System.Drawing.Point(129, 47);
			this.txtN2.Name = "txtN2";
			this.txtN2.Size = new System.Drawing.Size(100, 20);
			this.txtN2.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(57, 79);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Numero 3:";
			// 
			// txtN4
			// 
			this.txtN4.Location = new System.Drawing.Point(129, 102);
			this.txtN4.Name = "txtN4";
			this.txtN4.Size = new System.Drawing.Size(100, 20);
			this.txtN4.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(57, 105);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(56, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Numero 4:";
			// 
			// btnSumar
			// 
			this.btnSumar.Location = new System.Drawing.Point(60, 151);
			this.btnSumar.Name = "btnSumar";
			this.btnSumar.Size = new System.Drawing.Size(75, 23);
			this.btnSumar.TabIndex = 8;
			this.btnSumar.Text = "Sumar";
			this.btnSumar.UseVisualStyleBackColor = true;
			this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(98, 202);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Suma:";
			// 
			// lblSumatoria
			// 
			this.lblSumatoria.AutoSize = true;
			this.lblSumatoria.Location = new System.Drawing.Point(162, 202);
			this.lblSumatoria.Name = "lblSumatoria";
			this.lblSumatoria.Size = new System.Drawing.Size(0, 13);
			this.lblSumatoria.TabIndex = 10;
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.Location = new System.Drawing.Point(154, 151);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
			this.btnLimpiar.TabIndex = 11;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = true;
			this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnSumar;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnLimpiar;
			this.ClientSize = new System.Drawing.Size(282, 235);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.lblSumatoria);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnSumar);
			this.Controls.Add(this.txtN4);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtN2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtN3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtN1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtN1;
		private System.Windows.Forms.TextBox txtN3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtN2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtN4;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSumar;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblSumatoria;
		private System.Windows.Forms.Button btnLimpiar;
	}
}

