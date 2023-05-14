//Задание 3
//Представьте, что у вас на форме есть прямоугольник, границы которого на 10 пикселей отстоят от границ рабочей области формы.
//Необходимо создать следующие обработчики: 
//■ Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка:
//внутри прямоугольника, снаружи, на границе прямоугольника.
//Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться;
//■ Обработчик нажатия правой кнопки мыши, который выводит в заголовок окна информацию о размере клиентской
//(рабочей) области окна в виде: Ширина = x, Высота = y, где x и y – соответствующие параметры вышего окна;
//■ Обработчик перемещения указателя мыши в пределах рабочей области, который должен выводить в заголовок окна
//текущие координаты мыши x и y

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Yahooo!";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Location = new Point(100, 100);
            this.Width = 500;
            this.Height = 500;
            
        }
        int rect_with = 490;
        int rect_heigh = 490;
        bool temp = false;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Form frm = (Form)sender;
            frm.Text = String.Format($" x = {e.X}, y = {e.Y}, Button = {e.Button}");
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && temp==true) //Если при нажатии левой кнопки мыши была нажата кнопка Control (Ctrl), то приложение должно закрываться;
                Application.Exit();
            if (e.Button == MouseButtons.Left)   // Обработчик нажатия левой кнопки мыши, который выводит сообщение о том, где находится текущая точка:
                                                //внутри прямоугольника, снаружи, на границе прямоугольника.
            {
                if (e.X<rect_with && e.X>10 && e.Y<rect_heigh && e.Y > 10)
                    this.Text = String.Format($" x = {e.X}, y = {e.Y}, Button = {e.Button}, The mouse is inside the rectangle");
                else if (e.X == rect_with || e.X == 10 || e.Y == rect_heigh || e.Y == 10)
                    this.Text = String.Format($" x = {e.X}, y = {e.Y}, Button = {e.Button}, The mouse is on the rectangle border");
                else
                    this.Text = String.Format($" x = {e.X}, y = {e.Y}, Button = {e.Button}, The mouse is outside of the rectangle");
            }
            else if (e.Button==MouseButtons.Right)
                this.Text = String.Format($" x = {e.X}, y = {e.Y}, Button = {e.Button}, Form with: {this.Width}, height: {this.Height}");
            Thread.Sleep(1000);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Control)
                temp = true;
        }
    }
}
