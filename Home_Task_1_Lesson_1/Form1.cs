//Задание 1
//Вывести на экран свое (краткое!!!) резюме с помощью последовательности MessageBox’ов (числом не менее трех). Причем на заголовке 
//последнего должно отобразиться среднее число символов на странице (общее количество символов в резюме / количество MessageBox’ов). 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_Task_1_Lesson_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string message = "Name: Oleksandr\nSurname: Stepanichenko\nDuties: engineer";
            int symbols_quant= message.Length;
            MessageBox.Show(message, "Resume page 1");
            message = "Live region: Odessa\nLive country: Ukraine\nCitizenship: Ukrainian";
            symbols_quant += message.Length;
            MessageBox.Show(message, "Resume page 2");
            message = "Marital status: Married\nWork experiance: 22 years";
            symbols_quant += message.Length;
            MessageBox.Show(message, $"Resume page 3, aver sybols quant per page: {symbols_quant / 3}     ");
        }
    }
}
