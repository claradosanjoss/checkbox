namespace ImagemProjeto
{
    partial class OutrofForm
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
            this.img1 = new System.Windows.Forms.RadioButton();
            this.img2 = new System.Windows.Forms.RadioButton();
            this.img3 = new System.Windows.Forms.RadioButton();
            this.semborda = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pcb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).BeginInit();
            this.SuspendLayout();
            // 
            // img1
            // 
            this.img1.AutoSize = true;
            this.img1.Location = new System.Drawing.Point(34, 280);
            this.img1.Name = "img1";
            this.img1.Size = new System.Drawing.Size(71, 17);
            this.img1.TabIndex = 0;
            this.img1.TabStop = true;
            this.img1.Text = "Imagem 1";
            this.img1.UseVisualStyleBackColor = true;
            this.img1.CheckedChanged += new System.EventHandler(this.img1_CheckedChanged);
            // 
            // img2
            // 
            this.img2.AutoSize = true;
            this.img2.Location = new System.Drawing.Point(34, 333);
            this.img2.Name = "img2";
            this.img2.Size = new System.Drawing.Size(71, 17);
            this.img2.TabIndex = 1;
            this.img2.TabStop = true;
            this.img2.Text = "Imagem 2";
            this.img2.UseVisualStyleBackColor = true;
            this.img2.CheckedChanged += new System.EventHandler(this.img2_CheckedChanged);
            // 
            // img3
            // 
            this.img3.AutoSize = true;
            this.img3.Location = new System.Drawing.Point(34, 394);
            this.img3.Name = "img3";
            this.img3.Size = new System.Drawing.Size(86, 17);
            this.img3.TabIndex = 2;
            this.img3.TabStop = true;
            this.img3.Text = "Sem Imagem";
            this.img3.UseVisualStyleBackColor = true;
            this.img3.CheckedChanged += new System.EventHandler(this.img3_CheckedChanged);
            // 
            // semborda
            // 
            this.semborda.AutoSize = true;
            this.semborda.Location = new System.Drawing.Point(239, 280);
            this.semborda.Name = "semborda";
            this.semborda.Size = new System.Drawing.Size(76, 17);
            this.semborda.TabIndex = 3;
            this.semborda.TabStop = true;
            this.semborda.Text = "Sem borda";
            this.semborda.UseVisualStyleBackColor = true;
            this.semborda.CheckedChanged += new System.EventHandler(this.semborda_CheckedChanged);
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(239, 333);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(83, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Fixa Simples";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(239, 394);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(39, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "3D";
            this.radioButton6.UseVisualStyleBackColor = true;
            this.radioButton6.CheckedChanged += new System.EventHandler(this.radioButton6_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(470, 281);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(141, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Imagem visível/invisível";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Firebrick;
            this.button1.Location = new System.Drawing.Point(470, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pcb
            // 
            this.pcb.Image = global::ImagemProjeto.Properties.Resources.meninaesquisita;
            this.pcb.Location = new System.Drawing.Point(172, 15);
            this.pcb.Name = "pcb";
            this.pcb.Size = new System.Drawing.Size(353, 259);
            this.pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb.TabIndex = 8;
            this.pcb.TabStop = false;
            // 
            // OutrofForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 571);
            this.Controls.Add(this.pcb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.radioButton6);
            this.Controls.Add(this.radioButton5);
            this.Controls.Add(this.semborda);
            this.Controls.Add(this.img3);
            this.Controls.Add(this.img2);
            this.Controls.Add(this.img1);
            this.Name = "OutrofForm";
            this.Text = "RadioButton, CheckBox e PictureBox";
            this.Load += new System.EventHandler(this.OutrofForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton img1;
        private System.Windows.Forms.RadioButton img2;
        private System.Windows.Forms.RadioButton img3;
        private System.Windows.Forms.RadioButton semborda;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pcb;
    }
}

