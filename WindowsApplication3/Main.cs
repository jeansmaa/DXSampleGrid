using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using DevExpress.XtraBars.Docking2010.Views;
using DevExpress.XtraEditors;
using DXSample.Data;

namespace DXSample {
    public partial class Main : XtraForm {
        BindingList<Record> records = new BindingList<Record>();
        public Main() {
            InitializeComponent();
            recordBindingSource.DataSource = DataHelper.GetData(20, 10);

            gridControl2.DataSource = records;
        }

        private void simpleButton1_Click(object sender, EventArgs e) {
            int[] selectedRows = gridView1.GetSelectedRows();
            foreach (int index in selectedRows) {
                Record record = gridView1.GetRow(index) as Record;
                Record newRecord = new Record();
                newRecord.ID = record.ID;
                newRecord.Image = record.Image;
                newRecord.ParentID = record.ParentID;
                newRecord.State = record.State;
                newRecord.TestDetails = record.TestDetails;
                newRecord.Text = record.Text;

                records.Add(record);
            }
        }
    }
}
