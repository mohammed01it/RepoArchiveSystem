﻿namespace ArchiveSystem.Folder_view_data
{
    partial class Form_view_data_dqv
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_view_data_doc = new System.Windows.Forms.DataGridView();
            this.txt_seach = new System.Windows.Forms.TextBox();
            this.btn_search_claer = new System.Windows.Forms.Button();
            this.Label2_count_doc = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.Label2_count_doc_search = new System.Windows.Forms.Label();
            this.NumericUpDown_font_size = new System.Windows.Forms.NumericUpDown();
            this.Label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_data_doc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_font_size)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_view_data_doc
            // 
            this.dgv_view_data_doc.AllowUserToAddRows = false;
            this.dgv_view_data_doc.AllowUserToOrderColumns = true;
            this.dgv_view_data_doc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_view_data_doc.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_view_data_doc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_view_data_doc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_view_data_doc.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_view_data_doc.EnableHeadersVisualStyles = false;
            this.dgv_view_data_doc.Location = new System.Drawing.Point(2, 51);
            this.dgv_view_data_doc.Name = "dgv_view_data_doc";
            this.dgv_view_data_doc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_view_data_doc.RowTemplate.Height = 26;
            this.dgv_view_data_doc.Size = new System.Drawing.Size(1560, 868);
            this.dgv_view_data_doc.TabIndex = 3;
            this.dgv_view_data_doc.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_view_data_doc_ColumnHeaderMouseClick);
            // 
            // txt_seach
            // 
            this.txt_seach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_seach.Font = new System.Drawing.Font("Tahoma", 10.2F);
            this.txt_seach.Location = new System.Drawing.Point(1196, 9);
            this.txt_seach.Multiline = true;
            this.txt_seach.Name = "txt_seach";
            this.txt_seach.Size = new System.Drawing.Size(338, 36);
            this.txt_seach.TabIndex = 4;
            this.txt_seach.TextChanged += new System.EventHandler(this.txt_seach_TextChanged);
            // 
            // btn_search_claer
            // 
            this.btn_search_claer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search_claer.BackColor = System.Drawing.Color.White;
            this.btn_search_claer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_search_claer.FlatAppearance.BorderSize = 0;
            this.btn_search_claer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btn_search_claer.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btn_search_claer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_claer.Font = new System.Drawing.Font("Tahoma", 11F);
            this.btn_search_claer.Location = new System.Drawing.Point(1197, 10);
            this.btn_search_claer.Name = "btn_search_claer";
            this.btn_search_claer.Size = new System.Drawing.Size(35, 34);
            this.btn_search_claer.TabIndex = 399;
            this.btn_search_claer.Text = "x";
            this.btn_search_claer.UseVisualStyleBackColor = false;
            this.btn_search_claer.Click += new System.EventHandler(this.btn_search_claer_Click);
            // 
            // Label2_count_doc
            // 
            this.Label2_count_doc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2_count_doc.AutoSize = true;
            this.Label2_count_doc.Location = new System.Drawing.Point(1090, 27);
            this.Label2_count_doc.Name = "Label2_count_doc";
            this.Label2_count_doc.Size = new System.Drawing.Size(23, 17);
            this.Label2_count_doc.TabIndex = 401;
            this.Label2_count_doc.Text = "L2";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(1092, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(70, 17);
            this.Label1.TabIndex = 400;
            this.Label1.Text = "عدد النتائج";
            // 
            // Label15
            // 
            this.Label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label15.AutoSize = true;
            this.Label15.BackColor = System.Drawing.Color.White;
            this.Label15.Location = new System.Drawing.Point(1119, 26);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(13, 17);
            this.Label15.TabIndex = 408;
            this.Label15.Text = "/";
            // 
            // Label2_count_doc_search
            // 
            this.Label2_count_doc_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label2_count_doc_search.AutoSize = true;
            this.Label2_count_doc_search.BackColor = System.Drawing.Color.White;
            this.Label2_count_doc_search.Location = new System.Drawing.Point(1132, 26);
            this.Label2_count_doc_search.Name = "Label2_count_doc_search";
            this.Label2_count_doc_search.Size = new System.Drawing.Size(59, 17);
            this.Label2_count_doc_search.TabIndex = 407;
            this.Label2_count_doc_search.Text = "L2_sech";
            // 
            // NumericUpDown_font_size
            // 
            this.NumericUpDown_font_size.Location = new System.Drawing.Point(33, 14);
            this.NumericUpDown_font_size.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.NumericUpDown_font_size.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.NumericUpDown_font_size.Name = "NumericUpDown_font_size";
            this.NumericUpDown_font_size.Size = new System.Drawing.Size(51, 24);
            this.NumericUpDown_font_size.TabIndex = 409;
            this.NumericUpDown_font_size.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumericUpDown_font_size.ValueChanged += new System.EventHandler(this.NumericUpDown_font_size_ValueChanged);
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(90, 19);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(72, 18);
            this.Label2.TabIndex = 410;
            this.Label2.Text = "حجم الخط";
            // 
            // Form_view_data_dqv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1563, 923);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.NumericUpDown_font_size);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label2_count_doc_search);
            this.Controls.Add(this.Label2_count_doc);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.btn_search_claer);
            this.Controls.Add(this.txt_seach);
            this.Controls.Add(this.dgv_view_data_doc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_view_data_dqv";
            this.Text = "Form_view_data_dqv";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form_view_data_dqv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_view_data_doc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_font_size)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_view_data_doc;
        private System.Windows.Forms.TextBox txt_seach;
        internal System.Windows.Forms.Button btn_search_claer;
        internal System.Windows.Forms.Label Label2_count_doc;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label Label2_count_doc_search;
        internal System.Windows.Forms.NumericUpDown NumericUpDown_font_size;
        internal System.Windows.Forms.Label Label2;
    }
}