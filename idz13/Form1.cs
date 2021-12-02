using System.Windows.Forms;

namespace idz13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            for (int i = 1; i <= 10; i++)
            {
                label1.Text += i + " " + method(i) + "\n";
            }
        }
        public int method(int x)
        {
            if(x %2 == 0)
            {
                x = -x;
            }
            return x;
        }
    }
}
