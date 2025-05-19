namespace TicTacToe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pibReiniciar = new System.Windows.Forms.PictureBox();
            this.pibFechar = new System.Windows.Forms.PictureBox();
            this.pibFundo = new System.Windows.Forms.PictureBox();
            this.pibLogo = new System.Windows.Forms.PictureBox();
            this.btn11 = new System.Windows.Forms.Button();
            this.btn12 = new System.Windows.Forms.Button();
            this.btn13 = new System.Windows.Forms.Button();
            this.btn21 = new System.Windows.Forms.Button();
            this.btn22 = new System.Windows.Forms.Button();
            this.btn23 = new System.Windows.Forms.Button();
            this.btn31 = new System.Windows.Forms.Button();
            this.btn32 = new System.Windows.Forms.Button();
            this.btn33 = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pibReiniciar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pibReiniciar
            // 
            this.pibReiniciar.Image = global::TicTacToe.Properties.Resources.reload;
            this.pibReiniciar.Location = new System.Drawing.Point(420, 592);
            this.pibReiniciar.Name = "pibReiniciar";
            this.pibReiniciar.Size = new System.Drawing.Size(89, 81);
            this.pibReiniciar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibReiniciar.TabIndex = 3;
            this.pibReiniciar.TabStop = false;
            // 
            // pibFechar
            // 
            this.pibFechar.Image = global::TicTacToe.Properties.Resources.delete;
            this.pibFechar.Location = new System.Drawing.Point(481, 3);
            this.pibFechar.Name = "pibFechar";
            this.pibFechar.Size = new System.Drawing.Size(44, 43);
            this.pibFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibFechar.TabIndex = 2;
            this.pibFechar.TabStop = false;
            this.pibFechar.Click += new System.EventHandler(this.pibFechar_Click);
            // 
            // pibFundo
            // 
            this.pibFundo.Image = global::TicTacToe.Properties.Resources._tictactoe;
            this.pibFundo.Location = new System.Drawing.Point(27, 105);
            this.pibFundo.Name = "pibFundo";
            this.pibFundo.Size = new System.Drawing.Size(482, 473);
            this.pibFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibFundo.TabIndex = 1;
            this.pibFundo.TabStop = false;
            // 
            // pibLogo
            // 
            this.pibLogo.Image = global::TicTacToe.Properties.Resources.tttmarqlrg;
            this.pibLogo.Location = new System.Drawing.Point(27, 12);
            this.pibLogo.Name = "pibLogo";
            this.pibLogo.Size = new System.Drawing.Size(482, 87);
            this.pibLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pibLogo.TabIndex = 0;
            this.pibLogo.TabStop = false;
            // 
            // btn11
            // 
            this.btn11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn11.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn11.Location = new System.Drawing.Point(68, 153);
            this.btn11.Name = "btn11";
            this.btn11.Size = new System.Drawing.Size(103, 95);
            this.btn11.TabIndex = 4;
            this.btn11.UseVisualStyleBackColor = true;
            // 
            // btn12
            // 
            this.btn12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn12.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn12.Location = new System.Drawing.Point(215, 153);
            this.btn12.Name = "btn12";
            this.btn12.Size = new System.Drawing.Size(103, 95);
            this.btn12.TabIndex = 5;
            this.btn12.UseVisualStyleBackColor = true;
            // 
            // btn13
            // 
            this.btn13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn13.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn13.Location = new System.Drawing.Point(362, 153);
            this.btn13.Name = "btn13";
            this.btn13.Size = new System.Drawing.Size(103, 95);
            this.btn13.TabIndex = 6;
            this.btn13.UseVisualStyleBackColor = true;
            // 
            // btn21
            // 
            this.btn21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn21.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn21.Location = new System.Drawing.Point(68, 298);
            this.btn21.Name = "btn21";
            this.btn21.Size = new System.Drawing.Size(103, 95);
            this.btn21.TabIndex = 7;
            this.btn21.UseVisualStyleBackColor = true;
            // 
            // btn22
            // 
            this.btn22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn22.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn22.Location = new System.Drawing.Point(216, 299);
            this.btn22.Name = "btn22";
            this.btn22.Size = new System.Drawing.Size(103, 95);
            this.btn22.TabIndex = 8;
            this.btn22.UseVisualStyleBackColor = true;
            // 
            // btn23
            // 
            this.btn23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn23.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn23.Location = new System.Drawing.Point(362, 299);
            this.btn23.Name = "btn23";
            this.btn23.Size = new System.Drawing.Size(103, 95);
            this.btn23.TabIndex = 9;
            this.btn23.UseVisualStyleBackColor = true;
            // 
            // btn31
            // 
            this.btn31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn31.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn31.Location = new System.Drawing.Point(68, 440);
            this.btn31.Name = "btn31";
            this.btn31.Size = new System.Drawing.Size(103, 95);
            this.btn31.TabIndex = 10;
            this.btn31.UseVisualStyleBackColor = true;
            // 
            // btn32
            // 
            this.btn32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn32.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn32.Location = new System.Drawing.Point(215, 440);
            this.btn32.Name = "btn32";
            this.btn32.Size = new System.Drawing.Size(103, 95);
            this.btn32.TabIndex = 11;
            this.btn32.UseVisualStyleBackColor = true;
            // 
            // btn33
            // 
            this.btn33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn33.Font = new System.Drawing.Font("Comic Sans MS", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn33.Location = new System.Drawing.Point(362, 440);
            this.btn33.Name = "btn33";
            this.btn33.Size = new System.Drawing.Size(103, 95);
            this.btn33.TabIndex = 12;
            this.btn33.UseVisualStyleBackColor = true;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(27, 596);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(304, 67);
            this.lblInfo.TabIndex = 13;
            this.lblInfo.Text = "É a vez do X";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(537, 693);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btn33);
            this.Controls.Add(this.btn32);
            this.Controls.Add(this.btn31);
            this.Controls.Add(this.btn23);
            this.Controls.Add(this.btn22);
            this.Controls.Add(this.btn21);
            this.Controls.Add(this.btn13);
            this.Controls.Add(this.btn12);
            this.Controls.Add(this.btn11);
            this.Controls.Add(this.pibReiniciar);
            this.Controls.Add(this.pibFechar);
            this.Controls.Add(this.pibFundo);
            this.Controls.Add(this.pibLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            ((System.ComponentModel.ISupportInitialize)(this.pibReiniciar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pibLogo;
        private System.Windows.Forms.PictureBox pibFundo;
        private System.Windows.Forms.PictureBox pibFechar;
        private System.Windows.Forms.PictureBox pibReiniciar;
        private System.Windows.Forms.Button btn11;
        private System.Windows.Forms.Button btn12;
        private System.Windows.Forms.Button btn13;
        private System.Windows.Forms.Button btn21;
        private System.Windows.Forms.Button btn22;
        private System.Windows.Forms.Button btn23;
        private System.Windows.Forms.Button btn31;
        private System.Windows.Forms.Button btn32;
        private System.Windows.Forms.Button btn33;
        private System.Windows.Forms.Label lblInfo;
    }
}

