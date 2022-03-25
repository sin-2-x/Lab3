
namespace Lab3
{
    partial class MainForm
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.Title title5 = new System.Windows.Forms.DataVisualization.Charting.Title();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveInnerDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.exportToExelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.showGreetingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitContainerMain = new System.Windows.Forms.SplitContainer();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxStep = new System.Windows.Forms.TextBox();
      this.cleanBtn = new System.Windows.Forms.Button();
      this.startBtn = new System.Windows.Forms.Button();
      this.textBoxD = new System.Windows.Forms.TextBox();
      this.textBoxC = new System.Windows.Forms.TextBox();
      this.textBoxB = new System.Windows.Forms.TextBox();
      this.textBoxA = new System.Windows.Forms.TextBox();
      this.labelClose = new System.Windows.Forms.Label();
      this.labelXPlus = new System.Windows.Forms.Label();
      this.labelSin = new System.Windows.Forms.Label();
      this.labelPlus = new System.Windows.Forms.Label();
      this.labely = new System.Windows.Forms.Label();
      this.splitContainer1 = new System.Windows.Forms.SplitContainer();
      this.textBoxXMax = new System.Windows.Forms.TextBox();
      this.textBoxXMin = new System.Windows.Forms.TextBox();
      this.textBoxYMin = new System.Windows.Forms.TextBox();
      this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.textBoxYMax = new System.Windows.Forms.TextBox();
      this.gridView = new System.Windows.Forms.DataGridView();
      this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Y = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.menuStrip1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).BeginInit();
      this.splitContainerMain.Panel1.SuspendLayout();
      this.splitContainerMain.Panel2.SuspendLayout();
      this.splitContainerMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
      this.splitContainer1.Panel1.SuspendLayout();
      this.splitContainer1.Panel2.SuspendLayout();
      this.splitContainer1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
      this.SuspendLayout();
      // 
      // menuStrip1
      // 
      this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1010, 28);
      this.menuStrip1.TabIndex = 12;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openFileToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exportToExelToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
      this.fileToolStripMenuItem.Text = "File";
      // 
      // openFileToolStripMenuItem
      // 
      this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
      this.openFileToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
      this.openFileToolStripMenuItem.Text = "Open file...";
      this.openFileToolStripMenuItem.Click += new System.EventHandler(this.openFileToolStripMenuItem_Click);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveInnerDataToolStripMenuItem,
            this.saveResultsToolStripMenuItem});
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
      this.saveToolStripMenuItem.Text = "Save";
      // 
      // saveInnerDataToolStripMenuItem
      // 
      this.saveInnerDataToolStripMenuItem.Name = "saveInnerDataToolStripMenuItem";
      this.saveInnerDataToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
      this.saveInnerDataToolStripMenuItem.Text = "Save inner data";
      this.saveInnerDataToolStripMenuItem.Click += new System.EventHandler(this.saveInnerDataToolStripMenuItem_Click);
      // 
      // saveResultsToolStripMenuItem
      // 
      this.saveResultsToolStripMenuItem.Name = "saveResultsToolStripMenuItem";
      this.saveResultsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
      this.saveResultsToolStripMenuItem.Text = "Save results";
      this.saveResultsToolStripMenuItem.Click += new System.EventHandler(this.saveResultsToolStripMenuItem_Click);
      // 
      // exportToExelToolStripMenuItem
      // 
      this.exportToExelToolStripMenuItem.Name = "exportToExelToolStripMenuItem";
      this.exportToExelToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
      this.exportToExelToolStripMenuItem.Text = "Export to Exel";
      this.exportToExelToolStripMenuItem.Click += new System.EventHandler(this.exportToExelToolStripMenuItem_Click);
      // 
      // settingsToolStripMenuItem
      // 
      this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showGreetingsToolStripMenuItem});
      this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
      this.settingsToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
      this.settingsToolStripMenuItem.Text = "Settings";
      // 
      // showGreetingsToolStripMenuItem
      // 
      this.showGreetingsToolStripMenuItem.Name = "showGreetingsToolStripMenuItem";
      this.showGreetingsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
      this.showGreetingsToolStripMenuItem.Text = "Show greetings";
      this.showGreetingsToolStripMenuItem.Click += new System.EventHandler(this.showGreetingsToolStripMenuItem_Click);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // splitContainerMain
      // 
      this.splitContainerMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.splitContainerMain.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainerMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.splitContainerMain.IsSplitterFixed = true;
      this.splitContainerMain.Location = new System.Drawing.Point(0, 0);
      this.splitContainerMain.Margin = new System.Windows.Forms.Padding(5);
      this.splitContainerMain.Name = "splitContainerMain";
      this.splitContainerMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // splitContainerMain.Panel1
      // 
      this.splitContainerMain.Panel1.Controls.Add(this.label1);
      this.splitContainerMain.Panel1.Controls.Add(this.textBoxStep);
      this.splitContainerMain.Panel1.Controls.Add(this.cleanBtn);
      this.splitContainerMain.Panel1.Controls.Add(this.startBtn);
      this.splitContainerMain.Panel1.Controls.Add(this.textBoxD);
      this.splitContainerMain.Panel1.Controls.Add(this.textBoxC);
      this.splitContainerMain.Panel1.Controls.Add(this.textBoxB);
      this.splitContainerMain.Panel1.Controls.Add(this.textBoxA);
      this.splitContainerMain.Panel1.Controls.Add(this.labelClose);
      this.splitContainerMain.Panel1.Controls.Add(this.labelXPlus);
      this.splitContainerMain.Panel1.Controls.Add(this.labelSin);
      this.splitContainerMain.Panel1.Controls.Add(this.labelPlus);
      this.splitContainerMain.Panel1.Controls.Add(this.labely);
      this.splitContainerMain.Panel1.Controls.Add(this.menuStrip1);
      this.splitContainerMain.Panel1MinSize = 50;
      // 
      // splitContainerMain.Panel2
      // 
      this.splitContainerMain.Panel2.Controls.Add(this.splitContainer1);
      this.splitContainerMain.Panel2MinSize = 100;
      this.splitContainerMain.Size = new System.Drawing.Size(1012, 641);
      this.splitContainerMain.SplitterDistance = 118;
      this.splitContainerMain.SplitterWidth = 6;
      this.splitContainerMain.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.label1.Location = new System.Drawing.Point(799, 58);
      this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(89, 29);
      this.label1.TabIndex = 16;
      this.label1.Text = "Step = ";
      // 
      // textBoxStep
      // 
      this.textBoxStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxStep.Location = new System.Drawing.Point(891, 55);
      this.textBoxStep.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxStep.MinimumSize = new System.Drawing.Size(39, 4);
      this.textBoxStep.Name = "textBoxStep";
      this.textBoxStep.Size = new System.Drawing.Size(69, 34);
      this.textBoxStep.TabIndex = 15;
      this.textBoxStep.Text = "1";
      // 
      // cleanBtn
      // 
      this.cleanBtn.Location = new System.Drawing.Point(29, 78);
      this.cleanBtn.Margin = new System.Windows.Forms.Padding(5);
      this.cleanBtn.Name = "cleanBtn";
      this.cleanBtn.Size = new System.Drawing.Size(125, 26);
      this.cleanBtn.TabIndex = 14;
      this.cleanBtn.Text = "Clean";
      this.cleanBtn.UseVisualStyleBackColor = true;
      this.cleanBtn.Click += new System.EventHandler(this.cleanBtn_Click);
      // 
      // startBtn
      // 
      this.startBtn.Location = new System.Drawing.Point(29, 40);
      this.startBtn.Margin = new System.Windows.Forms.Padding(5);
      this.startBtn.Name = "startBtn";
      this.startBtn.Size = new System.Drawing.Size(125, 38);
      this.startBtn.TabIndex = 13;
      this.startBtn.Text = "Start";
      this.startBtn.UseVisualStyleBackColor = true;
      this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
      // 
      // textBoxD
      // 
      this.textBoxD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxD.Location = new System.Drawing.Point(505, 55);
      this.textBoxD.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxD.MinimumSize = new System.Drawing.Size(39, 4);
      this.textBoxD.Name = "textBoxD";
      this.textBoxD.Size = new System.Drawing.Size(39, 34);
      this.textBoxD.TabIndex = 11;
      this.textBoxD.Text = "0";
      // 
      // textBoxC
      // 
      this.textBoxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxC.Location = new System.Drawing.Point(415, 55);
      this.textBoxC.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxC.MinimumSize = new System.Drawing.Size(39, 4);
      this.textBoxC.Name = "textBoxC";
      this.textBoxC.Size = new System.Drawing.Size(39, 34);
      this.textBoxC.TabIndex = 10;
      this.textBoxC.Text = "1";
      // 
      // textBoxB
      // 
      this.textBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxB.Location = new System.Drawing.Point(321, 55);
      this.textBoxB.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxB.MinimumSize = new System.Drawing.Size(39, 4);
      this.textBoxB.Name = "textBoxB";
      this.textBoxB.Size = new System.Drawing.Size(39, 34);
      this.textBoxB.TabIndex = 9;
      this.textBoxB.Text = "0";
      // 
      // textBoxA
      // 
      this.textBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxA.Location = new System.Drawing.Point(243, 55);
      this.textBoxA.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxA.MinimumSize = new System.Drawing.Size(39, 4);
      this.textBoxA.Name = "textBoxA";
      this.textBoxA.Size = new System.Drawing.Size(39, 34);
      this.textBoxA.TabIndex = 8;
      this.textBoxA.Text = "0";
      // 
      // labelClose
      // 
      this.labelClose.AutoSize = true;
      this.labelClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelClose.Location = new System.Drawing.Point(547, 55);
      this.labelClose.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.labelClose.Name = "labelClose";
      this.labelClose.Size = new System.Drawing.Size(21, 29);
      this.labelClose.TabIndex = 4;
      this.labelClose.Text = ")";
      // 
      // labelXPlus
      // 
      this.labelXPlus.AutoSize = true;
      this.labelXPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelXPlus.Location = new System.Drawing.Point(457, 55);
      this.labelXPlus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.labelXPlus.Name = "labelXPlus";
      this.labelXPlus.Size = new System.Drawing.Size(44, 29);
      this.labelXPlus.TabIndex = 3;
      this.labelXPlus.Text = "x +";
      // 
      // labelSin
      // 
      this.labelSin.AutoSize = true;
      this.labelSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelSin.Location = new System.Drawing.Point(363, 55);
      this.labelSin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.labelSin.Name = "labelSin";
      this.labelSin.Size = new System.Drawing.Size(52, 29);
      this.labelSin.TabIndex = 2;
      this.labelSin.Text = "sin(";
      // 
      // labelPlus
      // 
      this.labelPlus.AutoSize = true;
      this.labelPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labelPlus.Location = new System.Drawing.Point(287, 55);
      this.labelPlus.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.labelPlus.Name = "labelPlus";
      this.labelPlus.Size = new System.Drawing.Size(27, 29);
      this.labelPlus.TabIndex = 1;
      this.labelPlus.Text = "+";
      // 
      // labely
      // 
      this.labely.AutoSize = true;
      this.labely.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.labely.Location = new System.Drawing.Point(189, 55);
      this.labely.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
      this.labely.Name = "labely";
      this.labely.Size = new System.Drawing.Size(44, 29);
      this.labely.TabIndex = 0;
      this.labely.Text = "y =";
      // 
      // splitContainer1
      // 
      this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.splitContainer1.Location = new System.Drawing.Point(0, 0);
      this.splitContainer1.Margin = new System.Windows.Forms.Padding(5);
      this.splitContainer1.Name = "splitContainer1";
      // 
      // splitContainer1.Panel1
      // 
      this.splitContainer1.Panel1.Controls.Add(this.textBoxXMax);
      this.splitContainer1.Panel1.Controls.Add(this.textBoxXMin);
      this.splitContainer1.Panel1.Controls.Add(this.textBoxYMin);
      this.splitContainer1.Panel1.Controls.Add(this.chart);
      this.splitContainer1.Panel1.Controls.Add(this.textBoxYMax);
      // 
      // splitContainer1.Panel2
      // 
      this.splitContainer1.Panel2.Controls.Add(this.gridView);
      this.splitContainer1.Size = new System.Drawing.Size(1010, 515);
      this.splitContainer1.SplitterDistance = 774;
      this.splitContainer1.SplitterWidth = 6;
      this.splitContainer1.TabIndex = 6;
      // 
      // textBoxXMax
      // 
      this.textBoxXMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.textBoxXMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxXMax.Location = new System.Drawing.Point(707, 467);
      this.textBoxXMax.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxXMax.MinimumSize = new System.Drawing.Size(59, 4);
      this.textBoxXMax.Name = "textBoxXMax";
      this.textBoxXMax.Size = new System.Drawing.Size(59, 34);
      this.textBoxXMax.TabIndex = 4;
      this.textBoxXMax.Text = "10";
      this.textBoxXMax.TextChanged += new System.EventHandler(this.textBoxXMax_TextChanged);
      // 
      // textBoxXMin
      // 
      this.textBoxXMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.textBoxXMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxXMin.Location = new System.Drawing.Point(69, 467);
      this.textBoxXMin.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxXMin.MinimumSize = new System.Drawing.Size(59, 4);
      this.textBoxXMin.Name = "textBoxXMin";
      this.textBoxXMin.Size = new System.Drawing.Size(59, 34);
      this.textBoxXMin.TabIndex = 3;
      this.textBoxXMin.Text = "0";
      // 
      // textBoxYMin
      // 
      this.textBoxYMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.textBoxYMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxYMin.Location = new System.Drawing.Point(5, 414);
      this.textBoxYMin.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxYMin.MinimumSize = new System.Drawing.Size(59, 4);
      this.textBoxYMin.Name = "textBoxYMin";
      this.textBoxYMin.Size = new System.Drawing.Size(59, 34);
      this.textBoxYMin.TabIndex = 2;
      this.textBoxYMin.Text = "0";
      // 
      // chart
      // 
      this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      chartArea5.Name = "ChartArea1";
      this.chart.ChartAreas.Add(chartArea5);
      this.chart.Location = new System.Drawing.Point(69, 5);
      this.chart.Margin = new System.Windows.Forms.Padding(5);
      this.chart.Name = "chart";
      series5.ChartArea = "ChartArea1";
      series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
      series5.Name = "Series1";
      this.chart.Series.Add(series5);
      this.chart.Size = new System.Drawing.Size(698, 451);
      this.chart.TabIndex = 0;
      this.chart.Text = "chart1";
      title5.Name = "Title1";
      this.chart.Titles.Add(title5);
      // 
      // textBoxYMax
      // 
      this.textBoxYMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxYMax.Location = new System.Drawing.Point(5, 5);
      this.textBoxYMax.Margin = new System.Windows.Forms.Padding(5);
      this.textBoxYMax.MinimumSize = new System.Drawing.Size(59, 4);
      this.textBoxYMax.Name = "textBoxYMax";
      this.textBoxYMax.Size = new System.Drawing.Size(59, 34);
      this.textBoxYMax.TabIndex = 1;
      this.textBoxYMax.Text = "10";
      // 
      // gridView
      // 
      this.gridView.AllowUserToAddRows = false;
      this.gridView.AllowUserToDeleteRows = false;
      this.gridView.AllowUserToResizeRows = false;
      this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
      this.gridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
      this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.Y});
      this.gridView.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridView.Location = new System.Drawing.Point(0, 0);
      this.gridView.Margin = new System.Windows.Forms.Padding(16, 2, 0, 0);
      this.gridView.MaximumSize = new System.Drawing.Size(500, 0);
      this.gridView.Name = "gridView";
      this.gridView.RowHeadersVisible = false;
      this.gridView.RowHeadersWidth = 50;
      this.gridView.RowTemplate.Height = 24;
      this.gridView.Size = new System.Drawing.Size(230, 515);
      this.gridView.TabIndex = 5;
      // 
      // X
      // 
      this.X.HeaderText = "X";
      this.X.MinimumWidth = 6;
      this.X.Name = "X";
      this.X.ReadOnly = true;
      // 
      // Y
      // 
      this.Y.HeaderText = "Y";
      this.Y.MinimumWidth = 6;
      this.Y.Name = "Y";
      this.Y.ReadOnly = true;
      // 
      // MainForm
      // 
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.ClientSize = new System.Drawing.Size(1012, 641);
      this.Controls.Add(this.splitContainerMain);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(5);
      this.MinimumSize = new System.Drawing.Size(828, 678);
      this.Name = "MainForm";
      this.Text = "Sinusoid";
      this.Shown += new System.EventHandler(this.ShowGreeting);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.splitContainerMain.Panel1.ResumeLayout(false);
      this.splitContainerMain.Panel1.PerformLayout();
      this.splitContainerMain.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainerMain)).EndInit();
      this.splitContainerMain.ResumeLayout(false);
      this.splitContainer1.Panel1.ResumeLayout(false);
      this.splitContainer1.Panel1.PerformLayout();
      this.splitContainer1.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
      this.splitContainer1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainerMain;
        private System.Windows.Forms.Label labely;
        private System.Windows.Forms.Label labelXPlus;
        private System.Windows.Forms.Label labelSin;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label labelClose;
        protected System.Windows.Forms.Label labelPlus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveInnerDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showGreetingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TextBox textBoxYMax;
        private System.Windows.Forms.TextBox textBoxXMax;
        private System.Windows.Forms.TextBox textBoxXMin;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button cleanBtn;
    private System.Windows.Forms.DataGridViewTextBoxColumn X;
    private System.Windows.Forms.DataGridViewTextBoxColumn Y;
    private System.Windows.Forms.DataGridView gridView;
    private System.Windows.Forms.SplitContainer splitContainer1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox textBoxStep;
    private System.Windows.Forms.ToolStripMenuItem exportToExelToolStripMenuItem;
    private System.Windows.Forms.TextBox textBoxYMin;
  }
}

