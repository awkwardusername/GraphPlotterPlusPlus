using System;
using System.Drawing;
using System.Windows.Forms;
using ExpressionPlotterControl;

namespace GraphPlotter {
    public partial class Main : Form {
        private readonly Color[] colorLevels = {
                                                   Color.Red, Color.Green, Color.Blue,
                                                   Color.Purple, Color.Brown, Color.Orange, Color.Chocolate,
                                                   Color.Maroon, Color.Navy, Color.YellowGreen
                                               };

        private readonly string[] strFunctions = {
                                                     "abs", "sin", "cos", "tan", "sec", "cosec", "cot", "arcsin",
                                                     "arccos", "arctan", "exp", "ln", "log", "antilog", "sqrt", "sinh",
                                                     "cosh", "tanh",
                                                     "arcsinh", "arccosh", "arctanh"
                                                 };

        private Graph _form;

        private tableOfPoints _tableOfPoints;

        public Main() { InitializeComponent(); }

        #region Event Handlers

        private void Form1_Load(object sender, EventArgs e) {
            mode.SelectedIndex = 0;
            sensitivity.Enabled = false;

            lstExpressions.Items.Add("sin(x)");
            lstExpressions.Items.Add("3*sin(x)*cos(4*x)");
            //lstExpressions.Items.Add("-ln(abs(x))");
            lstExpressions.Items.Add("x*sin(4*x/3)");
            //lstExpressions.Items.Add("x^2-4");
            //lstExpressions.Items.Add("x-3");
            //lstExpressions.Items.Add("5*(sin(x)+sin(3*x)/3+sin(5*x)/5+sin(7*x)/7+sin(9*x)/9+sin(11*x)/11+sin(13*x)/13)");
        }

        private void txtExpression_TextChanged(object sender, EventArgs e) {
            int cursorPosition = txtExpression.SelectionStart;
            WriteText(txtExpression.Text);
            txtExpression.SelectionStart = cursorPosition;
        }

        private void btnAdd_Click(object sender, EventArgs e) {
            AddExpression();
            lstExpressions.SelectedIndex = -1;
            lstExpressions.Refresh();
        }

        private void btnClear_Click(object sender, EventArgs e) { lstExpressions.Items.Clear(); }

        private void btnRemove_Click(object sender, EventArgs e) {
            int index = lstExpressions.SelectedIndex;
            lstExpressions.Items.Remove(lstExpressions.SelectedItem);
            if (index == lstExpressions.Items.Count)
                index--;
            if (index != -1)
                lstExpressions.SelectedIndex = index;
        }

        private void cmdPlotGraph_Click(object sender, EventArgs e) {
            if (_form == null || _form.IsDisposed) {
                _form = new Graph();
                _form.Show();
            }

            if (_tableOfPoints == null || _tableOfPoints.IsDisposed) {
                _tableOfPoints = new tableOfPoints();
                _tableOfPoints.Show();
            }

            _tableOfPoints.lstExpressions.DataSource = null;
            _tableOfPoints.lstExpressions.DataSource = lstExpressions.Items;

            _tableOfPoints.Refresh();
            _tableOfPoints.Activate();

            _form.SetRange((Double) startX.Value, (Double) endX.Value, (Double) startY.Value, (Double) endY.Value);
            _form.SetDivisions((int) divX.Value, (int) divY.Value);
            _form.SetPenWidth((int) penWidth.Value);

            if (mode.SelectedItem.ToString() == "Polar")
                _form.SetMode(GraphMode.Polar, (int) sensitivity.Value);
            else
                _form.SetMode(GraphMode.Rectangular, 50);

            _form.RemoveAllExpressions();
            for (int i = 0; i < lstExpressions.Items.Count; i++) {
                _form.AddExpression((string) lstExpressions.Items[i], colorLevels[i%colorLevels.Length]);
            }

            _form.Refresh();
            _form.Activate();
        }

        private void mode_SelectedIndexChanged(object sender, EventArgs e) {
            sensitivity.Enabled = mode.SelectedIndex == 1;
        }

        private void txtExpression_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == 13 && txtExpression.Text.Length > 0)
                AddExpression();

            //if a letter is found
            if (char.IsLetter(e.KeyChar)) {
                int cursorPos = txtExpression.SelectionStart;
                if (cursorPos > 0) {
                    //if the previous char is a digit, add a *
                    if (char.IsDigit(txtExpression.Text[cursorPos - 1])) {
                        txtExpression.Text = txtExpression.Text.Insert(cursorPos, "*" + e.KeyChar);
                        cursorPos += 2;
                        txtExpression.SelectionStart = cursorPos;
                        e.Handled = true;
                    }
                        //if a function is formed, add a "("
                    else {
                        string text = string.Empty;
                        int i = cursorPos - 1;
                        while (i >= 0) {
                            if (!char.IsLetter(txtExpression.Text[i]))
                                break;
                            i--;
                        }
                        i++;
                        //now i is the index where last text is started
                        if (i < cursorPos)
                            text = txtExpression.Text.Substring(i, cursorPos - i) + e.KeyChar;
                        if (IsFunction(text)) {
                            txtExpression.Text = txtExpression.Text.Insert(cursorPos, e.KeyChar + "(");
                            cursorPos += 2;
                            txtExpression.SelectionStart = cursorPos;
                            e.Handled = true;
                        }
                    }
                }
            }
        }

        private void lstExpressions_SelectedIndexChanged(object sender, EventArgs e) {
            if (lstExpressions.SelectedIndex != -1)
                txtExpression.Text = lstExpressions.Items[lstExpressions.SelectedIndex].ToString();
        }

        #endregion

        #region Helper Functions

        //this functions handles coloring of expressions
        private void WriteText(string text) {
            int colorIndex = 0;
            txtExpression.Text = "";
            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '(') {
                    colorIndex++;
                    if (colorIndex == colorLevels.Length)
                        colorIndex = 0;
                    txtExpression.SelectionColor = colorLevels[colorIndex];
                }

                txtExpression.AppendText(text[i].ToString());

                if (text[i] == ')') {
                    colorIndex--;
                    if (colorIndex < 0)
                        colorIndex = colorLevels.Length - 1;
                    txtExpression.SelectionColor = colorLevels[colorIndex];
                }
            }
        }

        private bool IsFunction(string text) {
            for (int i = 0; i < strFunctions.Length; i++) {
                if (String.Compare(text, strFunctions[i], StringComparison.OrdinalIgnoreCase) == 0)
                    return true;
            }
            return false;
        }

        private void AddExpression() {
            if (txtExpression.Text.Length == 0)
                return;
            txtExpression.Text = CompleteParenthesis(txtExpression.Text);
            string expText = txtExpression.Text;
            IEvaluatable exp = new Expression(expText);
            if (!exp.IsValid) {
                if (
                    MessageBox.Show("The expression entered does not seem to be valid, do you still want to add it?",
                        "ValidationError",
                        MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
            }
            lstExpressions.Items.Add(expText);
            txtExpression.Text = string.Empty;
        }

        private string CompleteParenthesis(string exp) {
            int leftBracket = 0;
            int rightBracket = 0;
            for (int i = 0; i < exp.Length; i++) {
                if (exp[i] == '(')
                    leftBracket++;
                else if (exp[i] == ')')
                    rightBracket++;
            }
            exp = exp.PadRight(exp.Length + leftBracket - rightBracket, ')');
            return exp;
        }

        #endregion
    }
}