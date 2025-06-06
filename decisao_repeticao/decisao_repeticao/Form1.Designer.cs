namespace decisao_repeticao
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
            lblLadoUm = new Label();
            inpLadoUm = new TextBox();
            inpLadoDois = new TextBox();
            lblLadoDois = new Label();
            inpLadoTres = new TextBox();
            lblLadoTres = new Label();
            btnVerificar = new Button();
            lblResult = new Label();
            SuspendLayout();
            // 
            // lblLadoUm
            // 
            lblLadoUm.AutoSize = true;
            lblLadoUm.Font = new Font("Segoe UI", 20.25F);
            lblLadoUm.Location = new Point(271, 99);
            lblLadoUm.Name = "lblLadoUm";
            lblLadoUm.Size = new Size(104, 37);
            lblLadoUm.TabIndex = 0;
            lblLadoUm.Text = "Lado 1:";
            // 
            // inpLadoUm
            // 
            inpLadoUm.Location = new Point(381, 113);
            inpLadoUm.Name = "inpLadoUm";
            inpLadoUm.Size = new Size(149, 23);
            inpLadoUm.TabIndex = 1;
            // 
            // inpLadoDois
            // 
            inpLadoDois.Location = new Point(381, 164);
            inpLadoDois.Name = "inpLadoDois";
            inpLadoDois.Size = new Size(149, 23);
            inpLadoDois.TabIndex = 3;
            // 
            // lblLadoDois
            // 
            lblLadoDois.AutoSize = true;
            lblLadoDois.Font = new Font("Segoe UI", 20.25F);
            lblLadoDois.Location = new Point(271, 150);
            lblLadoDois.Name = "lblLadoDois";
            lblLadoDois.Size = new Size(104, 37);
            lblLadoDois.TabIndex = 2;
            lblLadoDois.Text = "Lado 2:";
            // 
            // inpLadoTres
            // 
            inpLadoTres.Location = new Point(381, 216);
            inpLadoTres.Name = "inpLadoTres";
            inpLadoTres.Size = new Size(149, 23);
            inpLadoTres.TabIndex = 5;
            // 
            // lblLadoTres
            // 
            lblLadoTres.AutoSize = true;
            lblLadoTres.Font = new Font("Segoe UI", 20.25F);
            lblLadoTres.Location = new Point(271, 202);
            lblLadoTres.Name = "lblLadoTres";
            lblLadoTres.Size = new Size(104, 37);
            lblLadoTres.TabIndex = 4;
            lblLadoTres.Text = "Lado 3:";
            // 
            // btnVerificar
            // 
            btnVerificar.Location = new Point(329, 255);
            btnVerificar.Name = "btnVerificar";
            btnVerificar.Size = new Size(143, 43);
            btnVerificar.TabIndex = 6;
            btnVerificar.Text = "Verificar";
            btnVerificar.UseVisualStyleBackColor = true;
            btnVerificar.Click += btnVerificar_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 20.25F);
            lblResult.Location = new Point(271, 314);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(140, 37);
            lblResult.TabIndex = 7;
            lblResult.Text = "Resultado:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblResult);
            Controls.Add(btnVerificar);
            Controls.Add(inpLadoTres);
            Controls.Add(lblLadoTres);
            Controls.Add(inpLadoDois);
            Controls.Add(lblLadoDois);
            Controls.Add(inpLadoUm);
            Controls.Add(lblLadoUm);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLadoUm;
        private TextBox inpLadoUm;
        private TextBox inpLadoDois;
        private Label lblLadoDois;
        private TextBox inpLadoTres;
        private Label lblLadoTres;
        private Button btnVerificar;
        private Label lblResult;
    }
}
