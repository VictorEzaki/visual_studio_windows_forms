namespace second_project
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
            lblIniciar = new Label();
            inpInicial = new TextBox();
            inpFinal = new TextBox();
            lblFinal = new Label();
            ltbLista = new ListBox();
            btnLimpar = new Button();
            btnSair = new Button();
            btnLimites = new Button();
            SuspendLayout();
            // 
            // lblIniciar
            // 
            lblIniciar.AutoSize = true;
            lblIniciar.Location = new Point(326, 100);
            lblIniciar.Name = "lblIniciar";
            lblIniciar.Size = new Size(41, 15);
            lblIniciar.TabIndex = 0;
            lblIniciar.Text = "Inicial:";
            // 
            // inpInicial
            // 
            inpInicial.Location = new Point(373, 97);
            inpInicial.Name = "inpInicial";
            inpInicial.Size = new Size(100, 23);
            inpInicial.TabIndex = 1;
            // 
            // inpFinal
            // 
            inpFinal.Location = new Point(373, 141);
            inpFinal.Name = "inpFinal";
            inpFinal.Size = new Size(100, 23);
            inpFinal.TabIndex = 3;
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(332, 144);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(35, 15);
            lblFinal.TabIndex = 2;
            lblFinal.Text = "Final:";
            // 
            // ltbLista
            // 
            ltbLista.FormattingEnabled = true;
            ltbLista.ItemHeight = 15;
            ltbLista.Location = new Point(334, 200);
            ltbLista.Name = "ltbLista";
            ltbLista.Size = new Size(131, 154);
            ltbLista.TabIndex = 4;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(363, 170);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(75, 23);
            btnLimpar.TabIndex = 5;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Location = new Point(282, 171);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(75, 23);
            btnSair.TabIndex = 6;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLimites
            // 
            btnLimites.Location = new Point(444, 171);
            btnLimites.Name = "btnLimites";
            btnLimites.Size = new Size(75, 23);
            btnLimites.TabIndex = 7;
            btnLimites.Text = "Limites";
            btnLimites.UseVisualStyleBackColor = true;
            btnLimites.Click += btnLimites_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLimites);
            Controls.Add(btnSair);
            Controls.Add(btnLimpar);
            Controls.Add(ltbLista);
            Controls.Add(inpFinal);
            Controls.Add(lblFinal);
            Controls.Add(inpInicial);
            Controls.Add(lblIniciar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIniciar;
        private TextBox inpInicial;
        private TextBox inpFinal;
        private Label lblFinal;
        private ListBox ltbLista;
        private Button btnLimpar;
        private Button btnSair;
        private Button btnLimites;
    }
}