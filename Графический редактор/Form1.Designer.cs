namespace Графический_редактор
{
    partial class Form1
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
            panel1 = new Panel();
            bFill = new Button();
            bLine = new Button();
            bEllipse = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            bColorChoose = new Button();
            label1 = new Label();
            penWidthBar = new TrackBar();
            bUserColor = new Button();
            bBlack = new Button();
            bWhite = new Button();
            bBrown = new Button();
            bPurple = new Button();
            bPink = new Button();
            bBlue = new Button();
            bLightBlue = new Button();
            bGreen = new Button();
            bYellow = new Button();
            bOrange = new Button();
            bRed = new Button();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            открытьToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            закрытьToolStripMenuItem = new ToolStripMenuItem();
            видToolStripMenuItem = new ToolStripMenuItem();
            цветФонаToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            pictBox = new PictureBox();
            colorDialog = new ColorDialog();
            saveFD = new SaveFileDialog();
            openFD = new OpenFileDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)penWidthBar).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictBox).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(bFill);
            panel1.Controls.Add(bLine);
            panel1.Controls.Add(bEllipse);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(bColorChoose);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(penWidthBar);
            panel1.Controls.Add(bUserColor);
            panel1.Controls.Add(bBlack);
            panel1.Controls.Add(bWhite);
            panel1.Controls.Add(bBrown);
            panel1.Controls.Add(bPurple);
            panel1.Controls.Add(bPink);
            panel1.Controls.Add(bBlue);
            panel1.Controls.Add(bLightBlue);
            panel1.Controls.Add(bGreen);
            panel1.Controls.Add(bYellow);
            panel1.Controls.Add(bOrange);
            panel1.Controls.Add(bRed);
            panel1.Controls.Add(menuStrip1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1310, 105);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // bFill
            // 
            bFill.Image = Properties.Resources.Fill;
            bFill.Location = new Point(871, 49);
            bFill.Name = "bFill";
            bFill.Size = new Size(44, 34);
            bFill.TabIndex = 21;
            bFill.UseVisualStyleBackColor = true;
            bFill.Click += bFill_Click;
            // 
            // bLine
            // 
            bLine.Image = Properties.Resources.LineSeparator;
            bLine.Location = new Point(971, 49);
            bLine.Name = "bLine";
            bLine.Size = new Size(44, 34);
            bLine.TabIndex = 20;
            bLine.UseVisualStyleBackColor = true;
            bLine.Click += bLine_Click;
            // 
            // bEllipse
            // 
            bEllipse.Image = Properties.Resources.Ellipse;
            bEllipse.Location = new Point(1021, 49);
            bEllipse.Name = "bEllipse";
            bEllipse.Size = new Size(41, 34);
            bEllipse.TabIndex = 19;
            bEllipse.UseVisualStyleBackColor = true;
            bEllipse.Click += bEllipse_Click;
            // 
            // button3
            // 
            button3.Image = Properties.Resources.Brush;
            button3.Location = new Point(921, 49);
            button3.Name = "button3";
            button3.Size = new Size(44, 34);
            button3.TabIndex = 18;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Image = Properties.Resources.Rectangle;
            button2.Location = new Point(1068, 49);
            button2.Name = "button2";
            button2.Size = new Size(41, 34);
            button2.TabIndex = 17;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = Properties.Resources.Eraser;
            button1.Location = new Point(1135, 48);
            button1.Name = "button1";
            button1.Size = new Size(35, 35);
            button1.TabIndex = 16;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // bColorChoose
            // 
            bColorChoose.FlatStyle = FlatStyle.Flat;
            bColorChoose.Image = Properties.Resources.ColorPalette;
            bColorChoose.Location = new Point(486, 46);
            bColorChoose.Name = "bColorChoose";
            bColorChoose.Size = new Size(35, 35);
            bColorChoose.TabIndex = 15;
            bColorChoose.UseVisualStyleBackColor = true;
            bColorChoose.Click += button1_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(748, 71);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 13;
            label1.Text = "Толщина";
            // 
            // penWidthBar
            // 
            penWidthBar.Anchor = AnchorStyles.Top;
            penWidthBar.Location = new Point(715, 36);
            penWidthBar.Maximum = 100;
            penWidthBar.Minimum = 10;
            penWidthBar.Name = "penWidthBar";
            penWidthBar.Size = new Size(156, 69);
            penWidthBar.TabIndex = 12;
            penWidthBar.Value = 10;
            // 
            // bUserColor
            // 
            bUserColor.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            bUserColor.BackColor = Color.Black;
            bUserColor.Enabled = false;
            bUserColor.FlatStyle = FlatStyle.Flat;
            bUserColor.Location = new Point(1230, 46);
            bUserColor.Name = "bUserColor";
            bUserColor.Size = new Size(68, 35);
            bUserColor.TabIndex = 11;
            bUserColor.UseVisualStyleBackColor = false;
            // 
            // bBlack
            // 
            bBlack.BackColor = Color.Black;
            bBlack.FlatStyle = FlatStyle.Flat;
            bBlack.Location = new Point(445, 46);
            bBlack.Name = "bBlack";
            bBlack.Size = new Size(35, 35);
            bBlack.TabIndex = 10;
            bBlack.UseVisualStyleBackColor = false;
            bBlack.Click += bRed_Click;
            // 
            // bWhite
            // 
            bWhite.BackColor = Color.White;
            bWhite.FlatStyle = FlatStyle.Flat;
            bWhite.Location = new Point(404, 46);
            bWhite.Name = "bWhite";
            bWhite.Size = new Size(35, 35);
            bWhite.TabIndex = 9;
            bWhite.UseVisualStyleBackColor = false;
            bWhite.Click += bRed_Click;
            // 
            // bBrown
            // 
            bBrown.BackColor = Color.FromArgb(128, 64, 0);
            bBrown.FlatStyle = FlatStyle.Flat;
            bBrown.Location = new Point(363, 46);
            bBrown.Name = "bBrown";
            bBrown.Size = new Size(35, 35);
            bBrown.TabIndex = 8;
            bBrown.UseVisualStyleBackColor = false;
            bBrown.Click += bRed_Click;
            // 
            // bPurple
            // 
            bPurple.BackColor = Color.Purple;
            bPurple.FlatStyle = FlatStyle.Flat;
            bPurple.Location = new Point(322, 46);
            bPurple.Name = "bPurple";
            bPurple.Size = new Size(35, 35);
            bPurple.TabIndex = 7;
            bPurple.UseVisualStyleBackColor = false;
            bPurple.Click += bRed_Click;
            // 
            // bPink
            // 
            bPink.BackColor = Color.Fuchsia;
            bPink.FlatStyle = FlatStyle.Flat;
            bPink.Location = new Point(281, 46);
            bPink.Name = "bPink";
            bPink.Size = new Size(35, 35);
            bPink.TabIndex = 6;
            bPink.UseVisualStyleBackColor = false;
            bPink.Click += bRed_Click;
            // 
            // bBlue
            // 
            bBlue.BackColor = Color.Blue;
            bBlue.FlatStyle = FlatStyle.Flat;
            bBlue.Location = new Point(240, 46);
            bBlue.Name = "bBlue";
            bBlue.Size = new Size(35, 35);
            bBlue.TabIndex = 5;
            bBlue.UseVisualStyleBackColor = false;
            bBlue.Click += bRed_Click;
            // 
            // bLightBlue
            // 
            bLightBlue.BackColor = Color.Cyan;
            bLightBlue.FlatStyle = FlatStyle.Flat;
            bLightBlue.Location = new Point(199, 46);
            bLightBlue.Name = "bLightBlue";
            bLightBlue.Size = new Size(35, 35);
            bLightBlue.TabIndex = 4;
            bLightBlue.UseVisualStyleBackColor = false;
            bLightBlue.Click += bRed_Click;
            // 
            // bGreen
            // 
            bGreen.BackColor = Color.Lime;
            bGreen.FlatStyle = FlatStyle.Flat;
            bGreen.Location = new Point(158, 46);
            bGreen.Name = "bGreen";
            bGreen.Size = new Size(35, 35);
            bGreen.TabIndex = 3;
            bGreen.UseVisualStyleBackColor = false;
            bGreen.Click += bRed_Click;
            // 
            // bYellow
            // 
            bYellow.BackColor = Color.Yellow;
            bYellow.FlatStyle = FlatStyle.Flat;
            bYellow.Location = new Point(117, 46);
            bYellow.Name = "bYellow";
            bYellow.Size = new Size(35, 35);
            bYellow.TabIndex = 2;
            bYellow.UseVisualStyleBackColor = false;
            bYellow.Click += bRed_Click;
            // 
            // bOrange
            // 
            bOrange.BackColor = Color.FromArgb(255, 128, 0);
            bOrange.FlatStyle = FlatStyle.Flat;
            bOrange.Location = new Point(76, 46);
            bOrange.Name = "bOrange";
            bOrange.Size = new Size(35, 35);
            bOrange.TabIndex = 1;
            bOrange.UseVisualStyleBackColor = false;
            bOrange.Click += bRed_Click;
            // 
            // bRed
            // 
            bRed.BackColor = Color.Red;
            bRed.FlatStyle = FlatStyle.Flat;
            bRed.Location = new Point(35, 46);
            bRed.Name = "bRed";
            bRed.Size = new Size(35, 35);
            bRed.TabIndex = 0;
            bRed.UseVisualStyleBackColor = false;
            bRed.Click += bRed_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, видToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1310, 33);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { открытьToolStripMenuItem, сохранитьToolStripMenuItem, закрытьToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(69, 29);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // открытьToolStripMenuItem
            // 
            открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            открытьToolStripMenuItem.Size = new Size(200, 34);
            открытьToolStripMenuItem.Text = "Открыть";
            открытьToolStripMenuItem.Click += открытьToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(200, 34);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            сохранитьToolStripMenuItem.Click += сохранитьToolStripMenuItem_Click;
            // 
            // закрытьToolStripMenuItem
            // 
            закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            закрытьToolStripMenuItem.Size = new Size(200, 34);
            закрытьToolStripMenuItem.Text = "Закрыть";
            закрытьToolStripMenuItem.Click += закрытьToolStripMenuItem_Click;
            // 
            // видToolStripMenuItem
            // 
            видToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { цветФонаToolStripMenuItem });
            видToolStripMenuItem.Name = "видToolStripMenuItem";
            видToolStripMenuItem.Size = new Size(58, 29);
            видToolStripMenuItem.Text = "Вид";
            // 
            // цветФонаToolStripMenuItem
            // 
            цветФонаToolStripMenuItem.Name = "цветФонаToolStripMenuItem";
            цветФонаToolStripMenuItem.Size = new Size(200, 34);
            цветФонаToolStripMenuItem.Text = "Цвет фона";
            цветФонаToolStripMenuItem.Click += цветФонаToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(97, 29);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // pictBox
            // 
            pictBox.BackColor = Color.White;
            pictBox.Dock = DockStyle.Fill;
            pictBox.Location = new Point(0, 105);
            pictBox.Name = "pictBox";
            pictBox.Size = new Size(1310, 687);
            pictBox.TabIndex = 1;
            pictBox.TabStop = false;
            pictBox.Click += pictBox_Click;
            pictBox.Paint += pictBox_Paint;
            pictBox.MouseClick += pictBox_MouseClick;
            pictBox.MouseDown += pictBox_MouseDown;
            pictBox.MouseMove += pictBox_MouseMove;
            pictBox.MouseUp += pictBox_MouseUp;
            // 
            // saveFD
            // 
            saveFD.DefaultExt = "jpg";
            saveFD.FileName = "безымянный";
            saveFD.Filter = "Image(*.jpg)|*.jpg|*.*|*.*";
            // 
            // openFD
            // 
            openFD.FileName = "безымянная";
            openFD.Filter = "Image(*.jpg)|*.jpg|*.*|*.*";
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(24, 24);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 760);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1310, 32);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(117, 25);
            toolStripStatusLabel1.Text = "безымянный";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1310, 792);
            Controls.Add(statusStrip1);
            Controls.Add(pictBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Графический редактор";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)penWidthBar).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictBox).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button bRed;
        private PictureBox pictBox;
        private Button bLightBlue;
        private Button bGreen;
        private Button bYellow;
        private Button bOrange;
        private Button bUserColor;
        private Button bBlack;
        private Button bWhite;
        private Button bBrown;
        private Button bPurple;
        private Button bPink;
        private Button bBlue;
        private Label label1;
        private TrackBar penWidthBar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ColorDialog colorDialog;
        private Button bColorChoose;
        private Button button1;
        private ToolStripMenuItem цветФонаToolStripMenuItem;
        private Button button2;
        private Button button3;
        private Button bEllipse;
        private Button bLine;
        private Button bFill;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem закрытьToolStripMenuItem;
        private SaveFileDialog saveFD;
        private OpenFileDialog openFD;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}
