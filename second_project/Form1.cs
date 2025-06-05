namespace second_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void inpLogo_Click(object sender, EventArgs e)
        {

        }

        private void inpCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            inpCalendar.Text = e.Start.ToShortDateString();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            uploadImage(inpLogo);
        }

        private void uploadImage(PictureBox image)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Selecione uma imagem";
                openFileDialog.Filter = "Arquivos de imagens|*.jpg;*jpeg;*.png;*.bmp;*.gif";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        Image img = Image.FromFile(openFileDialog.FileName);
                        image.Image = img;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao carregar imagem: ", ex.Message);
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Tem certeza que deseja cancelar?", "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
