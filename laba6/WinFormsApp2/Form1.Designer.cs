
namespace WinFormsApp2
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
            this.components = new System.ComponentModel.Container();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progressStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spaceStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursorStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourGlassStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.handPointStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parallelFormStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modalFormStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MIClose = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.ContextMenuStrip = this.contextMenuStrip1;
            this.progressBar1.Location = new System.Drawing.Point(14, 97);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(114, 31);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4,
            this.toolStripMenuItem5});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(159, 52);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItem4.Text = "У&величить";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(158, 24);
            this.toolStripMenuItem5.Text = "У&меньшить";
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleName = "";
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progressStripMenuItem,
            this.spaceStripMenuItem,
            this.cursorStripMenuItem,
            this.formsStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // progressStripMenuItem
            // 
            this.progressStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.decreaseStripMenuItem,
            this.increaseStripMenuItem});
            this.progressStripMenuItem.Name = "progressStripMenuItem";
            this.progressStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.progressStripMenuItem.Text = "&Прогресс";
            // 
            // decreaseStripMenuItem
            // 
            this.decreaseStripMenuItem.Name = "decreaseStripMenuItem";
            this.decreaseStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.decreaseStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.decreaseStripMenuItem.Text = "У&меньшить";
            // 
            // increaseStripMenuItem
            // 
            this.increaseStripMenuItem.Name = "increaseStripMenuItem";
            this.increaseStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.increaseStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.increaseStripMenuItem.Text = "У&величить";
            // 
            // spaceStripMenuItem
            // 
            this.spaceStripMenuItem.Name = "spaceStripMenuItem";
            this.spaceStripMenuItem.Size = new System.Drawing.Size(29, 24);
            this.spaceStripMenuItem.Text = "-";
            // 
            // cursorStripMenuItem
            // 
            this.cursorStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultStripMenuItem,
            this.hourGlassStripMenuItem,
            this.handPointStripMenuItem});
            this.cursorStripMenuItem.Name = "cursorStripMenuItem";
            this.cursorStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.cursorStripMenuItem.Text = "&Курсор";
            // 
            // defaultStripMenuItem
            // 
            this.defaultStripMenuItem.Name = "defaultStripMenuItem";
            this.defaultStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.defaultStripMenuItem.Text = "&Default";
            // 
            // hourGlassStripMenuItem
            // 
            this.hourGlassStripMenuItem.Name = "hourGlassStripMenuItem";
            this.hourGlassStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.hourGlassStripMenuItem.Text = "&HourGlass";
            // 
            // handPointStripMenuItem
            // 
            this.handPointStripMenuItem.Name = "handPointStripMenuItem";
            this.handPointStripMenuItem.Size = new System.Drawing.Size(161, 26);
            this.handPointStripMenuItem.Text = "Hand&Point";
            // 
            // formsStripMenuItem
            // 
            this.formsStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parallelFormStripMenuItem,
            this.modalFormStripMenuItem,
            this.toolStripMenuItem1,
            this.MIClose});
            this.formsStripMenuItem.Name = "formsStripMenuItem";
            this.formsStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.formsStripMenuItem.Text = "&Формы";
            // 
            // parallelFormStripMenuItem
            // 
            this.parallelFormStripMenuItem.Name = "parallelFormStripMenuItem";
            this.parallelFormStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.parallelFormStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.parallelFormStripMenuItem.Text = "&Параллельная";
            // 
            // modalFormStripMenuItem
            // 
            this.modalFormStripMenuItem.Name = "modalFormStripMenuItem";
            this.modalFormStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
            this.modalFormStripMenuItem.Size = new System.Drawing.Size(243, 26);
            this.modalFormStripMenuItem.Text = "&Модальная";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(243, 26);
            this.toolStripMenuItem1.Text = "-";
            // 
            // MIClose
            // 
            this.MIClose.Checked = true;
            this.MIClose.CheckOnClick = true;
            this.MIClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.MIClose.Name = "MIClose";
            this.MIClose.Size = new System.Drawing.Size(243, 26);
            this.MIClose.Text = "&Запрос при закрытие";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem8.Text = "&Default";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem9.Text = "&HourGlass";
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem10.Text = "Hand&Point";
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem13.Text = "&Default";
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem14.Text = "&HourGlass";
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(131, 22);
            this.toolStripMenuItem15.Text = "Hand&Point";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Пример использования меню";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem progressStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increaseStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem9;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem10;
        private System.Windows.Forms.ToolStripMenuItem spaceStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursorStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourGlassStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem handPointStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem13;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem14;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem15;
        private System.Windows.Forms.ToolStripMenuItem formsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parallelFormStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modalFormStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MIClose;
    }
}

