namespace CartaoVisita
{
    partial class frmCartaoVisita
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblTelefone = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            lblEndereço = new Label();
            lblEmail = new Label();
            btnAvancar = new Button();
            mtxtTelefone = new MaskedTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 9);
            label1.Name = "label1";
            label1.Size = new Size(157, 25);
            label1.TabIndex = 0;
            label1.Text = "Criador de cartões";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 25);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 1;
            label2.Text = "Nome: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 102);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 2;
            label3.Text = "Idade:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(35, 183);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(81, 25);
            lblTelefone.TabIndex = 3;
            lblTelefone.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(35, 53);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 4;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(35, 130);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(150, 31);
            txtIdade.TabIndex = 5;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(35, 371);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(239, 31);
            txtEndereco.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(35, 290);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(239, 31);
            txtEmail.TabIndex = 11;
            // 
            // lblEndereço
            // 
            lblEndereço.AutoSize = true;
            lblEndereço.Location = new Point(35, 343);
            lblEndereço.Name = "lblEndereço";
            lblEndereço.Size = new Size(89, 25);
            lblEndereço.TabIndex = 9;
            lblEndereço.Text = "Endereço:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(35, 262);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(65, 25);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "e-mail:";
            // 
            // btnAvancar
            // 
            btnAvancar.Location = new Point(638, 393);
            btnAvancar.Name = "btnAvancar";
            btnAvancar.Size = new Size(112, 34);
            btnAvancar.TabIndex = 13;
            btnAvancar.Text = "Avançar";
            btnAvancar.UseVisualStyleBackColor = true;
            btnAvancar.Click += btnAvancar_Click;
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Location = new Point(35, 211);
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(150, 31);
            mtxtTelefone.TabIndex = 14;
            // 
            // frmCartaoVisita
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mtxtTelefone);
            Controls.Add(btnAvancar);
            Controls.Add(txtEndereco);
            Controls.Add(txtEmail);
            Controls.Add(lblEndereço);
            Controls.Add(lblEmail);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(lblTelefone);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmCartaoVisita";
            Text = "Criador de cartão de visita";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label txtEndereço;
        private Button btnAvancar;
        private Label lblTelefone;
        private TextBox txtEndereco;
        private Label lblEndereço;
        private Label lblEmail;
        private TextBox txtEmail;
        private MaskedTextBox mtxtTelefone;
    }
}