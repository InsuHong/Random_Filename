namespace Random_Filename
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_ext.SelectedIndex = 0;
            textBox_filename.Text = Make_Number();
        }

        public string Make_Number()
        {
            var timeSpan = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            long timeSpan2 = (long) timeSpan.TotalSeconds;
            return (string) timeSpan2.ToString() + "." + comboBox_ext.SelectedItem.ToString();

        }

        private void button_make_Click(object sender, EventArgs e)
        {
            textBox_filename.Text = Make_Number();
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            try
            {
               if(textBox_filename.Text != "") Clipboard.SetText(textBox_filename.Text);
            }
            catch { }

        }
    }
}
