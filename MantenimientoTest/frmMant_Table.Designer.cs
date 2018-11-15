namespace MantenimientoTest
{
    partial class frmMant_Table
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
            this.dgvMant_table = new System.Windows.Forms.DataGridView();
            this.lblCodeType = new System.Windows.Forms.Label();
            this.lblDescType = new System.Windows.Forms.Label();
            this.lblLevelAcces = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtBoxLevelAcces = new MantenimientoTest.SdsTextBox();
            this.txtBoxDescType = new MantenimientoTest.SdsTextBox();
            this.txtBoxCodeType = new MantenimientoTest.SdsTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMant_table)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMant_table
            // 
            this.dgvMant_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMant_table.Location = new System.Drawing.Point(314, 160);
            this.dgvMant_table.Name = "dgvMant_table";
            this.dgvMant_table.Size = new System.Drawing.Size(406, 278);
            this.dgvMant_table.TabIndex = 0;
            // 
            // lblCodeType
            // 
            this.lblCodeType.AutoSize = true;
            this.lblCodeType.Location = new System.Drawing.Point(56, 124);
            this.lblCodeType.Name = "lblCodeType";
            this.lblCodeType.Size = new System.Drawing.Size(56, 13);
            this.lblCodeType.TabIndex = 4;
            this.lblCodeType.Text = "CodeType";
            // 
            // lblDescType
            // 
            this.lblDescType.AutoSize = true;
            this.lblDescType.Location = new System.Drawing.Point(56, 176);
            this.lblDescType.Name = "lblDescType";
            this.lblDescType.Size = new System.Drawing.Size(56, 13);
            this.lblDescType.TabIndex = 5;
            this.lblDescType.Text = "DescType";
            // 
            // lblLevelAcces
            // 
            this.lblLevelAcces.AutoSize = true;
            this.lblLevelAcces.Location = new System.Drawing.Point(56, 227);
            this.lblLevelAcces.Name = "lblLevelAcces";
            this.lblLevelAcces.Size = new System.Drawing.Size(63, 13);
            this.lblLevelAcces.TabIndex = 6;
            this.lblLevelAcces.Text = "LevelAcces";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(33, 378);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(138, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtBoxLevelAcces
            // 
            this.txtBoxLevelAcces.ColumnName = "LevelAcces";
            this.txtBoxLevelAcces.Location = new System.Drawing.Point(56, 243);
            this.txtBoxLevelAcces.Name = "txtBoxLevelAcces";
            this.txtBoxLevelAcces.Nom = "";
            this.txtBoxLevelAcces.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLevelAcces.TabIndex = 3;
            // 
            // txtBoxDescType
            // 
            this.txtBoxDescType.ColumnName = "DescType";
            this.txtBoxDescType.Location = new System.Drawing.Point(56, 192);
            this.txtBoxDescType.Name = "txtBoxDescType";
            this.txtBoxDescType.Nom = "";
            this.txtBoxDescType.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDescType.TabIndex = 2;
            // 
            // txtBoxCodeType
            // 
            this.txtBoxCodeType.ColumnName = "CodeType";
            this.txtBoxCodeType.Location = new System.Drawing.Point(56, 143);
            this.txtBoxCodeType.Name = "txtBoxCodeType";
            this.txtBoxCodeType.Nom = "";
            this.txtBoxCodeType.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodeType.TabIndex = 1;
            this.txtBoxCodeType.Tag = "CodeType";
            // 
            // frmMant_Table
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblLevelAcces);
            this.Controls.Add(this.lblDescType);
            this.Controls.Add(this.lblCodeType);
            this.Controls.Add(this.txtBoxLevelAcces);
            this.Controls.Add(this.txtBoxDescType);
            this.Controls.Add(this.txtBoxCodeType);
            this.Controls.Add(this.dgvMant_table);
            this.Name = "frmMant_Table";
            this.Text = "frmMant_Table";
            this.Load += new System.EventHandler(this.frmMant_Table_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMant_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMant_table;
        private SdsTextBox txtBoxCodeType;
        private SdsTextBox txtBoxDescType;
        private SdsTextBox txtBoxLevelAcces;
        private System.Windows.Forms.Label lblCodeType;
        private System.Windows.Forms.Label lblDescType;
        private System.Windows.Forms.Label lblLevelAcces;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
    }
}

