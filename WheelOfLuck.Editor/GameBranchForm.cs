using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model;
using DrawGame.Editor.Properties;

namespace DrawGame.Editor
{
    public partial class GameBranchForm : DevExpress.XtraEditors.XtraForm
    {

        private List<Branch> _branchesNameList;

        private GameRepository _gameRepository;
        public GameBranchForm()
        {
            InitializeComponent();
            _gameRepository=new GameRepository(Settings.Default.ConnectionString);
            _branchesNameList=new List<Branch>();
        }

        public int GameId { get; set; }

        public List<Branch> BranchDatasource
        {
            get { return (List<Branch>)this.branchBindingSource.DataSource; }
            set
            {
                this.branchBindingSource.DataSource = value;
                
                foreach (var branch in value)
                {
                    _branchesNameList.Add(branch);
                }
                RemoveBranch();
                branchGridView.RefreshData();
            }
        }

        public List<BranchGame> BranchGameDatasource
        {
            get { return (List<BranchGame>)this.branchGameBindingSource.DataSource; }
            set { this.branchGameBindingSource.DataSource = value; }
        }

        public void RemoveBranch()
        {
            foreach (var branchGame in BranchGameDatasource.Where(branchGame => BranchDatasource.Exists(x => x.BranchCode == branchGame.BranchCode)))
            {
                BranchDatasource.Remove(BranchDatasource.Find(x => x.BranchCode == branchGame.BranchCode));
            }
        }

        private void RightArrowSimpleButton_Click(object sender, EventArgs e)
        {
            var branch= branchGridView.GetFocusedRow() as Branch;
            if(branch==null)return;
            BranchGameDatasource.Add(new BranchGame(){BranchCode = branch.BranchCode,GameId = GameId});
            
            branchGameGridView.RefreshData();
            branchGridView.DeleteRow(branchGridView.FocusedRowHandle);
            

        }

        private void LeftArrowSimpleButton_Click(object sender, EventArgs e)
        {
            var branchGame = branchGameGridView.GetFocusedRow() as BranchGame;
            if (branchGame == null) return;

            branchGameGridView.DeleteRow(branchGameGridView.FocusedRowHandle);

            BranchDatasource.Add(new Branch() { BranchCode = branchGame.BranchCode, BranchName = (_branchesNameList.Find(x => x.BranchCode == branchGame.BranchCode)).BranchName });
            branchGridView.RefreshData();
            


        }

        private void SaveBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var oldBranchGames = _gameRepository.GetBranchGames(GameId);

            foreach (var oldBranchGame in oldBranchGames.Where(oldBranchGame => !BranchGameDatasource.Exists(x=>x==oldBranchGame)))
            {
                _gameRepository.DeleteBranchGame(oldBranchGame);
            }

            foreach (var branchGame in BranchGameDatasource.Where(branchGame => !oldBranchGames.Exists(x => x == branchGame)))
            {
                _gameRepository.InsertBranchGame(branchGame);
            }

            _gameRepository.UpdateWizGameBranchRights(GameId, BranchGameDatasource.Count == 0);
        }

        private void ExitBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }

    }
}