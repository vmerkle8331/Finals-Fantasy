using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MerkleFinalsFantasyPractice
{
    public class MerkleFinalsFantasyPractice
    {
        private GameScreen screen;
        private GameLogic logic;

        public void Run()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ApplicationConfiguration.Initialize();
            Application.Run(new GameScreen());
        }
    }
}