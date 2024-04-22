namespace PokedexWinForms
{
    partial class frmPokedex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPokedex));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pcboxPokemon = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ltboxPoke = new System.Windows.Forms.ListBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnClearPokes = new System.Windows.Forms.Button();
            this.lblCountPoke = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(573, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pcboxPokemon
            // 
            this.pcboxPokemon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcboxPokemon.BackgroundImage")));
            this.pcboxPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcboxPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcboxPokemon.Location = new System.Drawing.Point(64, 140);
            this.pcboxPokemon.Name = "pcboxPokemon";
            this.pcboxPokemon.Size = new System.Drawing.Size(180, 120);
            this.pcboxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pcboxPokemon.TabIndex = 1;
            this.pcboxPokemon.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(340, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 82);
            this.label1.TabIndex = 2;
            this.label1.Text = "TIPO POKEMON";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ltboxPoke
            // 
            this.ltboxPoke.Font = new System.Drawing.Font("Montserrat Medium", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltboxPoke.FormattingEnabled = true;
            this.ltboxPoke.ItemHeight = 21;
            this.ltboxPoke.Location = new System.Drawing.Point(340, 225);
            this.ltboxPoke.Name = "ltboxPoke";
            this.ltboxPoke.Size = new System.Drawing.Size(177, 109);
            this.ltboxPoke.TabIndex = 3;
            this.ltboxPoke.SelectedIndexChanged += new System.EventHandler(this.LtBoxPokeSelectedIndexChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.Color.Teal;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoad.Location = new System.Drawing.Point(430, 352);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(87, 33);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad);
            // 
            // btnClearPokes
            // 
            this.btnClearPokes.BackColor = System.Drawing.Color.Teal;
            this.btnClearPokes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPokes.Font = new System.Drawing.Font("Montserrat Medium", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearPokes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearPokes.Location = new System.Drawing.Point(337, 352);
            this.btnClearPokes.Name = "btnClearPokes";
            this.btnClearPokes.Size = new System.Drawing.Size(87, 33);
            this.btnClearPokes.TabIndex = 5;
            this.btnClearPokes.Text = "Clear";
            this.btnClearPokes.UseVisualStyleBackColor = false;
            this.btnClearPokes.Click += new System.EventHandler(this.BtnClearPokesClick);
            // 
            // lblCountPoke
            // 
            this.lblCountPoke.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.lblCountPoke.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCountPoke.Font = new System.Drawing.Font("Montserrat SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountPoke.ForeColor = System.Drawing.Color.White;
            this.lblCountPoke.Location = new System.Drawing.Point(80, 343);
            this.lblCountPoke.Name = "lblCountPoke";
            this.lblCountPoke.Size = new System.Drawing.Size(101, 46);
            this.lblCountPoke.TabIndex = 6;
            this.lblCountPoke.Text = "0";
            this.lblCountPoke.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmPokedex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 427);
            this.Controls.Add(this.lblCountPoke);
            this.Controls.Add(this.btnClearPokes);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.ltboxPoke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcboxPokemon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPokedex";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcboxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pcboxPokemon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ltboxPoke;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnClearPokes;
        private System.Windows.Forms.Label lblCountPoke;
    }
}

