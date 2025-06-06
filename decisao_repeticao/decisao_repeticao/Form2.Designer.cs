namespace decisao_repeticao
{
    partial class Form2
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
            lblNum = new Label();
            inpNum = new TextBox();
            groupBox1 = new GroupBox();
            cbxWhile = new CheckBox();
            cbxDoWhile = new CheckBox();
            cbxFor = new CheckBox();
            btnLimpar = new Button();
            btnCalcular = new Button();
            lbxTabuada = new ListBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.Location = new Point(45, 56);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(51, 15);
            lblNum.TabIndex = 0;
            lblNum.Text = "Número";
            // 
            // inpNum
            // 
            inpNum.Location = new Point(102, 53);
            inpNum.Name = "inpNum";
            inpNum.Size = new Size(111, 23);
            inpNum.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbxWhile);
            groupBox1.Controls.Add(cbxDoWhile);
            groupBox1.Controls.Add(cbxFor);
            groupBox1.Location = new Point(45, 98);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 156);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Escolha";
            // 
            // cbxWhile
            // 
            cbxWhile.Anchor = AnchorStyles.Left;
            cbxWhile.AutoSize = true;
            cbxWhile.Location = new Point(20, 106);
            cbxWhile.Name = "cbxWhile";
            cbxWhile.Size = new Size(56, 19);
            cbxWhile.TabIndex = 5;
            cbxWhile.Text = "While";
            cbxWhile.UseVisualStyleBackColor = true;
            cbxWhile.CheckedChanged += cbxWhile_CheckedChanged;
            // 
            // cbxDoWhile
            // 
            cbxDoWhile.Anchor = AnchorStyles.Left;
            cbxDoWhile.AutoSize = true;
            cbxDoWhile.Location = new Point(20, 72);
            cbxDoWhile.Name = "cbxDoWhile";
            cbxDoWhile.Size = new Size(74, 19);
            cbxDoWhile.TabIndex = 4;
            cbxDoWhile.Text = "Do While";
            cbxDoWhile.UseVisualStyleBackColor = true;
            cbxDoWhile.CheckedChanged += cbxDoWhile_CheckedChanged;
            // 
            // cbxFor
            // 
            cbxFor.Anchor = AnchorStyles.Left;
            cbxFor.AutoSize = true;
            cbxFor.Location = new Point(20, 37);
            cbxFor.Name = "cbxFor";
            cbxFor.Size = new Size(43, 19);
            cbxFor.TabIndex = 3;
            cbxFor.Text = "For";
            cbxFor.UseVisualStyleBackColor = true;
            cbxFor.CheckedChanged += cbxFor_CheckedChanged;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(45, 274);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(113, 37);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(45, 327);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(113, 37);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lbxTabuada
            // 
            lbxTabuada.FormattingEnabled = true;
            lbxTabuada.ItemHeight = 15;
            lbxTabuada.Location = new Point(241, 53);
            lbxTabuada.Name = "lbxTabuada";
            lbxTabuada.Size = new Size(185, 319);
            lbxTabuada.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(470, 425);
            Controls.Add(lbxTabuada);
            Controls.Add(btnCalcular);
            Controls.Add(btnLimpar);
            Controls.Add(groupBox1);
            Controls.Add(inpNum);
            Controls.Add(lblNum);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum;
        private TextBox inpNum;
        private GroupBox groupBox1;
        private CheckBox cbxWhile;
        private CheckBox cbxDoWhile;
        private CheckBox cbxFor;
        private Button btnLimpar;
        private Button btnCalcular;
        private ListBox lbxTabuada;
    }
}