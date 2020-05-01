using OpenSente.UserControls;
using OSKernel;
using OSKernel.Competation;
using OSKernel.Competation.League;
using OSKernel.Game;
using OSKernel.GoPlayer;
using OSKernel.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenSente
{
    public partial class MainForm : Form
    {
        #region Ctor

        public MainForm()
        {
            InitializeComponent();
            PrepareUI();

            _CD = Deserialize();

            Rec2Form();
            SubscribeToEvents();
        }

        #endregion

        #region Private Fields

        private CompetitionDocument _CD;
        private bool _IsHeaderClicked;
        private Point _Location;
        private string _TournamentFilePath;
        private List<UserControl> _UndoStack;

        #endregion

        #region Private Methods

        private void Serialize()
        {
            string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);

            try
            {
                using (FileStream fsWrite = new FileStream(Path + "\\OpenSente.dat", FileMode.Create))
                {
                    BinaryFormatter bfWrite = new BinaryFormatter();
                    bfWrite.Serialize(fsWrite, _CD);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }

        private CompetitionDocument Deserialize()
        {
            string Path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
 
            try
            {
                CompetitionDocument result;
                using (FileStream fsRead = new FileStream(Path + "\\OpenSente.dat", FileMode.Open))
                {
                    BinaryFormatter bfRead = new BinaryFormatter();
                    result = (CompetitionDocument)bfRead.Deserialize(fsRead);
                }
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Error : " + ex.Message);
            }
        }
        
        private void SubscribeToEvents()
        {
            pbHome.Click += PbHome_Click;
            pbUndo.Click += PbUndo_Click;
            pbRedo.Click += PbRedo_Click;
            panelHeader.MouseDown += PanelHeader_MouseDown;
            panelHeader.MouseUp += PanelHeader_MouseUp;
            panelHeader.MouseMove += PanelHeader_MouseMove;
            hfBtnImportTournament.Click += HfBtnImportTournament_Click;
            hfBtnSelectTournament.Click += HfBtnSelectTournament_Click;
            hfBtnCheckPlayer.Click += HfBtnCheckPlayer_Click;
            hfBtnAbout.Click += HfBtnAbout_Click;
            pbClose.Click += PbClose_Click;
            pbMaximize.Click += PbMaximize_Click;
            pbMinimize.Click += PbMinimize_Click;
            this.SizeChanged += MainForm_SizeChanged;
        }

        private void UnsubscribeFromEvents()
        {
            pbHome.Click -= PbHome_Click;
            pbUndo.Click -= PbUndo_Click;
            pbRedo.Click -= PbRedo_Click;
            panelHeader.MouseDown -= PanelHeader_MouseDown;
            panelHeader.MouseUp -= PanelHeader_MouseUp;
            panelHeader.MouseMove -= PanelHeader_MouseMove;
            hfBtnImportTournament.Click -= HfBtnImportTournament_Click;
            hfBtnSelectTournament.Click -= HfBtnSelectTournament_Click;
            hfBtnCheckPlayer.Click -= HfBtnCheckPlayer_Click;
            hfBtnAbout.Click -= HfBtnAbout_Click;
            pbClose.Click -= PbClose_Click;
            pbMaximize.Click -= PbMaximize_Click;
            pbMinimize.Click -= PbMinimize_Click;
            this.SizeChanged -= MainForm_SizeChanged;
        }

        private void PrepareUI()
        {
            _UndoStack = new List<UserControl>();
            pbUndo.Visible = false;
            pbRedo.Visible = false;
        }

        private void Rec2Form()
        {

        }

        private List<AGoCompetition> GenerateDefaultTournaments()
        {
            List<AGoCompetition> competitions = new List<AGoCompetition>();
            GoLeague TGODHandicap = new GoLeague();
            TGODHandicap.Name = "Türkiye Online Avanslı Go Ligi";
            TGODHandicap.Type = eGoCompetitionType.League;
            TGODHandicap.Players = TGODGoLeagueHelper.GetLeaguePlayersFromPath("AvansliOyuncular.txt");
            TGODHandicap.Games = new List<GoGame>();
            TGODHandicap.Games.AddRange(TGODGoLeagueHelper.GetHandicapGroupAGames(TGODHandicap));
            TGODHandicap.Games.AddRange(TGODGoLeagueHelper.GetHandicapGroupBGames(TGODHandicap));
            competitions.Add(TGODHandicap);


            GoLeague TGODNoHandicap = new GoLeague();
            TGODNoHandicap.Name = "Türkiye Online Avanssız Go Ligi";
            TGODNoHandicap.Type = eGoCompetitionType.League;
            TGODNoHandicap.Players = TGODGoLeagueHelper.GetLeaguePlayersFromPath("AvanssizOyuncular.txt");
            TGODNoHandicap.Games = new List<GoGame>();
            TGODNoHandicap.Games.AddRange(TGODGoLeagueHelper.GetNoHandicapGroupAGames(TGODNoHandicap));
            TGODNoHandicap.Games.AddRange(TGODGoLeagueHelper.GetNoHandicapGroupBGames(TGODNoHandicap));
            competitions.Add(TGODNoHandicap);

            return competitions;
        }

        #endregion

        #region Resize

        protected override void WndProc(ref Message m)
        {
            const int RESIZE_HANDLE_SIZE = 10;

            switch (m.Msg)
            {
                case 0x0084/*NCHITTEST*/ :
                    base.WndProc(ref m);

                    if ((int)m.Result == 0x01/*HTCLIENT*/)
                    {
                        Point screenPoint = new Point(m.LParam.ToInt32());
                        Point clientPoint = this.PointToClient(screenPoint);
                        if (clientPoint.Y <= RESIZE_HANDLE_SIZE)
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)13/*HTTOPLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)12/*HTTOP*/ ;
                            else
                                m.Result = (IntPtr)14/*HTTOPRIGHT*/ ;
                        }
                        else if (clientPoint.Y <= (Size.Height - RESIZE_HANDLE_SIZE))
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)10/*HTLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)2/*HTCAPTION*/ ;
                            else
                                m.Result = (IntPtr)11/*HTRIGHT*/ ;
                        }
                        else
                        {
                            if (clientPoint.X <= RESIZE_HANDLE_SIZE)
                                m.Result = (IntPtr)16/*HTBOTTOMLEFT*/ ;
                            else if (clientPoint.X < (Size.Width - RESIZE_HANDLE_SIZE))
                                m.Result = (IntPtr)15/*HTBOTTOM*/ ;
                            else
                                m.Result = (IntPtr)17/*HTBOTTOMRIGHT*/ ;
                        }
                    }
                    return;
            }
            base.WndProc(ref m);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.Style |= 0x20000; // <--- use 0x20000
                return cp;
            }
        }

        #endregion

        #region Events

        private void PbHome_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _UndoStack.Count(); i++)
            {
                panelMain.Controls.Remove(_UndoStack[i]);
                _UndoStack[i].SendToBack();

            }
        }

        private void HfBtnCheckPlayer_Click(object sender, EventArgs e)
        {
            ucRequestPlayerFromEGD ucCheckPlayerEGD = new ucRequestPlayerFromEGD();

            ucCheckPlayerEGD.InitializeUC();
            ucCheckPlayerEGD.Dock = DockStyle.Fill;
            _UndoStack.Add(ucCheckPlayerEGD);
            panelMain.Controls.Add(ucCheckPlayerEGD);
            ucCheckPlayerEGD.BringToFront();
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            hfBtnSelectTournament.Location = new Point(this.Size.Width / 2 - 246,
                                                       this.Size.Height / 2 - 41 - 126);

            hfBtnImportTournament.Location = new Point(this.Size.Width / 2 + 6,
                                                       this.Size.Height / 2 - 41 - 126);

            hfBtnCheckPlayer.Location = new Point(this.Size.Width / 2 - 246,
                                                  this.Size.Height / 2 - 41 + 6);

            hfBtnAbout.Location = new Point(this.Size.Width / 2 + 6,
                                            this.Size.Height / 2 - 41 + 6);
        }

        private void PbMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PbMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void PbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (_IsHeaderClicked)
            {
                this.Location = new Point(this.Location.X + e.Location.X - _Location.X, this.Location.Y + e.Location.Y - _Location.Y);
            }
        }

        private void PanelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            _IsHeaderClicked = false;
        }

        private void PanelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            _IsHeaderClicked = true;
            _Location = e.Location;
        }

        private void PbUndo_Click(object sender, EventArgs e)
        {
            //if (_UndoStack.Count > 0)
            //{
            //    panelMain.Controls.Remove(_UndoStack.Last());
            //    _UndoStack.RemoveAt(_UndoStack.Count() - 1);

            //    if (_UndoStack.Count > 0)
            //    {
            //        _UndoStack.Last().BringToFront();
            //    }
            //}
            ////this.Close();
        }

        private void PbRedo_Click(object sender, EventArgs e)
        {

        }

        private void HfBtnAbout_Click(object sender, EventArgs e)
        {
            ucAbout ucAboutUs = new ucAbout();
            ucAboutUs.Dock = DockStyle.Fill;
            _UndoStack.Add(ucAboutUs);
            panelMain.Controls.Add(ucAboutUs);
            ucAboutUs.BringToFront();
        }

        private void HfBtnSelectTournament_Click(object sender, EventArgs e)
        {
            ucSelectTournament ucSTournament = new ucSelectTournament();

            ucSTournament.InitializeUC(_CD.Tournaments);
            ucSTournament.Dock = DockStyle.Fill;
            _UndoStack.Add(ucSTournament);
            panelMain.Controls.Add(ucSTournament);
            ucSTournament.BringToFront();
        }

        private void HfBtnImportTournament_Click(object sender, EventArgs e)
        {
            UnsubscribeFromEvents();
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _TournamentFilePath = ofd.FileName;
                List<Player> players = TGODGoLeagueHelper.GetLeaguePlayersFromPath(_TournamentFilePath);
                ucPlayerList ucPlayers = new ucPlayerList();
                ucPlayers.InitializeUC(players);
                ucPlayers.Dock = DockStyle.Fill;
                _UndoStack.Add(ucPlayers);
                panelMain.Controls.Add(ucPlayers);
                ucPlayers.BringToFront();
            }

            SubscribeToEvents();
        }

        #endregion
    }
}
