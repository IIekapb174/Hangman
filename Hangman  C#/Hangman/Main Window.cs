using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WMPLib;
using System.Media;

namespace Hangman
{
    public partial class main_window : Form
    {
     

        public main_window()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new_game g1 = new new_game();
            g1.Show();
            
            



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Эрика Репкова, Максим Кривоногов, Николай Гринько.",
                "Авторы",
                MessageBoxButtons.OK
                );

            
        }

        private void main_window_Load(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.kek);
            audio.PlayLooping();
        }

        private void label1_Click(object sender, EventArgs e)
        {
         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.kek);
            audio.Stop();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SoundPlayer audio = new SoundPlayer(Properties.Resources.kek);
            audio.PlayLooping();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Игроку загадывается слово, которое он должен угадать, используя буквы алфавита и возможность совершить ограниченное количество ошибок. Игроку дается 10 попыток.Слово показывается игроку в виде пустых ячеек на каждую букву слова. Игрок указывает на необходимую ему букву в поле алфавита, после чего, в случае присутствия данной буквы в загаданном слове, она отображается в соответствующей ячейке. Если в слове данная буква встречается несколько раз, то показываются все случаи присутствия этой буквы в слове. Если он отгадывает слово, он побеждает. ",
                "О игре",
                MessageBoxButtons.OK
                );
        }
    }
}
