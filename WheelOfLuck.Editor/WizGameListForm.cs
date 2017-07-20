using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DrawGame.Domain.Game;
using DrawGame.Domain.Model.Game;
using DrawGame.Editor.Properties;

namespace DrawGame.Editor
{
    public partial class WizGameListForm : Form
    {


        private GameRepository _repository;

        public WizGameListForm()
        {
            InitializeComponent();
            _repository = new GameRepository(Settings.Default.ConnectionString);
            Datasource = _repository.GetAllWizDrawGameInfo();

        }



        public List<WizDrawGameInfo> Datasource
        {
            get { return (List<WizDrawGameInfo>)this.wizDrawGameInfoBindingSource.DataSource; }
            set { this.wizDrawGameInfoBindingSource.DataSource = value; }
        }

        private void wizDrawGameInfoGridControl_DoubleClick(object sender, EventArgs e)
        {
            var info = this.gridView1.GetRow(gridView1.FocusedRowHandle) as WizDrawGameInfo;
            if (info == null) return;

            var frm = new GameEditForm();
            frm.Datasource = _repository.GetWizDrawGameById2(info.GameId);
            frm.RefreshEvent += frm_RefreshEvent;
            frm.Show();

        }

       

        private void NewBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var frm = new GameEditForm();
            frm.Datasource = new WizDrawGame();
            frm.RefreshEvent += frm_RefreshEvent;
            frm.Show();
        }

        void frm_RefreshEvent()
        {
            Datasource = _repository.GetAllWizDrawGameInfo();
        }

        private void DeleteBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var info = this.gridView1.GetRow(gridView1.FocusedRowHandle) as WizDrawGameInfo;
            if (info == null) return;
            _repository.DeleteWizDrawGame(info.GameId);
            Datasource = _repository.GetAllWizDrawGameInfo();
        }

        private void BranchBarButtonItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var info = this.gridView1.GetRow(gridView1.FocusedRowHandle) as WizDrawGameInfo;
            if(info==null)return;
            
            var frm = new GameBranchForm();

            frm.BranchGameDatasource = _repository.GetBranchGames(info.GameId);
            frm.BranchDatasource = _repository.GetBranches();
            
            frm.GameId = info.GameId;
            
            frm.Show();
        }

       


    }
}
