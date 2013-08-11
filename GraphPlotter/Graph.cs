using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using ExpressionPlotterControl;

namespace GraphPlotter {
    public partial class Graph : Form {
        public Graph() { InitializeComponent(); }

        #region Public Methods

        public void AddExpression(string text, Color color) {
            expPlotter.AddExpression(new Expression(text), color, true);
            lstExpressions.Items.Add(text);
            lstExpressions.SetItemChecked(lstExpressions.Items.IndexOf(text), true);
        }

        public void RemoveAllExpressions() {
            expPlotter.RemoveAllExpressions();
            lstExpressions.Items.Clear();
        }

        public void SetRange(double startX, double endX, double startY, double endY) {
            expPlotter.SetRangeX(startX, endX);
            expPlotter.SetRangeY(startY, endY);
        }

        public void SetDivisions(int divX, int divY) {
            expPlotter.DivisionsX = divX;
            expPlotter.DivisionsY = divY;
        }

        public void SetMode(GraphMode mode, int sensitivity) {
            expPlotter.GraphMode = mode;
            if (mode == GraphMode.Polar) {
                expPlotter.PolarSensitivity = sensitivity;
                lblSensitivity.Text = "Polar sensitivity: " + expPlotter.PolarSensitivity;
            }
        }

        public void SetPenWidth(int width) { expPlotter.PenWidth = width; }

        #endregion

        #region Private Methods

        private double GetR(double X, double Y) { return Math.Sqrt(X*X + Y*Y); }

        private double GetTheta(double X, double Y) {
            double dTheta;
            if (X == 0) {
                if (Y > 0)
                    dTheta = Math.PI/2;
                else
                    dTheta = -Math.PI/2;
            } else
                dTheta = Math.Atan(Y/X);

            //actual range of theta is from 0 to 2PI
            if (X < 0)
                dTheta = dTheta + Math.PI;
            else if (Y < 0)
                dTheta = dTheta + 2*Math.PI;
            return dTheta;
        }

        private ImageFormat GetImageFormat(string filename) {
            string[] tempArray = filename.Split('.');
            string extension = tempArray[tempArray.Length - 1];
            switch (extension) {
                case "bmp":
                    return ImageFormat.Bmp;
                case "jpg":
                    return ImageFormat.Jpeg;
                case "gif":
                    return ImageFormat.Gif;
                case "png":
                    return ImageFormat.Png;
                case "tiff":
                    return ImageFormat.Tiff;
                case "wmf":
                    return ImageFormat.Wmf;
                default:
                    return ImageFormat.Bmp;
            }
        }

        #endregion

        #region Event Handlers

        private void Graph_Load(object sender, EventArgs e) {
            expPlotter.MouseMove += ExpPlotter_OnMouseMove;
            expPlotter.MouseWheel += ExpPlotter_OnMouseWheel;
            lblSensitivity.Text = "";
        }

        private void ExpPlotter_OnMouseWheel(object sender, MouseEventArgs e) {
            if (e.Delta > 0)
                expPlotter.ZoomIn();
            else if (e.Delta < 0)
                expPlotter.ZoomOut();
            expPlotter.Refresh();
        }

        private void ExpPlotter_OnMouseMove(object sender, MouseEventArgs e) {
            double currentX, currentY;
            currentX = (e.X - expPlotter.Width/2)*expPlotter.ScaleX/expPlotter.Width*2.25 + expPlotter.ForwardX;
            currentY = (expPlotter.Height/2 - e.Y)*expPlotter.ScaleY/expPlotter.Height*2.25 + expPlotter.ForwardY;
            if (expPlotter.GraphMode == GraphMode.Polar) {
                double r = GetR(currentX, currentY);
                double theta = GetTheta(currentX, currentY);
                currentX = r;
                currentY = theta;
            }
            currentX = Math.Round(currentX, 3);
            currentY = Math.Round(currentY, 3);
            lblPosition.Text = "Current mouse position : " + currentX + "," + currentY;
        }

        private void btnUp_Click(object sender, EventArgs e) {
            expPlotter.MoveUp(1);
            expPlotter.Refresh();
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            expPlotter.MoveLeft(1);
            expPlotter.Refresh();
        }

        private void btnDown_Click(object sender, EventArgs e) {
            expPlotter.MoveDown(1);
            expPlotter.Refresh();
        }

        private void btnRight_Click(object sender, EventArgs e) {
            expPlotter.MoveRight(1);
            expPlotter.Refresh();
        }

