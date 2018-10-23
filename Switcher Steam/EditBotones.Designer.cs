namespace Switcher_Steam
{
    partial class EditBotones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditBotones));
            this.cmbOpcModif = new System.Windows.Forms.ComboBox();
            this.txtIdSteam = new System.Windows.Forms.TextBox();
            this.txtNombreJuego = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.Atras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_open_path = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbOpcModif
            // 
            this.cmbOpcModif.FormattingEnabled = true;
            this.cmbOpcModif.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbOpcModif.Location = new System.Drawing.Point(12, 31);
            this.cmbOpcModif.Name = "cmbOpcModif";
            this.cmbOpcModif.Size = new System.Drawing.Size(121, 21);
            this.cmbOpcModif.Sorted = true;
            this.cmbOpcModif.TabIndex = 0;
            this.cmbOpcModif.Tag = "";
            this.cmbOpcModif.Text = "1";
            this.cmbOpcModif.SelectedIndexChanged += new System.EventHandler(this.cmbOpcModif_SelectedIndexChanged);
            // 
            // txtIdSteam
            // 
            this.txtIdSteam.Location = new System.Drawing.Point(12, 71);
            this.txtIdSteam.Name = "txtIdSteam";
            this.txtIdSteam.Size = new System.Drawing.Size(121, 20);
            this.txtIdSteam.TabIndex = 1;
            this.txtIdSteam.TextChanged += new System.EventHandler(this.txtIdSteam_TextChanged);
            this.txtIdSteam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdSteam_KeyPress);
            // 
            // txtNombreJuego
            // 
            this.txtNombreJuego.Location = new System.Drawing.Point(12, 111);
            this.txtNombreJuego.Name = "txtNombreJuego";
            this.txtNombreJuego.Size = new System.Drawing.Size(100, 20);
            this.txtNombreJuego.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(166, 78);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Atras
            // 
            this.Atras.Location = new System.Drawing.Point(166, 107);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(75, 23);
            this.Atras.TabIndex = 4;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Seleccionar Botón";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(166, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "path";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_open_path
            // 
            this.btn_open_path.Location = new System.Drawing.Point(166, 21);
            this.btn_open_path.Name = "btn_open_path";
            this.btn_open_path.Size = new System.Drawing.Size(75, 23);
            this.btn_open_path.TabIndex = 9;
            this.btn_open_path.Text = "Abrir Ubicacion";
            this.btn_open_path.UseVisualStyleBackColor = true;
            this.btn_open_path.Click += new System.EventHandler(this.btn_open_path_Click);
            // 
            // EditBotones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 143);
            this.Controls.Add(this.btn_open_path);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreJuego);
            this.Controls.Add(this.txtIdSteam);
            this.Controls.Add(this.cmbOpcModif);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditBotones";
            this.Text = "EditBotones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbOpcModif;
        private System.Windows.Forms.TextBox txtIdSteam;
        private System.Windows.Forms.TextBox txtNombreJuego;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_open_path;
    }
}