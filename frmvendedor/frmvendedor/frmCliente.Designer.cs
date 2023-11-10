namespace slooknatacha
{
    partial class frmCliente
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
            label2 = new Label();
            groupBox4 = new GroupBox();
            btocadastrar = new Button();
            btoalterar = new Button();
            btoexcluir = new Button();
            btolimpar = new Button();
            txtsair = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btopesquisar = new Button();
            cbostatus = new ComboBox();
            label21 = new Label();
            txtnascimento = new MaskedTextBox();
            label22 = new Label();
            txttelefone2 = new MaskedTextBox();
            label23 = new Label();
            txtdata = new MaskedTextBox();
            txtid = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cbouf = new ComboBox();
            txtnumero = new NumericUpDown();
            groupBox1 = new GroupBox();
            txtemail = new TextBox();
            label5 = new Label();
            txttelefone1 = new MaskedTextBox();
            label6 = new Label();
            txtcpf = new MaskedTextBox();
            txtcep = new MaskedTextBox();
            txtbairro = new TextBox();
            txtcomplemento = new TextBox();
            txtcidade = new TextBox();
            txtlogradouro = new TextBox();
            txtnome = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label18 = new Label();
            label19 = new Label();
            label12 = new Label();
            label17 = new Label();
            label11 = new Label();
            tabPage3 = new TabPage();
            txtobs = new TextBox();
            label42 = new Label();
            groupBox4.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtnumero).BeginInit();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(13, 12);
            label2.Name = "label2";
            label2.Size = new Size(312, 32);
            label2.TabIndex = 4;
            label2.Text = "INFORMAÇÕES DO CLIENTE";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btocadastrar);
            groupBox4.Controls.Add(btoalterar);
            groupBox4.Controls.Add(btoexcluir);
            groupBox4.Controls.Add(btolimpar);
            groupBox4.Controls.Add(txtsair);
            groupBox4.Location = new Point(9, 805);
            groupBox4.Margin = new Padding(3, 4, 3, 4);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 4, 3, 4);
            groupBox4.Size = new Size(1106, 87);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            // 
            // btocadastrar
            // 
            btocadastrar.Location = new Point(643, 29);
            btocadastrar.Margin = new Padding(3, 4, 3, 4);
            btocadastrar.Name = "btocadastrar";
            btocadastrar.Size = new Size(86, 31);
            btocadastrar.TabIndex = 0;
            btocadastrar.Text = "Cadastrar";
            btocadastrar.UseVisualStyleBackColor = true;
            btocadastrar.Click += btocadastrar_Click;
            // 
            // btoalterar
            // 
            btoalterar.Location = new Point(736, 29);
            btoalterar.Margin = new Padding(3, 4, 3, 4);
            btoalterar.Name = "btoalterar";
            btoalterar.Size = new Size(86, 31);
            btoalterar.TabIndex = 1;
            btoalterar.Text = "Alterar";
            btoalterar.UseVisualStyleBackColor = true;
            btoalterar.Click += btoalterar_Click;
            // 
            // btoexcluir
            // 
            btoexcluir.Location = new Point(829, 29);
            btoexcluir.Margin = new Padding(3, 4, 3, 4);
            btoexcluir.Name = "btoexcluir";
            btoexcluir.Size = new Size(86, 31);
            btoexcluir.TabIndex = 2;
            btoexcluir.Text = "Excluir";
            btoexcluir.UseVisualStyleBackColor = true;
            btoexcluir.Click += btoexcluir_Click;
            // 
            // btolimpar
            // 
            btolimpar.Location = new Point(921, 29);
            btolimpar.Margin = new Padding(3, 4, 3, 4);
            btolimpar.Name = "btolimpar";
            btolimpar.Size = new Size(86, 31);
            btolimpar.TabIndex = 3;
            btolimpar.Text = "Limpar";
            btolimpar.UseVisualStyleBackColor = true;
            btolimpar.Click += btolimpar_Click_1;
            // 
            // txtsair
            // 
            txtsair.Location = new Point(1014, 29);
            txtsair.Margin = new Padding(3, 4, 3, 4);
            txtsair.Name = "txtsair";
            txtsair.Size = new Size(86, 31);
            txtsair.TabIndex = 4;
            txtsair.Text = "Sair";
            txtsair.UseVisualStyleBackColor = true;
            txtsair.Click += txtsair_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(9, 65);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1111, 717);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btopesquisar);
            tabPage1.Controls.Add(cbostatus);
            tabPage1.Controls.Add(label21);
            tabPage1.Controls.Add(txtnascimento);
            tabPage1.Controls.Add(label22);
            tabPage1.Controls.Add(txttelefone2);
            tabPage1.Controls.Add(label23);
            tabPage1.Controls.Add(txtdata);
            tabPage1.Controls.Add(txtid);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(cbouf);
            tabPage1.Controls.Add(txtnumero);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(txtemail);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txttelefone1);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(txtcpf);
            tabPage1.Controls.Add(txtcep);
            tabPage1.Controls.Add(txtbairro);
            tabPage1.Controls.Add(txtcomplemento);
            tabPage1.Controls.Add(txtcidade);
            tabPage1.Controls.Add(txtlogradouro);
            tabPage1.Controls.Add(txtnome);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label8);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(label10);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label16);
            tabPage1.Controls.Add(label18);
            tabPage1.Controls.Add(label19);
            tabPage1.Controls.Add(label12);
            tabPage1.Controls.Add(label17);
            tabPage1.Controls.Add(label11);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(1103, 684);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "LOJA";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btopesquisar
            // 
            btopesquisar.Location = new Point(149, 35);
            btopesquisar.Margin = new Padding(3, 4, 3, 4);
            btopesquisar.Name = "btopesquisar";
            btopesquisar.Size = new Size(54, 31);
            btopesquisar.TabIndex = 1;
            btopesquisar.Text = "...";
            btopesquisar.UseVisualStyleBackColor = true;
            btopesquisar.Click += btopesquisar_Click;
            // 
            // cbostatus
            // 
            cbostatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbostatus.FormattingEnabled = true;
            cbostatus.Items.AddRange(new object[] { "ATIVO", "INATIVO" });
            cbostatus.Location = new Point(553, 608);
            cbostatus.Margin = new Padding(3, 4, 3, 4);
            cbostatus.Name = "cbostatus";
            cbostatus.Size = new Size(510, 28);
            cbostatus.TabIndex = 12;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(559, 572);
            label21.Name = "label21";
            label21.Size = new Size(81, 35);
            label21.TabIndex = 141;
            label21.Text = "Status";
            // 
            // txtnascimento
            // 
            txtnascimento.Location = new Point(321, 604);
            txtnascimento.Margin = new Padding(3, 4, 3, 4);
            txtnascimento.Mask = "##/##/####";
            txtnascimento.Name = "txtnascimento";
            txtnascimento.Size = new Size(132, 27);
            txtnascimento.TabIndex = 16;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label22.Location = new Point(321, 563);
            label22.Name = "label22";
            label22.Size = new Size(148, 35);
            label22.TabIndex = 139;
            label22.Text = "Nascimento";
            // 
            // txttelefone2
            // 
            txttelefone2.Location = new Point(234, 491);
            txttelefone2.Margin = new Padding(3, 4, 3, 4);
            txttelefone2.Mask = "(##) # ####-####";
            txttelefone2.Name = "txttelefone2";
            txttelefone2.Size = new Size(219, 27);
            txttelefone2.TabIndex = 14;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label23.Location = new Point(239, 455);
            label23.Name = "label23";
            label23.Size = new Size(128, 35);
            label23.TabIndex = 138;
            label23.Text = "Telefone 2";
            // 
            // txtdata
            // 
            txtdata.Location = new Point(330, 35);
            txtdata.Margin = new Padding(3, 4, 3, 4);
            txtdata.Mask = "##/##/####";
            txtdata.Name = "txtdata";
            txtdata.ReadOnly = true;
            txtdata.Size = new Size(123, 27);
            txtdata.TabIndex = 3;
            // 
            // txtid
            // 
            txtid.Location = new Point(73, 35);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.Size = new Size(68, 27);
            txtid.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(250, 28);
            label3.Name = "label3";
            label3.Size = new Size(67, 35);
            label3.TabIndex = 134;
            label3.Text = "Data";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(31, 28);
            label4.Name = "label4";
            label4.Size = new Size(40, 35);
            label4.TabIndex = 135;
            label4.Text = "ID";
            // 
            // cbouf
            // 
            cbouf.DropDownStyle = ComboBoxStyle.DropDownList;
            cbouf.FormattingEnabled = true;
            cbouf.Items.AddRange(new object[] { "AC", "AM", "RR", "PA", "AP", "TO", "MA", "PI", "CE", "RN", "PB", "PE", "AL", "SE", "BA", "MG", "ES", "RJ", "SP", "PR", "SC", "RS", "MS", "MT", "GO", "DF" });
            cbouf.Location = new Point(958, 295);
            cbouf.Margin = new Padding(3, 4, 3, 4);
            cbouf.Name = "cbouf";
            cbouf.Size = new Size(109, 28);
            cbouf.TabIndex = 8;
            // 
            // txtnumero
            // 
            txtnumero.Location = new Point(810, 296);
            txtnumero.Margin = new Padding(3, 4, 3, 4);
            txtnumero.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            txtnumero.Name = "txtnumero";
            txtnumero.Size = new Size(141, 27);
            txtnumero.TabIndex = 7;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Gainsboro;
            groupBox1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.Location = new Point(31, 89);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(429, 324);
            groupBox1.TabIndex = 130;
            groupBox1.TabStop = false;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(30, 604);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(281, 27);
            txtemail.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(34, 563);
            label5.Name = "label5";
            label5.Size = new Size(85, 35);
            label5.TabIndex = 129;
            label5.Text = "E-mail";
            // 
            // txttelefone1
            // 
            txttelefone1.Location = new Point(30, 491);
            txttelefone1.Margin = new Padding(3, 4, 3, 4);
            txttelefone1.Mask = "(##) # ####-####";
            txttelefone1.Name = "txttelefone1";
            txttelefone1.Size = new Size(197, 27);
            txttelefone1.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(34, 455);
            label6.Name = "label6";
            label6.Size = new Size(108, 35);
            label6.TabIndex = 128;
            label6.Text = "Telefone";
            // 
            // txtcpf
            // 
            txtcpf.Location = new Point(562, 511);
            txtcpf.Margin = new Padding(3, 4, 3, 4);
            txtcpf.Mask = "###,###,###-##";
            txtcpf.Name = "txtcpf";
            txtcpf.Size = new Size(238, 27);
            txtcpf.TabIndex = 10;
            // 
            // txtcep
            // 
            txtcep.Location = new Point(562, 404);
            txtcep.Margin = new Padding(3, 4, 3, 4);
            txtcep.Mask = "#####-###";
            txtcep.Name = "txtcep";
            txtcep.Size = new Size(238, 27);
            txtcep.TabIndex = 8;
            // 
            // txtbairro
            // 
            txtbairro.Location = new Point(808, 511);
            txtbairro.Margin = new Padding(3, 4, 3, 4);
            txtbairro.Name = "txtbairro";
            txtbairro.Size = new Size(259, 27);
            txtbairro.TabIndex = 11;
            // 
            // txtcomplemento
            // 
            txtcomplemento.Location = new Point(808, 404);
            txtcomplemento.Margin = new Padding(3, 4, 3, 4);
            txtcomplemento.Name = "txtcomplemento";
            txtcomplemento.Size = new Size(259, 27);
            txtcomplemento.TabIndex = 9;
            // 
            // txtcidade
            // 
            txtcidade.Location = new Point(562, 296);
            txtcidade.Margin = new Padding(3, 4, 3, 4);
            txtcidade.Name = "txtcidade";
            txtcidade.Size = new Size(238, 27);
            txtcidade.TabIndex = 6;
            // 
            // txtlogradouro
            // 
            txtlogradouro.Location = new Point(562, 185);
            txtlogradouro.Margin = new Padding(3, 4, 3, 4);
            txtlogradouro.Name = "txtlogradouro";
            txtlogradouro.Size = new Size(505, 27);
            txtlogradouro.TabIndex = 5;
            // 
            // txtnome
            // 
            txtnome.Location = new Point(562, 84);
            txtnome.Margin = new Padding(3, 4, 3, 4);
            txtnome.Name = "txtnome";
            txtnome.Size = new Size(505, 27);
            txtnome.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(811, 259);
            label7.Name = "label7";
            label7.Size = new Size(43, 35);
            label7.TabIndex = 126;
            label7.Text = "N°";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(813, 368);
            label8.Name = "label8";
            label8.Size = new Size(173, 35);
            label8.TabIndex = 125;
            label8.Text = "Complemento";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(813, 475);
            label9.Name = "label9";
            label9.Size = new Size(81, 35);
            label9.TabIndex = 124;
            label9.Text = "Bairro";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(567, 260);
            label10.Name = "label10";
            label10.Size = new Size(92, 35);
            label10.TabIndex = 123;
            label10.Text = "Cidade";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(961, 257);
            label13.Name = "label13";
            label13.Size = new Size(44, 35);
            label13.TabIndex = 122;
            label13.Text = "UF";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(567, 475);
            label15.Name = "label15";
            label15.Size = new Size(56, 35);
            label15.TabIndex = 121;
            label15.Text = "CPF";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(567, 141);
            label16.Name = "label16";
            label16.Size = new Size(147, 35);
            label16.TabIndex = 120;
            label16.Text = "Logradouro";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(567, 368);
            label18.Name = "label18";
            label18.Size = new Size(57, 35);
            label18.TabIndex = 119;
            label18.Text = "CEP";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(567, 48);
            label19.Name = "label19";
            label19.Size = new Size(84, 35);
            label19.TabIndex = 127;
            label19.Text = "Nome";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(-117, 467);
            label12.Name = "label12";
            label12.Size = new Size(128, 35);
            label12.TabIndex = 24;
            label12.Text = "Telefone 2";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label17.Location = new Point(-115, 560);
            label17.Name = "label17";
            label17.Size = new Size(73, 35);
            label17.TabIndex = 23;
            label17.Text = "Setor";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(-117, 372);
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
            tabPage3.Size = new Size(1103, 684);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "OBSERVAÇÕES";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtobs
            // 
            txtobs.BackColor = SystemColors.ScrollBar;
            txtobs.Location = new Point(23, 75);
            txtobs.Margin = new Padding(3, 4, 3, 4);
            txtobs.Multiline = true;
            txtobs.Name = "txtobs";
            txtobs.Size = new Size(1051, 571);
            txtobs.TabIndex = 1;
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
            // frmCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1131, 925);
            Controls.Add(tabControl1);
            Controls.Add(groupBox4);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmCliente";
            Text = "Form1";
            groupBox4.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtnumero).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private GroupBox groupBox4;
        private Button btocadastrar;
        private Button btoalterar;
        private Button btoexcluir;
        private Button btolimpar;
        private Button txtsair;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private Label label12;
        private Label label17;
        private Label label11;
        private TabPage tabPage3;
        private TextBox txtobs;
        private Label label42;
        private ComboBox cbostatus;
        private Label label21;
        private MaskedTextBox txtnascimento;
        private Label label22;
        private MaskedTextBox txttelefone2;
        private Label label23;
        private MaskedTextBox txtdata;
        private TextBox txtid;
        private Label label3;
        private Label label4;
        private ComboBox cbouf;
        private NumericUpDown txtnumero;
        private GroupBox groupBox1;
        private TextBox txtemail;
        private Label label5;
        private MaskedTextBox txttelefone1;
        private Label label6;
        private MaskedTextBox txtcpf;
        private MaskedTextBox txtcep;
        private TextBox txtbairro;
        private TextBox txtcomplemento;
        private TextBox txtcidade;
        private TextBox txtlogradouro;
        private TextBox txtnome;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label18;
        private Label label19;
        private Button btopesquisar;
    }
}