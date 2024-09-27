namespace primerAppWinForms
{
    partial class Form1
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
            this.add = new System.Windows.Forms.Button();
            this.txtElements = new System.Windows.Forms.TextBox();
            this.lvElements = new System.Windows.Forms.ListView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.cbConformidad = new System.Windows.Forms.CheckBox();
            this.lblPerfilPersona = new System.Windows.Forms.Label();
            this.rbtn1Casado = new System.Windows.Forms.RadioButton();
            this.gbEstadoCivil = new System.Windows.Forms.GroupBox();
            this.rbtn2Soltero = new System.Windows.Forms.RadioButton();
            this.cbSeniority = new System.Windows.Forms.ComboBox();
            this.lblSeniority = new System.Windows.Forms.Label();
            this.numAñosExperiencia = new System.Windows.Forms.NumericUpDown();
            this.lblAñosSeñority = new System.Windows.Forms.Label();
            this.btnVerPerfil = new System.Windows.Forms.Button();
            this.gbEstadoCivil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñosExperiencia)).BeginInit();
            this.SuspendLayout();
            // 
            // add
            // 
            this.add.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.add.BackColor = System.Drawing.Color.LightGray;
            this.add.Location = new System.Drawing.Point(167, 621);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(94, 55);
            this.add.TabIndex = 9;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtElements
            // 
            this.txtElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtElements.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtElements.Location = new System.Drawing.Point(150, 118);
            this.txtElements.Name = "txtElements";
            this.txtElements.Size = new System.Drawing.Size(171, 20);
            this.txtElements.TabIndex = 12;
            // 
            // lvElements
            // 
            this.lvElements.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvElements.CheckBoxes = true;
            this.lvElements.HideSelection = false;
            this.lvElements.Location = new System.Drawing.Point(74, 511);
            this.lvElements.Name = "lvElements";
            this.lvElements.Size = new System.Drawing.Size(278, 104);
            this.lvElements.TabIndex = 8;
            this.lvElements.UseCompatibleStateImageBehavior = false;
            this.lvElements.View = System.Windows.Forms.View.List;
            this.lvElements.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(100, 120);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(44, 13);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Nombre";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(106, 171);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(218, 20);
            this.dtpFechaNacimiento.TabIndex = 0;
            // 
            // cbConformidad
            // 
            this.cbConformidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbConformidad.AutoSize = true;
            this.cbConformidad.Location = new System.Drawing.Point(106, 226);
            this.cbConformidad.Name = "cbConformidad";
            this.cbConformidad.Size = new System.Drawing.Size(205, 17);
            this.cbConformidad.TabIndex = 2;
            this.cbConformidad.Text = "Estas conforme con su salario actual?";
            this.cbConformidad.UseVisualStyleBackColor = true;
            // 
            // lblPerfilPersona
            // 
            this.lblPerfilPersona.AutoSize = true;
            this.lblPerfilPersona.Font = new System.Drawing.Font("Sans Serif Collection", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfilPersona.Location = new System.Drawing.Point(62, 21);
            this.lblPerfilPersona.Name = "lblPerfilPersona";
            this.lblPerfilPersona.Size = new System.Drawing.Size(284, 52);
            this.lblPerfilPersona.TabIndex = 11;
            this.lblPerfilPersona.Text = "Perfil de persona";
            // 
            // rbtn1Casado
            // 
            this.rbtn1Casado.AutoSize = true;
            this.rbtn1Casado.Checked = true;
            this.rbtn1Casado.Location = new System.Drawing.Point(33, 46);
            this.rbtn1Casado.Name = "rbtn1Casado";
            this.rbtn1Casado.Size = new System.Drawing.Size(61, 17);
            this.rbtn1Casado.TabIndex = 0;
            this.rbtn1Casado.TabStop = true;
            this.rbtn1Casado.Text = "Casado";
            this.rbtn1Casado.UseVisualStyleBackColor = true;
            // 
            // gbEstadoCivil
            // 
            this.gbEstadoCivil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbEstadoCivil.Controls.Add(this.rbtn2Soltero);
            this.gbEstadoCivil.Controls.Add(this.rbtn1Casado);
            this.gbEstadoCivil.Location = new System.Drawing.Point(100, 260);
            this.gbEstadoCivil.Name = "gbEstadoCivil";
            this.gbEstadoCivil.Size = new System.Drawing.Size(221, 100);
            this.gbEstadoCivil.TabIndex = 3;
            this.gbEstadoCivil.TabStop = false;
            this.gbEstadoCivil.Text = "Elija una opcion";
            // 
            // rbtn2Soltero
            // 
            this.rbtn2Soltero.AutoSize = true;
            this.rbtn2Soltero.Location = new System.Drawing.Point(123, 46);
            this.rbtn2Soltero.Name = "rbtn2Soltero";
            this.rbtn2Soltero.Size = new System.Drawing.Size(58, 17);
            this.rbtn2Soltero.TabIndex = 1;
            this.rbtn2Soltero.TabStop = true;
            this.rbtn2Soltero.Text = "Soltero";
            this.rbtn2Soltero.UseVisualStyleBackColor = true;
            // 
            // cbSeniority
            // 
            this.cbSeniority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbSeniority.FormattingEnabled = true;
            this.cbSeniority.Location = new System.Drawing.Point(200, 378);
            this.cbSeniority.Name = "cbSeniority";
            this.cbSeniority.Size = new System.Drawing.Size(121, 21);
            this.cbSeniority.TabIndex = 5;
            // 
            // lblSeniority
            // 
            this.lblSeniority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSeniority.AutoSize = true;
            this.lblSeniority.Location = new System.Drawing.Point(105, 381);
            this.lblSeniority.Name = "lblSeniority";
            this.lblSeniority.Size = new System.Drawing.Size(50, 13);
            this.lblSeniority.TabIndex = 5;
            this.lblSeniority.Text = "Seniority:";
            // 
            // numAñosExperiencia
            // 
            this.numAñosExperiencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numAñosExperiencia.Location = new System.Drawing.Point(200, 423);
            this.numAñosExperiencia.Name = "numAñosExperiencia";
            this.numAñosExperiencia.Size = new System.Drawing.Size(120, 20);
            this.numAñosExperiencia.TabIndex = 6;
            // 
            // lblAñosSeñority
            // 
            this.lblAñosSeñority.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAñosSeñority.AutoSize = true;
            this.lblAñosSeñority.Location = new System.Drawing.Point(105, 425);
            this.lblAñosSeñority.Name = "lblAñosSeñority";
            this.lblAñosSeñority.Size = new System.Drawing.Size(92, 13);
            this.lblAñosSeñority.TabIndex = 6;
            this.lblAñosSeñority.Text = "Años Experiencia:";
            // 
            // btnVerPerfil
            // 
            this.btnVerPerfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerPerfil.BackColor = System.Drawing.Color.DarkGray;
            this.btnVerPerfil.Location = new System.Drawing.Point(133, 474);
            this.btnVerPerfil.Name = "btnVerPerfil";
            this.btnVerPerfil.Size = new System.Drawing.Size(156, 23);
            this.btnVerPerfil.TabIndex = 7;
            this.btnVerPerfil.Text = "Ver Resumen de perfil";
            this.btnVerPerfil.UseVisualStyleBackColor = false;
            this.btnVerPerfil.Click += new System.EventHandler(this.btnVerPerfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(510, 684);
            this.Controls.Add(this.btnVerPerfil);
            this.Controls.Add(this.lblAñosSeñority);
            this.Controls.Add(this.numAñosExperiencia);
            this.Controls.Add(this.lblSeniority);
            this.Controls.Add(this.cbSeniority);
            this.Controls.Add(this.gbEstadoCivil);
            this.Controls.Add(this.lblPerfilPersona);
            this.Controls.Add(this.cbConformidad);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lvElements);
            this.Controls.Add(this.txtElements);
            this.Controls.Add(this.add);
            this.MaximumSize = new System.Drawing.Size(1259, 950);
            this.MinimumSize = new System.Drawing.Size(526, 693);
            this.Name = "Form1";
            this.Text = "Formulario Perfil Persona";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbEstadoCivil.ResumeLayout(false);
            this.gbEstadoCivil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAñosExperiencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox txtElements;
        private System.Windows.Forms.ListView lvElements;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.CheckBox cbConformidad;
        private System.Windows.Forms.Label lblPerfilPersona;
        private System.Windows.Forms.RadioButton rbtn1Casado;
        private System.Windows.Forms.GroupBox gbEstadoCivil;
        private System.Windows.Forms.RadioButton rbtn2Soltero;
        private System.Windows.Forms.ComboBox cbSeniority;
        private System.Windows.Forms.Label lblSeniority;
        private System.Windows.Forms.NumericUpDown numAñosExperiencia;
        private System.Windows.Forms.Label lblAñosSeñority;
        private System.Windows.Forms.Button btnVerPerfil;
    }
}

