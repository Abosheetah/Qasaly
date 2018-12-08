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
using TamerQasaly.Data.DBModel;
using TamerQasaly.Data.DAL;
using DevExpress.XtraEditors.Repository;

namespace TamerQasaly.Views.MainOffice
{
    public partial class frmOffice_MainCareerAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public Office_Career career;
        private Career_DAL _dal;
        private CareerType_DAL _dalCT;

        public frmOffice_MainCareerAddEdit()
        {
            InitializeComponent();
            _dal = new Career_DAL();
            _dalCT = new CareerType_DAL();
        }

        private void fillComboBox()
        {
            /*https://documentation.devexpress.com/WindowsForms/DevExpress.XtraEditors.Repository.RepositoryItemLookUpEditBase.DisplayMember.property*/
            RepositoryItemLookUpEdit items = new RepositoryItemLookUpEdit();
            //items.DataSource = _dalCT.GetCareerTypes.ToList();
            //items.DisplayMember = "Name";
            //items.ValueMember = "ID";
            //luCareerType.EditValue = items;

            luCareerType.Properties.DataSource = _dalCT.GetCareerTypes.ToList();
            luCareerType.Properties.DisplayMember = "Name";
            luCareerType.Properties.ValueMember = "ID";
        }

        private void Reload()
        {
            txtName.Text = career.Name;
            txtDescription.Text = career.Description;
            luCareerType.EditValue = career.CareerTypeID;
        }

        private void frmOffice_MainCareerAddEdit_Load(object sender, EventArgs e)
        {
            fillComboBox();
            Reload();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int idSelected;
            try
            {
                idSelected = Convert.ToInt32(luCareerType.EditValue);
            }
            catch (Exception)
            {
                return;
            }

            //some validations .
            if (string.IsNullOrEmpty(txtName.Text))
            {
                XtraMessageBox.Show("لا بد من كتابة اسم الوظيفة", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (idSelected == 0)
            {
                XtraMessageBox.Show("لا بد من نحديد اسم فئة الوظيفة", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (career.ID > 0)
            {
                //update
                career.Name = txtName.Text;
                career.Description = txtDescription.Text;
                career.CareerTypeID = Convert.ToInt16(idSelected);
                if (_dal.UpdateCareer(career) > 0)
                {
                    XtraMessageBox.Show("تمت عملية الحفظ بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("فشل في عملية الحفظ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                //add new 
                career.Name = txtName.Text;
                career.Description = txtDescription.Text;
                career.CareerTypeID = Convert.ToInt16(idSelected);

                if (_dal.AddCareer(career) > 0)
                {
                    XtraMessageBox.Show("تمت عملية الحفظ بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("فشل في عملية الحفظ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            this.Close();
             
        }
    }
}