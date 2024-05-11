namespace CartaoVisita
{
    partial class frmTelaCartao
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
            panel1 = new Panel();
            txtEndereco = new TextBox();
            txtEmail = new TextBox();
            mtxtTelefone = new TextBox();
            txtIdade = new TextBox();
            txtNome = new TextBox();
            label1 = new Label();
            btnFim = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(txtEndereco);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(mtxtTelefone);
            panel1.Controls.Add(txtIdade);
            panel1.Controls.Add(txtNome);
            panel1.Location = new Point(59, 121);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 280);
            panel1.TabIndex = 0;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(21, 230);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(269, 31);
            txtEndereco.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(21, 170);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(269, 31);
            txtEmail.TabIndex = 3;
            // 
            // mtxtTelefone
            // 
            mtxtTelefone.Location = new Point(21, 115);
            mtxtTelefone.Name = "mtxtTelefone";
            mtxtTelefone.Size = new Size(150, 31);
            mtxtTelefone.TabIndex = 2;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(21, 64);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(150, 31);
            txtIdade.TabIndex = 1;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(21, 16);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(150, 31);
            txtNome.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 29);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "Resultado:";
            // 
            // btnFim
            // 
            btnFim.Location = new Point(664, 407);
            btnFim.Name = "btnFim";
            btnFim.Size = new Size(112, 34);
            btnFim.TabIndex = 5;
            btnFim.Text = "Finalizar";
            btnFim.UseVisualStyleBackColor = true;
            btnFim.Click += btnFim_Click;
            // 
            // frmTelaCartao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnFim);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "frmTelaCartao";
            Text = "frmTelaCartao";
            Load += frmTelaCartao_load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtEndereco;
        private TextBox txtEmail;
        private TextBox mtxtTelefone;
        private TextBox txtIdade;
        private TextBox txtNome;
        private Label label1;
        private Button btnFim;
    }
}