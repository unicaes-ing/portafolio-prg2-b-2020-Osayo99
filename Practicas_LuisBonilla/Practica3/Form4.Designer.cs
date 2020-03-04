namespace Practica3
{
	partial class Form4
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
			this.lstDatos = new System.Windows.Forms.ListBox();
			this.btnLanzar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstDatos
			// 
			this.lstDatos.FormattingEnabled = true;
			this.lstDatos.Location = new System.Drawing.Point(35, 12);
			this.lstDatos.Name = "lstDatos";
			this.lstDatos.Size = new System.Drawing.Size(120, 186);
			this.lstDatos.TabIndex = 0;
			// 
			// btnLanzar
			// 
			this.btnLanzar.Location = new System.Drawing.Point(58, 204);
			this.btnLanzar.Name = "btnLanzar";
			this.btnLanzar.Size = new System.Drawing.Size(75, 23);
			this.btnLanzar.TabIndex = 1;
			this.btnLanzar.Text = "Lanzar";
			this.btnLanzar.UseVisualStyleBackColor = true;
			this.btnLanzar.Click += new System.EventHandler(this.btnLanzar_Click);
			// 
			// Form4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(184, 241);
			this.Controls.Add(this.btnLanzar);
			this.Controls.Add(this.lstDatos);
			this.Name = "Form4";
			this.Text = "Form4";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstDatos;
		private System.Windows.Forms.Button btnLanzar;
	}
}