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
            label1 = new Label();
            pictureBoxTestImage = new PictureBox();
            button1 = new Button();
            listViewTest = new ListView();
            columnHeaderTestImagePath = new ColumnHeader();
            toolStripCommands = new ToolStrip();
            toolStripButtonAddTrainImage = new ToolStripButton();
            toolStripButtonRemoveSelectedTrainImage = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolStripButtonAddTestImage = new ToolStripButton();
            toolStripButtonRemoveSelectedTestImage = new ToolStripButton();
            menuStripMainMenu.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            groupBoxTrain.SuspendLayout();
            groupBoxTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxTestImage).BeginInit();
            toolStripCommands.SuspendLayout();
            SuspendLayout();
            // 
            // menuStripMainMenu
            // 
            menuStripMainMenu.ImageScalingSize = new Size(20, 20);
            menuStripMainMenu.Items.AddRange(new ToolStripItem[] { پروندهToolStripMenuItem });
            menuStripMainMenu.Location = new Point(0, 0);
            menuStripMainMenu.Name = "menuStripMainMenu";
            menuStripMainMenu.Size = new Size(782, 28);
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
            tableLayoutPanel1.Size = new Size(782, 488);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // groupBoxTrain
            // 
            tableLayoutPanel1.SetColumnSpan(groupBoxTrain, 2);
            groupBoxTrain.Controls.Add(listViewTrain);
            groupBoxTrain.Dock = DockStyle.Fill;
            groupBoxTrain.Location = new Point(394, 10);
            groupBoxTrain.Name = "groupBoxTrain";
            groupBoxTrain.Size = new Size(385, 468);
            groupBoxTrain.TabIndex = 1;
            groupBoxTrain.TabStop = false;
            groupBoxTrain.Text = "آموزش";
            // 
            // listViewTrain
            // 
            listViewTrain.Columns.AddRange(new ColumnHeader[] { columnHeaderImageName, columnHeaderImageLabel, columnHeaderImagePath, columnHeaderImageDimensions });
            listViewTrain.Dock = DockStyle.Fill;
            listViewTrain.FullRowSelect = true;
            listViewTrain.GridLines = true;
            listViewTrain.Location = new Point(3, 23);
            listViewTrain.MultiSelect = false;
            listViewTrain.Name = "listViewTrain";
            listViewTrain.RightToLeftLayout = true;
            listViewTrain.Size = new Size(379, 442);
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
            groupBoxTest.Controls.Add(label1);
            groupBoxTest.Controls.Add(pictureBoxTestImage);
            groupBoxTest.Controls.Add(button1);
            groupBoxTest.Controls.Add(listViewTest);
            groupBoxTest.Dock = DockStyle.Fill;
            groupBoxTest.Location = new Point(10, 10);
            groupBoxTest.Name = "groupBoxTest";
            groupBoxTest.Size = new Size(378, 468);
            groupBoxTest.TabIndex = 0;
            groupBoxTest.TabStop = false;
            groupBoxTest.Text = "آزمایش";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoEllipsis = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(137, 346);
            label1.Name = "label1";
            label1.Size = new Size(235, 116);
            label1.TabIndex = 4;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBoxTestImage
            // 
            pictureBoxTestImage.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBoxTestImage.BorderStyle = BorderStyle.FixedSingle;
            pictureBoxTestImage.Location = new Point(6, 346);
            pictureBoxTestImage.Name = "pictureBoxTestImage";
            pictureBoxTestImage.Size = new Size(125, 116);
            pictureBoxTestImage.TabIndex = 3;
            pictureBoxTestImage.TabStop = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Cursor = Cursors.Hand;
            button1.Image = Properties.Resources.button_PredictImage_copy;
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(6, 290);
            button1.Name = "button1";
            button1.Size = new Size(366, 50);
            button1.TabIndex = 2;
            button1.Text = "شناسایی تصویر انتخاب شده";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // listViewTest
            // 
            listViewTest.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewTest.Columns.AddRange(new ColumnHeader[] { columnHeaderTestImagePath });
            listViewTest.FullRowSelect = true;
            listViewTest.GridLines = true;
            listViewTest.Location = new Point(6, 23);
            listViewTest.MultiSelect = false;
            listViewTest.Name = "listViewTest";
            listViewTest.RightToLeftLayout = true;
            listViewTest.Size = new Size(366, 261);
            listViewTest.TabIndex = 1;
            listViewTest.UseCompatibleStateImageBehavior = false;
            listViewTest.View = View.Details;
            listViewTest.SelectedIndexChanged += listViewTest_SelectedIndexChanged;
            // 
            // columnHeaderTestImagePath
            // 
            columnHeaderTestImagePath.Text = "تصویر";
            // 
            // toolStripCommands
            // 
            toolStripCommands.GripStyle = ToolStripGripStyle.Hidden;
            toolStripCommands.ImageScalingSize = new Size(30, 30);
            toolStripCommands.Items.AddRange(new ToolStripItem[] { toolStripButtonAddTrainImage, toolStripButtonRemoveSelectedTrainImage, toolStripSeparator1, toolStripButtonAddTestImage, toolStripButtonRemoveSelectedTestImage });
            toolStripCommands.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            toolStripCommands.Location = new Point(0, 28);
            toolStripCommands.Name = "toolStripCommands";
            toolStripCommands.Size = new Size(782, 37);
            toolStripCommands.TabIndex = 6;
            toolStripCommands.Text = "نوار ابزار";
            // 
            // toolStripButtonAddTrainImage
            // 
            toolStripButtonAddTrainImage.Image = Properties.Resources.button_AddImage_copy;
            toolStripButtonAddTrainImage.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddTrainImage.Name = "toolStripButtonAddTrainImage";
            toolStripButtonAddTrainImage.RightToLeftAutoMirrorImage = true;
            toolStripButtonAddTrainImage.Size = new Size(174, 34);
            toolStripButtonAddTrainImage.Text = "آموزش تصویر جدید...";
            toolStripButtonAddTrainImage.Click += toolStripButtonAddTrainImage_Click;
            // 
            // toolStripButtonRemoveSelectedTrainImage
            // 
            toolStripButtonRemoveSelectedTrainImage.Image = Properties.Resources.button_RemoveImage_copy;
            toolStripButtonRemoveSelectedTrainImage.ImageTransparentColor = Color.Magenta;
            toolStripButtonRemoveSelectedTrainImage.Name = "toolStripButtonRemoveSelectedTrainImage";
            toolStripButtonRemoveSelectedTrainImage.RightToLeftAutoMirrorImage = true;
            toolStripButtonRemoveSelectedTrainImage.Size = new Size(219, 34);
            toolStripButtonRemoveSelectedTrainImage.Text = "حذف تصویر آموزشی انتخابی";
            toolStripButtonRemoveSelectedTrainImage.Click += toolStripButtonRemoveSelectedTrainImage_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 37);
            // 
            // toolStripButtonAddTestImage
            // 
            toolStripButtonAddTestImage.Image = Properties.Resources.button_AddTestImage_copy;
            toolStripButtonAddTestImage.ImageTransparentColor = Color.Magenta;
            toolStripButtonAddTestImage.Name = "toolStripButtonAddTestImage";
            toolStripButtonAddTestImage.RightToLeftAutoMirrorImage = true;
            toolStripButtonAddTestImage.Size = new Size(162, 34);
            toolStripButtonAddTestImage.Text = "تست تصویر جدید...";
            // 
            // toolStripButtonRemoveSelectedTestImage
            // 
            toolStripButtonRemoveSelectedTestImage.Image = Properties.Resources.button_RemoveTestImage_copy;
            toolStripButtonRemoveSelectedTestImage.ImageTransparentColor = Color.Magenta;
            toolStripButtonRemoveSelectedTestImage.Name = "toolStripButtonRemoveSelectedTestImage";
            toolStripButtonRemoveSelectedTestImage.RightToLeftAutoMirrorImage = true;
            toolStripButtonRemoveSelectedTestImage.Size = new Size(204, 34);
            toolStripButtonRemoveSelectedTestImage.Text = "حذف تصویر تست انتخابی";
            // 
            // MainLBPHForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 553);
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
            groupBoxTest.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxTestImage).EndInit();
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
        private ListView listViewTest;
        private ColumnHeader columnHeaderTestImagePath;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButtonAddTestImage;
        private ToolStripButton toolStripButtonRemoveSelectedTestImage;
        private ToolStripButton toolStripButtonRemoveSelectedTrainImage;
        private Button button1;
        private PictureBox pictureBoxTestImage;
        private Label label1;
    }
}
