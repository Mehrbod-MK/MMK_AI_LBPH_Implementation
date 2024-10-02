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
            groupBoxTrain = new GroupBox();
            listViewTrain = new ListView();
            columnHeaderImageName = new ColumnHeader();
            columnHeaderImageLabel = new ColumnHeader();
            columnHeaderImagePath = new ColumnHeader();
            columnHeaderImageDimensions = new ColumnHeader();
            groupBoxTest = new GroupBox();
            toolStripCommands = new ToolStrip();
            toolStripButtonAddTrainImage = new ToolStripButton();
            menuStripMainMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxTrain.SuspendLayout();
            toolStripCommands.SuspendLayout();
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
            tableLayoutPanel1.Location = new Point(0, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 7F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(682, 388);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBoxTrain
            // 
            tableLayoutPanel1.SetColumnSpan(groupBoxTrain, 2);
            groupBoxTrain.Controls.Add(listViewTrain);
            groupBoxTrain.Dock = DockStyle.Fill;
            groupBoxTrain.Location = new Point(344, 10);
            groupBoxTrain.Name = "groupBoxTrain";
            groupBoxTrain.Size = new Size(335, 368);
            groupBoxTrain.TabIndex = 1;
            groupBoxTrain.TabStop = false;
            groupBoxTrain.Text = "Train";
            // 
            // listViewTrain
            // 
            listViewTrain.Columns.AddRange(new ColumnHeader[] { columnHeaderImageName, columnHeaderImageLabel, columnHeaderImagePath, columnHeaderImageDimensions });
            listViewTrain.Dock = DockStyle.Fill;
            listViewTrain.FullRowSelect = true;
            listViewTrain.GridLines = true;
            listViewTrain.Location = new Point(3, 23);
            listViewTrain.Name = "listViewTrain";
            listViewTrain.RightToLeftLayout = true;
            listViewTrain.Size = new Size(329, 342);
            listViewTrain.TabIndex = 0;
            listViewTrain.UseCompatibleStateImageBehavior = false;
            listViewTrain.View = View.Details;
            // 
            // columnHeaderImageName
            // 
            columnHeaderImageName.Text = "نام تصویر";
            // 
            // columnHeaderImageLabel
            // 
            columnHeaderImageLabel.Text = "برچسب";
            // 
            // columnHeaderImagePath
            // 
            columnHeaderImagePath.Text = "مسیر روی دیسک";
            // 
            // columnHeaderImageDimensions
            // 
            columnHeaderImageDimensions.Text = "ابعاد";
            // 
            // groupBoxTest
            // 
            groupBoxTest.Dock = DockStyle.Fill;
            groupBoxTest.Location = new Point(10, 10);
            groupBoxTest.Name = "groupBoxTest";
            groupBoxTest.Size = new Size(328, 368);
            groupBoxTest.TabIndex = 0;
            groupBoxTest.TabStop = false;
            groupBoxTest.Text = "Test";
            // 
            // toolStripCommands
            // 
            toolStripCommands.GripStyle = ToolStripGripStyle.Hidden;
            toolStripCommands.ImageScalingSize = new Size(30, 30);
            toolStripCommands.Items.AddRange(new ToolStripItem[] { toolStripButtonAddTrainImage });
            toolStripCommands.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStripCommands.Location = new Point(0, 28);
            toolStripCommands.Name = "toolStripCommands";
            toolStripCommands.Size = new Size(682, 37);
            toolStripCommands.TabIndex = 6;
            toolStripCommands.Text = "نوار ابزار";
            // 
            // toolStripButtonAddTrainImage
            // 
            toolStripButtonAddTrainImage.Image = Properties.Resources.button_AddImage_copy;
            toolStripButtonAddTrainImage.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddTrainImage.Name = "toolStripButtonAddTrainImage";
            toolStripButtonAddTrainImage.RightToLeftAutoMirrorImage = true;
            toolStripButtonAddTrainImage.Size = new Size(126, 34);
            toolStripButtonAddTrainImage.Text = "تصویر جدید...";
            toolStripButtonAddTrainImage.Click += toolStripButtonAddTrainImage_Click;
            // 
            // MainLBPHForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 453);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(toolStripCommands);
            Controls.Add(menuStripMainMenu);
            DoubleBuffered = true;
            MainMenuStrip = menuStripMainMenu;
            Name = "MainLBPHForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "پردازش تصویر - الگوریتم LBPH - مهربد ملاکاظمی خوبده - نسخه: ";
            menuStripMainMenu.ResumeLayout(false);
            menuStripMainMenu.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            groupBoxTrain.ResumeLayout(false);
            toolStripCommands.ResumeLayout(false);
            toolStripCommands.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStripMainMenu;
        private ToolStripMenuItem پروندهToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBoxTrain;
        private ListView listViewTrain;
        private GroupBox groupBoxTest;
        private ToolStrip toolStripCommands;
        private ToolStripButton toolStripButtonAddTrainImage;
        private ColumnHeader columnHeaderImageName;
        private ColumnHeader columnHeaderImageLabel;
        private ColumnHeader columnHeaderImagePath;
        private ColumnHeader columnHeaderImageDimensions;
    }
}
