namespace one_dim_array
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.elementsCount = new System.Windows.Forms.MaskedTextBox();
            this.lowerBoundBox = new System.Windows.Forms.TextBox();
            this.upperBoundBox = new System.Windows.Forms.TextBox();
            this.outputBox = new System.Windows.Forms.RichTextBox();
            this.createObjectButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.readFromFileButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.plotHistogramButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Диапазон значений";
            // 
            // elementsCount
            // 
            this.elementsCount.Location = new System.Drawing.Point(15, 25);
            this.elementsCount.Mask = "000";
            this.elementsCount.Name = "elementsCount";
            this.elementsCount.Size = new System.Drawing.Size(63, 20);
            this.elementsCount.TabIndex = 3;
            this.elementsCount.Text = "100";
            // 
            // lowerBoundBox
            // 
            this.lowerBoundBox.Location = new System.Drawing.Point(120, 25);
            this.lowerBoundBox.MaxLength = 3;
            this.lowerBoundBox.Name = "lowerBoundBox";
            this.lowerBoundBox.Size = new System.Drawing.Size(43, 20);
            this.lowerBoundBox.TabIndex = 4;
            this.lowerBoundBox.Text = "10";
            // 
            // upperBoundBox
            // 
            this.upperBoundBox.Location = new System.Drawing.Point(169, 25);
            this.upperBoundBox.MaxLength = 3;
            this.upperBoundBox.Name = "upperBoundBox";
            this.upperBoundBox.Size = new System.Drawing.Size(43, 20);
            this.upperBoundBox.TabIndex = 5;
            this.upperBoundBox.Text = "99";
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(15, 51);
            this.outputBox.Name = "outputBox";
            this.outputBox.Size = new System.Drawing.Size(400, 110);
            this.outputBox.TabIndex = 6;
            this.outputBox.Text = "";
            // 
            // createObjectButton
            // 
            this.createObjectButton.Location = new System.Drawing.Point(421, 49);
            this.createObjectButton.Name = "createObjectButton";
            this.createObjectButton.Size = new System.Drawing.Size(143, 23);
            this.createObjectButton.TabIndex = 7;
            this.createObjectButton.Text = "Создать объект";
            this.createObjectButton.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(421, 78);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(143, 23);
            this.sortButton.TabIndex = 8;
            this.sortButton.Text = "Сортировать";
            this.sortButton.UseVisualStyleBackColor = true;
            // 
            // readFromFileButton
            // 
            this.readFromFileButton.Location = new System.Drawing.Point(421, 107);
            this.readFromFileButton.Name = "readFromFileButton";
            this.readFromFileButton.Size = new System.Drawing.Size(143, 23);
            this.readFromFileButton.TabIndex = 9;
            this.readFromFileButton.Text = "Данные из файла";
            this.readFromFileButton.UseVisualStyleBackColor = true;
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(421, 136);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(143, 23);
            this.executeButton.TabIndex = 10;
            this.executeButton.Text = "Выполнить";
            this.executeButton.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(15, 167);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(400, 175);
            this.chart1.TabIndex = 11;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.AxisX.MajorGrid.Enabled = false;
            chartArea2.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            this.chart2.Location = new System.Drawing.Point(15, 348);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.IsValueShownAsLabel = true;
            series3.Name = "Series1";
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(400, 175);
            this.chart2.TabIndex = 12;
            this.chart2.Text = "chart2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(421, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 58);
            this.label3.TabIndex = 13;
            this.label3.Text = "Получить новый массив из сумм соседних элементов исходного массива";
            // 
            // plotHistogramButton
            // 
            this.plotHistogramButton.Location = new System.Drawing.Point(421, 323);
            this.plotHistogramButton.Name = "plotHistogramButton";
            this.plotHistogramButton.Size = new System.Drawing.Size(143, 23);
            this.plotHistogramButton.TabIndex = 14;
            this.plotHistogramButton.Text = "Гистограмма";
            this.plotHistogramButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(576, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(229, 17);
            this.toolStripStatusLabel1.Text = "Проект по модулю, задание 3, вариант 8";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(332, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "Корнев Д.Е., ЭУ-193631";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.plotHistogramButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.readFromFileButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.createObjectButton);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.upperBoundBox);
            this.Controls.Add(this.lowerBoundBox);
            this.Controls.Add(this.elementsCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Создание и использование классов при работе с числовым массивом";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox elementsCount;
        private System.Windows.Forms.TextBox lowerBoundBox;
        private System.Windows.Forms.TextBox upperBoundBox;
        private System.Windows.Forms.RichTextBox outputBox;
        private System.Windows.Forms.Button createObjectButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button readFromFileButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button plotHistogramButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
    }
}

