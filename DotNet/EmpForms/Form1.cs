using EmpLib;

namespace EmpForms
{
    public partial class Form1 : Form
    {
        Employee Kpmgemp = new Employee();
        Employee Mfemp = new Employee();
        public Form1()
        {
            InitializeComponent();
            button1.Click += button1_Click2;
            button1.Click += button1_Click3;


            Kpmgemp.Join += SriKar_join;
            Kpmgemp.Join += Praj_join;
            Kpmgemp.Join += Poovi_join;

            Mfemp.Resign += Poovi_resign;
            

        }

        private void Poovi_resign(object? sender, EventArgs e)
        {
            MessageBox.Show("poovi reign joined mf");
        }

        private void Poovi_join(object? sender, EventArgs e)
        {
            MessageBox.Show("poovi has  joined");
        }

        private void Praj_join(object? sender, EventArgs e)
        {
            MessageBox.Show("praj has  joined");
        }

        private void SriKar_join(object? sender, EventArgs e)
        {
            MessageBox.Show("srikar join" + ((Employee)sender).Aadhar);
        }

        private void button1_Click3(object? sender, EventArgs e)
        {
            MessageBox.Show("you clicked 3the button");
        }

        private void button1_Click2(object? sender, EventArgs e)
        {
            MessageBox.Show("you clicked 2 he button");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("you clicked  the button");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //SriKar_join(new Employee("5342543", "836"), null);
            //Praj_join(null, null);
            //Poovi_join(null, null);
            Kpmgemp.TriggerJoinEvent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Mfemp.TriggerResignEvent();
        }
    }
}