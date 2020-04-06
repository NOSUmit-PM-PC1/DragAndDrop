using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DragAndDrop2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonSourceDrag_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSourceDrag.DoDragDrop(buttonSourceDrag.Text, DragDropEffects.Copy);
        }

        private void buttonSourceDrag2_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSourceDrag2.DoDragDrop(buttonSourceDrag2.Text, DragDropEffects.Copy);
        }
        private void textBoxTargetDrop_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void textBoxTargetDrop_DragDrop(object sender, DragEventArgs e)
        {
            string s = (string) e.Data.GetData(DataFormats.Text);
            textBoxTargetDrop.Text = s;
        }

     
    }
}
