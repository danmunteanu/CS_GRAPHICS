namespace CS_GRAPHICS
{
    partial class EditorMandelbrot
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutMain = new TableLayoutPanel();
            lblMaxIter = new Label();
            cmbMaxIter = new ComboBox();
            tableLayoutMain.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 4;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 115F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 113F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutMain.Controls.Add(lblMaxIter, 1, 0);
            tableLayoutMain.Controls.Add(cmbMaxIter, 2, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 3;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutMain.Size = new Size(306, 206);
            tableLayoutMain.TabIndex = 0;
            // 
            // lblMaxIter
            // 
            lblMaxIter.Anchor = AnchorStyles.Right;
            lblMaxIter.AutoSize = true;
            lblMaxIter.Location = new Point(45, 7);
            lblMaxIter.Name = "lblMaxIter";
            lblMaxIter.Size = new Size(106, 20);
            lblMaxIter.TabIndex = 0;
            lblMaxIter.Text = "Max Iterations:";
            // 
            // cmbMaxIter
            // 
            cmbMaxIter.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cmbMaxIter.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMaxIter.FormattingEnabled = true;
            cmbMaxIter.Location = new Point(157, 3);
            cmbMaxIter.Name = "cmbMaxIter";
            cmbMaxIter.Size = new Size(107, 28);
            cmbMaxIter.TabIndex = 1;
            // 
            // EditorMandelbrot
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutMain);
            Name = "EditorMandelbrot";
            Size = new Size(306, 206);
            tableLayoutMain.ResumeLayout(false);
            tableLayoutMain.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private Label lblMaxIter;
        private ComboBox cmbMaxIter;
    }
}
