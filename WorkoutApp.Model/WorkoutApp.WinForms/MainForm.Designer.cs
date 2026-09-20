namespace WorkoutApp.WinForms
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtexercise = new TextBox();
            txttype = new TextBox();
            numsets = new NumericUpDown();
            numreps = new NumericUpDown();
            numweights = new NumericUpDown();
            dtpdate = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnReFresh = new Button();
            dgvWorkouts = new DataGridView();
            lblTotal = new Label();
            lblStats = new Label();
            ((System.ComponentModel.ISupportInitialize)numsets).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numreps).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numweights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).BeginInit();
            SuspendLayout();
            // 
            // txtexercise
            // 
            txtexercise.Location = new Point(28, 31);
            txtexercise.Name = "txtexercise";
            txtexercise.Size = new Size(125, 27);
            txtexercise.TabIndex = 0;
            // 
            // txttype
            // 
            txttype.Location = new Point(28, 77);
            txttype.Name = "txttype";
            txttype.Size = new Size(125, 27);
            txttype.TabIndex = 1;
            // 
            // numsets
            // 
            numsets.Location = new Point(28, 134);
            numsets.Name = "numsets";
            numsets.Size = new Size(150, 27);
            numsets.TabIndex = 2;
            numsets.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numreps
            // 
            numreps.Location = new Point(28, 180);
            numreps.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numreps.Name = "numreps";
            numreps.Size = new Size(150, 27);
            numreps.TabIndex = 3;
            numreps.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numweights
            // 
            numweights.DecimalPlaces = 1;
            numweights.Location = new Point(28, 227);
            numweights.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numweights.Name = "numweights";
            numweights.Size = new Size(150, 27);
            numweights.TabIndex = 4;
            // 
            // dtpdate
            // 
            dtpdate.Location = new Point(251, 29);
            dtpdate.Name = "dtpdate";
            dtpdate.Size = new Size(250, 27);
            dtpdate.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(251, 77);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(251, 134);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Изменить";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(251, 190);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 8;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnReFresh
            // 
            btnReFresh.Location = new Point(251, 243);
            btnReFresh.Name = "btnReFresh";
            btnReFresh.Size = new Size(94, 29);
            btnReFresh.TabIndex = 9;
            btnReFresh.Text = "Обновить";
            btnReFresh.UseVisualStyleBackColor = true;
            btnReFresh.Click += btnRefresh_Click;
            // 
            // dgvWorkouts
            // 
            dgvWorkouts.AllowUserToAddRows = false;
            dgvWorkouts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvWorkouts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvWorkouts.Location = new Point(12, 307);
            dgvWorkouts.Name = "dgvWorkouts";
            dgvWorkouts.ReadOnly = true;
            dgvWorkouts.RowHeadersWidth = 51;
            dgvWorkouts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvWorkouts.Size = new Size(459, 188);
            dgvWorkouts.TabIndex = 10;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(437, 86);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(50, 20);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "label1";
            // 
            // lblStats
            // 
            lblStats.AutoSize = true;
            lblStats.Location = new Point(437, 138);
            lblStats.Name = "lblStats";
            lblStats.Size = new Size(50, 20);
            lblStats.TabIndex = 12;
            lblStats.Text = "label1";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 600);
            Controls.Add(lblStats);
            Controls.Add(lblTotal);
            Controls.Add(dgvWorkouts);
            Controls.Add(btnReFresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dtpdate);
            Controls.Add(numweights);
            Controls.Add(numreps);
            Controls.Add(numsets);
            Controls.Add(txttype);
            Controls.Add(txtexercise);
            Name = "MainForm";
            Text = "Тренировки";
            ((System.ComponentModel.ISupportInitialize)numsets).EndInit();
            ((System.ComponentModel.ISupportInitialize)numreps).EndInit();
            ((System.ComponentModel.ISupportInitialize)numweights).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvWorkouts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private TextBox txtexercise;
        private TextBox txttype;
        private NumericUpDown numsets;
        private NumericUpDown numreps;
        private NumericUpDown numweights;
        private DateTimePicker dtpdate;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnReFresh;
        private DataGridView dgvWorkouts;
        private Label lblTotal;
        private Label lblStats;
    }
}
