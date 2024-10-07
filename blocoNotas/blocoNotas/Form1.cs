namespace blocoNotas
{
    public partial class Form1 : Form
    {
        string filename { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAbrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            var resultado = ofd.ShowDialog(this);
            filename = ofd.FileName;
            if (resultado == DialogResult.OK)
            {
                string text = File.ReadAllText(filename);
                textBox1.Text = text;
                label1.Text = filename;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            File.WriteAllText(filename, textBox1.Text);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
