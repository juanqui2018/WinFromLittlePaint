using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace juanCarlos.Paint
{
    public partial class Form1 : Form
    {
        private int contador = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MiHijo mdi = new MiHijo()
            {
                Text = $"Hijo {contador++}",
                MdiParent = this
            };

            mdi.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                //if (ActiveMdiChild != null)
                //{
                //    if (sfdSave.ShowDialog() == DialogResult.OK)
                //    {
                //        File.WriteAllText(sfdSave.FileName, ((MdiHijo)ActiveMdiChild).TextRTB);
                //        MessageBox.Show("Se guardó correctamente", "Save");
                //    }
                //}
                if (sfdSave.ShowDialog() == DialogResult.OK)
                {
                    //Path.Combine(@"C:\Users\Avantica\Desktop\", sfdSave.FileName);
                   /* ((MiHijo)ActiveMdiChild).unobitMap.Save(Path.Combine(@"C:\Users\Avantica\Desktop\", sfdSave.FileName));*/
                    //((MiHijo)ActiveMdiChild).unobitMap.Save(saveFileDialog.FileName);
                    //File.WriteAllBytes(sfdSave.FileName, (
                    //    (MiHijo)ActiveMdiChild).unobitMap
                    //    );
                    
                    ((MiHijo)ActiveMdiChild).unobitMap.Save(
                        //@"C:\Users\Avantica\Desktop\img_" + sfdSave.FileName + ".png", System.Drawing.Imaging.ImageFormat.Png
                        sfdSave.FileName, System.Drawing.Imaging.ImageFormat.Png
                        );
                    
                    // FileInfo img__ = new FileInfo(@"img_" + sfdSave.FileName + ".Bmp");
                    //  img__.MoveTo("myVideo\\img_" + sfdSave.FileName + ".jpg");
                    MessageBox.Show("Se guardó correctamente", "Save");
                }
            }
        }
    }
}
