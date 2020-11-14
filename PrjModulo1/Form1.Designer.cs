namespace PrjModulo1
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // btnButtonTwo
            // 
            this.btnButtonTwo.Location = new System.Drawing.Point(99, 141);
            this.btnButtonTwo.Name = "btnButtonTwo";
            this.btnButtonTwo.Size = new System.Drawing.Size(166, 61);
            this.btnButtonTwo.TabIndex = 1;
            this.btnButtonTwo.Text = "Botão 2";
            this.btnButtonTwo.UseVisualStyleBackColor = true;
            // 
            // btnButtonOne
            // 
            this.btnButtonOne.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnButtonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnButtonOne.Font = new System.Drawing.Font("Century Gothic", 14.26415F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnButtonOne.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnButtonOne.Image = global::PrjModulo1.Properties.Resources.button60;
            this.btnButtonOne.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnButtonOne.Location = new System.Drawing.Point(97, 66);
            this.btnButtonOne.Name = "btnButtonOne";
            this.btnButtonOne.Size = new System.Drawing.Size(169, 60);
            this.btnButtonOne.TabIndex = 0;
            this.btnButtonOne.Text = "Botão";
            this.btnButtonOne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnButtonOne.UseVisualStyleBackColor = false;
            this.btnButtonOne.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 281);
            this.Controls.Add(this.btnButtonTwo);
            this.Controls.Add(this.btnButtonOne);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnButtonOne;
        private System.Windows.Forms.Button btnButtonTwo;
    }
}

