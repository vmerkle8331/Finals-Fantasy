using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerkleFinalsFantasyPractice
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            MerkleFinalsFantasyPractice game = new MerkleFinalsFantasyPractice();
            game.Run();        
        }
    }
}
