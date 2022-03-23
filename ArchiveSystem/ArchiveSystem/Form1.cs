using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Net;
using System.IO;
using System.Threading;
using System.Diagnostics;
using System.Globalization;
using System.Management;
using System.Data.SqlClient;
using ArchiveSystem.Folder_view_data;

namespace ArchiveSystem
{
  
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {

       
         


        public Form1()
        {
            InitializeComponent();
        }
        public string selectedFolder = "";
        public string picture_path = "";
        public string Doc_source = "";

        string FTP_ip = ConfigurationSettings.AppSettings["FTP_Path"];
        string FTP_user = ConfigurationSettings.AppSettings["FTP_user"];
        string FTP_pass = ConfigurationSettings.AppSettings["FTP_pass"];


       
        public static string _con = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        SqlConnection con = new SqlConnection(_con);

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
          

              Doc_source = Properties.Settings.Default.DOC_Source.ToString(); // doc source
            
             
            metroTabControl1.RightToLeft = RightToLeft.Yes;
            metroTabControl1.RightToLeftLayout = true;

            //example
            //          string query = string.Format(@" SELECT TOP (1000) [PermitionTypeID]
            //    ,[PermitionType]
            //FROM [ArchiveSystem].[dbo].[PermitionType_TBL];", con);




            //          con.Open();
            //          SqlCommand cmd = new SqlCommand(query, con);

            //          SqlDataAdapter adp = new SqlDataAdapter(cmd);

            //          DataTable dt2 = new DataTable();

            //          adp.Fill(dt2);
            //          con.Close();



           








            try
            {
                string[] folders = Directory.GetDirectories(Doc_source); 
                DataTable folderDT = new DataTable();

                folderDT.Columns.Add("اسم الملف");

                for (int i = 0; i < folders.Length; i++)
                {
                    FileInfo folder = new FileInfo(folders[i]);
                    folderDT.Rows.Add(folder.Name);
                }
                DGV_Folders.DataSource = folderDT;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void DGV_Folders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            String folderName = DGV_Folders.Rows[e.RowIndex].Cells[0].Value.ToString();
            selectedFolder = folderName;
 
            string[] Files = Directory.GetFiles(Doc_source +@"\"+ folderName + "", "*.*");//put variable name instade of path
            DataTable table = new DataTable();

            table.Columns.Add("check", typeof(bool));
            table.Columns.Add("File Name");
 
            for (int i = 0; i < Files.Length; i++)
            {
                FileInfo file = new FileInfo(Files[i]);
               
                table.Rows.Add(false, file.Name);
             

            }

            DGV_Files.DataSource = table;

            DGV_Files.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            CHK_selectall.Visible = true;

            int row = DGV_Folders.CurrentCell.RowIndex;
            TXT_addFolder.Text = DGV_Folders.Rows[row].Cells[0].Value.ToString();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CHK_selectall.Checked == true)
            {
                foreach (DataGridViewRow row in DGV_Files.Rows)
                {
                    row.Cells[0].Value = row.Cells[0].Value = true;

                }
            }
            else if (CHK_selectall.Checked == false)
            {
                foreach (DataGridViewRow row in DGV_Files.Rows)
                {
                    row.Cells[0].Value = row.Cells[0].Value = false;

                }
            }
         
        }

        private void DGV_Files_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTN_Archive_Click(object sender, EventArgs e)
        {
            //get list of checked rows 
            List<string> files_checked = new List<string>();
            for (int i = 0; i < DGV_Files.Rows.Count; i++)
            {
                bool is_checked = (bool)DGV_Files.Rows[i].Cells[0].Value;
                {
                    if (is_checked == true)
                    {
                        //files_checked.Add(dataGridView1.Rows[i].Cells[1].ToString());
                        files_checked.Add(DGV_Files.Rows[i].Cells[1].Value.ToString());
                    }
                }
            }

            //create folder with same db index id
            var Typee = "وارد";// bring it from dropdown user chose
            //var BookCat = "كتاب عادي";// bring it from dropdown user chose
            var Code = "cjs2"; //bring it from db
  

            WebRequest request_ = WebRequest.Create(FTP_ip + Typee +  "/"+ Code + "/");
            request_.Method = WebRequestMethods.Ftp.MakeDirectory;
            request_.Credentials = new NetworkCredential(FTP_user,FTP_pass);
            using (var resp = (FtpWebResponse)request_.GetResponse())
            {
                Console.WriteLine(resp.StatusCode);
            }



            //create array of string with all local dir files names

            string[] Files = Directory.GetFiles(Doc_source + @"\" + selectedFolder + "");//put variable here 


            //get the record number (RecID)


            foreach (var item in files_checked)
            {

                string filenamechecked = item.ToString();
                foreach (string file in Files)
                {

                    string file_name = Path.GetFileName(file);
                    //if file == selected files from app
                    if (file_name == filenamechecked)
                    {
                        FtpWebRequest request = (FtpWebRequest)WebRequest.Create(FTP_ip + Typee + "/" + Code + "/" + file_name);
                        request.Credentials = new NetworkCredential(FTP_user,FTP_pass);
                        request.Method = WebRequestMethods.Ftp.UploadFile;

                        using (Stream fileStream = File.OpenRead(file))

                        using (Stream ftpStream = request.GetRequestStream())
                        {
                            fileStream.CopyTo(ftpStream);

                        }
                        //var processes = Process.GetProcessesByName(file);

                        //foreach (var proc in Process.GetProcessesByName(file))
                        //{
                        //    proc.Kill();
                        //}
                        //delete imges after coopy
                        if (File.Exists(file))
                        {
                            File.Delete(file);
                        }
                    }



                }
            }
            this.Form1_Load(null, null);
        }

        private void DGV_Files_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow row in DGV_Files.Rows)
            {
                String file_name = DGV_Files.Rows[e.RowIndex].Cells[1].Value.ToString();
                Image image2 = Image.FromFile(Doc_source + @"\" + selectedFolder+ @"\" + file_name + "");//put var here
                //pictureBox1.Image=file
                // Get a PropertyItem from image1.
                //PropertyItem propItem = image1.GetPropertyItem(20624);

                //// Change the ID of the PropertyItem.
                //propItem.Id = 20625;

                //// Set the PropertyItem for image2.
                //image2.SetPropertyItem(propItem);

                //// Draw the image.
                //e.Graphics.DrawImage(image2, 20.0F, 20.0F);

                PicB_displayBOOK.Image = new Bitmap(image2);

                image2.Dispose();
                picture_path = (Doc_source + @"\" + selectedFolder + @"\" + file_name + "");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ScanDialog sd = new ScanDialog();
            sd.Show();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PicB_displayBOOK_Click(object sender, EventArgs e)
        {
            
            // Use default image viewer  
            System.Diagnostics.Process.Start(picture_path);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void BTN_addfolder_Click(object sender, EventArgs e)
        {
            string root = Doc_source + @"\" + TXT_addFolder.Text + "";

            Directory.CreateDirectory(root);
            this.Form1_Load(null, null);
        }

        private void DGV_Folders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void BTN_DELFolder_Click(object sender, EventArgs e)
        {
            string root = Doc_source + @"\" + TXT_addFolder.Text + "";

            Directory.Delete(root, true);

            this.Form1_Load(null, null);
        }
     
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            Folder_Brows_DOC_Source.ShowDialog();
            string Doc_source = Folder_Brows_DOC_Source.SelectedPath;

            Properties.Settings.Default.DOC_Source = Doc_source;

            Properties.Settings.Default.Save();
            this.Form1_Load(null, null);


        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        public void btn_view_data_dqv_Click(object sender, EventArgs e)
        {
            Form_view_data_dqv new_tab = new Form_view_data_dqv();
            TabPage t = new TabPage();
            new_tab.TopLevel = false;
            t.Controls.Add(new_tab);
            metroTabControl1.TabPages.Add(t);
            new_tab.Show();
            new_tab.Dock = DockStyle.Fill;
            int x = metroTabControl1.TabCount;
            t.Text = "الارشيف العام" + x;
            metroTabControl1.SelectTab(x - 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //dawdawdawd
            //    aw
            //    d
            //    wad
            //    aw
            //    d
            //    aw
            //    dawd
        }
    }
}
