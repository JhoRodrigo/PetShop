namespace PetShop
{
    partial class frmBuscar
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
            lblTitulo = new Label();
            lblDescricao = new Label();
            label3 = new Label();
            lblRaca = new Label();
            cbxRaca = new ComboBox();
            lblTemp = new Label();
            lblRelt_Temp = new Label();
            lblResult_Orig = new Label();
            lblOrig = new Label();
            lblResult_Desc = new Label();
            lblDesc = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(264, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(182, 15);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ENCONTRE SUA RAÇA FAVORITA\r\n";
            lblTitulo.Click += label1_Click;
            // 
            // lblDescricao
            // 
            lblDescricao.AutoSize = true;
            lblDescricao.Location = new Point(16, 31);
            lblDescricao.Name = "lblDescricao";
            lblDescricao.Size = new Size(666, 15);
            lblDescricao.TabIndex = 1;
            lblDescricao.Text = "Ultiliza a caixa de seleção de raças para buscar características sobre determinado gatinho e descobrir qual é a sua raça favorita\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 46);
            label3.Name = "label3";
            label3.Size = new Size(682, 15);
            label3.TabIndex = 2;
            label3.Text = "_______________________________________________________________________________________________________________________________________";
            // 
            // lblRaca
            // 
            lblRaca.AutoSize = true;
            lblRaca.Location = new Point(19, 80);
            lblRaca.Name = "lblRaca";
            lblRaca.Size = new Size(80, 15);
            lblRaca.TabIndex = 3;
            lblRaca.Text = "Raça do Gato:";
            // 
            // cbxRaca
            // 
            cbxRaca.FormattingEnabled = true;
            cbxRaca.Location = new Point(146, 77);
            cbxRaca.Name = "cbxRaca";
            cbxRaca.Size = new Size(121, 23);
            cbxRaca.TabIndex = 4;
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(19, 119);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(91, 15);
            lblTemp.TabIndex = 5;
            lblTemp.Text = "Temperamento:";
            // 
            // lblRelt_Temp
            // 
            lblRelt_Temp.AutoSize = true;
            lblRelt_Temp.Location = new Point(146, 119);
            lblRelt_Temp.Name = "lblRelt_Temp";
            lblRelt_Temp.Size = new Size(59, 15);
            lblRelt_Temp.TabIndex = 6;
            lblRelt_Temp.Text = "Resultado";
            // 
            // lblResult_Orig
            // 
            lblResult_Orig.AutoSize = true;
            lblResult_Orig.Location = new Point(146, 153);
            lblResult_Orig.Name = "lblResult_Orig";
            lblResult_Orig.Size = new Size(59, 15);
            lblResult_Orig.TabIndex = 8;
            lblResult_Orig.Text = "Resultado";
            // 
            // lblOrig
            // 
            lblOrig.AutoSize = true;
            lblOrig.Location = new Point(19, 153);
            lblOrig.Name = "lblOrig";
            lblOrig.Size = new Size(50, 15);
            lblOrig.TabIndex = 7;
            lblOrig.Text = "Origem:";
            // 
            // lblResult_Desc
            // 
            lblResult_Desc.AutoSize = true;
            lblResult_Desc.Location = new Point(146, 186);
            lblResult_Desc.Name = "lblResult_Desc";
            lblResult_Desc.Size = new Size(59, 15);
            lblResult_Desc.TabIndex = 10;
            lblResult_Desc.Text = "Resultado";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(19, 186);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(61, 15);
            lblDesc.TabIndex = 9;
            lblDesc.Text = "Descrição:";
            // 
            // button1
            // 
            button1.Location = new Point(26, 223);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 11;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(120, 223);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Favoritar";
            button2.UseVisualStyleBackColor = true;
            // 
            // frmBuscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 259);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lblResult_Desc);
            Controls.Add(lblDesc);
            Controls.Add(lblResult_Orig);
            Controls.Add(lblOrig);
            Controls.Add(lblRelt_Temp);
            Controls.Add(lblTemp);
            Controls.Add(cbxRaca);
            Controls.Add(lblRaca);
            Controls.Add(label3);
            Controls.Add(lblDescricao);
            Controls.Add(lblTitulo);
            Name = "frmBuscar";
            Text = "Buscar Raças";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDescricao;
        private Label label3;
        private Label lblRaca;
        private ComboBox cbxRaca;
        private Label lblTemp;
        private Label lblRelt_Temp;
        private Label lblResult_Orig;
        private Label lblOrig;
        private Label lblResult_Desc;
        private Label lblDesc;
        private Button button1;
        private Button button2;
    }
}