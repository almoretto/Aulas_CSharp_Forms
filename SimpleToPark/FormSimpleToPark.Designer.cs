namespace SimpleToPark
{
    partial class FormSimpleToPark
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && ( components != null ))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSimpleToPark));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInsertRegister = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.dtgDataView = new System.Windows.Forms.DataGridView();
            this.lblHourValue = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 86.66666F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 595F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1140, 595);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lblTotalValue, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtgDataView, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(155, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.34126F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.658744F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(982, 589);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.lblHourValue, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnInsertRegister, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnConfig, 0, 3);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.906882F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.09312F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(146, 589);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnInsertRegister
            // 
            this.btnInsertRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertRegister.BackColor = System.Drawing.Color.DarkGray;
            this.btnInsertRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertRegister.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnInsertRegister.Location = new System.Drawing.Point(3, 3);
            this.btnInsertRegister.Name = "btnInsertRegister";
            this.btnInsertRegister.Size = new System.Drawing.Size(140, 40);
            this.btnInsertRegister.TabIndex = 0;
            this.btnInsertRegister.Text = "Cadastrar";
            this.btnInsertRegister.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.DarkGray;
            this.btnConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfig.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConfig.Location = new System.Drawing.Point(3, 538);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(140, 48);
            this.btnConfig.TabIndex = 1;
            this.btnConfig.Text = "Configurar";
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalValue.AutoSize = true;
            this.lblTotalValue.Location = new System.Drawing.Point(789, 566);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(190, 23);
            this.lblTotalValue.TabIndex = 0;
            this.lblTotalValue.Text = "Valor total: R$ 0,00";
            this.lblTotalValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtgDataView
            // 
            this.dtgDataView.AllowUserToAddRows = false;
            this.dtgDataView.AllowUserToDeleteRows = false;
            this.dtgDataView.AllowUserToResizeColumns = false;
            this.dtgDataView.AllowUserToResizeRows = false;
            this.dtgDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtgDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDataView.Location = new System.Drawing.Point(3, 3);
            this.dtgDataView.Name = "dtgDataView";
            this.dtgDataView.ReadOnly = true;
            this.dtgDataView.RowHeadersWidth = 51;
            this.dtgDataView.RowTemplate.Height = 24;
            this.dtgDataView.Size = new System.Drawing.Size(976, 532);
            this.dtgDataView.TabIndex = 1;
            // 
            // lblHourValue
            // 
            this.lblHourValue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHourValue.AutoSize = true;
            this.lblHourValue.Location = new System.Drawing.Point(3, 476);
            this.lblHourValue.Name = "lblHourValue";
            this.lblHourValue.Size = new System.Drawing.Size(140, 46);
            this.lblHourValue.TabIndex = 2;
            this.lblHourValue.Text = "Valor Hora: R$ 0,00";
            this.lblHourValue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormSimpleToPark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1154, 619);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormSimpleToPark";
            this.Text = "Simple To Park System";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblTotalValue;
        private System.Windows.Forms.DataGridView dtgDataView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnInsertRegister;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Label lblHourValue;
    }
}

