namespace PrjModulo1
{
    partial class frmMain
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
            if (disposing && (components != null))
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
            this.btnButtonTwo = new System.Windows.Forms.Button();
            this.btnButtonOne = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNameTxtBox = new System.Windows.Forms.Label();
            this.lblNameOut = new System.Windows.Forms.Label();
            this.lblNameList = new System.Windows.Forms.Label();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnButtonTwo
            // 
            this.btnButtonTwo.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButtonTwo.Location = new System.Drawing.Point(421, 32);
            this.btnButtonTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnButtonTwo.Name = "btnButtonTwo";
            this.btnButtonTwo.Size = new System.Drawing.Size(106, 36);
            this.btnButtonTwo.TabIndex = 1;
            this.btnButtonTwo.Text = "Limpar";
            this.btnButtonTwo.UseVisualStyleBackColor = true;
            this.btnButtonTwo.Click += new System.EventHandler(this.btnButtonTwo_Click);
            // 
            // btnButtonOne
            // 
            this.btnButtonOne.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnButtonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButtonOne.Font = new System.Drawing.Font("Calibri", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButtonOne.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnButtonOne.Location = new System.Drawing.Point(302, 32);
            this.btnButtonOne.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnButtonOne.Name = "btnButtonOne";
            this.btnButtonOne.Size = new System.Drawing.Size(111, 34);
            this.btnButtonOne.TabIndex = 0;
            this.btnButtonOne.Text = "Cadastrar";
            this.btnButtonOne.UseVisualStyleBackColor = false;
            this.btnButtonOne.Click += new System.EventHandler(this.btnButtonOne_Click);
            // 
            // lblNome
            // 
            this.lblNome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNome.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lblNome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblNome.Font = new System.Drawing.Font("Bodoni Bd BT", 14.26415F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNome.Location = new System.Drawing.Point(40, 15);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(210, 51);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "André Luís Moretto";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblCopy
            // 
            this.lblCopy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.22642F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.Location = new System.Drawing.Point(39, 66);
            this.lblCopy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(211, 49);
            this.lblCopy.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.AcceptsReturn = true;
            this.txtName.BackColor = System.Drawing.SystemColors.Control;
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(39, 152);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.MaxLength = 100;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(463, 29);
            this.txtName.TabIndex = 4;
            this.txtName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtName_KeyUp);
            this.txtName.Validating += new System.ComponentModel.CancelEventHandler(this.txtName_Validating);
            // 
            // lblNameTxtBox
            // 
            this.lblNameTxtBox.AutoSize = true;
            this.lblNameTxtBox.Location = new System.Drawing.Point(36, 124);
            this.lblNameTxtBox.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameTxtBox.Name = "lblNameTxtBox";
            this.lblNameTxtBox.Size = new System.Drawing.Size(55, 23);
            this.lblNameTxtBox.TabIndex = 5;
            this.lblNameTxtBox.Text = "Name";
            // 
            // lblNameOut
            // 
            this.lblNameOut.AutoSize = true;
            this.lblNameOut.Location = new System.Drawing.Point(40, 190);
            this.lblNameOut.Name = "lblNameOut";
            this.lblNameOut.Size = new System.Drawing.Size(0, 23);
            this.lblNameOut.TabIndex = 6;
            // 
            // lblNameList
            // 
            this.lblNameList.AutoSize = true;
            this.lblNameList.Location = new System.Drawing.Point(35, 223);
            this.lblNameList.Name = "lblNameList";
            this.lblNameList.Size = new System.Drawing.Size(126, 23);
            this.lblNameList.TabIndex = 7;
            this.lblNameList.Text = "Lista de Nomes";
            // 
            // lstNames
            // 
            this.lstNames.BackColor = System.Drawing.SystemColors.Control;
            this.lstNames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 22;
            this.lstNames.Location = new System.Drawing.Point(39, 250);
            this.lstNames.Name = "lstNames";
            this.lstNames.Size = new System.Drawing.Size(463, 156);
            this.lstNames.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 586);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.lblNameList);
            this.Controls.Add(this.lblNameOut);
            this.Controls.Add(this.lblNameTxtBox);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnButtonTwo);
            this.Controls.Add(this.btnButtonOne);
            this.Font = new System.Drawing.Font("Calibri", 12.22642F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Modulo1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnButtonOne;
        private System.Windows.Forms.Button btnButtonTwo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNameTxtBox;
        private System.Windows.Forms.Label lblNameOut;
        private System.Windows.Forms.Label lblNameList;
        private System.Windows.Forms.ListBox lstNames;
    }
}

