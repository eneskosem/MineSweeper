using System;
using System.Drawing;
using System.Windows.Forms;

namespace MayinTarlasiWinForms
{
    public partial class Form1 : Form
    {
        int rows;
        int cols;
        int mineCount;
        Button[,] buttons;
        bool[,] mines;
        int flagCount = 0;

        public Form1()
        {
            InitializeComponent();

            // NumericUpDown ayarları
            numericUpDownRows.Minimum = 5;
            numericUpDownRows.Maximum = 24;
            numericUpDownRows.Value = 8;

            numericUpDownCols.Minimum = 5;
            numericUpDownCols.Maximum = 24;
            numericUpDownCols.Value = 8;

            buttonStart.Click += ButtonStart_Click;
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            rows = (int)numericUpDownRows.Value;
            cols = (int)numericUpDownCols.Value;
            mineCount = (rows * cols) / 6; // Toplam hücrenin yaklaşık 1/6'sı mayın

            StartGame();
        }

        private void StartGame()
        {
            flagCount = 0;
            labelFlagCount.Text = "Bayrak: 0";

            // Panel içini temizle (varsa önceki butonları kaldır)
            panel.Controls.Clear();

            buttons = new Button[rows, cols];
            mines = new bool[rows, cols];

            Random rnd = new Random();
            int placed = 0;

            // Mayınları rastgele yerleştir
            while (placed < mineCount)
            {
                int r = rnd.Next(rows);
                int c = rnd.Next(cols);
                if (!mines[r, c])
                {
                    mines[r, c] = true;
                    placed++;
                }
            }

            // Panel boyutunu güncelle
            panel.Size = new Size(cols * 40, rows * 40);

            // Butonları oluştur ve panele ekle
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Button btn = new Button
                    {
                        Size = new Size(40, 40),
                        Location = new Point(j * 40, i * 40),
                        Tag = new Point(i, j)
                    };
                    btn.MouseDown += Cell_MouseDown;
                    buttons[i, j] = btn;
                    panel.Controls.Add(btn);
                }
            }

            // Formun boyutunu panel ve diğer kontrolleri kapsayacak şekilde ayarla
            this.ClientSize = new Size(panel.Right + 20, panel.Bottom + 20 + buttonStart.Height + numericUpDownRows.Height);
        }

        private void Cell_MouseDown(object sender, MouseEventArgs e)
        {
            Button clickedButton = (Button)sender;
            Point point = (Point)clickedButton.Tag;
            int row = point.X;
            int col = point.Y;

            if (e.Button == MouseButtons.Right)
            {
                if (clickedButton.Text == "🚩")
                {
                    clickedButton.Text = "";
                    flagCount--;
                }
                else if (clickedButton.Enabled)
                {
                    clickedButton.Text = "🚩";
                    flagCount++;
                }

                labelFlagCount.Text = "Bayrak: " + flagCount;
            }
            else if (e.Button == MouseButtons.Left)
            {
                // Sol tıklama: Bayraklıysa açma
                if (clickedButton.Text == "🚩") return;

                if (mines[row, col])
                {
                    clickedButton.BackColor = Color.Red;
                    MessageBox.Show("💥 Mayına bastınız! Oyun bitti.");
                    Application.Exit();
                }
                else
                {
                    int count = CountMinesAround(row, col);
                    clickedButton.Text = count.ToString();
                    clickedButton.Enabled = false;
                }
            }
        }

        private int CountMinesAround(int row, int col)
        {
            int count = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = col - 1; j <= col + 1; j++)
                {
                    if (i >= 0 && i < rows && j >= 0 && j < cols && mines[i, j])
                        count++;
                }
            }
            return count;
        }
    }
}
