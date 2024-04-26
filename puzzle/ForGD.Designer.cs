namespace WindowsFormsApplication1
{
	partial class ForGD
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
			this.btnStart = new System.Windows.Forms.Button();
			this.btnLuat = new System.Windows.Forms.Button();
			this.btnOUT = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnStart
			// 
			this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnStart.Location = new System.Drawing.Point(221, 100);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(127, 34);
			this.btnStart.TabIndex = 0;
			this.btnStart.Text = "Bắt đầu";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnLuat
			// 
			this.btnLuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuat.Location = new System.Drawing.Point(221, 174);
			this.btnLuat.Name = "btnLuat";
			this.btnLuat.Size = new System.Drawing.Size(127, 34);
			this.btnLuat.TabIndex = 1;
			this.btnLuat.Text = "Luật";
			this.btnLuat.UseVisualStyleBackColor = true;
			this.btnLuat.Click += new System.EventHandler(this.btnLuat_Click);
			// 
			// btnOUT
			// 
			this.btnOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOUT.Location = new System.Drawing.Point(221, 258);
			this.btnOUT.Name = "btnOUT";
			this.btnOUT.Size = new System.Drawing.Size(127, 34);
			this.btnOUT.TabIndex = 2;
			this.btnOUT.Text = "Thoát";
			this.btnOUT.UseVisualStyleBackColor = true;
			this.btnOUT.Click += new System.EventHandler(this.btnOUT_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(204, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "Ghép Ảnh";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// ForGD
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(564, 348);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnOUT);
			this.Controls.Add(this.btnLuat);
			this.Controls.Add(this.btnStart);
			this.Name = "ForGD";
			this.Text = "ForGD";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnLuat;
		private System.Windows.Forms.Button btnOUT;
		private System.Windows.Forms.Label label1;
	}
}