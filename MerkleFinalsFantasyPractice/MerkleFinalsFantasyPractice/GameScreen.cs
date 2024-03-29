using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerkleFinalsFantasyPractice
{
    public partial class GameScreen : Form
    {
        public event EventHandler TurnReady;

        public GameScreen()
        {
            InitializeComponent();
        }

    }
}
