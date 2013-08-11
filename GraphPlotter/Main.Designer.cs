namespace GraphPlotter
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lstExpressions = new System.Windows.Forms.ListBox();
            this.txtExpression = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.cmdPlotGraph = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.startX = new System.Windows.Forms.NumericUpDown();
            this.endX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.endY = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.startY = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.divY = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.divX = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.sensitivity = new System.Windows.Forms.NumericUpDown();
            this.mode = new System.Windows.Forms.ComboBox();
            this.penWidth = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.startX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.divX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // lstExpressions
            // 
            this.lstExpressions.FormattingEnabled = true;
            this.lstExpressions.HorizontalScrollbar = true;
            this.lstExpressions.Location = new System.Drawing.Point(15, 74);
            this.lstExpressions.Name = "lstExpressions";
            this.lstExpressions.Size = new System.Drawing.Size(295, 95);
            this.lstExpressions.TabIndex = 2;
            this.lstExpressions.SelectedIndexChanged += new System.EventHandler(this.lstExpressions_SelectedIndexChanged);
            // 
            // txtExpression
            // 
            this.txtExpression.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtExpression.Location = new System.Drawing.Point(15, 27);
            this.txtExpression.Multiline = false;
            this.txtExpression.Name = "txtExpression";
            this.txtExpression.Size = new System.Drawing.Size(228, 19);
            this.txtExpression.TabIndex = 0;
            this.txtExpression.Text = "";
            this.txtExpression.TextChanged += new System.EventHandler(this.txtExpression_TextChanged);
            this.txtExpression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExpression_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Expression";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(249, 24);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(61, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expressions to plot";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(15, 175);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 22);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear List";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(199, 175);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(111, 22);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "&Remove Expression";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // cmdPlotGraph
            // 
            this.cmdPlotGraph.Location = new System.Drawing.Point(12, 346);
            this.cmdPlotGraph.Name = "cmdPlotGraph";
            this.cmdPlotGraph.Size = new System.Drawing.Size(298, 41);
            this.cmdPlotGraph.TabIndex = 13;
            this.cmdPlotGraph.Text = "&Plot Graph and Find Roots";
            this.cmdPlotGraph.UseVisualStyleBackColor = true;
            this.cmdPlotGraph.Click += new System.EventHandler(this.cmdPlotGraph_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X-axis start";
            // 
            // startX
            // 
            this.startX.DecimalPlaces = 2;
            this.startX.Location = new System.Drawing.Point(91, 216);
            this.startX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.startX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.startX.Name = "startX";
            this.startX.Size = new System.Drawing.Size(61, 20);
            this.startX.TabIndex = 5;
            this.startX.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // endX
            // 
            this.endX.DecimalPlaces = 2;
            this.endX.Location = new System.Drawing.Point(249, 216);
            this.endX.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.endX.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.endX.Name = "endX";
            this.endX.Size = new System.Drawing.Size(61, 20);
            this.endX.TabIndex = 6;
            this.endX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(165, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X-axis end";
            // 
            // endY
            // 
            this.endY.DecimalPlaces = 2;
            this.endY.Location = new System.Drawing.Point(249, 241);
            this.endY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.endY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.endY.Name = "endY";
            this.endY.Size = new System.Drawing.Size(61, 20);
            this.endY.TabIndex = 8;
            this.endY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(165, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Y-axis end";
            // 
            // startY
            // 
            this.startY.DecimalPlaces = 2;
            this.startY.Location = new System.Drawing.Point(91, 241);
            this.startY.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.startY.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.startY.Name = "startY";
            this.startY.Size = new System.Drawing.Size(61, 20);
            this.startY.TabIndex = 7;
            this.startY.Value = new decimal(new int[] {
            5,
            0,
            0,
            -2147483648});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Y-axis start";
            // 
            // divY
            // 
            this.divY.Location = new System.Drawing.Point(249, 266);
            this.divY.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.divY.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.divY.Name = "divY";
            this.divY.Size = new System.Drawing.Size(61, 20);
            this.divY.TabIndex = 10;
            this.divY.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(165, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Y-axis divisions";
            // 
            // divX
            // 
            this.divX.Location = new System.Drawing.Point(91, 266);
            this.divX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.divX.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.divX.Name = "divX";
            this.divX.Size = new System.Drawing.Size(61, 20);
            this.divX.TabIndex = 9;
            this.divX.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 270);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "X-axis divisions";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(165, 295);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Polar Sensitivity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Graph Mode";
            // 
            // sensitivity
            // 
            this.sensitivity.Enabled = false;
            this.sensitivity.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sensitivity.Location = new System.Drawing.Point(249, 291);
            this.sensitivity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.sensitivity.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sensitivity.Name = "sensitivity";
            this.sensitivity.Size = new System.Drawing.Size(61, 20);
            this.sensitivity.TabIndex = 12;
            this.sensitivity.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // mode
            // 
            this.mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mode.FormattingEnabled = true;
            this.mode.Items.AddRange(new object[] {
            "Rectangular",
            "Polar"});
            this.mode.Location = new System.Drawing.Point(91, 319);
            this.mode.Name = "mode";
            this.mode.Size = new System.Drawing.Size(219, 21);
            this.mode.TabIndex = 11;
            this.mode.SelectedIndexChanged += new System.EventHandler(this.mode_SelectedIndexChanged);
            // 
            // penWidth
            // 
            this.penWidth.Location = new System.Drawing.Point(91, 291);
            this.penWidth.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.penWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.penWidth.Name = "penWidth";
            this.penWidth.Size = new System.Drawing.Size(61, 20);
            this.penWidth.TabIndex = 26;
            this.penWidth.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Pen Width";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 399);
            this.Controls.Add(this.penWidth);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.mode);
            this.Controls.Add(this.sensitivity);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.divY);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.divX);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.endY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.startY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.endX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmdPlotGraph);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtExpression);
            this.Controls.Add(this.lstExpressions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "GraphPlotter++";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.divX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sensitivity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.penWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ListBox lstExpressions;
        private System.Windows.Forms.RichTextBox txtExpression;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button cmdPlotGraph;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown startX;
        private System.Windows.Forms.NumericUpDown endX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown endY;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown startY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown divY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown divX;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown sensitivity;
        private System.Windows.Forms.ComboBox mode;
        private System.Windows.Forms.NumericUpDown penWidth;
        private System.Windows.Forms.Label label12;

    }
}

