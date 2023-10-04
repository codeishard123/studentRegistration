namespace StudentRegistration
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            string currentYear = DateTime.Now.Year.ToString();

            for (int i = 1900; i <= Convert.ToInt32(currentYear); i++)
            {
                yearBox.Items.Add(i);
            }

            for (int i = 1; i <= 31; i++)
            {
                dayBox.Items.Add(i);
            }

            for (int i = 1; i <= 12; i++)
            {
                monthBox.Items.Add(i);
            }

            Object selectedYear = yearBox.SelectedItem;
            Object selectedMonth = monthBox.SelectedItem;
            Object selectedDay = dayBox.SelectedItem;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {

            try
            {
                string firstname = firstName.Text;
                string lastname = lastName.Text;
                string middlename = middleName.Text;

                Object selectedYear = yearBox.SelectedItem;
                Object selectedMonth = monthBox.SelectedItem;
                Object selectedDay = dayBox.SelectedItem;

                string gender = " ";

                if (rbMale.Checked)
                {
                    gender = rbMale.Text;
                }
                else
                {
                    gender = rbFemale.Text;
                }



                MessageBox.Show("Student name: " + firstname + " " + middlename + " " + lastname + "\nGender: " + gender +
                    "\nDate of birth: " + selectedMonth + "/" + selectedDay + "/" + selectedYear);

            }
            catch (ArgumentNullException ane)
            {
                MessageBox.Show("Missing information");
            }
        }
    }
}