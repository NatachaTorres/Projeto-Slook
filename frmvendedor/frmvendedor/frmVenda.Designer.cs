﻿namespace slooknatacha
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Venda = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboproduto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbostatus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbocliente = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtquantidade = new System.Windows.Forms.NumericUpDown();
            this.txtvalorvenda = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboidproduto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboidcliente = new System.Windows.Forms.ComboBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdata = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btopesquisar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtobs = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btocadastrar = new System.Windows.Forms.Button();
            this.btoalterar = new System.Windows.Forms.Button();
            this.btoexcluir = new System.Windows.Forms.Button();
            this.btolimpar = new System.Windows.Forms.Button();
            this.btosair = new System.Windows.Forms.Button();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.tabControl1.SuspendLayout();
            this.Venda.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Venda);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(713, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // Venda
            // 
            this.Venda.Controls.Add(this.groupBox3);
            this.Venda.Controls.Add(this.groupBox1);
            this.Venda.Controls.Add(this.label12);
            this.Venda.Controls.Add(this.label17);
            this.Venda.Controls.Add(this.label11);
            this.Venda.Location = new System.Drawing.Point(4, 24);
            this.Venda.Name = "Venda";
            this.Venda.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Venda.Size = new System.Drawing.Size(705, 341);
            this.Venda.TabIndex = 0;
            this.Venda.Text = "VENDA";
            this.Venda.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboproduto);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cbostatus);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbocliente);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtquantidade);
            this.groupBox3.Controls.Add(this.txtvalorvenda);
            this.groupBox3.Location = new System.Drawing.Point(5, 104);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(695, 236);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            // 
            // cboproduto
            // 
            this.cboproduto.FormattingEnabled = true;
            this.cboproduto.Location = new System.Drawing.Point(18, 55);
            this.cboproduto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboproduto.Name = "cboproduto";
            this.cboproduto.Size = new System.Drawing.Size(345, 23);
            this.cboproduto.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(15, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 126;
            this.label2.Text = "Produto";
            // 
            // cbostatus
            // 
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Location = new System.Drawing.Point(18, 199);
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(650, 23);
            this.cbostatus.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(526, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 21);
            this.label8.TabIndex = 125;
            this.label8.Text = "Valor da Venda";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(18, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 28);
            this.label6.TabIndex = 126;
            this.label6.Text = "Status";
            // 
            // cbocliente
            // 
            this.cbocliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocliente.FormattingEnabled = true;
            this.cbocliente.Location = new System.Drawing.Point(18, 126);
            this.cbocliente.Name = "cbocliente";
            this.cbocliente.Size = new System.Drawing.Size(646, 23);
            this.cbocliente.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(368, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 21);
            this.label7.TabIndex = 126;
            this.label7.Text = "Quantidade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(15, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 28);
            this.label1.TabIndex = 126;
            this.label1.Text = "Cliente";
            // 
            // txtquantidade
            // 
            this.txtquantidade.Location = new System.Drawing.Point(376, 55);
            this.txtquantidade.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtquantidade.Name = "txtquantidade";
            this.txtquantidade.Size = new System.Drawing.Size(139, 23);
            this.txtquantidade.TabIndex = 2;
            // 
            // txtvalorvenda
            // 
            this.txtvalorvenda.Location = new System.Drawing.Point(526, 55);
            this.txtvalorvenda.Name = "txtvalorvenda";
            this.txtvalorvenda.Size = new System.Drawing.Size(139, 23);
            this.txtvalorvenda.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cboidproduto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboidcliente);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdata);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btopesquisar);
            this.groupBox1.Location = new System.Drawing.Point(5, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 84);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 28);
            this.label4.TabIndex = 135;
            this.label4.Text = "ID";
            // 
            // cboidproduto
            // 
            this.cboidproduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboidproduto.FormattingEnabled = true;
            this.cboidproduto.Location = new System.Drawing.Point(165, 34);
            this.cboidproduto.Name = "cboidproduto";
            this.cboidproduto.Size = new System.Drawing.Size(54, 23);
            this.cboidproduto.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(72, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 28);
            this.label3.TabIndex = 134;
            this.label3.Text = "Data";
            // 
            // cboidcliente
            // 
            this.cboidcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboidcliente.FormattingEnabled = true;
            this.cboidcliente.Location = new System.Drawing.Point(105, 34);
            this.cboidcliente.Name = "cboidcliente";
            this.cboidcliente.Size = new System.Drawing.Size(54, 23);
            this.cboidcliente.TabIndex = 1;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(46, 34);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(53, 23);
            this.txtid.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(165, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 145;
            this.label5.Text = "ID Produto";
            this.label5.Visible = false;
            // 
            // txtdata
            // 
            this.txtdata.Location = new System.Drawing.Point(131, 149);
            this.txtdata.Mask = "##/##/####";
            this.txtdata.Name = "txtdata";
            this.txtdata.ReadOnly = true;
            this.txtdata.Size = new System.Drawing.Size(108, 23);
            this.txtdata.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(90, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 145;
            this.label14.Text = "ID Cliente";
            this.label14.Visible = false;
            // 
            // btopesquisar
            // 
            this.btopesquisar.Location = new System.Drawing.Point(225, 34);
            this.btopesquisar.Name = "btopesquisar";
            this.btopesquisar.Size = new System.Drawing.Size(54, 23);
            this.btopesquisar.TabIndex = 3;
            this.btopesquisar.Text = "...";
            this.btopesquisar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(-96, 356);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(100, 28);
            this.label12.TabIndex = 24;
            this.label12.Text = "Telefone 2";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(-95, 426);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 28);
            this.label17.TabIndex = 23;
            this.label17.Text = "Setor";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(-96, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 28);
            this.label11.TabIndex = 20;
            this.label11.Text = "Telefone";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtobs);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(705, 341);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "OBSERVAÇÕES";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtobs
            // 
            this.txtobs.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtobs.Location = new System.Drawing.Point(20, 53);
            this.txtobs.Multiline = true;
            this.txtobs.Name = "txtobs";
            this.txtobs.Size = new System.Drawing.Size(660, 276);
            this.txtobs.TabIndex = 6;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label42.Location = new System.Drawing.Point(20, 13);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(138, 30);
            this.label42.TabIndex = 0;
            this.label42.Text = "Observações";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(235, 25);
            this.label9.TabIndex = 6;
            this.label9.Text = "INFORMAÇÕES DA VENDA";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialButton1);
            this.groupBox2.Controls.Add(this.btocadastrar);
            this.groupBox2.Controls.Add(this.btoalterar);
            this.groupBox2.Controls.Add(this.btoexcluir);
            this.groupBox2.Controls.Add(this.btolimpar);
            this.groupBox2.Controls.Add(this.btosair);
            this.groupBox2.Location = new System.Drawing.Point(12, 440);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(709, 61);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btocadastrar
            // 
            this.btocadastrar.Location = new System.Drawing.Point(304, 22);
            this.btocadastrar.Name = "btocadastrar";
            this.btocadastrar.Size = new System.Drawing.Size(75, 23);
            this.btocadastrar.TabIndex = 7;
            this.btocadastrar.Text = "Cadastrar";
            this.btocadastrar.UseVisualStyleBackColor = true;
            // 
            // btoalterar
            // 
            this.btoalterar.Location = new System.Drawing.Point(385, 22);
            this.btoalterar.Name = "btoalterar";
            this.btoalterar.Size = new System.Drawing.Size(75, 23);
            this.btoalterar.TabIndex = 8;
            this.btoalterar.Text = "Alterar";
            this.btoalterar.UseVisualStyleBackColor = true;
            // 
            // btoexcluir
            // 
            this.btoexcluir.Location = new System.Drawing.Point(466, 22);
            this.btoexcluir.Name = "btoexcluir";
            this.btoexcluir.Size = new System.Drawing.Size(75, 23);
            this.btoexcluir.TabIndex = 9;
            this.btoexcluir.Text = "Excluir";
            this.btoexcluir.UseVisualStyleBackColor = true;
            // 
            // btolimpar
            // 
            this.btolimpar.Location = new System.Drawing.Point(547, 22);
            this.btolimpar.Name = "btolimpar";
            this.btolimpar.Size = new System.Drawing.Size(75, 23);
            this.btolimpar.TabIndex = 10;
            this.btolimpar.Text = "Limpar";
            this.btolimpar.UseVisualStyleBackColor = true;
            // 
            // btosair
            // 
            this.btosair.Location = new System.Drawing.Point(628, 22);
            this.btosair.Name = "btosair";
            this.btosair.Size = new System.Drawing.Size(75, 23);
            this.btosair.TabIndex = 11;
            this.btosair.Text = "Sair";
            this.btosair.UseVisualStyleBackColor = true;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(114, 16);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(158, 36);
            this.materialButton1.TabIndex = 146;
            this.materialButton1.Text = "materialButton1";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // frmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 523);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmVenda";
            this.Text = "frmVenda";
            this.tabControl1.ResumeLayout(false);
            this.Venda.ResumeLayout(false);
            this.Venda.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtquantidade)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private MaterialSkin.Controls.MaterialButton materialButton1;
    }
}