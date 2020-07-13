using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();

            string strVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
        }
    }
}