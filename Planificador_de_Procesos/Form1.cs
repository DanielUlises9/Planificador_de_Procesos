using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planificador_de_Procesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        FCFS fcfs;


        private void btnFCFS_Click(object sender, EventArgs e)
        {
            
            txtTet.Text = "";
            txtRet.Text = "";
            fcfs.Normal();
            print();
        }

        private void btnSjfs_Click(object sender, EventArgs e)
        {
            
            txtTet.Text = "";
            txtRet.Text = "";
            fcfs.PosicionSJF();
            print();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {

            if (ValidacionQ())
            {

            }
            else
            {
                int num = Convert.ToInt32(txtProcess.Text);
                int max = Convert.ToInt32(txtMaxtime.Text);
                fcfs = new FCFS(num);
                fcfs.fill(max);
                txtShow.Text = fcfs.show();
            }
 
        }

        private void btnLjf_Click(object sender, EventArgs e)
        {
            
            txtTet.Text = "";
            txtRet.Text = "";
            fcfs.PosicionLJF();
            print();
        }

        private void btnRR_Click(object sender, EventArgs e)
        {
            if(veridicox2())
            {

            }
            else
            {
                fcfs.Normal();
                int quantum = Convert.ToInt32(txtQuatum.Text);
                txtTet.Text = Convert.ToString(fcfs.rrWT(quantum));
                txtRet.Text = Convert.ToString(fcfs.rrRt(quantum));
                txtTabla.Text = "No hay diagrama :c";
                lblCmax.Text = "Cmax: " + Convert.ToString(fcfs.Cmax());
            }
        }

        public void print()
        {
            txtTet.Text = Convert.ToString(fcfs.Waitedtime());
            txtRet.Text = Convert.ToString(fcfs.Responetime());
            txtTabla.Text = fcfs.P + "\r\n" + fcfs.WaitingTime;

            lblCmax.Text = "Cmax: " + Convert.ToString(fcfs.Cmax());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool ValidacionQ()
        {
            bool veridico = false;
            if (txtProcess.Text == "")
            {
                veridico = true;
                MessageBox.Show("No a ingresado el numero de procesos");
            }
            if (txtMaxtime.Text == "")
            {
                veridico = true;
                MessageBox.Show("No a ingresado el tiempo maximo");
            }
            return veridico;
        }

        public bool veridicox2()
        {
            bool veridico = false;
            if (txtQuatum.Text == "")
            {
                veridico = true;
                MessageBox.Show("No a iingresado el valor de Quantum");
            }
            return veridico;
        }
    }
}
