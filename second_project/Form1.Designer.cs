namespace second_project
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblName = new Label();
            inpName = new TextBox();
            lblCelular = new Label();
            lblEmail = new Label();
            inpEmail = new TextBox();
            maskedTextBox1 = new MaskedTextBox();
            lblDtNasc = new Label();
            inpCalendar = new MonthCalendar();
            lblUF = new Label();
            inpLogo = new PictureBox();
            btnCadastro = new Button();
            btnCancel = new Button();
            pnlMain = new Panel();
            selectUF = new ComboBox();
            groupBox1 = new GroupBox();
            lblTitle = new Label();
            lblFoto = new Label();
            btnUpload = new Button();
            ((System.ComponentModel.ISupportInitialize)inpLogo).BeginInit();
            pnlMain.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(192, 129);
            lblName.Name = "lblName";
            lblName.Size = new Size(43, 15);
            lblName.TabIndex = 0;
            lblName.Text = "Nome:";
            // 
            // inpName
            // 
            inpName.Location = new Point(241, 126);
            inpName.Name = "inpName";
            inpName.Size = new Size(260, 23);
            inpName.TabIndex = 1;
            // 
            // lblCelular
            // 
            lblCelular.AutoSize = true;
            lblCelular.Location = new Point(188, 158);
            lblCelular.Name = "lblCelular";
            lblCelular.Size = new Size(47, 15);
            lblCelular.TabIndex = 2;
            lblCelular.Text = "Celular:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(191, 187);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(44, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "E-mail:";
            // 
            // inpEmail
            // 
            inpEmail.Location = new Point(241, 184);
            inpEmail.Name = "inpEmail";
            inpEmail.Size = new Size(260, 23);
            inpEmail.TabIndex = 5;
            inpEmail.TextChanged += textBox1_TextChanged;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(241, 155);
            maskedTextBox1.Mask = "(00) 00000-0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(103, 23);
            maskedTextBox1.TabIndex = 6;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // lblDtNasc
            // 
            lblDtNasc.AutoSize = true;
            lblDtNasc.Location = new Point(120, 215);
            lblDtNasc.Name = "lblDtNasc";
            lblDtNasc.Size = new Size(115, 15);
            lblDtNasc.TabIndex = 7;
            lblDtNasc.Text = "Data de nascimento:";
            // 
            // inpCalendar
            // 
            inpCalendar.Location = new Point(241, 215);
            inpCalendar.Name = "inpCalendar";
            inpCalendar.TabIndex = 8;
            inpCalendar.DateChanged += inpCalendar_DateChanged;
            // 
            // lblUF
            // 
            lblUF.AutoSize = true;
            lblUF.Location = new Point(531, 215);
            lblUF.Name = "lblUF";
            lblUF.Size = new Size(24, 15);
            lblUF.TabIndex = 10;
            lblUF.Text = "UF:";
            // 
            // inpLogo
            // 
            inpLogo.Dock = DockStyle.Fill;
            inpLogo.Location = new Point(3, 19);
            inpLogo.Name = "inpLogo";
            inpLogo.Size = new Size(114, 58);
            inpLogo.TabIndex = 11;
            inpLogo.TabStop = false;
            inpLogo.Click += inpLogo_Click;
            // 
            // btnCadastro
            // 
            btnCadastro.BackColor = Color.FromArgb(128, 255, 128);
            btnCadastro.FlatStyle = FlatStyle.Flat;
            btnCadastro.ForeColor = SystemColors.ControlText;
            btnCadastro.Location = new Point(590, 360);
            btnCadastro.Name = "btnCadastro";
            btnCadastro.Size = new Size(91, 34);
            btnCadastro.TabIndex = 12;
            btnCadastro.Text = "Cadastrar";
            btnCadastro.UseVisualStyleBackColor = false;
            btnCadastro.Click += btnCadastro_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(493, 360);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(91, 34);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancelar";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.Transparent;
            pnlMain.Controls.Add(selectUF);
            pnlMain.Controls.Add(groupBox1);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(lblFoto);
            pnlMain.Controls.Add(btnUpload);
            pnlMain.Controls.Add(btnCancel);
            pnlMain.Controls.Add(btnCadastro);
            pnlMain.Controls.Add(lblName);
            pnlMain.Controls.Add(lblUF);
            pnlMain.Controls.Add(inpName);
            pnlMain.Controls.Add(lblCelular);
            pnlMain.Controls.Add(inpCalendar);
            pnlMain.Controls.Add(lblEmail);
            pnlMain.Controls.Add(lblDtNasc);
            pnlMain.Controls.Add(inpEmail);
            pnlMain.Controls.Add(maskedTextBox1);
            pnlMain.Location = new Point(1, 1);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 450);
            pnlMain.TabIndex = 0;
            // 
            // selectUF
            // 
            selectUF.FormattingEnabled = true;
            selectUF.Items.AddRange(new object[] { "SC", "SP", "RS", "PR" });
            selectUF.Location = new Point(557, 215);
            selectUF.Name = "selectUF";
            selectUF.Size = new Size(121, 23);
            selectUF.TabIndex = 18;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inpLogo);
            groupBox1.Location = new Point(561, 126);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(120, 80);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Perfil";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(226, 57);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(349, 45);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Formulário de cadastro";
            // 
            // lblFoto
            // 
            lblFoto.AutoSize = true;
            lblFoto.Location = new Point(521, 126);
            lblFoto.Name = "lblFoto";
            lblFoto.Size = new Size(34, 15);
            lblFoto.TabIndex = 15;
            lblFoto.Text = "Foto:";
            // 
            // btnUpload
            // 
            btnUpload.Image = Properties.Resources.img2_upload;
            btnUpload.Location = new Point(507, 144);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(48, 47);
            btnUpload.TabIndex = 14;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulário de cadastro";
            ((System.ComponentModel.ISupportInitialize)inpLogo).EndInit();
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblName;
        private TextBox inpName;
        private Label lblCelular;
        private Label lblEmail;
        private TextBox inpEmail;
        private MaskedTextBox maskedTextBox1;
        private Label lblDtNasc;
        private MonthCalendar inpCalendar;
        private Label lblUF;
        private PictureBox inpLogo;
        private Button btnCadastro;
        private Button btnCancel;
        private Panel pnlMain;
        private Button btnUpload;
        private Label lblFoto;
        private Label lblTitle;
        private GroupBox groupBox1;
        private ComboBox selectUF;
    }
}
