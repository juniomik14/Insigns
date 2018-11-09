namespace prueba
{
    partial class Form1
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
            this.badgesDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.badgesDataSet = new prueba.BadgesDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.userTypesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTypesTableAdapter = new prueba.BadgesDataSetTableAdapters.UserTypesTableAdapter();
            this.idUserTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levelAccesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.badgesDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // badgesDataSetBindingSource
            // 
            this.badgesDataSetBindingSource.DataSource = this.badgesDataSet;
            this.badgesDataSetBindingSource.Position = 0;
            // 
            // badgesDataSet
            // 
            this.badgesDataSet.DataSetName = "BadgesDataSet";
            this.badgesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Show";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idUserTypeDataGridViewTextBoxColumn,
            this.codeTypeDataGridViewTextBoxColumn,
            this.descTypeDataGridViewTextBoxColumn,
            this.levelAccesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userTypesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(666, 220);
            this.dataGridView1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(178, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userTypesBindingSource
            // 
            this.userTypesBindingSource.DataMember = "UserTypes";
            this.userTypesBindingSource.DataSource = this.badgesDataSet;
            // 
            // userTypesTableAdapter
            // 
            this.userTypesTableAdapter.ClearBeforeFill = true;
            // 
            // idUserTypeDataGridViewTextBoxColumn
            // 
            this.idUserTypeDataGridViewTextBoxColumn.DataPropertyName = "IdUserType";
            this.idUserTypeDataGridViewTextBoxColumn.HeaderText = "IdUserType";
            this.idUserTypeDataGridViewTextBoxColumn.Name = "idUserTypeDataGridViewTextBoxColumn";
            // 
            // codeTypeDataGridViewTextBoxColumn
            // 
            this.codeTypeDataGridViewTextBoxColumn.DataPropertyName = "CodeType";
            this.codeTypeDataGridViewTextBoxColumn.HeaderText = "CodeType";
            this.codeTypeDataGridViewTextBoxColumn.Name = "codeTypeDataGridViewTextBoxColumn";
            // 
            // descTypeDataGridViewTextBoxColumn
            // 
            this.descTypeDataGridViewTextBoxColumn.DataPropertyName = "DescType";
            this.descTypeDataGridViewTextBoxColumn.HeaderText = "DescType";
            this.descTypeDataGridViewTextBoxColumn.Name = "descTypeDataGridViewTextBoxColumn";
            // 
            // levelAccesDataGridViewTextBoxColumn
            // 
            this.levelAccesDataGridViewTextBoxColumn.DataPropertyName = "LevelAcces";
            this.levelAccesDataGridViewTextBoxColumn.HeaderText = "LevelAcces";
            this.levelAccesDataGridViewTextBoxColumn.Name = "levelAccesDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.badgesDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.badgesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTypesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource badgesDataSetBindingSource;
        private BadgesDataSet badgesDataSet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource userTypesBindingSource;
        private BadgesDataSetTableAdapters.UserTypesTableAdapter userTypesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idUserTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn levelAccesDataGridViewTextBoxColumn;
    }
}

