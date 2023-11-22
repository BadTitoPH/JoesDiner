using System.Windows.Forms;

namespace JoesDiner
{
    public partial class Form1 : Form
    {
        double[] itemcost = new double[32];
        double iTax, iSubTotal, iTotal;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            timer1.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableTextBox();

            timer1.Start();
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm if you want to exit", "Order Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //===================RESETTEXTBOX=================
        private void ResetTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //==============================================

        //================ENABLETEXTBOX=================
        private void EnableTextBox()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;
                    else
                        func(control.Controls);
            };
            func(Controls);
        }
        //==============================================
        private void resetbtn_Click(object sender, EventArgs e)
        {
            ResetTextBox();
            EnableTextBox();

            lblSubTotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";
            richTextBox1.Clear();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox1.Enabled = true;
                textBox1.Text = "";
                textBox1.Focus();
            }

            if (checkBox1.Checked == false)
            {
                textBox1.Enabled = false;
                textBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox2.Enabled = true;
                textBox2.Text = "";
                textBox2.Focus();
            }

            if (checkBox2.Checked == false)
            {
                textBox2.Enabled = false;
                textBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                textBox3.Enabled = true;
                textBox3.Text = "";
                textBox3.Focus();
            }

            if (checkBox3.Checked == false)
            {
                textBox3.Enabled = false;
                textBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                textBox4.Enabled = true;
                textBox4.Text = "";
                textBox4.Focus();
            }

            if (checkBox4.Checked == false)
            {
                textBox4.Enabled = false;
                textBox4.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked == true)
            {
                textBox5.Enabled = true;
                textBox5.Text = "";
                textBox5.Focus();
            }

            if (checkBox5.Checked == false)
            {
                textBox5.Enabled = false;
                textBox5.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked == true)
            {
                textBox6.Enabled = true;
                textBox6.Text = "";
                textBox6.Focus();
            }

            if (checkBox6.Checked == false)
            {
                textBox6.Enabled = false;
                textBox6.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked == true)
            {
                textBox7.Enabled = true;
                textBox7.Text = "";
                textBox7.Focus();
            }

            if (checkBox7.Checked == false)
            {
                textBox7.Enabled = false;
                textBox7.Text = "0";
            }
        }

        private void NumbersOnly2(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void NumbersOnly(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Tax_Rate = 0.65;
            itemcost[0] = Convert.ToDouble(textBox1.Text) * 100;
            itemcost[1] = Convert.ToDouble(textBox2.Text) * 45;
            itemcost[2] = Convert.ToDouble(textBox3.Text) * 90;
            itemcost[3] = Convert.ToDouble(textBox4.Text) * 450;
            itemcost[4] = Convert.ToDouble(textBox5.Text) * 85;
            itemcost[5] = Convert.ToDouble(textBox6.Text) * 75;
            itemcost[6] = Convert.ToDouble(textBox7.Text) * 150;

            itemcost[7] = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6];

            iSubTotal = itemcost[7];

            lblSubTotal.Text = Convert.ToString(iSubTotal);
            iTax = (iSubTotal * Tax_Rate) / 100;
            lblTax.Text = Convert.ToString(iTax);
            iTotal = (iSubTotal * iTax);
            lblTotal.Text = Convert.ToString(iTotal);


            richTextBox1.AppendText("\t" + "  HIGH RESTO" + Environment.NewLine);
            richTextBox1.AppendText("\t" + "04 - 20 High Street" + Environment.NewLine);
            richTextBox1.AppendText("\t" + "  Angeles City" + Environment.NewLine);
            richTextBox1.AppendText("\t" + "  Pampanga, 2009" + Environment.NewLine);
            richTextBox1.AppendText("==============================" + Environment.NewLine);
            richTextBox1.AppendText("Tax " + "\t\t" + lblTax.Text + Environment.NewLine);
            richTextBox1.AppendText("SubTotal " + "\t" + lblSubTotal.Text + Environment.NewLine);
            richTextBox1.AppendText("Total " + "\t\t" + lblTotal.Text + Environment.NewLine);
            richTextBox1.AppendText("==============================" + Environment.NewLine);
            richTextBox1.AppendText("Thank you for eating at HIGH RESTO");

        }
    }
}