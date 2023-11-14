namespace Dbsys.Forms
{
    partial class Frm_Student_Dashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.payBtnEvent = new System.Windows.Forms.Button();
            this.dgvMisc = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.payBtnMisc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisc)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "PSITS PAYMENT COLLECTION";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(76, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Events";
            // 
            // dgvEvents
            // 
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Location = new System.Drawing.Point(75, 117);
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.Size = new System.Drawing.Size(526, 113);
            this.dgvEvents.TabIndex = 1;
            // 
            // payBtnEvent
            // 
            this.payBtnEvent.Location = new System.Drawing.Point(75, 236);
            this.payBtnEvent.Name = "payBtnEvent";
            this.payBtnEvent.Size = new System.Drawing.Size(75, 23);
            this.payBtnEvent.TabIndex = 2;
            this.payBtnEvent.Text = "Pay";
            this.payBtnEvent.UseVisualStyleBackColor = true;
            this.payBtnEvent.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvMisc
            // 
            this.dgvMisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMisc.Location = new System.Drawing.Point(75, 328);
            this.dgvMisc.Name = "dgvMisc";
            this.dgvMisc.Size = new System.Drawing.Size(526, 112);
            this.dgvMisc.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(76, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 3;
            this.label5.Text = "Misc";
            // 
            // payBtnMisc
            // 
            this.payBtnMisc.Location = new System.Drawing.Point(75, 446);
            this.payBtnMisc.Name = "payBtnMisc";
            this.payBtnMisc.Size = new System.Drawing.Size(75, 23);
            this.payBtnMisc.TabIndex = 2;
            this.payBtnMisc.Text = "Pay";
            this.payBtnMisc.UseVisualStyleBackColor = true;
            this.payBtnMisc.Click += new System.EventHandler(this.payBtnMisc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Name";
            // 
            // Frm_Student_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 535);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvMisc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.payBtnMisc);
            this.Controls.Add(this.payBtnEvent);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_Student_Dashboard";
            this.Text = "Frm_Student_Dashboard";
            this.Load += new System.EventHandler(this.Frm_Student_Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMisc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.Button payBtnEvent;
        private System.Windows.Forms.DataGridView dgvMisc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button payBtnMisc;
        private System.Windows.Forms.Label label3;
    }
}