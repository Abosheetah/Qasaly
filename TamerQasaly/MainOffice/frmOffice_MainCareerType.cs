using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using TamerQasaly.DBModel;

namespace TamerQasaly.MainOffice
{
    public partial class frmOffice_MainCareerType : DevExpress.XtraEditors.XtraForm
    {
        private TamerQasalyDBEntities db;
        public frmOffice_MainCareerType()
        {
            InitializeComponent();

            

        }



        private void Reload()
        {
            db = new TamerQasalyDBEntities();
            dgvCareerTypes.DataSource = db.Office_CareerType.Select(x => new { x.ID,x.Name,x.Description }).ToList();


        }

        private void frmOffice_MainCareerType_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOffice_MainCareerTypeAddEdit frm = new frmOffice_MainCareerTypeAddEdit();
            frm.ShowDialog();
        }
    }
}