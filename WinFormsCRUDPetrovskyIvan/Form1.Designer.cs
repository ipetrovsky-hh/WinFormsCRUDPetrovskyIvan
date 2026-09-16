namespace WinFormsCRUDPetrovskyIvan
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
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            редактрированиеToolStripMenuItem = new ToolStripMenuItem();
            просмотрToolStripMenuItem = new ToolStripMenuItem();
            администрированиеToolStripMenuItem = new ToolStripMenuItem();
            отчетностьToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            treeView1 = new TreeView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(238, 83);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1223, 385);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem, редактрированиеToolStripMenuItem, просмотрToolStripMenuItem, администрированиеToolStripMenuItem, отчетностьToolStripMenuItem, справкаToolStripMenuItem, выходToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1574, 33);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(92, 29);
            файлToolStripMenuItem.Text = "Главная";
            // 
            // редактрированиеToolStripMenuItem
            // 
            редактрированиеToolStripMenuItem.Name = "редактрированиеToolStripMenuItem";
            редактрированиеToolStripMenuItem.Size = new Size(162, 29);
            редактрированиеToolStripMenuItem.Text = "Редактирование";
            // 
            // просмотрToolStripMenuItem
            // 
            просмотрToolStripMenuItem.Name = "просмотрToolStripMenuItem";
            просмотрToolStripMenuItem.Size = new Size(113, 29);
            просмотрToolStripMenuItem.Text = "Просмотр";
            // 
            // администрированиеToolStripMenuItem
            // 
            администрированиеToolStripMenuItem.Name = "администрированиеToolStripMenuItem";
            администрированиеToolStripMenuItem.Size = new Size(199, 29);
            администрированиеToolStripMenuItem.Text = "Администрирование";
            // 
            // отчетностьToolStripMenuItem
            // 
            отчетностьToolStripMenuItem.Name = "отчетностьToolStripMenuItem";
            отчетностьToolStripMenuItem.Size = new Size(120, 29);
            отчетностьToolStripMenuItem.Text = "Отчетность";
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(97, 29);
            справкаToolStripMenuItem.Text = "Справка";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(80, 29);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 83);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(220, 385);
            treeView1.TabIndex = 2;
            treeView1.AfterSelect += treeView1_AfterSelect;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1574, 596);
            Controls.Add(treeView1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Проект Windows Forms";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem редактрированиеToolStripMenuItem;
        private ToolStripMenuItem просмотрToolStripMenuItem;
        private ToolStripMenuItem администрированиеToolStripMenuItem;
        private ToolStripMenuItem отчетностьToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private TreeView treeView1;
    }
}
