using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lab2Varian8;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Motion
{
    public partial class Model : Form
    {
        /// <summary>
        /// Список класса IMotion
        /// </summary>
        List<IMotion> _motions;  
        public Model()
        {
            InitializeComponent();
            _motions = new List<IMotion>();           
        }

        /// <summary>
        /// Функция добавляющия в datagrid значения
        /// </summary>
        /// <param name="motion"></param>
        private void AddMotion(IMotion motion)
        {
            _motions.Add(motion);
            var row = new DataGridViewRow();
            row.CreateCells(_dataGridView);
            var motionType = motion.Name;
            var motionCalc = motion.CalculateCoordination().ToString("F");
            row.Cells[0].Value = motionType;
            row.Cells[1].Value = motionCalc;
            _dataGridView.Rows.Add(row);
        }
        /// <summary>
        /// Кнопка для добавления значения в datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            var addForm = new View();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var motion = addForm.GetMotion();
                    AddMotion(motion);
                }
                catch(MinusExeption s)
                {                   
                    MessageBox.Show("Время не должно быть отрицательным", s.Message);                    
                }              
            }
        }
        /// <summary>
        /// Кнопка для создания рандомных значений
        /// и добавления их в datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RandomButton_Click(object sender, EventArgs e)
        {
            var Rundom = new Random();
            for (int i = 0; i < 10; i++)
            {
                IMotion iMotion = null;
                const double chislo = 100;
                switch (Rundom.Next() % 3)
                {
                    case 0:
                        {
                            iMotion = new Lab2Varian8.AcceleratedMotion(Rundom.NextDouble() * chislo, Rundom.NextDouble() * chislo, Convert.ToInt32(Rundom.Next(0, 20) * chislo), Rundom.NextDouble() * chislo);
                            break;
                        }
                    case 1:
                        {
                            iMotion = new Lab2Varian8.OscillatoryMotion(Rundom.NextDouble() * chislo, Rundom.NextDouble() * chislo, Convert.ToInt32(Rundom.Next(0, 20) * chislo), Rundom.NextDouble() * chislo, Rundom.NextDouble() * chislo);
                            break;
                        }
                    case 2:
                        {
                            iMotion = new UniformlyAcceleratedMotion(Rundom.NextDouble() * chislo, Rundom.NextDouble() * chislo, Convert.ToInt32(Rundom.Next(0, 20) * chislo));
                            break;
                        }
                }
                AddMotion(iMotion);
            }
        }
        /// <summary>
        /// Удадения строки из datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeletedButton_Click(object sender, EventArgs e)
        {
            if (_dataGridView.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Не выбранно ни одно поле", 
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (_dataGridView.SelectedCells.Count > 0)
            {
                var rowIndex = _dataGridView.SelectedCells[0].RowIndex;
                _motions.RemoveAt(rowIndex);
                _dataGridView.Rows.RemoveAt(rowIndex);
            }
        }
        /// <summary>
        /// Кнопка для закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
       /// <summary>
       /// Открытая функция 
       /// которая узнаёт индекс строки
       /// </summary>
       /// <returns></returns>
        public int getIndex()
        {
            if (_dataGridView.SelectedCells.Count > 0)
            {
                var rowIndex = _dataGridView.SelectedCells[0].RowIndex;
                return rowIndex;
            }
            return 0;
        }
        /// <summary>
        /// Функция открывающая и вносящая значения 
        /// в datagrid
        /// </summary>
        /// <param name="addForm"></param>
        private void _OpenEditMotion(View addForm)
        {         
            addForm.GetMotion();
        }
        /// <summary>
        /// Функция которая открывает форму и вписывает
        /// изменёные значения в datgrid
        /// </summary>
        /// <param name="motion"></param>
        /// <param name="rowIndex"></param>
        private void EditMotion(IMotion motion, int rowIndex)
        {         
            _motions[rowIndex] = motion;
            var row = new DataGridViewRow();
            row.CreateCells(_dataGridView);
            var motionType = motion.Name;
            var motionCalc = motion.CalculateCoordination().ToString("F");
            _dataGridView.Rows[rowIndex].Cells[0].Value = motionType;
            _dataGridView.Rows[rowIndex].Cells[1].Value = motionCalc;
        }
        /// <summary>
        /// Кнопка открывающая форму
        /// для изменения значения строки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditButton_Click(object sender, EventArgs e)
        {           
            if(_dataGridView.SelectedCells.Count <= 0)
            {
                MessageBox.Show("Не выбранно ни одно поле",
                    "Warning", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            if (_dataGridView.SelectedCells.Count > 0)
            {                
                var addForm = new View();
     
                var motion = _motions[getIndex()];
                addForm.SetMotion(motion);
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    try { }
                    catch (MinusExeption sd)
                    {
                        MessageBox.Show(sd.Message, "Error", MessageBoxButtons.OKCancel);
                    }
                    var motion2 = addForm.GetMotion();
                    EditMotion(motion2, getIndex());
                    //var motion = addForm.GetMotion();
                }
            }
        }
        /// <summary>
        /// Кнопка в меню 
        /// создающая диалоговое окно 
        /// для открытия файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _motions.Clear();
                _dataGridView.Rows.Clear();
                IEnumerable<IMotion> obj;
                try
                {
                    using (var file = File.Open(openFileDialog1.FileName, FileMode.Open))
                    {
                        var bf = new BinaryFormatter();
                        obj = (IEnumerable<IMotion>)bf.Deserialize(file);
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show("Файл повреждён!", 
                        exception.Message,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
                _motions.Clear();
                foreach (var motion in obj)
                {
                    AddMotion(motion);
                }
            }
        }
        /// <summary>
        /// Кнопка для создания диалогового окна сохрания файла
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var file = File.Create(saveFileDialog1.FileName))
                {
                    var bf = new BinaryFormatter();
                    bf.Serialize(file, _motions);
                    file.Close();
                }
            }
        }
        /// <summary>
        /// Кнопка меню для 
        /// закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void _AddButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(_AddButton, "Добавить решение");
        }
        private void _EditButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(_EditButton, "Изменить данные");
        }
        private void _DeleteButton_MouseHover(object sender, EventArgs e)
        {
            ToolTip tool = new ToolTip();
            tool.SetToolTip(_DeleteButton, "Удалить даные");
        }
    }
}