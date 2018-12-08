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
using TamerQasaly.Data.DAL;
using System.Data.Entity;
using TamerQasaly.Data.DBModel;

namespace TamerQasaly.Views.MainOffice
{
    public partial class frmOffice_MainCareer : DevExpress.XtraEditors.XtraForm
    {
        Career_DAL _dal;
        public frmOffice_MainCareer()
        {
            InitializeComponent();
            _dal = new Career_DAL();
        }
        
        public void Reload()
        {
            dgvTQ.DataSource = null;
            dgvTQ.DataSource = _dal.GetCareers.ToList();
        }

        private void frmOffice_MainCareer_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void frmOffice_MainCareer_Activated(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmOffice_MainCareerAddEdit frm = new frmOffice_MainCareerAddEdit();
            frm.career = new Office_Career();
            frm.ShowDialog();
        }

        private void btnEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int id = gridView1.SelectedRowsCount > 0 ? Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")) : 0;
            Office_Career career = _dal.GetCareer(id);
            frmOffice_MainCareerAddEdit frm = new frmOffice_MainCareerAddEdit();
            frm.career = career;
            frm.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (XtraMessageBox.Show("هل تريد بالفعل حذف الوظيفة ؟","رسالة استفسار",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int id = gridView1.SelectedRowsCount > 0 ? Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")) : 0;
                if(_dal.DeleteCareer(id) > 0)
                {
                    XtraMessageBox.Show("تمت عملية الحذف بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                 else
                {
                    XtraMessageBox.Show("فشل في عملية الحذف", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}