using System;

namespace Placar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pb_clube2 = new System.Windows.Forms.PictureBox();
            this.lbl_tempo = new System.Windows.Forms.Label();
            this.flamengo = new System.Windows.Forms.Label();
            this.sao_paulo = new System.Windows.Forms.Label();
            this.placar_sp = new System.Windows.Forms.Label();
            this.placar_fla = new System.Windows.Forms.Label();
            this.mais_sp = new System.Windows.Forms.Button();
            this.menos_sp = new System.Windows.Forms.Button();
            this.menos_fla = new System.Windows.Forms.Button();
            this.mais_fla = new System.Windows.Forms.Button();
            this.pb_clube1 = new System.Windows.Forms.PictureBox();
            this.cronometro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube1)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_clube2
            // 
            this.pb_clube2.Image = ((System.Drawing.Image)(resources.GetObject("pb_clube2.Image")));
            this.pb_clube2.Location = new System.Drawing.Point(381, 12);
            this.pb_clube2.Name = "pb_clube2";
            this.pb_clube2.Size = new System.Drawing.Size(150, 150);
            this.pb_clube2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_clube2.TabIndex = 1;
            this.pb_clube2.TabStop = false;
            // 
            // lbl_tempo
            // 
            this.lbl_tempo.AutoSize = true;
            this.lbl_tempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tempo.Location = new System.Drawing.Point(212, 60);
            this.lbl_tempo.Name = "lbl_tempo";
            this.lbl_tempo.Size = new System.Drawing.Size(123, 47);
            this.lbl_tempo.TabIndex = 2;
            this.lbl_tempo.Text = "52:45";
            this.lbl_tempo.Click += new System.EventHandler(this.Cronometro_Tick);
            // 
            // flamengo
            // 
            this.flamengo.AutoSize = true;
            this.flamengo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flamengo.Location = new System.Drawing.Point(29, 188);
            this.flamengo.Name = "flamengo";
            this.flamengo.Size = new System.Drawing.Size(134, 31);
            this.flamengo.TabIndex = 3;
            this.flamengo.Text = "Flamengo";
            // 
            // sao_paulo
            // 
            this.sao_paulo.AutoSize = true;
            this.sao_paulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sao_paulo.Location = new System.Drawing.Point(393, 188);
            this.sao_paulo.Name = "sao_paulo";
            this.sao_paulo.Size = new System.Drawing.Size(138, 31);
            this.sao_paulo.TabIndex = 4;
            this.sao_paulo.Text = "São Paulo";
            // 
            // placar_sp
            // 
            this.placar_sp.AutoSize = true;
            this.placar_sp.BackColor = System.Drawing.Color.White;
            this.placar_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placar_sp.Location = new System.Drawing.Point(436, 247);
            this.placar_sp.Name = "placar_sp";
            this.placar_sp.Size = new System.Drawing.Size(29, 31);
            this.placar_sp.TabIndex = 5;
            this.placar_sp.Text = "0";
            // 
            // placar_fla
            // 
            this.placar_fla.AutoSize = true;
            this.placar_fla.BackColor = System.Drawing.Color.White;
            this.placar_fla.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placar_fla.Location = new System.Drawing.Point(63, 247);
            this.placar_fla.Name = "placar_fla";
            this.placar_fla.Size = new System.Drawing.Size(44, 31);
            this.placar_fla.TabIndex = 6;
            this.placar_fla.Text = "99";
            // 
            // mais_sp
            // 
            this.mais_sp.Location = new System.Drawing.Point(419, 322);
            this.mais_sp.Name = "mais_sp";
            this.mais_sp.Size = new System.Drawing.Size(30, 30);
            this.mais_sp.TabIndex = 7;
            this.mais_sp.Text = "+";
            this.mais_sp.UseVisualStyleBackColor = true;
            this.mais_sp.Click += new System.EventHandler(this.Bt_maissp);
            // 
            // menos_sp
            // 
            this.menos_sp.Location = new System.Drawing.Point(455, 322);
            this.menos_sp.Name = "menos_sp";
            this.menos_sp.Size = new System.Drawing.Size(30, 30);
            this.menos_sp.TabIndex = 8;
            this.menos_sp.Text = "-";
            this.menos_sp.UseVisualStyleBackColor = true;
            this.menos_sp.Click += new System.EventHandler(this.Bt_menossp);
            // 
            // menos_fla
            // 
            this.menos_fla.Location = new System.Drawing.Point(87, 322);
            this.menos_fla.Name = "menos_fla";
            this.menos_fla.Size = new System.Drawing.Size(30, 30);
            this.menos_fla.TabIndex = 9;
            this.menos_fla.Text = "-";
            this.menos_fla.UseVisualStyleBackColor = true;
            this.menos_fla.Click += new System.EventHandler(this.Bt_menosfla);
            // 
            // mais_fla
            // 
            this.mais_fla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mais_fla.Location = new System.Drawing.Point(51, 322);
            this.mais_fla.Name = "mais_fla";
            this.mais_fla.Size = new System.Drawing.Size(30, 30);
            this.mais_fla.TabIndex = 10;
            this.mais_fla.Text = "+";
            this.mais_fla.UseVisualStyleBackColor = true;
            this.mais_fla.Click += new System.EventHandler(this.Button);
            // 
            // pb_clube1
            // 
            this.pb_clube1.Image = ((System.Drawing.Image)(resources.GetObject("pb_clube1.Image")));
            this.pb_clube1.Location = new System.Drawing.Point(12, 12);
            this.pb_clube1.Name = "pb_clube1";
            this.pb_clube1.Size = new System.Drawing.Size(150, 150);
            this.pb_clube1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_clube1.TabIndex = 0;
            this.pb_clube1.TabStop = false;
            // 
            // cronometro
            // 
            this.cronometro.Enabled = true;
            this.cronometro.Interval = 1000;
            this.cronometro.Tick += new System.EventHandler(this.Cronometro_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 382);
            this.Controls.Add(this.mais_fla);
            this.Controls.Add(this.menos_fla);
            this.Controls.Add(this.menos_sp);
            this.Controls.Add(this.mais_sp);
            this.Controls.Add(this.placar_fla);
            this.Controls.Add(this.placar_sp);
            this.Controls.Add(this.sao_paulo);
            this.Controls.Add(this.flamengo);
            this.Controls.Add(this.lbl_tempo);
            this.Controls.Add(this.pb_clube2);
            this.Controls.Add(this.pb_clube1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_clube1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        #endregion
        private System.Windows.Forms.PictureBox pb_clube2;
        private System.Windows.Forms.Label lbl_tempo;
        private System.Windows.Forms.Label flamengo;
        private System.Windows.Forms.Label sao_paulo;
        private System.Windows.Forms.Label placar_sp;
        private System.Windows.Forms.Label placar_fla;
        private System.Windows.Forms.Button mais_sp;
        private System.Windows.Forms.Button menos_sp;
        private System.Windows.Forms.Button menos_fla;
        private System.Windows.Forms.Button mais_fla;
        private System.Windows.Forms.PictureBox pb_clube1;
        private System.Windows.Forms.Timer cronometro;
    }
}

