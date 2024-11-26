namespace PetShop
{
    partial class frmFavoritos
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
            button1 = new Button();
            label3 = new Label();
            lblDescricao = new Label();
            lblTitulo = new Label();
            listView1 = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(181, 415);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 24;
            button1.Text = "Excluir Favorito";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 74);
            label3.Name = "label3";
            label3.Size = new Size(292, 15);
            label3.TabIndex = 15;
            label3.Text = "_________________________________________________________\r\n";
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(12, 59);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(257, 30);
            lblDescricao.TabIndex = 14;
            lblDescricao.Text = "Aqui você encontra a lista de gatinhos favoritos\r\n\r\n";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(12, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(209, 80);
            lblTitulo.TabIndex = 13;
            lblTitulo.Text = "Meus Favoritos\r\n\r\n";
            // 
            // listView1
            // 
            listView1.Location = new Point(12, 92);
            listView1.Name = "listView1";
            listView1.Size = new Size(293, 305);
            listView1.TabIndex = 25;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // frmFavoritos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(317, 450);
            Controls.Add(listView1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Name = "frmFavoritos";
            Text = "Favoritos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label3;
        private Label lblDescricao;
        private Label lblTitulo;
        private ListView listView1;
    }
}