namespace QuadroLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmd_entrar.Enabled = false;
        }

        private void text_textChanged(object sender, EventArgs e)
        {
            cmd_entrar.Enabled = text_usuario.Text != "" && text_senha.Text != "" ? true : false; 
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                text_senha.Focus();
                e.Handled= true;    
                e.SuppressKeyPress= true;
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmd_entrar_Click(this, EventArgs.Empty);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmd_entrar_Click(object sender, EventArgs e)
        {
            if (!cmd_entrar.Enabled) return;
            MessageBox.Show("Entrou minha peda");
        }
    }
} 