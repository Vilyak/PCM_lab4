using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        // Получим панель для рисования
        GraphPane pane;

        public Form1()
        {
            InitializeComponent();

            pane = zedGraph.GraphPane;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewX.RowCount = 1;
            dataGridViewX.ColumnCount = 6;

            dataGridViewY.RowCount = 1;
            dataGridViewY.ColumnCount = 6;

            foreach (DataGridViewColumn column in dataGridViewX.Columns)
                column.Width = 60;

            foreach (DataGridViewColumn column in dataGridViewY.Columns)
                column.Width = 60;

            FillDefault();
        }

        public void FillDefault()
        {
            double[] x = { 0, 2, 4, 6, 8, 10};
            double[] y = { 5, -1, 0.5, 1.5, 4.5, 8.5 };

            for (int i = 0; i < x.Length; i++)
            {
                dataGridViewX.Rows[0].Cells[i].Value = x[i].ToString();
            }

            for (int i = 0; i < y.Length; i++)
            {
                dataGridViewY.Rows[0].Cells[i].Value = y[i].ToString();
            }
        }

        public double[] dataGridViewInMassive(DataGridView dataGridView)
        {
            double[] dArr = new double[dataGridView.ColumnCount];
            for (int i = 0; i < dataGridView.ColumnCount; i++)
                dArr[i] = double.Parse(dataGridView[i, 0].Value.ToString());

            return dArr;
        }

        public void addTextInTextBox(TextBox textBox, String text, bool newLine = false)
        {
            if (newLine)
                textBox.AppendText(Environment.NewLine + text);
            else
                textBox.AppendText(text);

        }

        public void DrawGraph(string nameCurve, double[] x, double[] y, Color color)
        {            
            LineItem curveFunc = pane.AddCurve(nameCurve, x, y, color, SymbolType.None);
           
            pane.YAxis.Scale.MinAuto = false;
            pane.XAxis.Scale.Min = x[0];
            pane.YAxis.Scale.MaxAuto = false;
            pane.XAxis.Scale.Max = x[x.Length - 1];

            // по Oy - автоматически (для Ox можно так же сделать)
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;

            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            int n = 6;

            double[] x = dataGridViewInMassive(dataGridViewX);
            double[] y = dataGridViewInMassive(dataGridViewY);

            DrawGraph("Исходный график", x, y, Color.Red);

            // Используется для графика аппроксимирующих функций
            double[] yApproximation = new double[n];

            MHK mhk = new MHK(x, y);

            // ------------------------- y = ax+b -------------------------
            mhk.LinearApproximation();

            addTextInTextBox(textBoxResult, "Функция y = ax+b:");
            addTextInTextBox(textBoxResult, String.Format("a = {0:f3} b = {1:f3} r = {2:f3}", mhk.a, mhk.b, mhk.r), true);

            addTextInTextBox(textBoxResult, "Y(xi)  |", true);
            for (int i = 0; i < n; i++)
            {
                yApproximation[i] = mhk.LinearFunc(x[i]);
                addTextInTextBox(textBoxResult, String.Format("{0:f3}", yApproximation[i]) + "  ");
            }
            DrawGraph("y = ax+b", x, yApproximation, Color.Blue);

            addTextInTextBox(textBoxResult, "", true);
            addTextInTextBox(textBoxResult, "", true);

            // ------------------------- y = ax^2+bx+c -------------------------
            mhk.QuadraticApproximation();

            addTextInTextBox(textBoxResult, "Функция y = ax^2+bx+c:");
            addTextInTextBox(textBoxResult, String.Format("a = {0:f3} b = {1:f3} c = {2:f3} r = {3:f3}", mhk.a, mhk.b, mhk.c, mhk.r), true);

            addTextInTextBox(textBoxResult, "Y(xi)  |", true);
            for (int i = 0; i < n; i++)
            {
                yApproximation[i] = mhk.QuadraticFunc(x[i]);
                addTextInTextBox(textBoxResult, String.Format("{0:f3}", yApproximation[i]) + "  ");

            }
            DrawGraph("y = ax^2+bx+c", x, yApproximation, Color.Green);

            addTextInTextBox(textBoxResult, "", true);
            addTextInTextBox(textBoxResult, "", true);

            // ------------------------- y = a lnx + b -------------------------
            mhk.LogarifmApproximation();

            addTextInTextBox(textBoxResult, "Функция y = a lnx + b:");
            addTextInTextBox(textBoxResult, String.Format("a = {0:f3} b = {1:f3} r = {2:f3}", mhk.a, mhk.b, mhk.r), true);

            addTextInTextBox(textBoxResult, "Y(xi)  |", true);
            for (int i = 0; i < n; i++)
            {
                yApproximation[i] = mhk.LogarifmFunc(x[i]);
                addTextInTextBox(textBoxResult, String.Format("{0:f3}", yApproximation[i]) + "  ");
            }
            DrawGraph("y = a lnx + b", x, yApproximation, Color.Yellow);

        }

        private void buttonGraphClear_Click(object sender, EventArgs e)
        {
            pane.CurveList.Clear();
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }

        private void zedGraph_Load(object sender, EventArgs e)
        {

        }
    }
}
