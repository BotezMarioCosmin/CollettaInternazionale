namespace CollettaDizionario
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
            this.labelTotal = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonTotale = new System.Windows.Forms.Button();
            this.textBoxTotale = new System.Windows.Forms.TextBox();
            this.textBoxImporto = new System.Windows.Forms.TextBox();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.buttonCancella = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.labelTotaleVersato = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelValuta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(9, 8);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(71, 24);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total: 0";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(8, 52);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(205, 295);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // buttonTotale
            // 
            this.buttonTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTotale.Location = new System.Drawing.Point(549, 2);
            this.buttonTotale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonTotale.Name = "buttonTotale";
            this.buttonTotale.Size = new System.Drawing.Size(95, 34);
            this.buttonTotale.TabIndex = 5;
            this.buttonTotale.Text = "Imposta";
            this.buttonTotale.UseVisualStyleBackColor = true;
            this.buttonTotale.Click += new System.EventHandler(this.buttonTotale_Click);
            // 
            // textBoxTotale
            // 
            this.textBoxTotale.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTotale.Location = new System.Drawing.Point(451, 6);
            this.textBoxTotale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTotale.Name = "textBoxTotale";
            this.textBoxTotale.Size = new System.Drawing.Size(95, 29);
            this.textBoxTotale.TabIndex = 6;
            // 
            // textBoxImporto
            // 
            this.textBoxImporto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxImporto.Location = new System.Drawing.Point(454, 57);
            this.textBoxImporto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxImporto.Name = "textBoxImporto";
            this.textBoxImporto.Size = new System.Drawing.Size(191, 29);
            this.textBoxImporto.TabIndex = 8;
            this.textBoxImporto.Text = "Importo";
            this.textBoxImporto.Click += new System.EventHandler(this.textBoxAggiungiImporto_Click);
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiungi.Location = new System.Drawing.Point(245, 98);
            this.buttonAggiungi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(131, 34);
            this.buttonAggiungi.TabIndex = 7;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // textBoxNome
            // 
            this.textBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNome.Location = new System.Drawing.Point(247, 57);
            this.textBoxNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(205, 29);
            this.textBoxNome.TabIndex = 9;
            this.textBoxNome.Text = "Nome";
            this.textBoxNome.Click += new System.EventHandler(this.textBoxAggiungiNome_Click);
            // 
            // buttonCancella
            // 
            this.buttonCancella.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancella.Location = new System.Drawing.Point(380, 98);
            this.buttonCancella.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancella.Name = "buttonCancella";
            this.buttonCancella.Size = new System.Drawing.Size(131, 34);
            this.buttonCancella.TabIndex = 10;
            this.buttonCancella.Text = "Cancella";
            this.buttonCancella.UseVisualStyleBackColor = true;
            this.buttonCancella.Click += new System.EventHandler(this.buttonCancella_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifica.Location = new System.Drawing.Point(513, 98);
            this.buttonModifica.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(131, 34);
            this.buttonModifica.TabIndex = 11;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // labelTotaleVersato
            // 
            this.labelTotaleVersato.AutoSize = true;
            this.labelTotaleVersato.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotaleVersato.Location = new System.Drawing.Point(242, 151);
            this.labelTotaleVersato.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotaleVersato.Name = "labelTotaleVersato";
            this.labelTotaleVersato.Size = new System.Drawing.Size(172, 26);
            this.labelTotaleVersato.TabIndex = 12;
            this.labelTotaleVersato.Text = "Totale versato: 0";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(333, 228);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 33);
            this.comboBox1.TabIndex = 13;
            // 
            // labelValuta
            // 
            this.labelValuta.AutoSize = true;
            this.labelValuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValuta.Location = new System.Drawing.Point(242, 231);
            this.labelValuta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelValuta.Name = "labelValuta";
            this.labelValuta.Size = new System.Drawing.Size(86, 26);
            this.labelValuta.TabIndex = 14;
            this.labelValuta.Text = "Valuta: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 354);
            this.Controls.Add(this.labelValuta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelTotaleVersato);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonCancella);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.textBoxImporto);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.textBoxTotale);
            this.Controls.Add(this.buttonTotale);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.labelTotal);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonTotale;
        private System.Windows.Forms.TextBox textBoxTotale;
        private System.Windows.Forms.TextBox textBoxImporto;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.Button buttonCancella;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.Label labelTotaleVersato;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelValuta;
    }
}

