using Lab3.Servises;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Windows.Forms.DataVisualization.Charting;


namespace Lab3 {
  public partial class MainForm : Form {
    private readonly IGraphics _grafServ;
    bool onValidation = true;
    public MainForm(IGraphics grafServ) {
      InitializeComponent();

      
      _grafServ = grafServ;


      ChangeChartArea();
      chart.ChartAreas[0].AxisY.Title = "Axis Y";
      chart.ChartAreas[0].AxisX.Title = "Axis X";

      chart.Series[0].Points.Add();

      textBoxA.TextChanged += new EventHandler(MoveFormula);
      textBoxB.TextChanged += new EventHandler(MoveFormula);
      textBoxC.TextChanged += new EventHandler(MoveFormula);
      textBoxD.TextChanged += new EventHandler(MoveFormula);
      textBoxStep.TextChanged += new EventHandler(MoveFormula);

      textBoxXMin.TextChanged += new EventHandler((s, e) => Validation(s, false));
      textBoxXMax.TextChanged += new EventHandler((s, e) => Validation(s, false));
      textBoxYMin.TextChanged += new EventHandler((s, e) => Validation(s, false));
      textBoxYMax.TextChanged += new EventHandler((s, e) => Validation(s, false));
      MoveFormula(textBoxA,  default);
    }
    #region Greeting
    private void ShowGreeting(object sender, EventArgs e) {
      if (bool.Parse(ConfigurationManager.AppSettings["showGreeting"])) {
        ShowGreetingForm();
        showGreetingsToolStripMenuItem.Checked = true;
      }
      else {
        showGreetingsToolStripMenuItem.Checked = false;
      }
    }
    private void ShowGreetingForm() {
      new Lab3.MessageForm(
          Left + Width / 2,
          Top + Height / 2,
          "Студент СПБГТИ(ТУ) \n" +
          "Старков Силантий Денисович \n" +
          "403 группа\nЛабораторная работа №1\n" +
          "Вариант №1\nПостроение простого бинарного дерева").ShowDialog();
    }
    private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
      ShowGreetingForm();
    }

    private void showGreetingsToolStripMenuItem_Click(object sender, EventArgs e) {
      var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
      bool show = !bool.Parse(ConfigurationManager.AppSettings["showGreeting"]);
      config.AppSettings.Settings["showGreeting"].Value = (show).ToString();
      config.Save();
      showGreetingsToolStripMenuItem.Checked = show;


      ConfigurationManager.RefreshSection("appSettings");
    }
    #endregion

