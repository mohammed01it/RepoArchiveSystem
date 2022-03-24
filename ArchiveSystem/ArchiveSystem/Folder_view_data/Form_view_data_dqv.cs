using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ArchiveSystem.Folder_view_data
{
    public partial class Form_view_data_dqv : Form
    {
        public Form_view_data_dqv()
        {
            InitializeComponent();
        }

        public static string _con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection(_con);


        DataTable dt = new DataTable();
            SqlDataAdapter adapter;

        void fill_dgv_view_data_doc()
        {
           


            adapter = new SqlDataAdapter(@"SELECT

dbo.ArchiveBooks_TBL.BookCode as [كود الكتاب],
dbo.ArchiveBooks_TBL.BookNumber as [رقم الكتاب],
dbo.ArchiveBooks_TBL.BookDate as [تاريخ الكتاب],
dbo.ArchiveBooks_TBL.InboundNumber as [رقم واردنا],
dbo.ArchiveBooks_TBL.InboundDate as [تاريخ واردنا],
dbo.ArchiveBooks_TBL.Subject as [موضوع الكتاب],
dbo.ArchiveBooks_TBL.BooksTypeID as [النوع(الكابينة)],
dbo.ArchiveBooks_TBL.[From] as [من],
dbo.ArchiveBooks_TBL.[To] as [الى],
dbo.ArchiveBooks_TBL.SearchKeysID as [مفاتيح البحث],
dbo.ArchiveBooks_TBL.BookPriority as [الاولوية],
dbo.ArchiveBooks_TBL.ArchivedDate as [تاريخ الارشفة],
dbo.ArchiveBooks_TBL.BookPaperType as [نوع النسخة],
dbo.ArchiveBooks_TBL.Notes as [الملاحظات],
dbo.ArchiveBooks_TBL.BookCatID as [BookCatID],
dbo.ArchiveBooks_TBL.DepartmentID_archivedBy as [القسم],
dbo.ArchiveBooks_TBL.UserID_archivedBy as [المستخدم],
dbo.ArchiveBooks_TBL.BookStatus as [حالة الكتاب],
dbo.ArchiveBooks_TBL.Privacy as [الخصوصية]



FROM ArchiveBooks_TBL
                ", con);



            dt.Clear();

            adapter.Fill(dt);
            dgv_view_data_doc.DataSource = dt;
            Label2_count_doc.Text = Convert.ToString(BindingContext[dt].Count);
            Label2_count_doc_search.Text = Convert.ToString(BindingContext[dt].Count);
        }


        private void Form_view_data_dqv_Load(object sender, EventArgs e)
        {

            fill_dgv_view_data_doc();

            for (int i = 0; i < dgv_view_data_doc.Columns.Count - 1; i++)
               {
                dgv_view_data_doc.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
               }

           

            dgv_view_data_doc.Columns[0].HeaderCell.Style.BackColor = Color.DeepSkyBlue;
           
            dgv_view_data_doc.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 11);

        }

        private void btn_search_claer_Click(object sender, EventArgs e)
        {
            txt_seach.Clear();
        }

        private void txt_seach_TextChanged(object sender, EventArgs e)
        {
            try
                {
                  DataView dv = dt.DefaultView;

                 dv.RowFilter = "[" + dgv_view_data_doc.Columns[col_index_select].Name + "]+[كود الكتاب]  Like '%" + txt_seach.Text + "%'";
                  this.dgv_view_data_doc.DataSource = dv;
                Label2_count_doc_search.Text = Convert.ToString(BindingContext[dt].Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "يجب اختيار عمود لبحث بة");
           }

       
        }

        int col_index_select = 1;
        private void dgv_view_data_doc_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_seach.Clear();

            col_index_select = e.ColumnIndex;

            for(int i = 0; i < dgv_view_data_doc.Columns.Count - 1; i++)
               {
                
                dgv_view_data_doc.Columns[i].HeaderCell.Style.BackColor = Color.LightGray;

                dgv_view_data_doc.Columns[e.ColumnIndex].HeaderCell.Style.BackColor = Color.DeepSkyBlue;

            }
            txt_seach.Select();
        }

        private void NumericUpDown_font_size_ValueChanged(object sender, EventArgs e)
        {

            //dgv_view_data_doc.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", NumericUpDown_font_size.Value + 2);

            //dgv_view_data_doc.DefaultCellStyle.Font = new Font("Tahoma", NumericUpDown_font_size.Value);
        }
    }
}
