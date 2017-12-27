using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lab2Varian8;


namespace Motion
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        /// <summary>
        /// функция для записи в textbox
        /// </summary>
        /// <param name="motion"></param>
        public void SetMotion(IMotion motion)
        {
            var FOrm = new Model();

            if (motion is AcceleratedMotion)
            {
                _RadioButtonAscillatoryMotion.Checked = true;
                var Ax = (AcceleratedMotion)(motion);
                _TextboxAcellerationMotion_AX0.Text = Convert.ToString(Ax.AX);
                _TextboxAcellerationMotion_V0.Text = Convert.ToString(Ax.V0X);
                _TextboxAcellerationMotion_X0.Text = Convert.ToString(Ax.X0);
                _TextboxAcellerationMotion_Time.Text = Convert.ToString(Ax.Time);
            }
            if (motion is UniformlyAcceleratedMotion)
            {
                _RadioButtonUnidormMotion.Checked = true;
                var Ux = (UniformlyAcceleratedMotion)(motion);
                _TextboxUniformMotion_X0.Text = Convert.ToString(Ux.X0);
                _TextboxUniformMotion_V0.Text = Convert.ToString(Ux.VX);
                _TextboxUniformMotion_Time.Text = Convert.ToString(Ux.Time);
            }
            if (motion is OscillatoryMotion)
            {
                _RadioButtonOcillatoryMotion.Checked = true;
                var Ox = (OscillatoryMotion)(motion);
                _TextboxOscillatoryMotion_F0.Text = Convert.ToString(Ox.F0);
                _TextboxOscillatoryMotion_W0.Text = Convert.ToString(Ox.W0);
                _TextboxOscillatoryMotion_X0.Text = Convert.ToString(Ox.X0);
                _TextboxOscillatoryMotion_VX0.Text = Convert.ToString(Ox.XM);
                _TextboxOscillatoryMotion_Time.Text = Convert.ToString(Ox.Time);
            }
        }
        /// <summary>
        /// Считывает и возвращает значения IMotion
        /// </summary>
        /// <returns>IMotion</returns>
        public IMotion GetMotion()
        {


            if (_RadioButtonUnidormMotion.Checked)
            {
                return new UniformlyAcceleratedMotion(double.Parse(_TextboxUniformMotion_X0.Text),
                    double.Parse(_TextboxUniformMotion_V0.Text),
                    int.Parse(_TextboxUniformMotion_Time.Text));
            }

            else if (_RadioButtonAscillatoryMotion.Checked == true)
            {
                return new AcceleratedMotion(double.Parse(_TextboxAcellerationMotion_X0.Text),
                    double.Parse(_TextboxAcellerationMotion_AX0.Text),
                    int.Parse(_TextboxAcellerationMotion_Time.Text),
                    double.Parse(_TextboxAcellerationMotion_V0.Text));
            }


            else if (_RadioButtonOcillatoryMotion.Checked == true)
            {
                return new OscillatoryMotion(double.Parse(_TextboxOscillatoryMotion_X0.Text),
                    double.Parse(_TextboxOscillatoryMotion_VX0.Text),
                    int.Parse(_TextboxOscillatoryMotion_Time.Text),
                    double.Parse(_TextboxOscillatoryMotion_F0.Text),
                    double.Parse(_TextboxOscillatoryMotion_W0.Text));
            }



            return null;
        }
        /// <summary>
        /// Кнопка для закрытия формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CloseButton_Click(object sender, EventArgs e) => Close();
        /// <summary>
        /// Скрывает _GroupBoxOscillatoryMotion
        ///_GroupBoxAcceleratedMotion
        /// и показывает _GroupBoxUniformMotion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _RadioButtonUnidormMotion_CheckedChanged(object sender, EventArgs e)
        {
            _GroupBoxUniformMotion.Visible = true;
            _GroupBoxOscillatoryMotion.Visible = false;
            _GroupBoxAcceleratedMotion.Visible = false;

        }
        /// <summary>
        /// Скрывает __GroupBoxOscillatoryMotion
        ///_GroupBoxUniformMotion
        /// и показывает  _GroupBoxAcceleratedMotion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _RadioButtonAscillatoryMotion_CheckedChanged(object sender, EventArgs e)
        {
            _GroupBoxUniformMotion.Visible = false;
            _GroupBoxOscillatoryMotion.Visible = false;
            _GroupBoxAcceleratedMotion.Visible = true;
        }
        /// <summary>
        /// Скрывает _GroupBoxUniformMotion
        ///_GroupBoxAcceleratedMotion
        /// и показывает _GroupBoxOscillatoryMotion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _RadioButtonOcillatoryMotion_CheckedChanged(object sender, EventArgs e)
        {
            _GroupBoxUniformMotion.Visible = false;
            _GroupBoxOscillatoryMotion.Visible = true;
            _GroupBoxAcceleratedMotion.Visible = false;
        }
        /// <summary>
        /// Кнопка для добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;

        }

        /// <summary>
        /// Функция проверяющая ошибку
        /// </summary>
        /// <param name="e"></param>
        /// <param name="selectedTextBox"></param>
        /// <param name="textBox"></param>
        private void _ErrorText(KeyPressEventArgs e, TextBox selectedTextBox, TextBox textBox)
        {

            if (e.KeyChar == (char)13)
            {
                if (textBox.Text == "")

                    MessageBox.Show("Введите значение",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                else
                {
                    selectedTextBox.Select();
                    e.Handled = true;
                }
            }

            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)27 &&
                e.KeyChar != Convert.ToChar('\b') &&
                e.KeyChar != (char)13)
            {
                textBox.Clear();
                MessageBox.Show("Введён не правельный символ. \nнужно ввести цифры", "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Функция определяющая ошибку
        /// </summary>
        /// <param name="e"></param>
        /// <param name="selectedButton"></param>
        /// <param name="textBox"></param>
        private void _ErrorTextLast(KeyPressEventArgs e, Button selectedButton, TextBox textBox)
        {

            if (e.KeyChar == (char)13)
            {
                if (textBox.Text == "")

                    MessageBox.Show("Введите значение",
                        "Warning",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                else
                {
                    button1.Select();
                    e.Handled = true;
                }
            }

            if (!Char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)27 &&
                e.KeyChar != Convert.ToChar('\b') &&
                e.KeyChar != (char)13 &&
                e.KeyChar != (char)'-')
            {
                textBox.Clear();
                MessageBox.Show("Введён не правельный символ. \nнужно ввести цифры", "Error",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                e.Handled = true;
            }
        }
        /// <summary>
        /// Вывести сообщение об ошибке
        /// если в textbox ничего не записанно
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxUniformMotion_X0_KeyPress_1(object sender, KeyPressEventArgs e)
        {

            _ErrorText(e, _TextboxUniformMotion_V0, _TextboxUniformMotion_X0);
        }
        /// <summary>
        /// Вывести сообщение об ошибке
        /// если в textbox ничего не записанно
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxUniformMotion_V0_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorText(e, _TextboxUniformMotion_Time, _TextboxUniformMotion_V0);
        }
        /// <summary>
        /// Вывести сообщение об ошибки 
        /// если в texbox ничего не записано 
        /// или выделить кнопку добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxUniformMotion_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorTextLast(e, button1, _TextboxUniformMotion_Time);
        }
        /// <summary>
        ///  Вывести сообщение об ошибке
        /// если в textbox ничего не записанно
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxAcellerationMotion_X0_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorText(e, _TextboxAcellerationMotion_V0, _TextboxAcellerationMotion_X0);
        }
        /// <summary>
        /// Вывести сообщение об ошибке
        /// если в textbox ничего не записанно 
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxAcellerationMotion_V0_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorText(e, _TextboxAcellerationMotion_AX0, _TextboxAcellerationMotion_V0);
        }
        /// <summary>
        /// Вывести сообщение об ошибке
        /// если в textbox ничего не записанно
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxAcellerationMotion_AX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorText(e, _TextboxAcellerationMotion_Time, _TextboxAcellerationMotion_AX0);
        }
        /// <summary>
        /// Вывести сообщение об ошибки 
        /// если в texbox ничего не записано 
        /// или выделить кнопку добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxAcellerationMotion_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorTextLast(e, button1, _TextboxAcellerationMotion_Time);
        }
        /// <summary>
        /// Вывести сообщение об ошибке
        /// если в textbox ничего не записанно
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxOscillatoryMotion_X0_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorText(e, _TextboxOscillatoryMotion_W0, _TextboxOscillatoryMotion_X0);
        }
        /// <summary>
        /// Вывести сообщение об ошибке
        /// если в textbox ничего не записанно
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxOscillatoryMotion_W0_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorText(e, _TextboxOscillatoryMotion_F0, _TextboxOscillatoryMotion_W0);
        }
        /// <summary>
        /// Вывести сообщение об ошибке
        /// если в textbox ничего не записанно
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxOscillatoryMotion_F0_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorText(e, _TextboxOscillatoryMotion_VX0, _TextboxOscillatoryMotion_F0);
        }
        /// <summary>
        /// Вывести сообщение об ошибке
        /// если в textbox ничего не записанно
        /// или выделяет другой textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxOscillatoryMotion_VX0_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorText(e, _TextboxOscillatoryMotion_Time, _TextboxOscillatoryMotion_VX0);
        }
        /// <summary>
        /// Вывести сообщение об ошибки 
        /// если в texbox ничего не записано 
        /// или выделить кнопку добавить
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _TextboxOscillatoryMotion_Time_KeyPress(object sender, KeyPressEventArgs e)
        {
            _ErrorTextLast(e, button1, _TextboxOscillatoryMotion_Time);
        }
    }
}