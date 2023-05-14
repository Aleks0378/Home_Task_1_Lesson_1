//Задание 2
//Написать функцию, которая «угадывает» задуманное пользователем число от 1 до 2000. Для запроса к пользователю использовать 
//MessageBox. После того, как число отгадано, необходимо вывести количество запросов, потребовавшихся для этого, и предоставить 
//пользователю возможность сыграть еще раз, не выходя из программы (MessageBox’ы оформляются кнопками и значками соответственно ситуации).

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace Task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Pictionary();
        }

        public void Pictionary()
        {
            MessageBox.Show("Загадайте число от 1 до 2000", "Игра Угадайка");
            int min = 1, max = 2000;
            int num;
            for (int i = 1; ; i++)
            {
                num = (max + min) / 2;
                DialogResult result = MessageBox.Show($"Ваше число: {num}?", "Угадайка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Число угадано\nВаше число: {num}\nКолличество попыток: {i}", "Угадайка");
                    break;
                }
                else
                {
                    result = MessageBox.Show($"Ваше число больше {num}?", "Угадайка", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                        min = num + 1;
                    else
                        max = num - 1;
                }
            }
        }
    }
}
