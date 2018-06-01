namespace lec5
{
    partial class Results
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._lec5_GameModelDataSet = new lec5._lec5_GameModelDataSet();
            this.lec5GameModelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gameEntitiesTableAdapter = new lec5._lec5_GameModelDataSetTableAdapters.GameEntitiesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._lec5_GameModelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lec5GameModelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.winnerDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gameEntitiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 20);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(345, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // _lec5_GameModelDataSet
            // 
            this._lec5_GameModelDataSet.DataSetName = "_lec5_GameModelDataSet";
            this._lec5_GameModelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lec5GameModelDataSetBindingSource
            // 
            this.lec5GameModelDataSetBindingSource.DataSource = this._lec5_GameModelDataSet;
            this.lec5GameModelDataSetBindingSource.Position = 0;
            // 
            // gameEntitiesBindingSource
            // 
            this.gameEntitiesBindingSource.DataMember = "GameEntities";
            this.gameEntitiesBindingSource.DataSource = this._lec5_GameModelDataSet;
            // 
            // gameEntitiesTableAdapter
            // 
            this.gameEntitiesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // winnerDataGridViewTextBoxColumn
            // 
            this.winnerDataGridViewTextBoxColumn.DataPropertyName = "Winner";
            this.winnerDataGridViewTextBoxColumn.HeaderText = "Winner";
            this.winnerDataGridViewTextBoxColumn.Name = "winnerDataGridViewTextBoxColumn";
            this.winnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Results
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Results";
            this.Text = "Results";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._lec5_GameModelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lec5GameModelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gameEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource lec5GameModelDataSetBindingSource;
        private _lec5_GameModelDataSet _lec5_GameModelDataSet;
        private System.Windows.Forms.BindingSource gameEntitiesBindingSource;
        private _lec5_GameModelDataSetTableAdapters.GameEntitiesTableAdapter gameEntitiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn winnerDataGridViewTextBoxColumn;
    }
}