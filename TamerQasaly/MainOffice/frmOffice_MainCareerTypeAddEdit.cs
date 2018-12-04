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
using TamerQasaly.DBModel;
using TamerQasaly.Data.DAL;

namespace TamerQasaly.MainOffice
{
    public partial class frmOffice_MainCareerTypeAddEdit : DevExpress.XtraEditors.XtraForm
    {      
        public int intCareerTypeID ;
        private CareerType_DAL _dal;

        public frmOffice_MainCareerTypeAddEdit()
        {
            InitializeComponent();                       
        }

        private void frmOffice_MainCareerTypeAddEdit_Load(object sender, EventArgs e) {
            if (intCareerTypeID != 0)
            {
                Office_CareerType careerType = _dal.GetCareerType(intCareerTypeID);
                txtName.Text = careerType.Name;
                txtDescription.Text = careerType.Description;
            }
        }   
               

        private void btnSave_Click(object sender, EventArgs e)
        {
            Office_CareerType careerType = new Office_CareerType() { ID=Convert.ToInt16(intCareerTypeID),
                    Name = txtName.Text, Description = txtDescription.Text };
            if (string.IsNullOrEmpty(careerType.Name))
            {
                XtraMessageBox.Show("لا بد من كتابة اسم فئة الوظيفة", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (intCareerTypeID != 0)
            {
                //update               
                if( _dal.UpdateCareerType(careerType) > 0)
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
                careerType.ID = 0;
                if (_dal.AddCareerType(careerType) > 0)
                {
                    XtraMessageBox.Show("تمت عملية الحفظ بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    XtraMessageBox.Show("فشل في عملية الحفظ", "رسالة خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        }
    }
}