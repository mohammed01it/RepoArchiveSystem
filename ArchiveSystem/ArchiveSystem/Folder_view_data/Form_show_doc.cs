﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Configuration;
using System.Diagnostics;

namespace ArchiveSystem.Folder_view_data
{

    

    public partial class Form_show_doc : MetroFramework.Forms.MetroForm
    {
        public Form_show_doc()
        {
            InitializeComponent();
        }
        public static implicit operator Form_show_doc(ScanDialog v)
        {
            throw new NotImplementedException();
        }



        String fn_g;

        void check_Extension_file()
        {
 
            var Extension_file = Path.GetExtension(fn_g);


            if (Extension_file == ".docx")
            { ImageList_add_viwe.Images.Add(fn_g, ImageList_Extension.Images[0]); }
            else if (Extension_file == ".pptx") //بور بوينت"
            { ImageList_add_viwe.Images.Add(fn_g, ImageList_Extension.Images[1]); }
            else if (Extension_file == ".xlsx") //ملف اكسل
            { ImageList_add_viwe.Images.Add(fn_g, ImageList_Extension.Images[2]); }
            else if (Extension_file == ".accdb") //'ملف اكسس
            { ImageList_add_viwe.Images.Add(fn_g, ImageList_Extension.Images[3]); }
            else if (Extension_file == ".txt") //'ملف نصي
            { ImageList_add_viwe.Images.Add(fn_g, ImageList_Extension.Images[4]); }
            else if (Extension_file == ".pdf") //'ملف pdf
            { ImageList_add_viwe.Images.Add(fn_g, ImageList_Extension.Images[5]); }
            else if (Extension_file == ".mp4") //'فيديو
            { ImageList_add_viwe.Images.Add(fn_g, ImageList_Extension.Images[6]); }
            else if (Extension_file == ".bnp" || Extension_file == ".bmp" || Extension_file == ".gif" || Extension_file == ".tif" || Extension_file == ".exe" || Extension_file == ".dll" || Extension_file == ".ico" || Extension_file == ".glp" || Extension_file == ".psd" || Extension_file == "." || Extension_file == ".xml" || Extension_file == ".html" || Extension_file == ".js" || Extension_file == ".css") //اخرى
            { ImageList_add_viwe.Images.Add(fn_g, ImageList_Extension.Images[7]); }
            else
            { ImageList_add_viwe.Images.Add(fn_g, Bitmap.FromFile(fn_g));}
          
        }


      
        private void Form_show_doc_Load(object sender, EventArgs e)
        {
            ListView_show_doc.Columns.Add("الملف", 300);
            ListView_show_doc.View = View.LargeIcon;

            ListView_show_doc.Items.Clear();
            ImageList_add_viwe.Images.Clear();

            ImageList_add_viwe.ImageSize = new Size(100,100);
            ListView_show_doc.Columns[0].Width =  120;

            string path_folder_client_temp = ConfigurationManager.AppSettings["Path_Folder_Client_Temp"];

            foreach (string file in System.IO.Directory.GetFiles(path_folder_client_temp))
            { 
                         
             fn_g = file;

             check_Extension_file();
               

             FileInfo fi = new FileInfo(fn_g);

             //var files_n = new List<String>();
             //files_n.Add(fi.FullName);
                
             ListView_show_doc.Items.Add(fi.Name, ImageList_add_viwe.Images.Count - 1);

            }
            foreach (var proce in Process.GetProcessesByName(@"D:\New folder\202008240925211.jpg\"))
            {
                proce.Kill();
            }

        }

        private void Form_show_doc_FormClosed(object sender, FormClosedEventArgs e)
        {
           ImageList_add_viwe.Dispose();
        }
    }
}
