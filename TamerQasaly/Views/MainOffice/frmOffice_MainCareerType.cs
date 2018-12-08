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
using TamerQasaly.Data.DBModel;
using TamerQasaly.Data.DAL;
using DevExpress.XtraEditors;

namespace TamerQasaly.MainOffice
{
    public partial class frmOffice_MainCareerType : DevExpress.XtraEditors.XtraForm
    {
        
        private CareerType_DAL _dal = new CareerType_DAL();
        public frmOffice_MainCareerType()
        {
            InitializeComponent();            
        }

        private void Reload()
        {            
            dgvTQ.DataSource = _dal.GetCareerTypes.ToList();
        }

        private void frmOffice_MainCareerType_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnAdd_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOffice_MainCareerTypeAddEdit frm = new frmOffice_MainCareerTypeAddEdit();
            Office_CareerType careerType = new Office_CareerType();
            frm.careerType = careerType;
            frm.ShowDialog();
        }

        private void frmOffice_MainCareerType_Activated(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            int id = gridView1.SelectedRowsCount > 0 ? Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")) : 0 ;            
            Office_CareerType careerType = _dal.GetCareerType(id);
            frmOffice_MainCareerTypeAddEdit frm = new frmOffice_MainCareerTypeAddEdit();
            frm.careerType = careerType;
            frm.ShowDialog();
        }

        private void btnDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            int id = gridView1.SelectedRowsCount > 0 ? Convert.ToInt32(gridView1.GetFocusedRowCellValue("ID")) : 0;           
            DialogResult dr = XtraMessageBox.Show("هل تريد بالفعل عملية الحذف ؟", "رسالة تأكيد", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                if(_dal.DeleteCareerType(id) > 0)
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