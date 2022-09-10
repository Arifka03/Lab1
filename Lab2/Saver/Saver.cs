using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saver
{
    public class PointsSaver
    {
        public SaveFileDialog dialog;
        public PointsSaver()
        {
            dialog = new SaveFileDialog()
            {
                Filter = "TXT (*.txt)|*.txt"
            };
        }

        public void Save(EquationPoints points)
        {
            try
            {
                if (dialog.ShowDialog() == DialogResult.Cancel)
                    return;
                string x = string.Join(" ", points.xValues);
                string y = string.Join(" ", points.yValues);
                System.IO.File.WriteAllText(dialog.FileName, x + Environment.NewLine + y);

                MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Unable to save file!");
            }
        }

    }
}
