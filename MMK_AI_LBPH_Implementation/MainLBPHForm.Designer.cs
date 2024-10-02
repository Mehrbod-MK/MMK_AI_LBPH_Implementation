namespace MMK_AI_LBPH_Implementation
{
    partial class MainLBPHForm
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
            menuStripMainMenu = new MenuStrip();
            پروندهToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBoxTest = new GroupBox();
            groupBoxTrain = new GroupBox();
            menuStripMainMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            menuStripMainMenu.ImageScalingSize = new Size(20, 20);
            menuStripMainMenu.Items.AddRange(new ToolStripItem[] { پروندهToolStripMenuItem });
            menuStripMainMenu.Location = new Point(0, 0);
            menuStripMainMenu.Name = "menuStripMainMenu";
            menuStripMainMenu.Size = new Size(682, 28);
            menuStripMainMenu.TabIndex = 0;
            menuStripMainMenu.Text = "menuStrip1";
            // 
            // پروندهToolStripMenuItem
            // 
            پروندهToolStripMenuItem.Name = "پروندهToolStripMenuItem";
            پروندهToolStripMenuItem.Size = new Size(62, 24);
            پروندهToolStripMenuItem.Text = "پرونده";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.Controls.Add(groupBoxTrain, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBoxTest, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 28);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(682, 425);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // groupBoxTest
            // 
            groupBoxTest.Dock = DockStyle.Fill;
            groupBoxTest.Location = new Point(10, 10);
            groupBoxTest.Name = "groupBoxTest";
            groupBoxTest.Size = new Size(328, 405);
            groupBoxTest.TabIndex = 0;
            groupBoxTest.TabStop = false;
            groupBoxTest.Text = "Test";
            // 
            // groupBoxTrain
            // 
            tableLayoutPanel1.SetColumnSpan(groupBoxTrain, 2);
            groupBoxTrain.Dock = DockStyle.Fill;
            groupBoxTrain.Location = new Point(344, 10);
            groupBoxTrain.Name = "groupBoxTrain";
            groupBoxTrain.Size = new Size(335, 405);
            groupBoxTrain.TabIndex = 1;
            groupBoxTrain.TabStop = false;
            groupBoxTrain.Text = "Train";
            // 
            // MainLBPHForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStripMainMenu);
            MainMenuStrip = menuStripMainMenu;
            Name = "MainLBPHForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پردازش تصویر - الگوریتم LBPH - مهربد ملاکاظمی خوبده - نسخه: ";
            menuStripMainMenu.ResumeLayout(false);
            menuStripMainMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainMenu;
        private ToolStripMenuItem پروندهToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxTest;
        private GroupBox groupBoxTrain;
    }
}
