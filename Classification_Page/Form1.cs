using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Classification_Page
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bindData(string condition)
        {
            if (this.s구분 == "3" || this.s구분 == "4")
            {
                this.bindData2(condition);
            }
            else
            {
                this.GridRecord.RowCount = 0;
                this.GridRecord.DataSource = (object)null;
                try
                {
                    DataTable dataTable = new wnDm().fn_분류코드_List(this.s테이블명, condition, Common.p_strConn);
                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        this.GridRecord.RowCount = dataTable.Rows.Count;
                        for (int index = 0; index < dataTable.Rows.Count; ++index)
                        {
                            this.GridRecord.Rows[index].Cells[0].Value = (object)dataTable.Rows[index]["코드"].ToString();
                            this.GridRecord.Rows[index].Cells[1].Value = (object)dataTable.Rows[index]["명칭"].ToString();
                            this.GridRecord.Rows[index].Cells[2].Value = (object)dataTable.Rows[index]["비고"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    wnLog.writeLog(100, ex.Message + " - " + ex.ToString());
                }
            }
        }

        private void bindData2(string condition)
        {
            this.GridRecord.RowCount = 0;
            this.GridRecord.DataSource = (object)null;
            try
            {
                DataTable dataTable = new wnDm().fn_분류코드2_List(this.s테이블명, condition, Common.p_strConn);
                if (dataTable == null || dataTable.Rows.Count <= 0)
                    return;
                this.GridRecord.RowCount = dataTable.Rows.Count;
                for (int index = 0; index < dataTable.Rows.Count; ++index)
                {
                    this.GridRecord.Rows[index].Cells[0].Value = (object)dataTable.Rows[index]["코드"].ToString();
                    this.GridRecord.Rows[index].Cells[1].Value = (object)dataTable.Rows[index]["명칭"].ToString();
                    this.GridRecord.Rows[index].Cells[2].Value = (object)dataTable.Rows[index]["비고"].ToString();
                }
            }
            catch (Exception ex)
            {
                wnLog.writeLog(100, ex.Message + " - " + ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void new_btn(object sender, EventArgs e)
        {

        }

        private void save_btn(object sender, EventArgs e)
        {

        }

        private void delete_btn(object sender, EventArgs e)
        {

        }

        private void close_btn(object sender, EventArgs e)
        {

        }

        private void search_btn(object sender, EventArgs e)
        {

        }
    }
}
