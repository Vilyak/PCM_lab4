namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewX = new System.Windows.Forms.DataGridView();
            this.dataGridViewY = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.buttonGraphClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewX
            // 
            this.dataGridViewX.AllowUserToAddRows = false;
            this.dataGridViewX.AllowUserToDeleteRows = false;
            this.dataGridViewX.AllowUserToResizeColumns = false;
            this.dataGridViewX.AllowUserToResizeRows = false;
            this.dataGridViewX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewX.ColumnHeadersVisible = false;
            this.dataGridViewX.EnableHeadersVisualStyles = false;
            this.dataGridViewX.Location = new System.Drawing.Point(35, 12);
            this.dataGridViewX.Name = "dataGridViewX";
            this.dataGridViewX.RowHeadersVisible = false;
            this.dataGridViewX.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewX.ShowCellErrors = false;
            this.dataGridViewX.ShowCellToolTips = false;
            this.dataGridViewX.ShowEditingIcon = false;
            this.dataGridViewX.ShowRowErrors = false;
            this.dataGridViewX.Size = new System.Drawing.Size(632, 25);
            this.dataGridViewX.TabIndex = 0;
            // 
            // dataGridViewY
            // 
            this.dataGridViewY.AllowUserToAddRows = false;
            this.dataGridViewY.AllowUserToDeleteRows = false;
            this.dataGridViewY.AllowUserToResizeColumns = false;
            this.dataGridViewY.AllowUserToResizeRows = false;
            this.dataGridViewY.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewY.ColumnHeadersVisible = false;
            this.dataGridViewY.EnableHeadersVisualStyles = false;
            this.dataGridViewY.Location = new System.Drawing.Point(38, 54);
            this.dataGridViewY.Name = "dataGridViewY";
            this.dataGridViewY.RowHeadersVisible = false;
            this.dataGridViewY.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewY.ShowCellErrors = false;
            this.dataGridViewY.ShowCellToolTips = false;
            this.dataGridViewY.ShowEditingIcon = false;
            this.dataGridViewY.ShowRowErrors = false;
            this.dataGridViewY.Size = new System.Drawing.Size(629, 25);
            this.dataGridViewY.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "x:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "y:";
            // 
            // buttonSolve
            // 
            this.buttonSolve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonSolve.Location = new System.Drawing.Point(686, 12);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(115, 32);
            this.buttonSolve.TabIndex = 4;
            this.buttonSolve.Text = "Run";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBoxResult.Location = new System.Drawing.Point(12, 95);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(431, 283);
            this.textBoxResult.TabIndex = 5;
            // 
            // zedGraph
            // 
            this.zedGraph.BackColor = System.Drawing.Color.SteelBlue;
            this.zedGraph.Location = new System.Drawing.Point(467, 95);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(390, 283);
            this.zedGraph.TabIndex = 6;
            this.zedGraph.UseExtendedPrintDialog = true;
            this.zedGraph.Load += new System.EventHandler(this.zedGraph_Load);
            // 
            // buttonGraphClear
            // 
            this.buttonGraphClear.Location = new System.Drawing.Point(686, 54);
            this.buttonGraphClear.Name = "buttonGraphClear";
            this.buttonGraphClear.Size = new System.Drawing.Size(127, 30);
            this.buttonGraphClear.TabIndex = 7;
            this.buttonGraphClear.Text = "Clean UP";
            this.buttonGraphClear.UseVisualStyleBackColor = true;
            this.buttonGraphClear.Click += new System.EventHandler(this.buttonGraphClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(869, 390);
            this.Controls.Add(this.buttonGraphClear);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewY);
            this.Controls.Add(this.dataGridViewX);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewX;
        private System.Windows.Forms.DataGridView dataGridViewY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.TextBox textBoxResult;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.Button buttonGraphClear;
    }
}

