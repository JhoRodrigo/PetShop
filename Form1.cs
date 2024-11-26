using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PetShop
{
    public partial class frmHome : Form
    {
        Thread navegacao;
        public frmHome()
        {
            InitializeComponent();
        }

        private void meusFavoritosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //fechando a primeira tela
            navegacao = new Thread(abrirFavoritos);
            navegacao.SetApartmentState(ApartmentState.STA);
            navegacao.Start();
        }

        private void buscarRaçaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close(); //fechando a primeira tela
            navegacao = new Thread(abrirBuscar);
            navegacao.SetApartmentState(ApartmentState.STA);
            navegacao.Start();
               
        }

        private void abrirBuscar()
        {
            Application.Run(new frmBuscar());
        }
        private void abrirFavoritos()
        {
            Application.Run(new frmFavoritos());
        }
    }
}
