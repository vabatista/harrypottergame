namespace HarryPotterGame
{
    partial class InitialForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InitialForm));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.timerLabel = new System.Windows.Forms.Label();
            this.btIniciarJogo = new System.Windows.Forms.Button();
            this.btSortear = new System.Windows.Forms.Button();
            this.txtPergunta = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtEquipe1 = new System.Windows.Forms.Label();
            this.txtEquipe2 = new System.Windows.Forms.Label();
            this.txtPontosEquipe1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPontosEquipe2 = new System.Windows.Forms.TextBox();
            this.txtResposta = new System.Windows.Forms.Label();
            this.imgPergunta = new System.Windows.Forms.PictureBox();
            this.btMostrarResposta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPergunta)).BeginInit();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 60;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(501, 156);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(64, 46);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "60";
            this.timerLabel.Visible = false;
            // 
            // btIniciarJogo
            // 
            this.btIniciarJogo.Location = new System.Drawing.Point(253, 10);
            this.btIniciarJogo.Name = "btIniciarJogo";
            this.btIniciarJogo.Size = new System.Drawing.Size(148, 40);
            this.btIniciarJogo.TabIndex = 1;
            this.btIniciarJogo.Text = "Iniciar Jogo";
            this.btIniciarJogo.UseVisualStyleBackColor = true;
            this.btIniciarJogo.Click += new System.EventHandler(this.btIniciarJogo_Click);
            // 
            // btSortear
            // 
            this.btSortear.Enabled = false;
            this.btSortear.Location = new System.Drawing.Point(429, 9);
            this.btSortear.Name = "btSortear";
            this.btSortear.Size = new System.Drawing.Size(145, 41);
            this.btSortear.TabIndex = 2;
            this.btSortear.Text = "Sortear Pergunta";
            this.btSortear.UseVisualStyleBackColor = true;
            this.btSortear.Click += new System.EventHandler(this.btSortear_Click);
            // 
            // txtPergunta
            // 
            this.txtPergunta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPergunta.Location = new System.Drawing.Point(115, 53);
            this.txtPergunta.Name = "txtPergunta";
            this.txtPergunta.Size = new System.Drawing.Size(881, 104);
            this.txtPergunta.TabIndex = 3;
            this.txtPergunta.Text = "Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla ";
            this.txtPergunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtPergunta.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 205);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(961, 205);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(85, 77);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // txtEquipe1
            // 
            this.txtEquipe1.BackColor = System.Drawing.Color.White;
            this.txtEquipe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipe1.Location = new System.Drawing.Point(12, 285);
            this.txtEquipe1.Name = "txtEquipe1";
            this.txtEquipe1.Size = new System.Drawing.Size(174, 101);
            this.txtEquipe1.TabIndex = 6;
            // 
            // txtEquipe2
            // 
            this.txtEquipe2.BackColor = System.Drawing.Color.White;
            this.txtEquipe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipe2.Location = new System.Drawing.Point(920, 285);
            this.txtEquipe2.Name = "txtEquipe2";
            this.txtEquipe2.Size = new System.Drawing.Size(169, 101);
            this.txtEquipe2.TabIndex = 7;
            // 
            // txtPontosEquipe1
            // 
            this.txtPontosEquipe1.Location = new System.Drawing.Point(47, 481);
            this.txtPontosEquipe1.Name = "txtPontosEquipe1";
            this.txtPontosEquipe1.Size = new System.Drawing.Size(57, 20);
            this.txtPontosEquipe1.TabIndex = 8;
            this.txtPontosEquipe1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 484);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "pontos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1024, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "pontos";
            // 
            // txtPontosEquipe2
            // 
            this.txtPontosEquipe2.Location = new System.Drawing.Point(961, 481);
            this.txtPontosEquipe2.Name = "txtPontosEquipe2";
            this.txtPontosEquipe2.Size = new System.Drawing.Size(57, 20);
            this.txtPontosEquipe2.TabIndex = 10;
            this.txtPontosEquipe2.Text = "0";
            // 
            // txtResposta
            // 
            this.txtResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResposta.Location = new System.Drawing.Point(164, 302);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.Size = new System.Drawing.Size(774, 71);
            this.txtResposta.TabIndex = 12;
            this.txtResposta.Text = "Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla Bla ";
            this.txtResposta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtResposta.Visible = false;
            // 
            // imgPergunta
            // 
            this.imgPergunta.Location = new System.Drawing.Point(211, 205);
            this.imgPergunta.Name = "imgPergunta";
            this.imgPergunta.Size = new System.Drawing.Size(686, 343);
            this.imgPergunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPergunta.TabIndex = 13;
            this.imgPergunta.TabStop = false;
            this.imgPergunta.Visible = false;
            this.imgPergunta.Click += new System.EventHandler(this.imgPergunta_Click);
            // 
            // btMostrarResposta
            // 
            this.btMostrarResposta.Enabled = false;
            this.btMostrarResposta.Location = new System.Drawing.Point(596, 9);
            this.btMostrarResposta.Name = "btMostrarResposta";
            this.btMostrarResposta.Size = new System.Drawing.Size(145, 41);
            this.btMostrarResposta.TabIndex = 14;
            this.btMostrarResposta.Text = "Mostrar Resposta";
            this.btMostrarResposta.UseVisualStyleBackColor = true;
            this.btMostrarResposta.Click += new System.EventHandler(this.btMostrarResposta_Click);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1119, 726);
            this.Controls.Add(this.txtResposta);
            this.Controls.Add(this.btMostrarResposta);
            this.Controls.Add(this.imgPergunta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPontosEquipe2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPontosEquipe1);
            this.Controls.Add(this.txtEquipe2);
            this.Controls.Add(this.txtEquipe1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPergunta);
            this.Controls.Add(this.btSortear);
            this.Controls.Add(this.btIniciarJogo);
            this.Controls.Add(this.timerLabel);
            this.Name = "InitialForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPergunta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button btIniciarJogo;
        private System.Windows.Forms.Button btSortear;
        private System.Windows.Forms.Label txtPergunta;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label txtEquipe1;
        private System.Windows.Forms.Label txtEquipe2;
        private System.Windows.Forms.TextBox txtPontosEquipe1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPontosEquipe2;
        private System.Windows.Forms.Label txtResposta;
        private System.Windows.Forms.PictureBox imgPergunta;
        private System.Windows.Forms.Button btMostrarResposta;
    }
}

