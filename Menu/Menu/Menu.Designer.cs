﻿
namespace Menu
{
    partial class Menu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.play = new System.Windows.Forms.Button();
            this.options = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.customize = new System.Windows.Forms.Button();
            this.difficulty = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.endless = new System.Windows.Forms.Button();
            this.challenge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // play
            // 
            this.play.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.play.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(396, 334);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(267, 65);
            this.play.TabIndex = 0;
            this.play.Text = "Classic ";
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.ClassicPlay);
            this.play.MouseEnter += new System.EventHandler(this.play_MouseEnter);
            this.play.MouseLeave += new System.EventHandler(this.play_MouseLeave);
            // 
            // options
            // 
            this.options.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.options.BackColor = System.Drawing.Color.Transparent;
            this.options.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.options.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.options.FlatAppearance.BorderSize = 0;
            this.options.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.options.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.options.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.options.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.options.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.options.ForeColor = System.Drawing.Color.White;
            this.options.Location = new System.Drawing.Point(396, 620);
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(267, 65);
            this.options.TabIndex = 1;
            this.options.Text = "Options";
            this.options.UseVisualStyleBackColor = false;
            this.options.Click += new System.EventHandler(this.options_Click_1);
            this.options.MouseEnter += new System.EventHandler(this.options_MouseEnter);
            this.options.MouseLeave += new System.EventHandler(this.options_MouseLeave);
            // 
            // exit
            // 
            this.exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.Location = new System.Drawing.Point(396, 678);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(267, 65);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            this.exit.MouseEnter += new System.EventHandler(this.exit_MouseEnter);
            this.exit.MouseLeave += new System.EventHandler(this.exit_MouseLeave);
            // 
            // customize
            // 
            this.customize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.customize.BackColor = System.Drawing.Color.Transparent;
            this.customize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.customize.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.customize.FlatAppearance.BorderSize = 0;
            this.customize.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.customize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.customize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.customize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customize.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.customize.ForeColor = System.Drawing.Color.White;
            this.customize.Location = new System.Drawing.Point(396, 563);
            this.customize.Name = "customize";
            this.customize.Size = new System.Drawing.Size(267, 65);
            this.customize.TabIndex = 3;
            this.customize.Text = "Customize";
            this.customize.UseVisualStyleBackColor = false;
            this.customize.Click += new System.EventHandler(this.customize_Click);
            this.customize.MouseEnter += new System.EventHandler(this.customize_MouseEnter);
            this.customize.MouseLeave += new System.EventHandler(this.customize_MouseLeave);
            // 
            // difficulty
            // 
            this.difficulty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difficulty.BackColor = System.Drawing.Color.Transparent;
            this.difficulty.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.difficulty.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.difficulty.FlatAppearance.BorderSize = 0;
            this.difficulty.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.difficulty.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.difficulty.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.difficulty.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.difficulty.ForeColor = System.Drawing.Color.White;
            this.difficulty.Location = new System.Drawing.Point(396, 505);
            this.difficulty.Name = "difficulty";
            this.difficulty.Size = new System.Drawing.Size(267, 65);
            this.difficulty.TabIndex = 4;
            this.difficulty.Text = "Difficulty";
            this.difficulty.UseVisualStyleBackColor = false;
            this.difficulty.Click += new System.EventHandler(this.difficulty_Click);
            this.difficulty.MouseEnter += new System.EventHandler(this.difficulty_MouseEnter);
            this.difficulty.MouseLeave += new System.EventHandler(this.difficulty_MouseLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(318, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 73);
            this.label2.TabIndex = 6;
            this.label2.Text = "Snake game";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // endless
            // 
            this.endless.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endless.BackColor = System.Drawing.Color.Transparent;
            this.endless.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.endless.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.endless.FlatAppearance.BorderSize = 0;
            this.endless.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.endless.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.endless.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.endless.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endless.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.endless.ForeColor = System.Drawing.Color.White;
            this.endless.Location = new System.Drawing.Point(396, 392);
            this.endless.Name = "endless";
            this.endless.Size = new System.Drawing.Size(267, 65);
            this.endless.TabIndex = 7;
            this.endless.Text = "Endless";
            this.endless.UseVisualStyleBackColor = false;
            this.endless.Click += new System.EventHandler(this.endless_Click);
            this.endless.MouseEnter += new System.EventHandler(this.endless_MouseEnter);
            this.endless.MouseLeave += new System.EventHandler(this.endless_MouseLeave);
            // 
            // challenge
            // 
            this.challenge.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.challenge.BackColor = System.Drawing.Color.Transparent;
            this.challenge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.challenge.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.challenge.FlatAppearance.BorderSize = 0;
            this.challenge.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.challenge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.challenge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.challenge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.challenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.challenge.ForeColor = System.Drawing.Color.White;
            this.challenge.Location = new System.Drawing.Point(396, 447);
            this.challenge.Name = "challenge";
            this.challenge.Size = new System.Drawing.Size(267, 65);
            this.challenge.TabIndex = 8;
            this.challenge.Text = "Challenge";
            this.challenge.UseVisualStyleBackColor = false;
            this.challenge.Click += new System.EventHandler(this.challenge_Click);
            this.challenge.MouseEnter += new System.EventHandler(this.challenge_MouseEnter);
            this.challenge.MouseLeave += new System.EventHandler(this.challenge_MouseLeave);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::Menu.Properties.Resources.asd;
            this.ClientSize = new System.Drawing.Size(1076, 879);
            this.Controls.Add(this.challenge);
            this.Controls.Add(this.endless);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.difficulty);
            this.Controls.Add(this.customize);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.options);
            this.Controls.Add(this.play);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button options;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button customize;
        private System.Windows.Forms.Button difficulty;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button endless;
        private System.Windows.Forms.Button challenge;
    }
}

