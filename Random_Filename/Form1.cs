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
            
            string ret_text = (string)timeSpan2.ToString() + "." + comboBox_ext.SelectedItem.ToString();

            try
            {
                if (ret_text != "") Clipboard.SetText(ret_text);
            }
            catch { }

            return ret_text;

        }

        private void button_make_Click(object sender, EventArgs e)
        {
            textBox_filename.Text = Make_Number();
        }

    }
}
