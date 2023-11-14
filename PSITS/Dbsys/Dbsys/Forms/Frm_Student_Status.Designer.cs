namespace Dbsys.Forms
{
    partial class Frm_Student_Status
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
            this.statusDgv = new System.Windows.Forms.DataGridView();
            this.labelSearch = new System.Windows.Forms.Label();
            this.searchTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.statusDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // statusDgv
            // 
            this.statusDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDgv.Location = new System.Drawing.Point(21, 73);
            this.statusDgv.Name = "statusDgv";
            this.statusDgv.Size = new System.Drawing.Size(348, 343);
            this.statusDgv.TabIndex = 0;
            this.statusDgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(18, 33);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(44, 13);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search:";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(68, 30);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(174, 20);
            this.searchTxt.TabIndex = 2;
            // 
            // Frm_Student_Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 428);
            this.Controls.Add(this.searchTxt);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.statusDgv);
            this.Name = "Frm_Student_Status";
            this.Text = "Frm_Student_Status";
            ((System.ComponentModel.ISupportInitialize)(this.statusDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView statusDgv;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox searchTxt;
    }
}