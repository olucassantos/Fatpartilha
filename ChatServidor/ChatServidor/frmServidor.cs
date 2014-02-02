using System.Windows.Forms;
using System.Net;
using System;

namespace ChatServidor
{
    public partial class Form1 : Form
    {
        private delegate void AtualizaStatusCallback(string strMensagem);

        public Form1()
        {
            InitializeComponent();
        }

        public void btnAtender_Click(object sender, System.EventArgs e)
        {
            if (txtIP.Text==string.Empty)
            {
                MessageBox.Show("Informe o endereço IP.");
                txtIP.Focus();
                return;
            }

            try
            {
                // Analisa o endereço IP do servidor informado no textbox
                IPAddress enderecoIP = IPAddress.Parse(txtIP.Text);

                // Cria uma nova instância do objeto ChatServidor
                ChatServidor mainServidor = new ChatServidor(enderecoIP);

                // Vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
                ChatServidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

                // Inicia o atendimento das conexões
                mainServidor.IniciaAtendimento();

                // Mostra que nos iniciamos o atendimento para conexões
                txtLog.AppendText("Monitorando as conexões...\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro de conexão : " + ex.Message);
            }
        }

        public void mainServidor_StatusChanged(object sender, StatusChangedEventArgs e)
        {
            // Chama o método que atualiza o formulário
            this.Invoke(new AtualizaStatusCallback(this.AtualizaStatus), new object[] { e.EventMessage });
        }

        private void AtualizaStatus(string strMensagem)
        {
            // Atualiza o log com mensagens
            txtLog.AppendText(strMensagem + "\r\n");
        }

        public void attUsuarios_Click(object sender, EventArgs e)
        {
            // Analisa o endereço IP do servidor informado no textbox
            IPAddress enderecoIP = IPAddress.Parse(txtIP.Text);

            // Cria uma nova instância do objeto ChatServidor
            ChatServidor mainServidor = new ChatServidor(enderecoIP);

            // Vincula o tratamento de evento StatusChanged a mainServer_StatusChanged
            ChatServidor.StatusChanged += new StatusChangedEventHandler(mainServidor_StatusChanged);

            String[] userlist = new String[50];

            int i = 0;
            foreach (string name in mainServidor.usersList())
            {
                userlist[i] = name;
                txtLog.Text += userlist[i];
                i++;
            }
            
        }

        private void send_Click(object sender, EventArgs e)
        {
            if (mstMessage.Text != string.Empty)
            {
                ChatServidor.EnviaMensagemAdmin(mstMessage.Text);
                mstMessage.Clear();
            }
        }
    }
}
