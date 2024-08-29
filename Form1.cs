namespace TrainDistanceCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //distance = speed X Time

            Single speed = 0, hoursTotal = 0, hourCount = 0;

            Single.TryParse(txtKmHour.Text, out speed);
            Single.TryParse(txtHours.Text, out hoursTotal);



            while (hourCount < hoursTotal)
            {

                lbxOutput.Items.Add("After hour " + hourCount + " the distance is " + speed * hourCount);



                hourCount++;

            }

        }
    }
}
