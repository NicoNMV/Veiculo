namespace Veiculo
{
    partial class Veiculos
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
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.btnCarro = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.Location = new System.Drawing.Point(199, 145);
            this.btnCaminhao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(112, 34);
            this.btnCaminhao.TabIndex = 0;
            this.btnCaminhao.Text = "Cadastrar Caminhão";
            this.btnCaminhao.UseVisualStyleBackColor = true;
            this.btnCaminhao.Click += new System.EventHandler(this.btnCaminhao_Click);
            // 
            // btnCarro
            // 
            this.btnCarro.Location = new System.Drawing.Point(38, 145);
            this.btnCarro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCarro.Name = "btnCarro";
            this.btnCarro.Size = new System.Drawing.Size(112, 34);
            this.btnCarro.TabIndex = 1;
            this.btnCarro.Text = "Cadastrar Carro";
            this.btnCarro.UseVisualStyleBackColor = true;
            this.btnCarro.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(356, 145);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(112, 34);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 344);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCarro);
            this.Controls.Add(this.btnCaminhao);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Veiculos";
            this.Text = "Meus veiculos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCaminhao;
        private System.Windows.Forms.Button btnCarro;
        private System.Windows.Forms.Button btnSair;
    }
}

