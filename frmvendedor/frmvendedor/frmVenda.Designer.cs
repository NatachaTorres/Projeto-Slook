namespace slooknatacha
{
    partial class frmVenda
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
            tabControl1 = new TabControl();
            Venda = new TabPage();
            groupBox3 = new GroupBox();
            cboproduto = new ComboBox();
            label2 = new Label();
            cbostatus = new ComboBox();
            label8 = new Label();
            label6 = new Label();
            cbocliente = new ComboBox();
            label7 = new Label();
            label1 = new Label();
            txtquantidade = new NumericUpDown();
            txtvalorvenda = new TextBox();
            groupBox1 = new GroupBox();
            label4 = new Label();
            cboidproduto = new ComboBox();
            label3 = new Label();
            cboidcliente = new ComboBox();
            txtid = new TextBox();
            label5 = new Label();
            txtdata = new MaskedTextBox();
            label14 = new Label();
            label12 = new Label();
            label17 = new Label();
            label11 = new Label();
            tabPage3 = new TabPage();
            txtobs = new TextBox();
            label42 = new Label();
            label9 = new Label();
            groupBox2 = new GroupBox();
            btocadastrar = new Button();
            btoalterar = new Button();
            btoexcluir = new Button();
            btolimpar = new Button();
            btosair = new Button();
            btopesquisar = new Button();
            tabControl1.SuspendLayout();
            Venda.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtquantidade).BeginInit();
            groupBox1.SuspendLayout();
            tabPage3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Venda);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(14, 80);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(815, 492);
            tabControl1.TabIndex = 0;
            // 
            // Venda
            // 
            Venda.Controls.Add(groupBox3);
            Venda.Controls.Add(groupBox1);
            Venda.Controls.Add(label12);
            Venda.Controls.Add(label17);
            Venda.Controls.Add(label11);
            Venda.Location = new Point(4, 29);
            Venda.Margin = new Padding(3, 4, 3, 4);
            Venda.Name = "Venda";
            Venda.Padding = new Padding(3, 4, 3, 4);
            Venda.Size = new Size(807, 459);
            Venda.TabIndex = 0;
            Venda.Text = "VENDA";
            Venda.UseVisualStyleBackColor = true;
            Venda.Click += Venda_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboproduto);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cbostatus);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(cbocliente);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(txtquantidade);
            groupBox3.Controls.Add(txtvalorvenda);
            groupBox3.Location = new Point(6, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(794, 314);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            // 
            // cboproduto
            // 
            cboproduto.FormattingEnabled = true;
            cboproduto.Location = new Point(21, 73);
            cboproduto.Name = "cboproduto";
            cboproduto.Size = new Size(394, 28);
            cboproduto.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(17, 25);
            label2.Name = "label2";
            label2.Size = new Size(105, 35);
            label2.TabIndex = 126;
            label2.Text = "Produto";
            // 
            // cbostatus
            // 
            cbostatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbostatus.FormattingEnabled = true;
            cbostatus.Location = new Point(21, 265);
            cbostatus.Margin = new Padding(3, 4, 3, 4);
            cbostatus.Name = "cbostatus";
            cbostatus.Size = new Size(742, 28);
            cbostatus.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(601, 34);
            label8.Name = "label8";
            label8.Size = new Size(143, 28);
            label8.TabIndex = 125;
            label8.Text = "Valor da Venda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(21, 215);
            label6.Name = "label6";
            label6.Size = new Size(81, 35);
            label6.TabIndex = 126;
            label6.Text = "Status";
            // 
            // cbocliente
            // 
            cbocliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbocliente.FormattingEnabled = true;
            cbocliente.Location = new Point(21, 168);
            cbocliente.Margin = new Padding(3, 4, 3, 4);
            cbocliente.Name = "cbocliente";
            cbocliente.Size = new Size(738, 28);
            cbocliente.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(421, 25);
            label7.Name = "label7";
            label7.Size = new Size(115, 28);
            label7.TabIndex = 126;
            label7.Text = "Quantidade";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 129);
            label1.Name = "label1";
            label1.Size = new Size(90, 35);
            label1.TabIndex = 126;
            label1.Text = "Cliente";
            // 
            // txtquantidade
            // 
            txtquantidade.Location = new Point(430, 73);
            txtquantidade.Margin = new Padding(3, 4, 3, 4);
            txtquantidade.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtquantidade.Name = "txtquantidade";
            txtquantidade.Size = new Size(159, 27);
            txtquantidade.TabIndex = 2;
            // 
            // txtvalorvenda
            // 
            txtvalorvenda.Location = new Point(601, 73);
            txtvalorvenda.Margin = new Padding(3, 4, 3, 4);
            txtvalorvenda.Name = "txtvalorvenda";
            txtvalorvenda.Size = new Size(158, 27);
            txtvalorvenda.TabIndex = 3;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(cboidproduto);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(cboidcliente);
            groupBox1.Controls.Add(txtid);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtdata);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(btopesquisar);
            groupBox1.Location = new Point(6, 19);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(794, 112);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(10, 39);
            label4.Name = "label4";
            label4.Size = new Size(40, 35);
            label4.TabIndex = 135;
            label4.Text = "ID";
            // 
            // cboidproduto
            // 
            cboidproduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboidproduto.FormattingEnabled = true;
            cboidproduto.Location = new Point(189, 45);
            cboidproduto.Margin = new Padding(3, 4, 3, 4);
            cboidproduto.Name = "cboidproduto";
            cboidproduto.Size = new Size(61, 28);
            cboidproduto.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(82, 192);
            label3.Name = "label3";
            label3.Size = new Size(67, 35);
            label3.TabIndex = 134;
            label3.Text = "Data";
            // 
            // cboidcliente
            // 
            cboidcliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboidcliente.FormattingEnabled = true;
            cboidcliente.Location = new Point(120, 45);
            cboidcliente.Margin = new Padding(3, 4, 3, 4);
            cboidcliente.Name = "cboidcliente";
            cboidcliente.Size = new Size(61, 28);
            cboidcliente.TabIndex = 1;
            // 
            // txtid
            // 
            txtid.Location = new Point(53, 45);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(60, 27);
            txtid.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(189, 16);
            label5.Name = "label5";
            label5.Size = new Size(94, 23);
            label5.TabIndex = 145;
            label5.Text = "ID Produto";
            label5.Visible = false;
            // 
            // txtdata
            // 
            txtdata.Location = new Point(150, 199);
            txtdata.Margin = new Padding(3, 4, 3, 4);
            txtdata.Mask = "##/##/####";
            txtdata.Name = "txtdata";
            txtdata.ReadOnly = true;
            txtdata.Size = new Size(123, 27);
            txtdata.TabIndex = 1;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(103, 16);
            label14.Name = "label14";
            label14.Size = new Size(85, 23);
            label14.TabIndex = 145;
            label14.Text = "ID Cliente";
            label14.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(-110, 475);
            label12.Name = "label12";
            label12.Size = new Size(128, 35);
            label12.TabIndex = 24;
            label12.Text = "Telefone 2";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(-109, 568);
            label17.Name = "label17";
            label17.Size = new Size(73, 35);
            label17.TabIndex = 23;
            label17.Text = "Setor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(-110, 380);
            label11.Name = "label11";
            label11.Size = new Size(108, 35);
            label11.TabIndex = 20;
            label11.Text = "Telefone";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(txtobs);
            tabPage3.Controls.Add(label42);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Margin = new Padding(3, 4, 3, 4);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(807, 459);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "OBSERVAÇÕES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtobs
            // 
            txtobs.BackColor = SystemColors.ScrollBar;
            txtobs.Location = new Point(23, 71);
            txtobs.Margin = new Padding(3, 4, 3, 4);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new Size(754, 367);
            txtobs.TabIndex = 6;
            // 
            // label42
            // 
            label42.AutoSize = true;
            label42.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label42.Location = new Point(23, 17);
            label42.Name = "label42";
            label42.Size = new Size(167, 37);
            label42.TabIndex = 0;
            label42.Text = "Observações";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(14, 12);
            label9.Name = "label9";
            label9.Size = new Size(297, 32);
            label9.TabIndex = 6;
            label9.Text = "INFORMAÇÕES DA VENDA";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btocadastrar);
            groupBox2.Controls.Add(btoalterar);
            groupBox2.Controls.Add(btoexcluir);
            groupBox2.Controls.Add(btolimpar);
            groupBox2.Controls.Add(btosair);
            groupBox2.Location = new Point(14, 587);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(810, 81);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // btocadastrar
            // 
            btocadastrar.Location = new Point(347, 29);
            btocadastrar.Margin = new Padding(3, 4, 3, 4);
            btocadastrar.Name = "btocadastrar";
            btocadastrar.Size = new Size(86, 31);
            btocadastrar.TabIndex = 7;
            btocadastrar.Text = "Cadastrar";
            btocadastrar.UseVisualStyleBackColor = true;
            btocadastrar.Click += btocadastrar_Click;
            // 
            // btoalterar
            // 
            btoalterar.Location = new Point(440, 29);
            btoalterar.Margin = new Padding(3, 4, 3, 4);
            btoalterar.Name = "btoalterar";
            btoalterar.Size = new Size(86, 31);
            btoalterar.TabIndex = 8;
            btoalterar.Text = "Alterar";
            btoalterar.UseVisualStyleBackColor = true;
            btoalterar.Click += btoalterar_Click;
            // 
            // btoexcluir
            // 
            btoexcluir.Location = new Point(533, 29);
            btoexcluir.Margin = new Padding(3, 4, 3, 4);
            btoexcluir.Name = "btoexcluir";
            btoexcluir.Size = new Size(86, 31);
            btoexcluir.TabIndex = 9;
            btoexcluir.Text = "Excluir";
            btoexcluir.UseVisualStyleBackColor = true;
            btoexcluir.Click += btoexcluir_Click;
            // 
            // btolimpar
            // 
            btolimpar.Location = new Point(625, 29);
            btolimpar.Margin = new Padding(3, 4, 3, 4);
            btolimpar.Name = "btolimpar";
            btolimpar.Size = new Size(86, 31);
            btolimpar.TabIndex = 10;
            btolimpar.Text = "Limpar";
            btolimpar.UseVisualStyleBackColor = true;
            btolimpar.Click += btolimpar_Click;
            // 
            // btosair
            // 
            btosair.Location = new Point(718, 29);
            btosair.Margin = new Padding(3, 4, 3, 4);
            btosair.Name = "btosair";
            btosair.Size = new Size(86, 31);
            btosair.TabIndex = 11;
            btosair.Text = "Sair";
            btosair.UseVisualStyleBackColor = true;
            btosair.Click += btosair_Click;
            // 
            // btopesquisar
            // 
            btopesquisar.Location = new Point(257, 45);
            btopesquisar.Margin = new Padding(3, 4, 3, 4);
            btopesquisar.Name = "btopesquisar";
            btopesquisar.Size = new Size(62, 31);
            btopesquisar.TabIndex = 3;
            btopesquisar.Text = "...";
            btopesquisar.UseVisualStyleBackColor = true;
            btopesquisar.Click += btopesquisar_Click;
            // 
            // frmVenda
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 697);
            Controls.Add(groupBox2);
            Controls.Add(label9);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmVenda";
            Text = "frmVenda";
            Load += frmVenda_Load;
            tabControl1.ResumeLayout(false);
            Venda.ResumeLayout(false);
            Venda.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtquantidade).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage Venda;
        private ComboBox cboidcliente;
        private Label label14;
        private ComboBox cbocliente;
        private MaskedTextBox txtdata;
        private TextBox txtid;
        private Label label3;
        private Label label4;
        private NumericUpDown txtquantidade;
        private TextBox txtvalorvenda;
        private Label label7;
        private Label label8;
        private Label label12;
        private Label label17;
        private Label label11;
        private TabPage tabPage3;
        private TextBox txtobs;
        private Label label42;
        private ComboBox cboidproduto;
        private Label label5;
        private ComboBox cbostatus;
        private Label label6;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label9;
        private GroupBox groupBox2;
        private Button btocadastrar;
        private Button btoalterar;
        private Button btoexcluir;
        private Button btolimpar;
        private Button btosair;
        private ComboBox cboproduto;
        private GroupBox groupBox3;
        private Button btopesquisar;
    }
}