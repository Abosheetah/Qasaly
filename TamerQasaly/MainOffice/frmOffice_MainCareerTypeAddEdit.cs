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

namespace TamerQasaly.MainOffice
{
    public partial class frmOffice_MainCareerTypeAddEdit : DevExpress.XtraEditors.XtraForm
    {
        public static int intCareerTypeID = 0 ;
        private TamerQasalyDBEntities db ;
        private Office_CareerType oc;

        public frmOffice_MainCareerTypeAddEdit()
        {
            InitializeComponent();

            db = new TamerQasalyDBEntities();

            
        }

        private void frmOffice_MainCareerTypeAddEdit_Load(object sender, EventArgs e) {
            FillData(intCareerTypeID);
        }   
        
        private void FillData(int id)
        {
            if (id != 0)
            {
                oc = db.Office_CareerType.Where(x => x.ID == intCareerTypeID).Single();
                txtName.Text = oc.Name.ToString();
                txtDescription.Text = oc.Description.ToString();
            }
            else
            {
                return;
            }
        }        
    }
}