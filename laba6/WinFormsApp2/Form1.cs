using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            decreaseStripMenuItem.Click += decrease;
            increaseStripMenuItem.Click += increase;
          
            toolStripMenuItem4.Click += increase;
            toolStripMenuItem5.Click += decrease;

            defaultStripMenuItem.Click += changeCursorStyle;
            hourGlassStripMenuItem.Click += changeCursorStyle;
            handPointStripMenuItem.Click += changeCursorStyle;

            modalFormStripMenuItem.Click += create_ModalForm;
            parallelFormStripMenuItem.Click += create_ParallelForm;
        }

        private void changeCursorStyle(object sender,EventArgs e)
        {
            ToolStripMenuItem menuItem = (ToolStripMenuItem)sender;

            switch (menuItem.Text+"den")
            {
                case "&Defaultden":
                    Cursor = Cursors.Default;
                    break;
                case "&HourGlassden":
                    Cursor = Cursors.WaitCursor;
                    break;
                case "Hand&Pointden":
                    Cursor = Cursors.Hand;
                    break;
            }
        }

        private void create_ParallelForm(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void create_ModalForm(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show(this);
        }

        private void decrease(object sender, EventArgs e)
        {
            if (progressBar1.Value > 2)
                progressBar1.Value -= 3;
            else
                progressBar1.Value -= 2;
        }

        private void increase(object sender, EventArgs e)
        {
            if (progressBar1.Value < 98)
                progressBar1.Value += 3;
            else
                progressBar1.Value += 2;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MIClose.Checked)
            {
                e.Cancel = MessageBox.Show("Закрыть форму?","Закрытие формы",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Question) != DialogResult.Yes;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
