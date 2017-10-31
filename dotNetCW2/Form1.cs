using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace dotNetCW2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void facultyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.facultyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.profession". При необходимости она может быть перемещена или удалена.
            this.professionTableAdapter.Fill(this.databaseDataSet.profession);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "databaseDataSet.faculty". При необходимости она может быть перемещена или удалена.
            this.facultyTableAdapter.Fill(this.databaseDataSet.faculty);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.facultyTableAdapter.FillBy(this.databaseDataSet.faculty);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        { // Load image from file
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataRowView drw = (DataRowView)professionBindingSource.Current;
                databaseDataSet.professionRow ur = (databaseDataSet.professionRow)(drw.Row);
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
                MemoryStream ms = new MemoryStream();
                fs.CopyTo(ms);
                ur.prof_image = ms.ToArray();
                ms.Close();
                fs.Close();
                professionTableAdapter.Update(ur);
                ur.AcceptChanges();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        { // Save image to file
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                DataRowView drw = (DataRowView)professionBindingSource.Current;
                databaseDataSet.professionRow ur = (databaseDataSet.professionRow)(drw.Row);
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.CreateNew);
                MemoryStream ms = new MemoryStream(ur.prof_image);
                ms.CopyTo(fs);
                fs.Close();
                ms.Close();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.professionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            var frmProp = new frmProperties();
            frmProp.propertyGrid1.SelectedObject = prof_imagePictureBox;
            frmProp.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
