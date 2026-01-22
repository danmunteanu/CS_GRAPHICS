namespace CS_GRAPHICS
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutMain = new TableLayoutPanel();
            tableLayoutRight = new TableLayoutPanel();
            pictureBox = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnRender = new Button();
            tableLayoutLeft = new TableLayoutPanel();
            panelEditor = new Panel();
            tableLayoutMain.SuspendLayout();
            tableLayoutRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutLeft.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutMain
            // 
            tableLayoutMain.ColumnCount = 2;
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 278F));
            tableLayoutMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutMain.Controls.Add(tableLayoutRight, 1, 0);
            tableLayoutMain.Controls.Add(tableLayoutLeft, 0, 0);
            tableLayoutMain.Dock = DockStyle.Fill;
            tableLayoutMain.Location = new Point(0, 0);
            tableLayoutMain.Name = "tableLayoutMain";
            tableLayoutMain.RowCount = 1;
            tableLayoutMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutMain.Size = new Size(1058, 594);
            tableLayoutMain.TabIndex = 0;
            // 
            // tableLayoutRight
            // 
            tableLayoutRight.ColumnCount = 1;
            tableLayoutRight.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutRight.Controls.Add(pictureBox, 0, 1);
            tableLayoutRight.Controls.Add(tableLayoutPanel1, 0, 2);
            tableLayoutRight.Dock = DockStyle.Fill;
            tableLayoutRight.Location = new Point(281, 3);
            tableLayoutRight.Name = "tableLayoutRight";
            tableLayoutRight.RowCount = 3;
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutRight.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutRight.Size = new Size(774, 588);
            tableLayoutRight.TabIndex = 2;
            // 
            // pictureBox
            // 
            pictureBox.BackColor = SystemColors.ActiveCaption;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 48);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(768, 492);
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 159F));
            tableLayoutPanel1.Controls.Add(btnRender, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 546);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(768, 39);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnRender
            // 
            btnRender.Dock = DockStyle.Fill;
            btnRender.Location = new Point(612, 3);
            btnRender.Name = "btnRender";
            btnRender.Size = new Size(153, 33);
            btnRender.TabIndex = 1;
            btnRender.Text = "RENDER";
            btnRender.UseVisualStyleBackColor = true;
            btnRender.Click += btnRender_Click;
            // 
            // tableLayoutLeft
            // 
            tableLayoutLeft.ColumnCount = 1;
            tableLayoutLeft.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutLeft.Controls.Add(panelEditor, 0, 1);
            tableLayoutLeft.Dock = DockStyle.Fill;
            tableLayoutLeft.Location = new Point(3, 3);
            tableLayoutLeft.Name = "tableLayoutLeft";
            tableLayoutLeft.RowCount = 4;
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 181F));
            tableLayoutLeft.RowStyles.Add(new RowStyle(SizeType.Absolute, 45F));
            tableLayoutLeft.Size = new Size(272, 588);
            tableLayoutLeft.TabIndex = 3;
            // 
            // panelEditor
            // 
            panelEditor.Dock = DockStyle.Fill;
            panelEditor.Location = new Point(3, 48);
            panelEditor.Name = "panelEditor";
            panelEditor.Size = new Size(266, 311);
            panelEditor.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 594);
            Controls.Add(tableLayoutMain);
            Name = "MainForm";
            Text = "CS Graphics";
            tableLayoutMain.ResumeLayout(false);
            tableLayoutRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutMain;
        private PictureBox pictureBox;
        private Button btnRender;
        private TableLayoutPanel tableLayoutRight;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutLeft;
        private Panel panelEditor;
    }
}
