namespace TP02
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rouge = new System.Windows.Forms.Button();
            this.vert = new System.Windows.Forms.Button();
            this.jaune = new System.Windows.Forms.Button();
            this.bleur = new System.Windows.Forms.Button();
            this.gris = new System.Windows.Forms.Button();
            this.scrollertaille = new System.Windows.Forms.TrackBar();
            this.black = new System.Windows.Forms.Button();
            this.white = new System.Windows.Forms.Button();
            this.lookForColor = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scrollertaille)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rouge);
            this.flowLayoutPanel1.Controls.Add(this.vert);
            this.flowLayoutPanel1.Controls.Add(this.jaune);
            this.flowLayoutPanel1.Controls.Add(this.bleur);
            this.flowLayoutPanel1.Controls.Add(this.gris);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(425, 28);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // rouge
            // 
            this.rouge.BackColor = System.Drawing.Color.Red;
            this.rouge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rouge.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rouge.ForeColor = System.Drawing.SystemColors.Control;
            this.rouge.Location = new System.Drawing.Point(3, 3);
            this.rouge.Name = "rouge";
            this.rouge.Size = new System.Drawing.Size(75, 23);
            this.rouge.TabIndex = 0;
            this.rouge.Text = "rouge";
            this.rouge.UseVisualStyleBackColor = false;
            this.rouge.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rouge_MouseDown);
            // 
            // vert
            // 
            this.vert.BackColor = System.Drawing.Color.Green;
            this.vert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vert.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vert.ForeColor = System.Drawing.SystemColors.Control;
            this.vert.Location = new System.Drawing.Point(84, 3);
            this.vert.Name = "vert";
            this.vert.Size = new System.Drawing.Size(75, 23);
            this.vert.TabIndex = 1;
            this.vert.Text = "vert";
            this.vert.UseVisualStyleBackColor = false;
            this.vert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button1_MouseDown);
            // 
            // jaune
            // 
            this.jaune.BackColor = System.Drawing.Color.Yellow;
            this.jaune.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.jaune.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.jaune.ForeColor = System.Drawing.SystemColors.Control;
            this.jaune.Location = new System.Drawing.Point(165, 3);
            this.jaune.Name = "jaune";
            this.jaune.Size = new System.Drawing.Size(75, 23);
            this.jaune.TabIndex = 2;
            this.jaune.Text = "jaune";
            this.jaune.UseVisualStyleBackColor = false;
            this.jaune.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button2_MouseDown);
            // 
            // bleur
            // 
            this.bleur.BackColor = System.Drawing.Color.Blue;
            this.bleur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bleur.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bleur.ForeColor = System.Drawing.SystemColors.Control;
            this.bleur.Location = new System.Drawing.Point(246, 3);
            this.bleur.Name = "bleur";
            this.bleur.Size = new System.Drawing.Size(75, 23);
            this.bleur.TabIndex = 3;
            this.bleur.Text = "bleu";
            this.bleur.UseVisualStyleBackColor = false;
            this.bleur.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button3_MouseDown);
            // 
            // gris
            // 
            this.gris.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gris.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gris.ForeColor = System.Drawing.SystemColors.Control;
            this.gris.Location = new System.Drawing.Point(327, 3);
            this.gris.Name = "gris";
            this.gris.Size = new System.Drawing.Size(75, 23);
            this.gris.TabIndex = 4;
            this.gris.Text = "gris";
            this.gris.UseVisualStyleBackColor = false;
            this.gris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button4_MouseDown);
            // 
            // scrollertaille
            // 
            this.scrollertaille.LargeChange = 3;
            this.scrollertaille.Location = new System.Drawing.Point(13, 45);
            this.scrollertaille.Minimum = 1;
            this.scrollertaille.Name = "scrollertaille";
            this.scrollertaille.Size = new System.Drawing.Size(165, 45);
            this.scrollertaille.TabIndex = 1;
            this.scrollertaille.Value = 1;
            this.scrollertaille.Scroll += new System.EventHandler(this.Scroll);
            // 
            // black
            // 
            this.black.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.black.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.black.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.black.ForeColor = System.Drawing.SystemColors.Control;
            this.black.Location = new System.Drawing.Point(84, 3);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(75, 23);
            this.black.TabIndex = 5;
            this.black.Text = "noire";
            this.black.UseVisualStyleBackColor = false;
            this.black.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button5_MouseDown);
            // 
            // white
            // 
            this.white.BackColor = System.Drawing.Color.White;
            this.white.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.white.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.white.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.white.Location = new System.Drawing.Point(3, 3);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(75, 23);
            this.white.TabIndex = 6;
            this.white.Text = "blanc";
            this.white.UseVisualStyleBackColor = false;
            this.white.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button6_MouseDown);
            // 
            // lookForColor
            // 
            this.lookForColor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lookForColor.Font = new System.Drawing.Font("Marlett", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookForColor.ForeColor = System.Drawing.SystemColors.Control;
            this.lookForColor.Location = new System.Drawing.Point(480, 15);
            this.lookForColor.Name = "lookForColor";
            this.lookForColor.Size = new System.Drawing.Size(75, 23);
            this.lookForColor.TabIndex = 8;
            this.lookForColor.Text = "recherche";
            this.lookForColor.UseVisualStyleBackColor = false;
            this.lookForColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button8_MouseDown);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.white);
            this.flowLayoutPanel2.Controls.Add(this.black);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(628, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(163, 28);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.scrollertaille);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lookForColor);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.draw_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.draw_MouseMove);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scrollertaille)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar scrollertaille;
        private System.Windows.Forms.Button rouge;
        private System.Windows.Forms.Button vert;
        private System.Windows.Forms.Button jaune;
        private System.Windows.Forms.Button bleur;
        private System.Windows.Forms.Button gris;
        private System.Windows.Forms.Button black;
        private System.Windows.Forms.Button white;
        private System.Windows.Forms.Button lookForColor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}

