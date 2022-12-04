using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Signal
{
    public partial class Form1 : Form
    {
        public Form1() //생성자함수 프로그램 실행시키자마자 실행
        {
            InitializeComponent();
            Thread thread = new Thread(SignalTower);
            thread.Start();
        }


        void SignalTower()
        {
            int D100 = 0;

            while (true)
            {
                switch (D100)
                {
                    case 0:
                        LampRed.BackColor = Color.Red;
                        LampYellow.BackColor = SystemColors.Control;
                        LampGreen.BackColor = SystemColors.Control;
                        Thread.Sleep(1000);
                        D100 = 100;
                        break;


                    case 100:
                        LampRed.BackColor = SystemColors.Control;
                        LampYellow.BackColor = Color.Yellow;
                        LampGreen.BackColor = SystemColors.Control;
                        Thread.Sleep(1000);
                        D100 = 200;
                        break;


                    case 200:
                        LampRed.BackColor = SystemColors.Control;
                        LampYellow.BackColor = SystemColors.Control;
                        LampGreen.BackColor = Color.Green;
                        Thread.Sleep(1000);
                        D100 = 0;
                        break;

                    default:
                        D100 = 0;
                        break;
                }
            }
        }
    }
}