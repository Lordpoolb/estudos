using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prova
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtmatematica1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int M1, M2, M3, M4,MM;

            M1 = Convert.ToInt32(txtM1.Text);
            M2 = Convert.ToInt32(txtM2.Text);
            M3 = Convert.ToInt32(txtM3.Text);
            M4 = Convert.ToInt32(txtM4.Text);          
            MM=( M1+ M2 + M3 + M4)/4;
            txtMM.Text = MM.ToString();

            int P1, P2, P3, P4, PM;
            P1 = Convert.ToInt32(txtP1.Text);
            P2 = Convert.ToInt32(txtP2.Text);
            P3 = Convert.ToInt32(txtP3.Text);
            P4 = Convert.ToInt32(txtP4.Text);
            PM = (P1 + P2 + P3 + P4) / 4;
            txtPM.Text = PM.ToString();

            int B1, B2, B3, B4, BM;
            B1 = Convert.ToInt32(txtB1.Text);
            B2 = Convert.ToInt32(txtB2.Text);
            B3 = Convert.ToInt32(txtB3.Text);
            B4 = Convert.ToInt32(txtB4.Text);
            BM = (B1 + B2 + B3 + B4) / 4;
            txtBM.Text = BM.ToString();

            int Q1, Q2, Q3, Q4, QM;
            Q1 = Convert.ToInt32(txtQ1.Text);
            Q2 = Convert.ToInt32(txtQ2.Text);
            Q3 = Convert.ToInt32(txtQ3.Text);
            Q4 = Convert.ToInt32(txtQ4.Text);
            QM = (Q1 + Q2 + Q3 + Q4) / 4;
            txtQM.Text = QM.ToString();


            int G1, G2, G3, G4, GM;
            G1 = Convert.ToInt32(txtG1.Text);
            G2 = Convert.ToInt32(txtG2.Text);
            G3 = Convert.ToInt32(txtG3.Text);
            G4 = Convert.ToInt32(txtG4.Text);
            GM = (G1 + G2 + G3 + G4) / 4;
            txtGM.Text = GM.ToString();

            int N1, N2, N3, N4, NG;
            N1 = (M1 + P1 + B1 + Q1 + G1) / 5;
            N2 = (M2 + P2 + B2 + Q2 + G2) / 5;
            N3 = (M3 + P3 + B3 + Q3 + G3) / 5;
            N4 = (M4 + P4 + B4 + Q4 + G4) / 5;
            NG = (MM + PM + BM + QM + GM) / 5;
            txtN1.Text = N1.ToString();
            txtN2.Text = N2.ToString();
            txtN3.Text = N3.ToString();
            txtN4.Text = N4.ToString();
            txtNG.Text = NG.ToString();


            int FM, FP, FB, FQ, FG,FT;
            FM = Convert.ToInt32(txtFM.Text);
            FP = Convert.ToInt32(txtFP.Text);
            FB = Convert.ToInt32(txtFB.Text);
            FQ = Convert.ToInt32(txtFQ.Text);
            FG = Convert.ToInt32(txtFG.Text);
            FT = (FM + FP + FB + FQ + FG);
            txtFT.Text = FT.ToString();

            int NMM, NMenorM;
            if (MM > PM && MM > BM && MM >QM && MM>GM )
            {
                NMM = MM;
                txtNMM.Text = NMM.ToString("Matématica");
            }
            else if (PM > MM && PM > BM && PM > QM && PM > GM)
            {
                NMM = PM;
                txtNMM.Text = NMM.ToString("Português");

            }
            else if (QM > MM && QM > PM && QM > BM && QM > GM)
            {
                NMM = BM;
                txtNMM.Text = NMM.ToString("Química");
            }
            else if (BM > MM && BM > PM && BM > QM && PM > GM)
            {
                NMM = BM;
                txtNMM.Text = NMM.ToString("Biologia");
            }
            else
            {
                NMM = GM;
                txtNMM.Text = NMM.ToString("Geografia");
            }


            if (MM < PM && MM < BM && MM < QM && MM < GM)
            {
                NMenorM = MM;
                txtNMenorM.Text = NMenorM.ToString("Matématica");
            }
            else if (PM < MM && PM < BM && PM < QM && PM < GM)
            {
                NMenorM = PM;
                txtNMenorM.Text = NMenorM.ToString("Português");

            }
            else if (QM < MM && QM < PM && QM < BM && QM < GM)
            {
                NMenorM = BM;
                txtNMenorM.Text = NMenorM.ToString("Química");
            }
            else if (BM < MM && BM < PM && BM < QM && PM < GM)
            {
                NMenorM = BM;
                txtNMenorM.Text = NMenorM.ToString("Biologia");
            }
            else
            {
                NMenorM = GM;
                txtNMenorM.Text = NMenorM.ToString("Geografia");
            }

        }
    }
    }