        private void btnZoomOut_Click(object sender, EventArgs e) {
            expPlotter.ZoomOut();
            expPlotter.Refresh();
        }

        private void btnZoomIn_Click(object sender, EventArgs e) {
            expPlotter.ZoomIn();
            expPlotter.Refresh();
        }

        private void btnZoomInX_Click(object sender, EventArgs e) {
            expPlotter.ZoomInX();
            expPlotter.Refresh();
        }

        private void btnZoomInY_Click(object sender, EventArgs e) {
            expPlotter.ZoomInY();
            expPlotter.Refresh();
        }

        private void btnZoomOutX_Click(object sender, EventArgs e) {
            expPlotter.ZoomOutX();
            expPlotter.Refresh();
        }

        private void btnZoomOutY_Click(object sender, EventArgs e) {
            expPlotter.ZoomOutY();
            expPlotter.Refresh();
        }

        private void btnGrids_Click(object sender, EventArgs e) {
            expPlotter.ToggleGrids();
            expPlotter.Refresh();
        }

        private void btnShowOrigin_Click(object sender, EventArgs e) {
            expPlotter.ForwardX = expPlotter.ForwardY = 0;
            expPlotter.Refresh();
        }

        private void btnDefault_Click(object sender, EventArgs e) {
            expPlotter.RestoreDefaults();
            expPlotter.Refresh();
        }

        private void btnRectangularMode_Click(object sender, EventArgs e) {
            if (expPlotter.GraphMode != GraphMode.Rectangular) {
                lblSensitivity.Text = "";
                expPlotter.GraphMode = GraphMode.Rectangular;
                expPlotter.Refresh();
            }
        }

        private void btnPolarMode_Click(object sender, EventArgs e) {
            if (expPlotter.GraphMode != GraphMode.Polar) {
                lblSensitivity.Text = "Polar sensitivity: " + expPlotter.PolarSensitivity;
                expPlotter.GraphMode = GraphMode.Polar;
                expPlotter.Refresh();
            }
        }

        private void btnIncreaseSensitivity_Click(object sender, EventArgs e) {
            if (expPlotter.GraphMode == GraphMode.Polar && expPlotter.PolarSensitivity < 500) {
                expPlotter.PolarSensitivity += 50;
                expPlotter.Refresh();
                lblSensitivity.Text = "Polar sensitivity: " + expPlotter.PolarSensitivity;
            }
        }

        private void btnDecreaseSensitivity_Click(object sender, EventArgs e) {
            if (expPlotter.GraphMode == GraphMode.Polar && expPlotter.PolarSensitivity > 50) {
                expPlotter.PolarSensitivity -= 50;
                expPlotter.Refresh();
                lblSensitivity.Text = "Polar sensitivity: " + expPlotter.PolarSensitivity;
            }
        }

        private void btnText_Click(object sender, EventArgs e) {
            expPlotter.DisplayText = !expPlotter.DisplayText;
            expPlotter.Refresh();
        }

        private void btnRefresh_Click(object sender, EventArgs e) {
            for (int i = 0; i < lstExpressions.Items.Count; i++) {
                if (lstExpressions.CheckedIndices.Contains(i))
                    expPlotter.SetExpressionVisibility(i, true);
                else
                    expPlotter.SetExpressionVisibility(i, false);
            }
            expPlotter.Refresh();
        }

        private void Graph_Resize(object sender, EventArgs e) { expPlotter.Refresh(); }

        private void btnClipboard_Click(object sender, EventArgs e) { expPlotter.CopyToClipboard(); }

        private void btnSave_Click(object sender, EventArgs e) {
            var dialog = new SaveFileDialog();
            dialog.Title = "Save Graph";
            string filter = "Bitmap (*.bmp)|*.bmp|" +
                            "JPEG (*.jpg)|*.jpg|" +
                            "GIF (*.gif)|*.gif|" +
                            "PNG (*.png)|*.png|" +
                            "TIFF (*.tiff)|*.tiff|" +
                            "WMF (*.wmf)|*.wmf";
            dialog.Filter = filter;
            dialog.FileName = "graph";
            if (dialog.ShowDialog() == DialogResult.OK) {
                Bitmap bmp = expPlotter.GetGraphBitmap();
                bmp.Save(dialog.FileName, GetImageFormat(dialog.FileName));
                MessageBox.Show("Graph successfully saved to " + dialog.FileName, "Saved");
            }
        }

        private void expPlotter_Click(object sender, EventArgs e) { expPlotter.Select(); }

        #endregion
    }
}