namespace ProjetoPizzaria
{
    partial class Form1
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
            this.lblValorPizza = new System.Windows.Forms.Label();
            this.lblValorOpcionais = new System.Windows.Forms.Label();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.lblValorPagar = new System.Windows.Forms.Label();
            this.dgvPedido = new System.Windows.Forms.DataGridView();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.cmbTamanhoPizza = new System.Windows.Forms.ComboBox();
            this.chkBorda = new System.Windows.Forms.CheckBox();
            this.chkCebola = new System.Windows.Forms.CheckBox();
            this.chkCatupiry = new System.Windows.Forms.CheckBox();
            this.chkTempero = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.grpOpcionais = new System.Windows.Forms.GroupBox();
            this.txtValorPizza = new System.Windows.Forms.TextBox();
            this.txtValorOpcionais = new System.Windows.Forms.TextBox();
            this.txtValorPagar = new System.Windows.Forms.TextBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).BeginInit();
            this.grpOpcionais.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblValorPizza
            // 
            this.lblValorPizza.AutoSize = true;
            this.lblValorPizza.Location = new System.Drawing.Point(272, 55);
            this.lblValorPizza.Name = "lblValorPizza";
            this.lblValorPizza.Size = new System.Drawing.Size(95, 13);
            this.lblValorPizza.TabIndex = 0;
            this.lblValorPizza.Text = "VALOR DA PIZZA";
            // 
            // lblValorOpcionais
            // 
            this.lblValorOpcionais.AutoSize = true;
            this.lblValorOpcionais.Location = new System.Drawing.Point(428, 55);
            this.lblValorOpcionais.Name = "lblValorOpcionais";
            this.lblValorOpcionais.Size = new System.Drawing.Size(130, 13);
            this.lblValorOpcionais.TabIndex = 1;
            this.lblValorOpcionais.Text = "VALOR DOS OPCIONAIS";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(272, 141);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(69, 13);
            this.lblPesquisar.TabIndex = 2;
            this.lblPesquisar.Text = "PESQUISAR";
            // 
            // lblValorPagar
            // 
            this.lblValorPagar.AutoSize = true;
            this.lblValorPagar.Location = new System.Drawing.Point(608, 55);
            this.lblValorPagar.Name = "lblValorPagar";
            this.lblValorPagar.Size = new System.Drawing.Size(93, 13);
            this.lblValorPagar.TabIndex = 3;
            this.lblValorPagar.Text = "VALOR A PAGAR";
            // 
            // dgvPedido
            // 
            this.dgvPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPedido.Location = new System.Drawing.Point(39, 250);
            this.dgvPedido.Name = "dgvPedido";
            this.dgvPedido.Size = new System.Drawing.Size(662, 130);
            this.dgvPedido.TabIndex = 4;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(79, 395);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(160, 23);
            this.btnNovo.TabIndex = 5;
            this.btnNovo.Text = "NOVO";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(229, 395);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(146, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "SALVAR";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(372, 395);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(157, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(524, 395);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(135, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // cmbTamanhoPizza
            // 
            this.cmbTamanhoPizza.FormattingEnabled = true;
            this.cmbTamanhoPizza.Location = new System.Drawing.Point(39, 52);
            this.cmbTamanhoPizza.Name = "cmbTamanhoPizza";
            this.cmbTamanhoPizza.Size = new System.Drawing.Size(131, 21);
            this.cmbTamanhoPizza.TabIndex = 9;
            this.cmbTamanhoPizza.Text = "TAMANHO DA PIZZA";
            // 
            // chkBorda
            // 
            this.chkBorda.AutoSize = true;
            this.chkBorda.Location = new System.Drawing.Point(0, 42);
            this.chkBorda.Name = "chkBorda";
            this.chkBorda.Size = new System.Drawing.Size(107, 17);
            this.chkBorda.TabIndex = 10;
            this.chkBorda.Text = "Borda Recheada";
            this.chkBorda.UseVisualStyleBackColor = true;
            // 
            // chkCebola
            // 
            this.chkCebola.AutoSize = true;
            this.chkCebola.Location = new System.Drawing.Point(0, 65);
            this.chkCebola.Name = "chkCebola";
            this.chkCebola.Size = new System.Drawing.Size(111, 17);
            this.chkCebola.TabIndex = 11;
            this.chkCebola.Text = "Cebola sem choro";
            this.chkCebola.UseVisualStyleBackColor = true;
            // 
            // chkCatupiry
            // 
            this.chkCatupiry.AutoSize = true;
            this.chkCatupiry.Location = new System.Drawing.Point(0, 88);
            this.chkCatupiry.Name = "chkCatupiry";
            this.chkCatupiry.Size = new System.Drawing.Size(102, 17);
            this.chkCatupiry.TabIndex = 12;
            this.chkCatupiry.Text = "Catupiry Original";
            this.chkCatupiry.UseVisualStyleBackColor = true;
            // 
            // chkTempero
            // 
            this.chkTempero.AutoSize = true;
            this.chkTempero.Location = new System.Drawing.Point(0, 111);
            this.chkTempero.Name = "chkTempero";
            this.chkTempero.Size = new System.Drawing.Size(103, 17);
            this.chkTempero.TabIndex = 13;
            this.chkTempero.Text = "Tempero do City";
            this.chkTempero.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(39, 29);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(80, 17);
            this.checkBox5.TabIndex = 14;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // grpOpcionais
            // 
            this.grpOpcionais.Controls.Add(this.chkBorda);
            this.grpOpcionais.Controls.Add(this.chkCebola);
            this.grpOpcionais.Controls.Add(this.chkTempero);
            this.grpOpcionais.Controls.Add(this.chkCatupiry);
            this.grpOpcionais.Location = new System.Drawing.Point(39, 84);
            this.grpOpcionais.Name = "grpOpcionais";
            this.grpOpcionais.Size = new System.Drawing.Size(200, 158);
            this.grpOpcionais.TabIndex = 15;
            this.grpOpcionais.TabStop = false;
            this.grpOpcionais.Text = "ESCOLHA OPCIONAIS";
            // 
            // txtValorPizza
            // 
            this.txtValorPizza.Location = new System.Drawing.Point(275, 84);
            this.txtValorPizza.Name = "txtValorPizza";
            this.txtValorPizza.Size = new System.Drawing.Size(92, 20);
            this.txtValorPizza.TabIndex = 16;
            // 
            // txtValorOpcionais
            // 
            this.txtValorOpcionais.Location = new System.Drawing.Point(431, 85);
            this.txtValorOpcionais.Name = "txtValorOpcionais";
            this.txtValorOpcionais.Size = new System.Drawing.Size(127, 20);
            this.txtValorOpcionais.TabIndex = 17;
            // 
            // txtValorPagar
            // 
            this.txtValorPagar.Location = new System.Drawing.Point(611, 85);
            this.txtValorPagar.Name = "txtValorPagar";
            this.txtValorPagar.Size = new System.Drawing.Size(90, 20);
            this.txtValorPagar.TabIndex = 18;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(347, 138);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(100, 20);
            this.txtPesquisar.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.txtValorPagar);
            this.Controls.Add(this.txtValorOpcionais);
            this.Controls.Add(this.txtValorPizza);
            this.Controls.Add(this.grpOpcionais);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.cmbTamanhoPizza);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.dgvPedido);
            this.Controls.Add(this.lblValorPagar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.lblValorOpcionais);
            this.Controls.Add(this.lblValorPizza);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPedido)).EndInit();
            this.grpOpcionais.ResumeLayout(false);
            this.grpOpcionais.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValorPizza;
        private System.Windows.Forms.Label lblValorOpcionais;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Label lblValorPagar;
        private System.Windows.Forms.DataGridView dgvPedido;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox cmbTamanhoPizza;
        private System.Windows.Forms.CheckBox chkBorda;
        private System.Windows.Forms.CheckBox chkCebola;
        private System.Windows.Forms.CheckBox chkCatupiry;
        private System.Windows.Forms.CheckBox chkTempero;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.GroupBox grpOpcionais;
        private System.Windows.Forms.TextBox txtValorPizza;
        private System.Windows.Forms.TextBox txtValorOpcionais;
        private System.Windows.Forms.TextBox txtValorPagar;
        private System.Windows.Forms.TextBox txtPesquisar;
    }
}

