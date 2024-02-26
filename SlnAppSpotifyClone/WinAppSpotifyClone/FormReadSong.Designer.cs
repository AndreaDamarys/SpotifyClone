namespace WinAppSpotifyClone
{
    partial class FormReadSong
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
            this.bDD_SpotifyMusicDataSet = new WinAppSpotifyClone.BDD_SpotifyMusicDataSet();
            this.tBLSONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tBL_SONGTableAdapter = new WinAppSpotifyClone.BDD_SpotifyMusicDataSetTableAdapters.TBL_SONGTableAdapter();
            this.iDSONGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sONGPATHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pLAYSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_SpotifyMusicDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSONGBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Thistle;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDSONGDataGridViewTextBoxColumn,
            this.sONGNAMEDataGridViewTextBoxColumn,
            this.sONGPATHDataGridViewTextBoxColumn,
            this.pLAYSDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tBLSONGBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 175);
            this.dataGridView1.TabIndex = 0;
            // 
            // bDD_SpotifyMusicDataSet
            // 
            this.bDD_SpotifyMusicDataSet.DataSetName = "BDD_SpotifyMusicDataSet";
            this.bDD_SpotifyMusicDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tBLSONGBindingSource
            // 
            this.tBLSONGBindingSource.DataMember = "TBL_SONG";
            this.tBLSONGBindingSource.DataSource = this.bDD_SpotifyMusicDataSet;
            // 
            // tBL_SONGTableAdapter
            // 
            this.tBL_SONGTableAdapter.ClearBeforeFill = true;
            // 
            // iDSONGDataGridViewTextBoxColumn
            // 
            this.iDSONGDataGridViewTextBoxColumn.DataPropertyName = "ID_SONG";
            this.iDSONGDataGridViewTextBoxColumn.HeaderText = "ID_SONG";
            this.iDSONGDataGridViewTextBoxColumn.Name = "iDSONGDataGridViewTextBoxColumn";
            this.iDSONGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sONGNAMEDataGridViewTextBoxColumn
            // 
            this.sONGNAMEDataGridViewTextBoxColumn.DataPropertyName = "SONG_NAME";
            this.sONGNAMEDataGridViewTextBoxColumn.HeaderText = "SONG_NAME";
            this.sONGNAMEDataGridViewTextBoxColumn.Name = "sONGNAMEDataGridViewTextBoxColumn";
            // 
            // sONGPATHDataGridViewTextBoxColumn
            // 
            this.sONGPATHDataGridViewTextBoxColumn.DataPropertyName = "SONG_PATH";
            this.sONGPATHDataGridViewTextBoxColumn.HeaderText = "SONG_PATH";
            this.sONGPATHDataGridViewTextBoxColumn.Name = "sONGPATHDataGridViewTextBoxColumn";
            // 
            // pLAYSDataGridViewTextBoxColumn
            // 
            this.pLAYSDataGridViewTextBoxColumn.DataPropertyName = "PLAYS";
            this.pLAYSDataGridViewTextBoxColumn.HeaderText = "PLAYS";
            this.pLAYSDataGridViewTextBoxColumn.Name = "pLAYSDataGridViewTextBoxColumn";
            // 
            // FormReadSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 199);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormReadSong";
            this.Text = "Song Player";
            this.Load += new System.EventHandler(this.FormReadSong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDD_SpotifyMusicDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tBLSONGBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BDD_SpotifyMusicDataSet bDD_SpotifyMusicDataSet;
        private System.Windows.Forms.BindingSource tBLSONGBindingSource;
        private BDD_SpotifyMusicDataSetTableAdapters.TBL_SONGTableAdapter tBL_SONGTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDSONGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sONGPATHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pLAYSDataGridViewTextBoxColumn;
    }
}