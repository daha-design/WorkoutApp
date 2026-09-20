using Microsoft.VisualBasic;
using System;
using System.Windows.Forms;
using WorkoutApp.Model;

namespace WorkoutApp.WinForms
{
    public partial class MainForm : Form
    {
        private Logic _logic = new Logic();

        public MainForm()
        {
            InitializeComponent();
            dgvWorkouts.SelectionChanged += DgvWorkouts_SelectionChanged;
            Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void RefreshGrid()
        {
            dgvWorkouts.DataSource = null;
            dgvWorkouts.DataSource = _logic.GetWorkouts();

            lblTotal.Text = $"Общий вес: {_logic.GetTotalLiftedWeights()} кг";

            var stats = _logic.GetWorkoutsCountBytype();
            string statsText = "Статистика: ";
            foreach (var pair in stats)
                statsText += $"{pair.Key} — {pair.Value}; ";
            lblStats.Text = statsText;
        }

        private void DgvWorkouts_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvWorkouts.CurrentRow == null) return;
            var w = (Workout)dgvWorkouts.CurrentRow.DataBoundItem;

            txtexercise.Text = w.exercise;
            txttype.Text = w.type;
            numsets.Value = w.sets;
            numreps.Value = w.reps;
            numweights.Value = (decimal)w.weights;
            dtpdate.Value = w.date;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _logic.CreateWorkout(txtexercise.Text, txttype.Text,
                    (int)numsets.Value, (int)numreps.Value,
                    (double)numweights.Value, dtpdate.Value);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvWorkouts.CurrentRow == null)
            {
                MessageBox.Show("Выберите тренировку.");
                return;
            }
            var w = (Workout)dgvWorkouts.CurrentRow.DataBoundItem;
            try
            {
                _logic.UpdateWorkout(w.id, txtexercise.Text, txttype.Text,
                    (int)numsets.Value, (int)numreps.Value,
                    (double)numweights.Value, dtpdate.Value);
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvWorkouts.CurrentRow == null)
            {
                MessageBox.Show("Выберите тренировку.");
                return;
            }
            var w = (Workout)dgvWorkouts.CurrentRow.DataBoundItem;
            _logic.DeleteWorkout(w.id);
            RefreshGrid();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }
    }
}