    #region File
    private void saveInnerDataToolStripMenuItem_Click(object sender, EventArgs e) {
      SaveFileDialog saveFileDialog = new SaveFileDialog {

        Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
      };

      if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      string filename = saveFileDialog.FileName;

      StringBuilder data = new StringBuilder();
      data.Append("A = " + textBoxA.Text + "\n");
      data.Append("B = " + textBoxB.Text + "\n");
      data.Append("C = " + textBoxC.Text + "\n");
      data.Append("D = " + textBoxD.Text);

      System.IO.File.WriteAllText(filename, data.ToString());
    }
    private void saveResultsToolStripMenuItem_Click(object sender, EventArgs e) {
      SaveFileDialog saveFileDialog = new SaveFileDialog {

        Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
      };

      if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      string filename = saveFileDialog.FileName;

      StringBuilder data = new StringBuilder();
      foreach (System.Windows.Forms.DataVisualization.Charting.DataPoint item in chart.Series[0].Points) {
        data.Append("X = " + item.XValue + " Y = " + item.YValues[0] + "\n");
      }

      System.IO.File.WriteAllText(filename, data.ToString());
    }
    private void openFileToolStripMenuItem_Click(object sender, EventArgs e) {
      OpenFileDialog openFileDialog = new OpenFileDialog {

        Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*"
      };

      if (openFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      string filename = openFileDialog.FileName;
      string[] data = System.IO.File.ReadAllText(filename).Split('\n');
      try {
        textBoxA.Text = data[0].Substring(data[0].IndexOf("= ") + "= ".Length);
        textBoxB.Text = data[1].Substring(data[1].IndexOf("= ") + "= ".Length);
        textBoxC.Text = data[2].Substring(data[2].IndexOf("= ") + "= ".Length);
        textBoxD.Text = data[3].Substring(data[3].IndexOf("= ") + "= ".Length);
        startBtn_Click(sender, e);
      }
      catch (Exception) {
        new Lab3.MessageForm(
     Left + Width / 2,
     Top + Height / 2,
     "Ошибка:\nНеверный формат данных.").ShowDialog();
        //throw;
      }
    }

    private void exportToExelToolStripMenuItem_Click(object sender, EventArgs e) {
      // Получить объект приложения Excel.
      Microsoft.Office.Interop.Excel.Application excel_app =
          new Microsoft.Office.Interop.Excel.Application();

      // Сделать Excel видимым (необязательно).
      Visible = true;

      // Создаем книгу.
      Microsoft.Office.Interop.Excel.Workbook workbook =
          excel_app.Workbooks.Add(Type.Missing);

      // Получить первый рабочий лист.
      Microsoft.Office.Interop.Excel.Worksheet sheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Sheets[1];

      object[,] values = new object[gridView.Rows.Count + 1, 2];
      values[0, 0] = "x";
      values[0, 1] = "y";

      for (int i = 0; i < gridView.Rows.Count; i++) {
        values[i + 1, 0] = gridView.Rows[i].Cells[0].Value;
        values[i + 1, 1] = gridView.Rows[i].Cells[1].Value;
      }

      Microsoft.Office.Interop.Excel.Range value_range = sheet.get_Range("A1", "B" + (gridView.Rows.Count + 1).ToString());
      value_range.Value2 = values;

      Microsoft.Office.Interop.Excel.Range colA = (Microsoft.Office.Interop.Excel.Range)sheet.Columns[1, Type.Missing];
      colA.ColumnWidth = 12;

      // Создаем диаграмму.
      Microsoft.Office.Interop.Excel.Shape chart_shape = sheet.Shapes.AddChart(
           Microsoft.Office.Interop.Excel.XlChartType.xlLine, 200, 5, 300, 200);
      Microsoft.Office.Interop.Excel.Chart chart = chart_shape.Chart;

      // Устанавливаем данные.
      Microsoft.Office.Interop.Excel.Range chart_range = sheet.get_Range("B2", "B" + (gridView.Rows.Count + 1).ToString());
      chart.SetSourceData(chart_range, Microsoft.Office.Interop.Excel.XlRowCol.xlColumns);

      // Установите метки оси X.
      Microsoft.Office.Interop.Excel.Range axis_range = sheet.get_Range("A2", "A" + (gridView.Rows.Count + 1).ToString());
      Microsoft.Office.Interop.Excel.Series series = (Microsoft.Office.Interop.Excel.Series)chart.SeriesCollection(1);
      series.XValues = axis_range;




      // Удалите сохраненный файл, если он уже существует.
      /*string filename = Application.StartupPath + "\\Chart.xlsx";
      System.IO.File.Delete(filename);*/
      SaveFileDialog saveFileDialog = new SaveFileDialog {

        Filter = "Excel files(*.xlsx)|*.xlsx|All files(*.*)|*.*"
      };

      if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
        return;
      string filename = saveFileDialog.FileName;

      // Сохраните изменения и закройте книгу.
      workbook.SaveAs(filename, Type.Missing, Type.Missing,
          Type.Missing, Type.Missing, Type.Missing,
           Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing,
          Type.Missing, Type.Missing, Type.Missing,
          Type.Missing);
      workbook.Close(true, Type.Missing, Type.Missing);

      // Закройте сервер Excel.
      excel_app.Quit();
    }
    #endregion

    #region UI
    private void MoveFormula(object sender, EventArgs e) {
      Validation(sender, true);
      textBoxA.Size = TextRenderer.MeasureText(textBoxA.Text + ' ', textBoxA.Font);
      textBoxB.Size = TextRenderer.MeasureText(textBoxB.Text + ' ', textBoxB.Font);
      textBoxC.Size = TextRenderer.MeasureText(textBoxC.Text + ' ', textBoxC.Font);
      textBoxD.Size = TextRenderer.MeasureText(textBoxD.Text + ' ', textBoxD.Font);
      labelPlus.Location = new Point(textBoxA.Location.X + textBoxA.Size.Width, labelPlus.Location.Y);
      textBoxB.Location = new Point(labelPlus.Location.X + labelPlus.Size.Width, textBoxB.Location.Y);
      labelSin.Location = new Point(textBoxB.Location.X + textBoxB.Size.Width, labelSin.Location.Y);
      textBoxC.Location = new Point(labelSin.Location.X + labelSin.Size.Width, textBoxC.Location.Y);
      labelXPlus.Location = new Point(textBoxC.Location.X + textBoxC.Size.Width, labelXPlus.Location.Y);
      textBoxD.Location = new Point(labelXPlus.Location.X + labelXPlus.Size.Width, textBoxD.Location.Y);
      labelClose.Location = new Point(textBoxD.Location.X + textBoxD.Size.Width, labelClose.Location.Y);

    }
    private void MoveGrafic(object sender, EventArgs e) {
      TextBox tb = (TextBox)sender;

      tb.Size = TextRenderer.MeasureText(tb.Text + ' ', tb.Font);
      chart.Location = new Point(tb.Location.X + tb.Width, 0);
      chart.Width = splitContainerMain.Width - chart.Location.X - gridView.Width;

    }//отодвигает график при расширении полей ввода

    /*        private void chart_SizeChanged(object sender, EventArgs e)
            {

                chart.Location = new Point(Math.Max(textBoxYMax.Location.X + textBoxYMax.Width, textBoxYMin.Location.X + textBoxYMin.Width), 0);
                chart.Width =  gridView.Location.X- chart.Location.X;
          chart.Height =  textBoxXMax.Location.Y- chart.Location.Y;
            }*/
    private void ChangeChartArea() {
      if (onValidation) {
        if (int.Parse(textBoxXMin.Text) < int.Parse(textBoxXMax.Text)) {
          chart.ChartAreas.ElementAt(0).AxisX.Minimum = int.Parse(textBoxXMin.Text);
          chart.ChartAreas.ElementAt(0).AxisX.Maximum = int.Parse(textBoxXMax.Text);
        }
        else {
          new Lab3.MessageForm(
    Left + Width / 2,
    Top + Height / 2,
    "Ошибка:\nМаксимальное значение Х меньше минимального!").ShowDialog();
        }
        if (int.Parse(textBoxYMin.Text) < int.Parse(textBoxYMax.Text)) {
          chart.ChartAreas.ElementAt(0).AxisY.Minimum = int.Parse(textBoxYMin.Text);
          chart.ChartAreas.ElementAt(0).AxisY.Maximum = int.Parse(textBoxYMax.Text);
        }
        else {
          new Lab3.MessageForm(
    Left + Width / 2,
    Top + Height / 2,
    "Ошибка:\nМаксимальное значение Y меньше минимального!").ShowDialog();

        }
      }
    }

    private void cleanBtn_Click(object sender, EventArgs e) {
      textBoxA.Text = "0";
      textBoxB.Text = "0";
      textBoxC.Text = "0";
      textBoxD.Text = "0";
      textBoxXMin.Text = "0";
      textBoxXMax.Text = "10";
      textBoxYMin.Text = "0";
      textBoxYMax.Text = "10";
      chart.Series[0].Points.Clear();
      chart.Series[0].Points.Add();
      ChangeChartArea();
      gridView.Rows.Clear();
    }

    private void Validation(object sender, bool doDouble) {

      TextBox tb = (TextBox)sender;
      string sequenceTextNewValue = tb.Text;
      if (sequenceTextNewValue.Length > 0) {
        for (int i = 0; i < sequenceTextNewValue.Length; i++) {
          if (sequenceTextNewValue.Length > 0 && (sequenceTextNewValue.ElementAt(i) < '0' || sequenceTextNewValue.ElementAt(i) > '9') && sequenceTextNewValue.ElementAt(i) != '-' && (doDouble ? sequenceTextNewValue.ElementAt(i) != ',' : true)) {
            sequenceTextNewValue = sequenceTextNewValue.Remove(i, 1);
            i--;

          }

        }
        if (tb.Name == textBoxStep.Name) {
          for (int a = 0; a < sequenceTextNewValue.Length; a++) {
            if (sequenceTextNewValue.ElementAt(a) == '-') {
              sequenceTextNewValue = sequenceTextNewValue.Remove(a, 1);
              a--;

            }
          }
        }


        if (doDouble) {
          while (sequenceTextNewValue.IndexOf(',') != sequenceTextNewValue.LastIndexOf(',')) { //в числе только одна точка
            sequenceTextNewValue = sequenceTextNewValue.Remove(sequenceTextNewValue.LastIndexOf(','), 1);
          }
          while (sequenceTextNewValue.IndexOf("-0") != -1)
            sequenceTextNewValue = sequenceTextNewValue.Replace("-0", "0");
          while (sequenceTextNewValue.Length > 1 && sequenceTextNewValue.ElementAt(0) == '0' && sequenceTextNewValue.ElementAt(1) != ',') {
            sequenceTextNewValue = sequenceTextNewValue.Remove(0, 1);
          }
          if (sequenceTextNewValue.LastIndexOf("-") > 0)
            sequenceTextNewValue = sequenceTextNewValue.Remove(sequenceTextNewValue.LastIndexOf("-"), 1);
          tb.Text = sequenceTextNewValue;
        }
        else {
          while (sequenceTextNewValue.IndexOf("-0") != -1)
            sequenceTextNewValue = sequenceTextNewValue.Replace("-0", "0");
          while (sequenceTextNewValue.Length > 1 && sequenceTextNewValue.ElementAt(0) == '0') {
            sequenceTextNewValue = sequenceTextNewValue.Remove(0, 1);
          }
          if (sequenceTextNewValue.LastIndexOf("-") > 0)
            sequenceTextNewValue = sequenceTextNewValue.Remove(sequenceTextNewValue.LastIndexOf("-"), 1);
          tb.Text = sequenceTextNewValue;
          if ((sequenceTextNewValue.Length > 1 && sequenceTextNewValue.Contains("-") ||
              sequenceTextNewValue.Length > 0 && !sequenceTextNewValue.Contains("-")))

            ChangeChartArea();
        }

        return;
      }

    }

    #endregion

    private void startBtn_Click(object sender, EventArgs e) {
      onValidation = false;
      double.TryParse(textBoxA.Text, out double a);
      double.TryParse(textBoxB.Text, out double b);
      double.TryParse(textBoxC.Text, out double c);
      double.TryParse(textBoxD.Text, out double d);
      double.TryParse(textBoxStep.Text, out double step);


      int.TryParse(textBoxYMax.Text, out int yMax);
      int.TryParse(textBoxYMin.Text, out int yMin);
      int.TryParse(textBoxXMax.Text, out int xMax);
      int.TryParse(textBoxXMin.Text, out int xMin);
      var Points = _grafServ.CalculatePoints(a, b, c, d, step, yMax, yMin, xMax, xMin);

      chart.Series[0].Points.Clear();
      while (gridView.Rows.Count != 0) {
        gridView.Rows.RemoveAt(gridView.Rows.Count - 1);
      }
      chart.ChartAreas[0].AxisY.MajorTickMark.Interval = 0;
      for (int i = 0; i < Points.Count; i++) {
        chart.Series[0].Points.AddXY(Points.Keys.ElementAt(i), Points.Values.ElementAt(i));
        gridView.Rows.Add(Points.Keys.ElementAt(i), Points.Values.ElementAt(i));
      }

      textBoxYMax.Text = ((int)(chart.Series[0].Points.FindMaxByValue().YValues[0] + 1)).ToString();
      textBoxYMin.Text = ((int)(chart.Series[0].Points.FindMinByValue().YValues[0] - 1)).ToString();
      onValidation = true;
      ChangeChartArea();
    }

    private void textBoxXMax_TextChanged(object sender, EventArgs e) {

    }
  }
}




