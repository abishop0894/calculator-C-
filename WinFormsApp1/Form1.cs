namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("the sum of " + textBox1.Text + " and " + textBox2.Text + " is " + (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)));
            }
            catch (Exception ex)

            {
                MessageBox.Show("you must enter a number");
            }
            finally
            {

            }

            }



        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("the remainder of " + textBox1.Text + " and " + textBox2.Text + " is " + (Convert.ToDouble(textBox1.Text) % Convert.ToDouble(textBox2.Text)));
            }
            catch (Exception ex)

            {
                MessageBox.Show("you must enter a number");
            }
            finally
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(textBox1.Text + " minus " + textBox2.Text + " is " + (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)));
            }
            catch (Exception ex)

            {
                MessageBox.Show("you must enter a number");
            }
            finally
            {

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show( textBox1.Text + " divided by " + textBox2.Text + " is " + (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)));
            }
            catch (Exception ex)

            {
                MessageBox.Show("you must enter a number");
            }
            finally
            {

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(textBox1.Text + " multiplied by " + textBox2.Text + " is " + (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)));
            }
            catch (Exception ex)

            {
                MessageBox.Show("you must enter a number");
            }
            finally
            {

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}