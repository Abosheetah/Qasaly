using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.XtraScheduler;
using TamerQasaly.MainOffice;

namespace TamerQasaly
{
    public partial class Form1 : RibbonForm
    {
        frmOffice_MainCareerType frm;
        public Form1()
        {
            InitializeComponent();
            InitSkinGallery();
            
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void btnOffice_CareerType_ItemClick(object sender, ItemClickEventArgs e)
        {
            frm = new frmOffice_MainCareerType();
            frm.ShowDialog();
        }
    }
}