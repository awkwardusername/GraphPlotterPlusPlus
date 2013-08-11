using System;
using System.Data;
using System.Windows.Forms;
using Ciloci.Flee;

namespace GraphPlotter {
    internal class Algorithm {
        public DataTable Table;
        private IGenericExpression<double> _compileGeneric;
        private ExpressionContext _context;

        public Algorithm(int iterations, double error, double xlow, double xhigh, string expression, int operation) {
            Iterations =   iterations;
            Error = error;
            xLow = xlow;
            xHigh = xhigh;
            Expression = expression;

            switch (operation) {
                case 1:
                    BisectionMethod();
                    break;
                case 2:
                    FalsePositionMethod();
                    break;
                case 3:
                    secantMethod();
                    break;
            }
        }

        #region BisectionMethod!

        private void BisectionMethod() {
            try {
                #region Declare stuff

                _context = new ExpressionContext();

                _context.Imports.AddType(typeof (Math));
                _context.Imports.AddType(typeof (AdditionalFunctions));

                Table = new DataTable();

                Table.Columns.Add("i", typeof (int));
                Table.Columns.Add("a", typeof (double));
                Table.Columns.Add("b", typeof (double));
                Table.Columns.Add("m(c)", typeof (double));
                Table.Columns.Add("f(a)", typeof (double));
                Table.Columns.Add("f(b)", typeof (double));
                Table.Columns.Add("f(c)", typeof (double));

                #endregion

                double xMidTemp;
                int i = 0;
                do {
                    i++;
                    double xMid = (xLow + xHigh)/2;

                    _context.Variables["x"] = xLow;
                    _compileGeneric = _context.CompileGeneric<double>(Expression);
                    double xLowTemp = _compileGeneric.Evaluate();
                    _context.Variables["x"] = xHigh;
                    double xHighTemp = _compileGeneric.Evaluate();

                    _context.Variables["x"] = xMid;
                    xMidTemp = _compileGeneric.Evaluate();

                    if (xLowTemp*xMidTemp < 0)
                        xHigh = xMid;
                    else
                        xLow = xMid;

                    Table.Rows.Add(i, xLow, xHigh, xMid, xLowTemp, xHighTemp, xMidTemp);
                } while (((Math.Abs(xLow - xHigh) > Error) && (Math.Abs(xMidTemp) > Error)) && i < Iterations);
            } catch (ExpressionCompileException e) {
                Table = null;
            }
        }

        #endregion

        #region False Position Method

        private void FalsePositionMethod() {
            #region Declare stuff

            _context = new ExpressionContext();

            _context.Imports.AddType(typeof (Math));
            _context.Imports.AddType(typeof (AdditionalFunctions));

            Table = new DataTable();

            Table.Columns.Add("i", typeof (int));
            Table.Columns.Add("a", typeof (double));
            Table.Columns.Add("b", typeof (double));
            Table.Columns.Add("m(c)", typeof (double));
            Table.Columns.Add("f(a)", typeof (double));
            Table.Columns.Add("f(b)", typeof (double));
            Table.Columns.Add("f(c)", typeof (double));

            #endregion

            _context.Variables["x"] = xLow;
            _compileGeneric = _context.CompileGeneric<double>(Expression);
            double xLowTemp = _compileGeneric.Evaluate();

            _context.Variables["x"] = xHigh;
            double xHighTemp = _compileGeneric.Evaluate();
            if ((xLowTemp*xHighTemp) > 0) {
                MessageBox.Show("More than one root found. Change the lower and upper boundaries and try again.");
            }

            double xMidTemp;
            int i = 0;
            do {
                i++;
                double xMid = (xLow*xHighTemp - xHigh*xLowTemp)/(xHighTemp - xLowTemp);
                _context.Variables["x"] = xMid;
                xMidTemp = _compileGeneric.Evaluate();
                if (xLowTemp*xMidTemp < 0) {
                    xHigh = xMid;
                    xHighTemp = xMidTemp;
                } else {
                    xLow = xMid;
                    xLowTemp = xMidTemp;
                }
                Table.Rows.Add(i, xLow, xHigh, xMid, xLowTemp, xHighTemp, xMidTemp);
            } while (((Math.Abs(xLow - xHigh) > Error) && (Math.Abs(xMidTemp) > Error)) && i < Iterations);
        }

        #endregion

        #region Secant Method

        private void secantMethod() {
            #region Declare stuff

            _context = new ExpressionContext();

            _context.Imports.AddType(typeof (Math));
            _context.Imports.AddType(typeof (AdditionalFunctions));

            Table = new DataTable();

            Table.Columns.Add("i", typeof (int));
            Table.Columns.Add("a", typeof (double));
            Table.Columns.Add("b", typeof (double));
            Table.Columns.Add("m(c)", typeof (double));
            Table.Columns.Add("f(a)", typeof (double));
            Table.Columns.Add("f(b)", typeof (double));
            Table.Columns.Add("f(c)", typeof (double));

            #endregion

            _context.Variables["x"] = xLow;
            _compileGeneric = _context.CompileGeneric<double>(Expression);
            double xLowTemp = _compileGeneric.Evaluate();
            _context.Variables["x"] = xHigh;
            double xHighTemp = _compileGeneric.Evaluate();

            for (int i = 0; i < Iterations; i++) {
                double xMid = (xLow*xHighTemp - xHigh*xLowTemp)/(xHighTemp - xLowTemp);
                _context.Variables["x"] = xMid;
                double xMidTemp = _compileGeneric.Evaluate();

                _context.Variables["x"] = xLow;
                xLowTemp = _compileGeneric.Evaluate();
                if ((Math.Abs((xMid - xHigh)/xMid)) <= Error && (Math.Abs(xLowTemp) < Error)) {
                    MessageBox.Show("SOLVED. The approximate root is " + xMid);
                    break;
                }
                xLow = xHigh;
                xLowTemp = xHighTemp;
                xHigh = xMid;
                xHighTemp = xMidTemp;
                Table.Rows.Add(i, xLow, xHigh, xMid, xLowTemp, xHighTemp, xMidTemp);
            }
        }

        #endregion

        public int Iterations { get; set; }
        public double Error { get; set; }
        public double xLow { get; set; }
        public double xHigh { get; set; }
        public string Expression { get; set; }
    }
}