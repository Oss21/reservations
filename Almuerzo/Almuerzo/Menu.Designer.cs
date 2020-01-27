namespace Almuerzo
{
	partial class Menu
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.btAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIdentification = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbProtein = new System.Windows.Forms.ComboBox();
            this.tbGrain = new System.Windows.Forms.ComboBox();
            this.tbSalad = new System.Windows.Forms.ComboBox();
            this.identificationError = new System.Windows.Forms.ErrorProvider(this.components);
            this.nameError = new System.Windows.Forms.ErrorProvider(this.components);
            this.SeeRecord = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.identificationError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).BeginInit();
            this.SuspendLayout();
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(344, 299);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 0;
            this.btAdd.Text = "Agregar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Proteina";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Granos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ensalada";
            // 
            // tbIdentification
            // 
            this.tbIdentification.Location = new System.Drawing.Point(131, 108);
            this.tbIdentification.Name = "tbIdentification";
            this.tbIdentification.Size = new System.Drawing.Size(216, 20);
            this.tbIdentification.TabIndex = 6;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(131, 143);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(216, 20);
            this.tbName.TabIndex = 9;
            // 
            // tbProtein
            // 
            this.tbProtein.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbProtein.FormattingEnabled = true;
            this.tbProtein.Location = new System.Drawing.Point(131, 178);
            this.tbProtein.Name = "tbProtein";
            this.tbProtein.Size = new System.Drawing.Size(216, 21);
            this.tbProtein.TabIndex = 10;
            // 
            // tbGrain
            // 
            this.tbGrain.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbGrain.FormattingEnabled = true;
            this.tbGrain.Location = new System.Drawing.Point(131, 210);
            this.tbGrain.Name = "tbGrain";
            this.tbGrain.Size = new System.Drawing.Size(216, 21);
            this.tbGrain.TabIndex = 11;
            // 
            // tbSalad
            // 
            this.tbSalad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tbSalad.FormattingEnabled = true;
            this.tbSalad.Location = new System.Drawing.Point(131, 237);
            this.tbSalad.Name = "tbSalad";
            this.tbSalad.Size = new System.Drawing.Size(216, 21);
            this.tbSalad.TabIndex = 12;
            // 
            // identificationError
            // 
            this.identificationError.ContainerControl = this;
            // 
            // nameError
            // 
            this.nameError.ContainerControl = this;
            // 
            // SeeRecord
            // 
            this.SeeRecord.Location = new System.Drawing.Point(263, 299);
            this.SeeRecord.Name = "SeeRecord";
            this.SeeRecord.Size = new System.Drawing.Size(75, 23);
            this.SeeRecord.TabIndex = 13;
            this.SeeRecord.Text = "Registros";
            this.SeeRecord.UseVisualStyleBackColor = true;
            this.SeeRecord.Click += new System.EventHandler(this.SeeRecord_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 344);
            this.Controls.Add(this.SeeRecord);
            this.Controls.Add(this.tbSalad);
            this.Controls.Add(this.tbGrain);
            this.Controls.Add(this.tbProtein);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.tbIdentification);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAdd);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.identificationError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nameError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btAdd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIdentification;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox tbProtein;
        private System.Windows.Forms.ComboBox tbGrain;
        private System.Windows.Forms.ComboBox tbSalad;
        private System.Windows.Forms.ErrorProvider identificationError;
        private System.Windows.Forms.ErrorProvider nameError;
        private System.Windows.Forms.Button SeeRecord;
    }
}

