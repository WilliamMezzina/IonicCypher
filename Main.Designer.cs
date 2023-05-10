namespace IonicCypher
{
	partial class Main
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
			this.btCriptografar = new System.Windows.Forms.Button();
			this.btDecriptografar = new System.Windows.Forms.Button();
			this.txtCripto = new System.Windows.Forms.TextBox();
			this.txtDecripto = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btCriptografar
			// 
			this.btCriptografar.Location = new System.Drawing.Point(48, 136);
			this.btCriptografar.Name = "btCriptografar";
			this.btCriptografar.Size = new System.Drawing.Size(75, 23);
			this.btCriptografar.TabIndex = 0;
			this.btCriptografar.Text = "Criptografar";
			this.btCriptografar.UseVisualStyleBackColor = true;
			this.btCriptografar.Click += new System.EventHandler(this.btCriptografar_Click);
			// 
			// btDecriptografar
			// 
			this.btDecriptografar.Location = new System.Drawing.Point(153, 136);
			this.btDecriptografar.Name = "btDecriptografar";
			this.btDecriptografar.Size = new System.Drawing.Size(91, 23);
			this.btDecriptografar.TabIndex = 1;
			this.btDecriptografar.Text = "Decriptografar";
			this.btDecriptografar.UseVisualStyleBackColor = true;
			this.btDecriptografar.Click += new System.EventHandler(this.btDecriptografar_Click);
			// 
			// txtCripto
			// 
			this.txtCripto.Location = new System.Drawing.Point(48, 54);
			this.txtCripto.Name = "txtCripto";
			this.txtCripto.Size = new System.Drawing.Size(324, 20);
			this.txtCripto.TabIndex = 2;
			// 
			// txtDecripto
			// 
			this.txtDecripto.Location = new System.Drawing.Point(48, 212);
			this.txtDecripto.Name = "txtDecripto";
			this.txtDecripto.Size = new System.Drawing.Size(324, 20);
			this.txtDecripto.TabIndex = 3;
			// 
			// Main
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(410, 274);
			this.Controls.Add(this.txtDecripto);
			this.Controls.Add(this.txtCripto);
			this.Controls.Add(this.btDecriptografar);
			this.Controls.Add(this.btCriptografar);
			this.Name = "Main";
			this.Text = "Main";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btCriptografar;
		private System.Windows.Forms.Button btDecriptografar;
		private System.Windows.Forms.TextBox txtCripto;
		private System.Windows.Forms.TextBox txtDecripto;
	}
}