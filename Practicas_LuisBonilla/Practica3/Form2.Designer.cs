namespace Practica3
{
	partial class Form2
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
			this.lstAbc = new System.Windows.Forms.ListBox();
			this.btnGenerar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstAbc
			// 
			this.lstAbc.FormattingEnabled = true;
			this.lstAbc.Location = new System.Drawing.Point(63, 12);
			this.lstAbc.Name = "lstAbc";
			this.lstAbc.Size = new System.Drawing.Size(139, 264);
			this.lstAbc.TabIndex = 0;
			// 
			// btnGenerar
			// 
			this.btnGenerar.Location = new System.Drawing.Point(97, 282);
			this.btnGenerar.Name = "btnGenerar";
			this.btnGenerar.Size = new System.Drawing.Size(75, 23);
			this.btnGenerar.TabIndex = 1;
			this.btnGenerar.Text = "Generar";
			this.btnGenerar.UseVisualStyleBackColor = true;
			this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(271, 321);
			this.Controls.Add(this.btnGenerar);
			this.Controls.Add(this.lstAbc);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox lstAbc;
		private System.Windows.Forms.Button btnGenerar;
	}
}