using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatchMe
{
    public partial class CatchTheButton : Form
    {
        public CatchTheButton()
        {
            InitializeComponent();
        }

        private void buttonCatch_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            var maxWidth = this.ClientSize.Width - this.buttonCatch.ClientSize.Width;
            var maxHeight = this.ClientSize.Height - this.buttonCatch.ClientSize.Height;
            this.buttonCatch.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));

        }

        private void buttonCatch_MouseClick(object sender, MouseEventArgs e)
        {
            string message = "You win!";
            string caption = "Congratulations";
            MessageBox.Show(message, caption);
        }
    }
}
