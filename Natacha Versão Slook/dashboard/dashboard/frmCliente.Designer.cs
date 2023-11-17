namespace dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbostatus = new MaterialSkin.Controls.MaterialComboBox();
            this.cbouf = new MaterialSkin.Controls.MaterialComboBox();
            this.txtcep = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtdata = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txttelefone2 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txttelefone1 = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtnascimento = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtcpf = new MaterialSkin.Controls.MaterialMaskedTextBox();
            this.txtnumero = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtcomplemento = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtbairro = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtemail = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtcidade = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtlogradouro = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtnome = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.txtid = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btoalterar = new MaterialSkin.Controls.MaterialButton();
            this.btocadastrar = new MaterialSkin.Controls.MaterialButton();
            this.btoexcluir = new MaterialSkin.Controls.MaterialButton();
            this.btolimpar = new MaterialSkin.Controls.MaterialButton();
            this.txtsair = new MaterialSkin.Controls.MaterialButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtobs = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btopesquisar = new MaterialSkin.Controls.MaterialButton();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 78);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(767, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btopesquisar);
            this.tabPage1.Controls.Add(this.cbostatus);
            this.tabPage1.Controls.Add(this.cbouf);
            this.tabPage1.Controls.Add(this.txtcep);
            this.tabPage1.Controls.Add(this.txtdata);
            this.tabPage1.Controls.Add(this.txttelefone2);
            this.tabPage1.Controls.Add(this.txttelefone1);
            this.tabPage1.Controls.Add(this.txtnascimento);
            this.tabPage1.Controls.Add(this.txtcpf);
            this.tabPage1.Controls.Add(this.txtnumero);
            this.tabPage1.Controls.Add(this.txtcomplemento);
            this.tabPage1.Controls.Add(this.txtbairro);
            this.tabPage1.Controls.Add(this.txtemail);
            this.tabPage1.Controls.Add(this.txtcidade);
            this.tabPage1.Controls.Add(this.txtlogradouro);
            this.tabPage1.Controls.Add(this.txtnome);
            this.tabPage1.Controls.Add(this.txtid);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(759, 563);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Pessoais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbostatus
            // 
            this.cbostatus.AutoResize = false;
            this.cbostatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbostatus.Depth = 0;
            this.cbostatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbostatus.DropDownHeight = 174;
            this.cbostatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbostatus.DropDownWidth = 121;
            this.cbostatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbostatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbostatus.FormattingEnabled = true;
            this.cbostatus.Hint = "STATUS";
            this.cbostatus.IntegralHeight = false;
            this.cbostatus.ItemHeight = 43;
            this.cbostatus.Items.AddRange(new object[] {
            "ATIVO",
            "INATIVO"});
            this.cbostatus.Location = new System.Drawing.Point(328, 20);
            this.cbostatus.Margin = new System.Windows.Forms.Padding(2);
            this.cbostatus.MaxDropDownItems = 4;
            this.cbostatus.MouseState = MaterialSkin.MouseState.OUT;
            this.cbostatus.Name = "cbostatus";
            this.cbostatus.Size = new System.Drawing.Size(206, 49);
            this.cbostatus.StartIndex = 0;
            this.cbostatus.TabIndex = 11;
            // 
            // cbouf
            // 
            this.cbouf.AutoResize = false;
            this.cbouf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbouf.Depth = 0;
            this.cbouf.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbouf.DropDownHeight = 174;
            this.cbouf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbouf.DropDownWidth = 121;
            this.cbouf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbouf.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbouf.FormattingEnabled = true;
            this.cbouf.Hint = "UF";
            this.cbouf.IntegralHeight = false;
            this.cbouf.ItemHeight = 43;
            this.cbouf.Items.AddRange(new object[] {
            "AC",
            "AM",
            "RR",
            "PA",
            "AP",
            "TO",
            "MA",
            "PI",
            "CE",
            "RN",
            "PB",
            "PE",
            "AL",
            "SE",
            "BA",
            "MG",
            "ES",
            "RJ",
            "SP",
            "PR",
            "SC",
            "RS",
            "MS",
            "MT",
            "GO",
            "DF"});
            this.cbouf.Location = new System.Drawing.Point(456, 258);
            this.cbouf.Margin = new System.Windows.Forms.Padding(2);
            this.cbouf.MaxDropDownItems = 4;
            this.cbouf.MouseState = MaterialSkin.MouseState.OUT;
            this.cbouf.Name = "cbouf";
            this.cbouf.Size = new System.Drawing.Size(78, 49);
            this.cbouf.StartIndex = 0;
            this.cbouf.TabIndex = 11;
            // 
            // txtcep
            // 
            this.txtcep.AllowPromptAsInput = true;
            this.txtcep.AnimateReadOnly = false;
            this.txtcep.AsciiOnly = false;
            this.txtcep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcep.BeepOnError = false;
            this.txtcep.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtcep.Depth = 0;
            this.txtcep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcep.HidePromptOnLeave = false;
            this.txtcep.HideSelection = true;
            this.txtcep.Hint = "C.E.P";
            this.txtcep.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtcep.LeadingIcon = null;
            this.txtcep.Location = new System.Drawing.Point(423, 323);
            this.txtcep.Margin = new System.Windows.Forms.Padding(2);
            this.txtcep.Mask = "#####-###";
            this.txtcep.MaxLength = 32767;
            this.txtcep.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcep.Name = "txtcep";
            this.txtcep.PasswordChar = '\0';
            this.txtcep.PrefixSuffixText = null;
            this.txtcep.PromptChar = '_';
            this.txtcep.ReadOnly = false;
            this.txtcep.RejectInputOnFirstFailure = false;
            this.txtcep.ResetOnPrompt = true;
            this.txtcep.ResetOnSpace = true;
            this.txtcep.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcep.SelectedText = "";
            this.txtcep.SelectionLength = 0;
            this.txtcep.SelectionStart = 0;
            this.txtcep.ShortcutsEnabled = true;
            this.txtcep.Size = new System.Drawing.Size(110, 48);
            this.txtcep.SkipLiterals = true;
            this.txtcep.TabIndex = 6;
            this.txtcep.TabStop = false;
            this.txtcep.Text = "     -";
            this.txtcep.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcep.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtcep.TrailingIcon = null;
            this.txtcep.UseSystemPasswordChar = false;
            this.txtcep.ValidatingType = null;
            // 
            // txtdata
            // 
            this.txtdata.AllowPromptAsInput = true;
            this.txtdata.AnimateReadOnly = false;
            this.txtdata.AsciiOnly = false;
            this.txtdata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtdata.BeepOnError = false;
            this.txtdata.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtdata.Depth = 0;
            this.txtdata.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdata.HidePromptOnLeave = false;
            this.txtdata.HideSelection = true;
            this.txtdata.Hint = "Data";
            this.txtdata.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtdata.LeadingIcon = null;
            this.txtdata.Location = new System.Drawing.Point(112, 20);
            this.txtdata.Margin = new System.Windows.Forms.Padding(2);
            this.txtdata.Mask = "##/##/####";
            this.txtdata.MaxLength = 32767;
            this.txtdata.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdata.Name = "txtdata";
            this.txtdata.PasswordChar = '\0';
            this.txtdata.PrefixSuffixText = null;
            this.txtdata.PromptChar = '_';
            this.txtdata.ReadOnly = true;
            this.txtdata.RejectInputOnFirstFailure = false;
            this.txtdata.ResetOnPrompt = true;
            this.txtdata.ResetOnSpace = true;
            this.txtdata.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtdata.SelectedText = "";
            this.txtdata.SelectionLength = 0;
            this.txtdata.SelectionStart = 0;
            this.txtdata.ShortcutsEnabled = true;
            this.txtdata.Size = new System.Drawing.Size(211, 48);
            this.txtdata.SkipLiterals = true;
            this.txtdata.TabIndex = 6;
            this.txtdata.TabStop = false;
            this.txtdata.Text = "  /  /";
            this.txtdata.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtdata.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtdata.TrailingIcon = null;
            this.txtdata.UseSystemPasswordChar = false;
            this.txtdata.ValidatingType = null;
            // 
            // txttelefone2
            // 
            this.txttelefone2.AllowPromptAsInput = true;
            this.txttelefone2.AnimateReadOnly = false;
            this.txttelefone2.AsciiOnly = false;
            this.txttelefone2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txttelefone2.BeepOnError = false;
            this.txttelefone2.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txttelefone2.Depth = 0;
            this.txttelefone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txttelefone2.HidePromptOnLeave = false;
            this.txttelefone2.HideSelection = true;
            this.txttelefone2.Hint = "Telefone";
            this.txttelefone2.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txttelefone2.LeadingIcon = null;
            this.txttelefone2.Location = new System.Drawing.Point(300, 453);
            this.txttelefone2.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefone2.Mask = "##/##/####";
            this.txttelefone2.MaxLength = 32767;
            this.txttelefone2.MouseState = MaterialSkin.MouseState.OUT;
            this.txttelefone2.Name = "txttelefone2";
            this.txttelefone2.PasswordChar = '\0';
            this.txttelefone2.PrefixSuffixText = null;
            this.txttelefone2.PromptChar = '_';
            this.txttelefone2.ReadOnly = false;
            this.txttelefone2.RejectInputOnFirstFailure = false;
            this.txttelefone2.ResetOnPrompt = true;
            this.txttelefone2.ResetOnSpace = true;
            this.txttelefone2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttelefone2.SelectedText = "";
            this.txttelefone2.SelectionLength = 0;
            this.txttelefone2.SelectionStart = 0;
            this.txttelefone2.ShortcutsEnabled = true;
            this.txttelefone2.Size = new System.Drawing.Size(233, 48);
            this.txttelefone2.SkipLiterals = true;
            this.txttelefone2.TabIndex = 6;
            this.txttelefone2.TabStop = false;
            this.txttelefone2.Text = "  /  /";
            this.txttelefone2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttelefone2.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txttelefone2.TrailingIcon = null;
            this.txttelefone2.UseSystemPasswordChar = false;
            this.txttelefone2.ValidatingType = null;
            // 
            // txttelefone1
            // 
            this.txttelefone1.AllowPromptAsInput = true;
            this.txttelefone1.AnimateReadOnly = false;
            this.txttelefone1.AsciiOnly = false;
            this.txttelefone1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txttelefone1.BeepOnError = false;
            this.txttelefone1.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txttelefone1.Depth = 0;
            this.txttelefone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txttelefone1.HidePromptOnLeave = false;
            this.txttelefone1.HideSelection = true;
            this.txttelefone1.Hint = "Celular";
            this.txttelefone1.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txttelefone1.LeadingIcon = null;
            this.txttelefone1.Location = new System.Drawing.Point(36, 453);
            this.txttelefone1.Margin = new System.Windows.Forms.Padding(2);
            this.txttelefone1.Mask = "##/##/####";
            this.txttelefone1.MaxLength = 32767;
            this.txttelefone1.MouseState = MaterialSkin.MouseState.OUT;
            this.txttelefone1.Name = "txttelefone1";
            this.txttelefone1.PasswordChar = '\0';
            this.txttelefone1.PrefixSuffixText = null;
            this.txttelefone1.PromptChar = '_';
            this.txttelefone1.ReadOnly = false;
            this.txttelefone1.RejectInputOnFirstFailure = false;
            this.txttelefone1.ResetOnPrompt = true;
            this.txttelefone1.ResetOnSpace = true;
            this.txttelefone1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttelefone1.SelectedText = "";
            this.txttelefone1.SelectionLength = 0;
            this.txttelefone1.SelectionStart = 0;
            this.txttelefone1.ShortcutsEnabled = true;
            this.txttelefone1.Size = new System.Drawing.Size(251, 48);
            this.txttelefone1.SkipLiterals = true;
            this.txttelefone1.TabIndex = 6;
            this.txttelefone1.TabStop = false;
            this.txttelefone1.Text = "  /  /";
            this.txttelefone1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txttelefone1.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txttelefone1.TrailingIcon = null;
            this.txttelefone1.UseSystemPasswordChar = false;
            this.txttelefone1.ValidatingType = null;
            // 
            // txtnascimento
            // 
            this.txtnascimento.AllowPromptAsInput = true;
            this.txtnascimento.AnimateReadOnly = false;
            this.txtnascimento.AsciiOnly = false;
            this.txtnascimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnascimento.BeepOnError = false;
            this.txtnascimento.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtnascimento.Depth = 0;
            this.txtnascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtnascimento.HidePromptOnLeave = false;
            this.txtnascimento.HideSelection = true;
            this.txtnascimento.Hint = "Data De Nascimento";
            this.txtnascimento.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtnascimento.LeadingIcon = null;
            this.txtnascimento.Location = new System.Drawing.Point(372, 89);
            this.txtnascimento.Margin = new System.Windows.Forms.Padding(2);
            this.txtnascimento.Mask = "##/##/####";
            this.txtnascimento.MaxLength = 32767;
            this.txtnascimento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnascimento.Name = "txtnascimento";
            this.txtnascimento.PasswordChar = '\0';
            this.txtnascimento.PrefixSuffixText = null;
            this.txtnascimento.PromptChar = '_';
            this.txtnascimento.ReadOnly = false;
            this.txtnascimento.RejectInputOnFirstFailure = false;
            this.txtnascimento.ResetOnPrompt = true;
            this.txtnascimento.ResetOnSpace = true;
            this.txtnascimento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnascimento.SelectedText = "";
            this.txtnascimento.SelectionLength = 0;
            this.txtnascimento.SelectionStart = 0;
            this.txtnascimento.ShortcutsEnabled = true;
            this.txtnascimento.Size = new System.Drawing.Size(161, 48);
            this.txtnascimento.SkipLiterals = true;
            this.txtnascimento.TabIndex = 6;
            this.txtnascimento.TabStop = false;
            this.txtnascimento.Text = "  /  /";
            this.txtnascimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnascimento.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtnascimento.TrailingIcon = null;
            this.txtnascimento.UseSystemPasswordChar = false;
            this.txtnascimento.ValidatingType = null;
            // 
            // txtcpf
            // 
            this.txtcpf.AllowPromptAsInput = true;
            this.txtcpf.AnimateReadOnly = false;
            this.txtcpf.AsciiOnly = false;
            this.txtcpf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcpf.BeepOnError = false;
            this.txtcpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtcpf.Depth = 0;
            this.txtcpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtcpf.HidePromptOnLeave = false;
            this.txtcpf.HideSelection = true;
            this.txtcpf.Hint = "C.P.F";
            this.txtcpf.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtcpf.LeadingIcon = null;
            this.txtcpf.Location = new System.Drawing.Point(36, 148);
            this.txtcpf.Margin = new System.Windows.Forms.Padding(2);
            this.txtcpf.Mask = "##,###,###-##";
            this.txtcpf.MaxLength = 32767;
            this.txtcpf.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcpf.Name = "txtcpf";
            this.txtcpf.PasswordChar = '\0';
            this.txtcpf.PrefixSuffixText = null;
            this.txtcpf.PromptChar = '_';
            this.txtcpf.ReadOnly = false;
            this.txtcpf.RejectInputOnFirstFailure = false;
            this.txtcpf.ResetOnPrompt = true;
            this.txtcpf.ResetOnSpace = true;
            this.txtcpf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcpf.SelectedText = "";
            this.txtcpf.SelectionLength = 0;
            this.txtcpf.SelectionStart = 0;
            this.txtcpf.ShortcutsEnabled = true;
            this.txtcpf.Size = new System.Drawing.Size(497, 48);
            this.txtcpf.SkipLiterals = true;
            this.txtcpf.TabIndex = 6;
            this.txtcpf.TabStop = false;
            this.txtcpf.Text = "  .   .   -";
            this.txtcpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcpf.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtcpf.TrailingIcon = null;
            this.txtcpf.UseSystemPasswordChar = false;
            this.txtcpf.ValidatingType = null;
            // 
            // txtnumero
            // 
            this.txtnumero.AnimateReadOnly = false;
            this.txtnumero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnumero.Depth = 0;
            this.txtnumero.HideSelection = true;
            this.txtnumero.Hint = "N°";
            this.txtnumero.Location = new System.Drawing.Point(314, 323);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(2);
            this.txtnumero.MaxLength = 32767;
            this.txtnumero.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.PasswordChar = '\0';
            this.txtnumero.ReadOnly = false;
            this.txtnumero.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnumero.SelectedText = "";
            this.txtnumero.SelectionLength = 0;
            this.txtnumero.SelectionStart = 0;
            this.txtnumero.ShortcutsEnabled = true;
            this.txtnumero.Size = new System.Drawing.Size(104, 50);
            this.txtnumero.TabIndex = 5;
            this.txtnumero.TabStop = false;
            this.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnumero.UseSystemPasswordChar = false;
            // 
            // txtcomplemento
            // 
            this.txtcomplemento.AnimateReadOnly = false;
            this.txtcomplemento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcomplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcomplemento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcomplemento.Depth = 0;
            this.txtcomplemento.HideSelection = true;
            this.txtcomplemento.Hint = "Complemento";
            this.txtcomplemento.Location = new System.Drawing.Point(36, 389);
            this.txtcomplemento.Margin = new System.Windows.Forms.Padding(2);
            this.txtcomplemento.MaxLength = 32767;
            this.txtcomplemento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcomplemento.Name = "txtcomplemento";
            this.txtcomplemento.PasswordChar = '\0';
            this.txtcomplemento.ReadOnly = false;
            this.txtcomplemento.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcomplemento.SelectedText = "";
            this.txtcomplemento.SelectionLength = 0;
            this.txtcomplemento.SelectionStart = 0;
            this.txtcomplemento.ShortcutsEnabled = true;
            this.txtcomplemento.Size = new System.Drawing.Size(497, 50);
            this.txtcomplemento.TabIndex = 5;
            this.txtcomplemento.TabStop = false;
            this.txtcomplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcomplemento.UseSystemPasswordChar = false;
            // 
            // txtbairro
            // 
            this.txtbairro.AnimateReadOnly = false;
            this.txtbairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtbairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtbairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbairro.Depth = 0;
            this.txtbairro.HideSelection = true;
            this.txtbairro.Hint = "Bairro";
            this.txtbairro.Location = new System.Drawing.Point(36, 323);
            this.txtbairro.Margin = new System.Windows.Forms.Padding(2);
            this.txtbairro.MaxLength = 32767;
            this.txtbairro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtbairro.Name = "txtbairro";
            this.txtbairro.PasswordChar = '\0';
            this.txtbairro.ReadOnly = false;
            this.txtbairro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtbairro.SelectedText = "";
            this.txtbairro.SelectionLength = 0;
            this.txtbairro.SelectionStart = 0;
            this.txtbairro.ShortcutsEnabled = true;
            this.txtbairro.Size = new System.Drawing.Size(274, 50);
            this.txtbairro.TabIndex = 5;
            this.txtbairro.TabStop = false;
            this.txtbairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbairro.UseSystemPasswordChar = false;
            // 
            // txtemail
            // 
            this.txtemail.AnimateReadOnly = false;
            this.txtemail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtemail.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtemail.Depth = 0;
            this.txtemail.HideSelection = true;
            this.txtemail.Hint = "E-mail";
            this.txtemail.Location = new System.Drawing.Point(36, 514);
            this.txtemail.Margin = new System.Windows.Forms.Padding(2);
            this.txtemail.MaxLength = 32767;
            this.txtemail.MouseState = MaterialSkin.MouseState.OUT;
            this.txtemail.Name = "txtemail";
            this.txtemail.PasswordChar = '\0';
            this.txtemail.ReadOnly = false;
            this.txtemail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtemail.SelectedText = "";
            this.txtemail.SelectionLength = 0;
            this.txtemail.SelectionStart = 0;
            this.txtemail.ShortcutsEnabled = true;
            this.txtemail.Size = new System.Drawing.Size(497, 40);
            this.txtemail.TabIndex = 5;
            this.txtemail.TabStop = false;
            this.txtemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtemail.UseSystemPasswordChar = false;
            // 
            // txtcidade
            // 
            this.txtcidade.AnimateReadOnly = false;
            this.txtcidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtcidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtcidade.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcidade.Depth = 0;
            this.txtcidade.HideSelection = true;
            this.txtcidade.Hint = "Cidade";
            this.txtcidade.Location = new System.Drawing.Point(36, 258);
            this.txtcidade.Margin = new System.Windows.Forms.Padding(2);
            this.txtcidade.MaxLength = 32767;
            this.txtcidade.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcidade.Name = "txtcidade";
            this.txtcidade.PasswordChar = '\0';
            this.txtcidade.ReadOnly = false;
            this.txtcidade.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtcidade.SelectedText = "";
            this.txtcidade.SelectionLength = 0;
            this.txtcidade.SelectionStart = 0;
            this.txtcidade.ShortcutsEnabled = true;
            this.txtcidade.Size = new System.Drawing.Size(416, 50);
            this.txtcidade.TabIndex = 5;
            this.txtcidade.TabStop = false;
            this.txtcidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtcidade.UseSystemPasswordChar = false;
            // 
            // txtlogradouro
            // 
            this.txtlogradouro.AnimateReadOnly = false;
            this.txtlogradouro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtlogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtlogradouro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtlogradouro.Depth = 0;
            this.txtlogradouro.HideSelection = true;
            this.txtlogradouro.Hint = "Logradouro";
            this.txtlogradouro.Location = new System.Drawing.Point(36, 201);
            this.txtlogradouro.Margin = new System.Windows.Forms.Padding(2);
            this.txtlogradouro.MaxLength = 32767;
            this.txtlogradouro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtlogradouro.Name = "txtlogradouro";
            this.txtlogradouro.PasswordChar = '\0';
            this.txtlogradouro.ReadOnly = false;
            this.txtlogradouro.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtlogradouro.SelectedText = "";
            this.txtlogradouro.SelectionLength = 0;
            this.txtlogradouro.SelectionStart = 0;
            this.txtlogradouro.ShortcutsEnabled = true;
            this.txtlogradouro.Size = new System.Drawing.Size(497, 40);
            this.txtlogradouro.TabIndex = 5;
            this.txtlogradouro.TabStop = false;
            this.txtlogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtlogradouro.UseSystemPasswordChar = false;
            // 
            // txtnome
            // 
            this.txtnome.AnimateReadOnly = false;
            this.txtnome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtnome.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtnome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnome.Depth = 0;
            this.txtnome.HideSelection = true;
            this.txtnome.Hint = "Nome";
            this.txtnome.Location = new System.Drawing.Point(36, 89);
            this.txtnome.Margin = new System.Windows.Forms.Padding(2);
            this.txtnome.MaxLength = 32767;
            this.txtnome.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnome.Name = "txtnome";
            this.txtnome.PasswordChar = '\0';
            this.txtnome.ReadOnly = false;
            this.txtnome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtnome.SelectedText = "";
            this.txtnome.SelectionLength = 0;
            this.txtnome.SelectionStart = 0;
            this.txtnome.ShortcutsEnabled = true;
            this.txtnome.Size = new System.Drawing.Size(332, 49);
            this.txtnome.TabIndex = 5;
            this.txtnome.TabStop = false;
            this.txtnome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtnome.UseSystemPasswordChar = false;
            // 
            // txtid
            // 
            this.txtid.AnimateReadOnly = false;
            this.txtid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtid.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtid.Depth = 0;
            this.txtid.HideSelection = true;
            this.txtid.Hint = "ID";
            this.txtid.Location = new System.Drawing.Point(36, 20);
            this.txtid.Margin = new System.Windows.Forms.Padding(2);
            this.txtid.MaxLength = 32767;
            this.txtid.MouseState = MaterialSkin.MouseState.OUT;
            this.txtid.Name = "txtid";
            this.txtid.PasswordChar = '\0';
            this.txtid.ReadOnly = false;
            this.txtid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtid.SelectedText = "";
            this.txtid.SelectionLength = 0;
            this.txtid.SelectionStart = 0;
            this.txtid.ShortcutsEnabled = true;
            this.txtid.Size = new System.Drawing.Size(72, 49);
            this.txtid.TabIndex = 5;
            this.txtid.TabStop = false;
            this.txtid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtid.UseSystemPasswordChar = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.txtobs);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(759, 563);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Observações";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btoalterar);
            this.groupBox2.Controls.Add(this.btocadastrar);
            this.groupBox2.Controls.Add(this.btoexcluir);
            this.groupBox2.Controls.Add(this.btolimpar);
            this.groupBox2.Controls.Add(this.txtsair);
            this.groupBox2.Location = new System.Drawing.Point(4, 469);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(751, 76);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btoalterar
            // 
            this.btoalterar.AutoSize = false;
            this.btoalterar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btoalterar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btoalterar.Depth = 0;
            this.btoalterar.HighEmphasis = true;
            this.btoalterar.Icon = null;
            this.btoalterar.Location = new System.Drawing.Point(332, 21);
            this.btoalterar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btoalterar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btoalterar.Name = "btoalterar";
            this.btoalterar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btoalterar.Size = new System.Drawing.Size(97, 36);
            this.btoalterar.TabIndex = 0;
            this.btoalterar.Text = "Alterar";
            this.btoalterar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btoalterar.UseAccentColor = false;
            this.btoalterar.UseVisualStyleBackColor = true;
            this.btoalterar.Click += new System.EventHandler(this.btoalterar_Click);
            // 
            // btocadastrar
            // 
            this.btocadastrar.AutoSize = false;
            this.btocadastrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btocadastrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btocadastrar.Depth = 0;
            this.btocadastrar.HighEmphasis = true;
            this.btocadastrar.Icon = null;
            this.btocadastrar.Location = new System.Drawing.Point(227, 21);
            this.btocadastrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btocadastrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btocadastrar.Name = "btocadastrar";
            this.btocadastrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btocadastrar.Size = new System.Drawing.Size(97, 36);
            this.btocadastrar.TabIndex = 0;
            this.btocadastrar.Text = "Cadastrar";
            this.btocadastrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btocadastrar.UseAccentColor = false;
            this.btocadastrar.UseVisualStyleBackColor = true;
            this.btocadastrar.Click += new System.EventHandler(this.btocadastrar_Click);
            // 
            // btoexcluir
            // 
            this.btoexcluir.AutoSize = false;
            this.btoexcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btoexcluir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btoexcluir.Depth = 0;
            this.btoexcluir.HighEmphasis = true;
            this.btoexcluir.Icon = null;
            this.btoexcluir.Location = new System.Drawing.Point(437, 21);
            this.btoexcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btoexcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btoexcluir.Name = "btoexcluir";
            this.btoexcluir.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btoexcluir.Size = new System.Drawing.Size(97, 36);
            this.btoexcluir.TabIndex = 0;
            this.btoexcluir.Text = "Excluir";
            this.btoexcluir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btoexcluir.UseAccentColor = false;
            this.btoexcluir.UseVisualStyleBackColor = true;
            this.btoexcluir.Click += new System.EventHandler(this.btoexcluir_Click);
            // 
            // btolimpar
            // 
            this.btolimpar.AutoSize = false;
            this.btolimpar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btolimpar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btolimpar.Depth = 0;
            this.btolimpar.HighEmphasis = true;
            this.btolimpar.Icon = null;
            this.btolimpar.Location = new System.Drawing.Point(542, 21);
            this.btolimpar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btolimpar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btolimpar.Name = "btolimpar";
            this.btolimpar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btolimpar.Size = new System.Drawing.Size(97, 36);
            this.btolimpar.TabIndex = 0;
            this.btolimpar.Text = "Limpar";
            this.btolimpar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btolimpar.UseAccentColor = false;
            this.btolimpar.UseVisualStyleBackColor = true;
            this.btolimpar.Click += new System.EventHandler(this.btolimpar_Click);
            // 
            // txtsair
            // 
            this.txtsair.AutoSize = false;
            this.txtsair.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.txtsair.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.txtsair.Depth = 0;
            this.txtsair.HighEmphasis = true;
            this.txtsair.Icon = null;
            this.txtsair.Location = new System.Drawing.Point(647, 21);
            this.txtsair.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtsair.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtsair.Name = "txtsair";
            this.txtsair.NoAccentTextColor = System.Drawing.Color.Empty;
            this.txtsair.Size = new System.Drawing.Size(97, 36);
            this.txtsair.TabIndex = 0;
            this.txtsair.Text = "SAIR";
            this.txtsair.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.txtsair.UseAccentColor = false;
            this.txtsair.UseVisualStyleBackColor = true;
            this.txtsair.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(4, 586);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(565, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // txtobs
            // 
            this.txtobs.AnimateReadOnly = false;
            this.txtobs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtobs.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtobs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtobs.Depth = 0;
            this.txtobs.HideSelection = true;
            this.txtobs.Hint = "Observações";
            this.txtobs.Location = new System.Drawing.Point(4, 13);
            this.txtobs.Margin = new System.Windows.Forms.Padding(2);
            this.txtobs.MaxLength = 32767;
            this.txtobs.MouseState = MaterialSkin.MouseState.OUT;
            this.txtobs.Name = "txtobs";
            this.txtobs.PasswordChar = '\0';
            this.txtobs.ReadOnly = false;
            this.txtobs.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtobs.SelectedText = "";
            this.txtobs.SelectionLength = 0;
            this.txtobs.SelectionStart = 0;
            this.txtobs.ShortcutsEnabled = true;
            this.txtobs.Size = new System.Drawing.Size(751, 452);
            this.txtobs.TabIndex = 2;
            this.txtobs.TabStop = false;
            this.txtobs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtobs.UseSystemPasswordChar = false;
            // 
            // btopesquisar
            // 
            this.btopesquisar.AutoSize = false;
            this.btopesquisar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btopesquisar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btopesquisar.Depth = 0;
            this.btopesquisar.HighEmphasis = true;
            this.btopesquisar.Icon = null;
            this.btopesquisar.Location = new System.Drawing.Point(588, 36);
            this.btopesquisar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btopesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btopesquisar.Name = "btopesquisar";
            this.btopesquisar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btopesquisar.Size = new System.Drawing.Size(41, 33);
            this.btopesquisar.TabIndex = 12;
            this.btopesquisar.Text = "...";
            this.btopesquisar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btopesquisar.UseAccentColor = false;
            this.btopesquisar.UseVisualStyleBackColor = true;
            this.btopesquisar.Click += new System.EventHandler(this.btopesquisar_Click);
            // 
            // frmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 662);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCliente";
            this.Padding = new System.Windows.Forms.Padding(2, 52, 2, 2);
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro do Cliente";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCliente_FormClosed);
            this.Load += new System.EventHandler(this.frmCliente_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtid;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtobs;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtcidade;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtlogradouro;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtnome;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtcpf;
        private MaterialSkin.Controls.MaterialComboBox cbouf;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtbairro;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtcep;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtdata;
        private MaterialSkin.Controls.MaterialMaskedTextBox txttelefone2;
        private MaterialSkin.Controls.MaterialMaskedTextBox txttelefone1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtemail;
        private MaterialSkin.Controls.MaterialComboBox cbostatus;
        private MaterialSkin.Controls.MaterialMaskedTextBox txtnascimento;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtnumero;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtcomplemento;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialButton btoalterar;
        private MaterialSkin.Controls.MaterialButton btocadastrar;
        private MaterialSkin.Controls.MaterialButton btoexcluir;
        private MaterialSkin.Controls.MaterialButton btolimpar;
        private MaterialSkin.Controls.MaterialButton txtsair;
        private MaterialSkin.Controls.MaterialButton btopesquisar;
    }
}