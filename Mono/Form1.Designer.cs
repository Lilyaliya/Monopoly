namespace Mono
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monopolyDataSet = new Mono.MonopolyDataSet();
            this.сессииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сессииTableAdapter = new Mono.MonopolyDataSetTableAdapters.СессииTableAdapter();
            this.sessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countOfPlayersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.player4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monopolyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сессииBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sessionDataGridViewTextBoxColumn,
            this.countOfPlayersDataGridViewTextBoxColumn,
            this.player1DataGridViewTextBoxColumn,
            this.player2DataGridViewTextBoxColumn,
            this.player3DataGridViewTextBoxColumn,
            this.player4DataGridViewTextBoxColumn,
            this.statusDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.сессииBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(926, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // monopolyDataSet
            // 
            this.monopolyDataSet.DataSetName = "MonopolyDataSet";
            this.monopolyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сессииBindingSource
            // 
            this.сессииBindingSource.DataMember = "Сессии";
            this.сессииBindingSource.DataSource = this.monopolyDataSet;
            // 
            // сессииTableAdapter
            // 
            this.сессииTableAdapter.ClearBeforeFill = true;
            // 
            // sessionDataGridViewTextBoxColumn
            // 
            this.sessionDataGridViewTextBoxColumn.DataPropertyName = "№Session";
            this.sessionDataGridViewTextBoxColumn.HeaderText = "№Session";
            this.sessionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sessionDataGridViewTextBoxColumn.Name = "sessionDataGridViewTextBoxColumn";
            this.sessionDataGridViewTextBoxColumn.Width = 125;
            // 
            // countOfPlayersDataGridViewTextBoxColumn
            // 
            this.countOfPlayersDataGridViewTextBoxColumn.DataPropertyName = "CountOfPlayers";
            this.countOfPlayersDataGridViewTextBoxColumn.HeaderText = "CountOfPlayers";
            this.countOfPlayersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.countOfPlayersDataGridViewTextBoxColumn.Name = "countOfPlayersDataGridViewTextBoxColumn";
            this.countOfPlayersDataGridViewTextBoxColumn.Width = 125;
            // 
            // player1DataGridViewTextBoxColumn
            // 
            this.player1DataGridViewTextBoxColumn.DataPropertyName = "Player1";
            this.player1DataGridViewTextBoxColumn.HeaderText = "Player1";
            this.player1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.player1DataGridViewTextBoxColumn.Name = "player1DataGridViewTextBoxColumn";
            this.player1DataGridViewTextBoxColumn.Width = 125;
            // 
            // player2DataGridViewTextBoxColumn
            // 
            this.player2DataGridViewTextBoxColumn.DataPropertyName = "Player2";
            this.player2DataGridViewTextBoxColumn.HeaderText = "Player2";
            this.player2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.player2DataGridViewTextBoxColumn.Name = "player2DataGridViewTextBoxColumn";
            this.player2DataGridViewTextBoxColumn.Width = 125;
            // 
            // player3DataGridViewTextBoxColumn
            // 
            this.player3DataGridViewTextBoxColumn.DataPropertyName = "Player3";
            this.player3DataGridViewTextBoxColumn.HeaderText = "Player3";
            this.player3DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.player3DataGridViewTextBoxColumn.Name = "player3DataGridViewTextBoxColumn";
            this.player3DataGridViewTextBoxColumn.Width = 125;
            // 
            // player4DataGridViewTextBoxColumn
            // 
            this.player4DataGridViewTextBoxColumn.DataPropertyName = "Player4";
            this.player4DataGridViewTextBoxColumn.HeaderText = "Player4";
            this.player4DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.player4DataGridViewTextBoxColumn.Name = "player4DataGridViewTextBoxColumn";
            this.player4DataGridViewTextBoxColumn.Width = 125;
            // 
            // statusDataGridViewCheckBoxColumn
            // 
            this.statusDataGridViewCheckBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewCheckBoxColumn.HeaderText = "Status";
            this.statusDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewCheckBoxColumn.Name = "statusDataGridViewCheckBoxColumn";
            this.statusDataGridViewCheckBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monopolyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сессииBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private MonopolyDataSet monopolyDataSet;
        private System.Windows.Forms.BindingSource сессииBindingSource;
        private MonopolyDataSetTableAdapters.СессииTableAdapter сессииTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn countOfPlayersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn player1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn player2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn player3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn player4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn statusDataGridViewCheckBoxColumn;
    }
}

