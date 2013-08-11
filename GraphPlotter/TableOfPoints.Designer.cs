namespace GraphPlotter
{
    partial class tableOfPoints
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(tableOfPoints));
            this.dataGridView_TablePoints = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.lowerBoundary = new System.Windows.Forms.NumericUpDown();
            this.upperBoundary = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.iterations = new System.Windows.Forms.NumericUpDown();
            this.lstExpressions = new System.Windows.Forms.ListBox();
            this.radioBisection = new System.Windows.Forms.RadioButton();
            this.radioFPosition = new System.Windows.Forms.RadioButton();
            this.radioSecant = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TablePoints)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_TablePoints
            // 
            this.dataGridView_TablePoints.AllowUserToAddRows = false;
            this.dataGridView_TablePoints.AllowUserToDeleteRows = false;
            this.dataGridView_TablePoints.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView_TablePoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_TablePoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_TablePoints.Location = new System.Drawing.Point(12, 164);
            this.dataGridView_TablePoints.Name = "dataGridView_TablePoints";
            this.dataGridView_TablePoints.ReadOnly = true;
            this.dataGridView_TablePoints.Size = new System.Drawing.Size(515, 352);
            this.dataGridView_TablePoints.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lower Boundary:";
            // 
            // lowerBoundary
            // 
            this.lowerBoundary.DecimalPlaces = 5;
            this.lowerBoundary.Location = new System.Drawing.Point(99, 17);
            this.lowerBoundary.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.lowerBoundary.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.lowerBoundary.Name = "lowerBoundary";
            this.lowerBoundary.Size = new System.Drawing.Size(92, 20);
            this.lowerBoundary.TabIndex = 2;
            this.lowerBoundary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lowerBoundary.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upperBoundary
            // 
            this.upperBoundary.DecimalPlaces = 5;
            this.upperBoundary.Location = new System.Drawing.Point(99, 43);
            this.upperBoundary.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.upperBoundary.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.upperBoundary.Name = "upperBoundary";
            this.upperBoundary.Size = new System.Drawing.Size(92, 20);
            this.upperBoundary.TabIndex = 4;
            this.upperBoundary.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.upperBoundary.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Upper Boundary:";
            // 
            // error
            // 
            this.error.DecimalPlaces = 5;
            this.error.Increment = new decimal(new int[] {
            1,
            0,
            0,
            327680});
            this.error.Location = new System.Drawing.Point(257, 17);
            this.error.Maximum = new decimal(new int[] {
            32767,
            0,
            0,
            0});
            this.error.Minimum = new decimal(new int[] {
            32767,
            0,
            0,
            -2147483648});
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(92, 20);
            this.error.TabIndex = 6;
            this.error.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.error.Value = new decimal(new int[] {
            5,
            0,
            0,
            327680});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(198, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Epsilon:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(355, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 52);
            this.button1.TabIndex = 7;
            this.button1.Text = "Refresh Table";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.iterations);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.error);
            this.groupBox1.Controls.Add(this.lowerBoundary);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.upperBoundary);
            this.groupBox1.Location = new System.Drawing.Point(12, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(515, 71);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Controls";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(198, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Iterations:";
            // 
            // iterations
            // 
            this.iterations.Location = new System.Drawing.Point(257, 43);
            this.iterations.Name = "iterations";
            this.iterations.Size = new System.Drawing.Size(92, 20);
            this.iterations.TabIndex = 9;
            this.iterations.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.iterations.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // lstExpressions
            // 
            this.lstExpressions.FormattingEnabled = true;
            this.lstExpressions.HorizontalScrollbar = true;
            this.lstExpressions.Location = new System.Drawing.Point(12, 12);
            this.lstExpressions.Name = "lstExpressions";
            this.lstExpressions.Size = new System.Drawing.Size(384, 69);
            this.lstExpressions.TabIndex = 9;
            this.lstExpressions.SelectedIndexChanged += new System.EventHandler(this.lstExpressions_SelectedIndexChanged);
            // 
            // radioBisection
            // 
            this.radioBisection.AutoSize = true;
            this.radioBisection.Checked = true;
            this.radioBisection.Location = new System.Drawing.Point(402, 12);
            this.radioBisection.Name = "radioBisection";
            this.radioBisection.Size = new System.Drawing.Size(107, 17);
            this.radioBisection.TabIndex = 10;
            this.radioBisection.TabStop = true;
            this.radioBisection.Text = "Bisection Method";
            this.radioBisection.UseVisualStyleBackColor = true;
            // 
            // radioFPosition
            // 
            this.radioFPosition.AutoSize = true;
            this.radioFPosition.Location = new System.Drawing.Point(402, 38);
            this.radioFPosition.Name = "radioFPosition";
            this.radioFPosition.Size = new System.Drawing.Size(129, 17);
            this.radioFPosition.TabIndex = 11;
            this.radioFPosition.Text = "False Position Method";
            this.radioFPosition.UseVisualStyleBackColor = true;
            // 
            // radioSecant
            // 
            this.radioSecant.AutoSize = true;
            this.radioSecant.Location = new System.Drawing.Point(402, 64);
            this.radioSecant.Name = "radioSecant";
            this.radioSecant.Size = new System.Drawing.Size(98, 17);
            this.radioSecant.TabIndex = 12;
            this.radioSecant.Text = "Secant Method";
            this.radioSecant.UseVisualStyleBackColor = true;
            // 
            // tableOfPoints
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 528);
            this.Controls.Add(this.radioSecant);
            this.Controls.Add(this.radioFPosition);
            this.Controls.Add(this.radioBisection);
            this.Controls.Add(this.lstExpressions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView_TablePoints);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(545, 516);
            this.Name = "tableOfPoints";
            this.Text = "Root Finder";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_TablePoints)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerBoundary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperBoundary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_TablePoints;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown lowerBoundary;
        private System.Windows.Forms.NumericUpDown upperBoundary;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown error;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown iterations;
        public System.Windows.Forms.ListBox lstExpressions;
        private System.Windows.Forms.RadioButton radioBisection;
        private System.Windows.Forms.RadioButton radioFPosition;
        private System.Windows.Forms.RadioButton radioSecant;
    }
}