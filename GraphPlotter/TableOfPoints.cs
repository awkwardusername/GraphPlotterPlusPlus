using System;
using System.Windows.Forms;

namespace GraphPlotter {
    public partial class tableOfPoints : Form {
        private Algorithm algorithm;

        public tableOfPoints() { InitializeComponent(); }

        private void button1_Click(object sender, EventArgs e) {
            if (radioBisection.Checked) {
                InitializeTheAlgorithm(1);
            } else if (radioFPosition.Checked) {
                InitializeTheAlgorithm(2);
            } else if (radioSecant.Checked) {
                InitializeTheAlgorithm(3);
            }
        }

        private void lstExpressions_SelectedIndexChanged(object sender, EventArgs e) {
            //initializeTheAlgorithm();
        }

        private void InitializeTheAlgorithm(int operation) {
            algorithm = new Algorithm((int) iterations.Value,
                (double) error.Value,
                (double) lowerBoundary.Value,
                (double) upperBoundary.Value,
                lstExpressions.SelectedValue.ToString(),
                operation);

            dataGridView_TablePoints.DataSource = null;
            dataGridView_TablePoints.DataSource = algorithm.Table;

            dataGridView_TablePoints.Refresh();
        }
    }
}