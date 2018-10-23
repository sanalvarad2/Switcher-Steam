namespace Switcher_Steam
{
    partial class SteamSwitcher
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SteamSwitcher));
            this.btnOpc1 = new System.Windows.Forms.Button();
            this.btnOpc2 = new System.Windows.Forms.Button();
            this.btnOpc3 = new System.Windows.Forms.Button();
            this.btnOpc4 = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.btnOpc5 = new System.Windows.Forms.Button();
            this.btnApp2 = new System.Windows.Forms.Button();
            this.btnApp1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOpc1
            // 
            this.btnOpc1.Location = new System.Drawing.Point(24, 12);
            this.btnOpc1.Name = "btnOpc1";
            this.btnOpc1.Size = new System.Drawing.Size(140, 37);
            this.btnOpc1.TabIndex = 0;
            this.btnOpc1.Text = "1 - CS:GO";
            this.btnOpc1.UseVisualStyleBackColor = true;
            this.btnOpc1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOpc2
            // 
            this.btnOpc2.Location = new System.Drawing.Point(24, 55);
            this.btnOpc2.Name = "btnOpc2";
            this.btnOpc2.Size = new System.Drawing.Size(140, 37);
            this.btnOpc2.TabIndex = 1;
            this.btnOpc2.Text = "2 - Rocket League";
            this.btnOpc2.UseVisualStyleBackColor = true;
            this.btnOpc2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpc3
            // 
            this.btnOpc3.Location = new System.Drawing.Point(24, 98);
            this.btnOpc3.Name = "btnOpc3";
            this.btnOpc3.Size = new System.Drawing.Size(140, 37);
            this.btnOpc3.TabIndex = 2;
            this.btnOpc3.Text = "3 - Shadow of War";
            this.btnOpc3.UseVisualStyleBackColor = true;
            this.btnOpc3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnOpc4
            // 
            this.btnOpc4.Location = new System.Drawing.Point(24, 142);
            this.btnOpc4.Name = "btnOpc4";
            this.btnOpc4.Size = new System.Drawing.Size(140, 37);
            this.btnOpc4.TabIndex = 3;
            this.btnOpc4.Text = "4 - Just Cause 3";
            this.btnOpc4.UseVisualStyleBackColor = true;
            this.btnOpc4.Click += new System.EventHandler(this.button4_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(170, 141);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(140, 37);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Editar";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // btnOpc5
            // 
            this.btnOpc5.Location = new System.Drawing.Point(170, 12);
            this.btnOpc5.Name = "btnOpc5";
            this.btnOpc5.Size = new System.Drawing.Size(140, 37);
            this.btnOpc5.TabIndex = 5;
            this.btnOpc5.Text = "5 - Juego";
            this.btnOpc5.UseVisualStyleBackColor = true;
            this.btnOpc5.Click += new System.EventHandler(this.btnOpc5_Click);
            // 
            // btnApp2
            // 
            this.btnApp2.Location = new System.Drawing.Point(170, 98);
            this.btnApp2.Name = "btnApp2";
            this.btnApp2.Size = new System.Drawing.Size(140, 37);
            this.btnApp2.TabIndex = 6;
            this.btnApp2.Text = "Aplicacion2";
            this.btnApp2.UseVisualStyleBackColor = true;
            this.btnApp2.Click += new System.EventHandler(this.btnApp2_Click);
            // 
            // btnApp1
            // 
            this.btnApp1.Location = new System.Drawing.Point(170, 55);
            this.btnApp1.Name = "btnApp1";
            this.btnApp1.Size = new System.Drawing.Size(140, 37);
            this.btnApp1.TabIndex = 7;
            this.btnApp1.Text = "Aplicacion1";
            this.btnApp1.UseVisualStyleBackColor = true;
            this.btnApp1.Click += new System.EventHandler(this.btnApp1_Click);
            // 
            // SteamSwitcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(332, 191);
            this.Controls.Add(this.btnApp1);
            this.Controls.Add(this.btnApp2);
            this.Controls.Add(this.btnOpc5);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.btnOpc4);
            this.Controls.Add(this.btnOpc3);
            this.Controls.Add(this.btnOpc2);
            this.Controls.Add(this.btnOpc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SteamSwitcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SteamSwitcher";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpc1;
        private System.Windows.Forms.Button btnOpc2;
        private System.Windows.Forms.Button btnOpc3;
        private System.Windows.Forms.Button btnOpc4;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button btnOpc5;
        private System.Windows.Forms.Button btnApp1;
        private System.Windows.Forms.Button btnApp2;
    }
}

