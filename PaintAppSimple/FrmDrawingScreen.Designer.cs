
namespace PaintAppSimple
{
	partial class FrmDrawingScreen
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if ( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDrawingScreen));
            this.grpControls = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.cmbPenThickness = new System.Windows.Forms.ComboBox();
            this.btnPenColor = new System.Windows.Forms.Button();
            this.lblPenThickness = new System.Windows.Forms.Label();
            this.lblPenColor = new System.Windows.Forms.Label();
            this.pnlDrawPad = new System.Windows.Forms.Panel();
            this.grpControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpControls
            // 
            this.grpControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpControls.AutoSize = true;
            this.grpControls.Controls.Add(this.btnSave);
            this.grpControls.Controls.Add(this.btnClean);
            this.grpControls.Controls.Add(this.btnEraser);
            this.grpControls.Controls.Add(this.cmbPenThickness);
            this.grpControls.Controls.Add(this.btnPenColor);
            this.grpControls.Controls.Add(this.lblPenThickness);
            this.grpControls.Controls.Add(this.lblPenColor);
            this.grpControls.ForeColor = System.Drawing.Color.White;
            this.grpControls.Location = new System.Drawing.Point(12, 24);
            this.grpControls.Name = "grpControls";
            this.grpControls.Size = new System.Drawing.Size(1240, 112);
            this.grpControls.TabIndex = 0;
            this.grpControls.TabStop = false;
            this.grpControls.Text = "Controles";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(890, 43);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 36);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnClean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClean.Location = new System.Drawing.Point(764, 43);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(109, 36);
            this.btnClean.TabIndex = 5;
            this.btnClean.Text = "Limpar";
            this.btnClean.UseVisualStyleBackColor = false;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.Location = new System.Drawing.Point(638, 43);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(109, 36);
            this.btnEraser.TabIndex = 4;
            this.btnEraser.Text = "Borracha";
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnEraser_MouseDown);
            // 
            // cmbPenThickness
            // 
            this.cmbPenThickness.BackColor = System.Drawing.SystemColors.Desktop;
            this.cmbPenThickness.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbPenThickness.ForeColor = System.Drawing.Color.White;
            this.cmbPenThickness.FormattingEnabled = true;
            this.cmbPenThickness.Location = new System.Drawing.Point(444, 43);
            this.cmbPenThickness.Name = "cmbPenThickness";
            this.cmbPenThickness.Size = new System.Drawing.Size(151, 36);
            this.cmbPenThickness.TabIndex = 3;
            this.cmbPenThickness.SelectedIndexChanged += new System.EventHandler(this.cmbPenThickness_SelectedIndexChanged);
            // 
            // btnPenColor
            // 
            this.btnPenColor.BackColor = System.Drawing.Color.Blue;
            this.btnPenColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPenColor.Location = new System.Drawing.Point(170, 42);
            this.btnPenColor.Name = "btnPenColor";
            this.btnPenColor.Size = new System.Drawing.Size(36, 36);
            this.btnPenColor.TabIndex = 2;
            this.btnPenColor.UseVisualStyleBackColor = false;
            this.btnPenColor.Click += new System.EventHandler(this.btnPenColor_Click);
            // 
            // lblPenThickness
            // 
            this.lblPenThickness.AutoSize = true;
            this.lblPenThickness.Location = new System.Drawing.Point(236, 46);
            this.lblPenThickness.Name = "lblPenThickness";
            this.lblPenThickness.Size = new System.Drawing.Size(202, 28);
            this.lblPenThickness.TabIndex = 1;
            this.lblPenThickness.Text = "Espessura da caneta";
            // 
            // lblPenColor
            // 
            this.lblPenColor.AutoSize = true;
            this.lblPenColor.Location = new System.Drawing.Point(22, 46);
            this.lblPenColor.Name = "lblPenColor";
            this.lblPenColor.Size = new System.Drawing.Size(142, 28);
            this.lblPenColor.TabIndex = 0;
            this.lblPenColor.Text = "Cor da caneta";
            // 
            // pnlDrawPad
            // 
            this.pnlDrawPad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDrawPad.AutoSize = true;
            this.pnlDrawPad.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlDrawPad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDrawPad.Location = new System.Drawing.Point(34, 156);
            this.pnlDrawPad.Margin = new System.Windows.Forms.Padding(10);
            this.pnlDrawPad.Name = "pnlDrawPad";
            this.pnlDrawPad.Size = new System.Drawing.Size(1196, 551);
            this.pnlDrawPad.TabIndex = 1;
            this.pnlDrawPad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlDrawPad_MouseDown);
            this.pnlDrawPad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnlDrawPad_MouseMove);
            this.pnlDrawPad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnlDrawPad_MouseUp);
            this.pnlDrawPad.Resize += new System.EventHandler(this.pnlDrawPad_Resize);
            // 
            // FrmDrawingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1267, 759);
            this.Controls.Add(this.pnlDrawPad);
            this.Controls.Add(this.grpControls);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDrawingScreen";
            this.Text = "Paint App Simple";
            this.grpControls.ResumeLayout(false);
            this.grpControls.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox grpControls;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnClean;
		private System.Windows.Forms.Button btnEraser;
		private System.Windows.Forms.ComboBox cmbPenThickness;
		private System.Windows.Forms.Button btnPenColor;
		private System.Windows.Forms.Label lblPenThickness;
		private System.Windows.Forms.Label lblPenColor;
        private System.Windows.Forms.Panel pnlDrawPad;
    }
}

