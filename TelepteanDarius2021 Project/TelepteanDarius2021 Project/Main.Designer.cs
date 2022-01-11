
namespace PopGeorge2021_Project_
{
    partial class Main
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
            this.dtLaod = new System.Windows.Forms.DataGridView();
            this.btnChart = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.bntSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtSR = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtLaod)).BeginInit();
            this.SuspendLayout();
            // 
            // dtLaod
            // 
            this.dtLaod.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtLaod.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtLaod.Location = new System.Drawing.Point(12, 63);
            this.dtLaod.Name = "dtLaod";
            this.dtLaod.Size = new System.Drawing.Size(724, 191);
            this.dtLaod.TabIndex = 1;
            this.dtLaod.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtLaod_CellContentClick);
            // 
            // btnChart
            // 
            this.btnChart.Image = global::PopGeorge2021_Project_.Properties.Resources.Chart_32x32;
            this.btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChart.Location = new System.Drawing.Point(655, 4);
            this.btnChart.Name = "btnChart";
            this.btnChart.Size = new System.Drawing.Size(81, 45);
            this.btnChart.TabIndex = 0;
            this.btnChart.Text = "Chart";
            this.btnChart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChart.UseVisualStyleBackColor = true;
            this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Image = global::PopGeorge2021_Project_.Properties.Resources.Delete_32x32;
            this.bntDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntDelete.Location = new System.Drawing.Point(550, 4);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(81, 45);
            this.bntDelete.TabIndex = 0;
            this.bntDelete.Text = "Delete";
            this.bntDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::PopGeorge2021_Project_.Properties.Resources.Add_32x32;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(446, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 45);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Image = global::PopGeorge2021_Project_.Properties.Resources.Edit_32x32;
            this.btnDetails.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetails.Location = new System.Drawing.Point(345, 4);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(81, 45);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Details";
            this.btnDetails.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // bntSave
            // 
            this.bntSave.Image = global::PopGeorge2021_Project_.Properties.Resources.Save_32x32;
            this.bntSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntSave.Location = new System.Drawing.Point(243, 4);
            this.bntSave.Name = "bntSave";
            this.bntSave.Size = new System.Drawing.Size(81, 45);
            this.bntSave.TabIndex = 0;
            this.bntSave.Text = "Save";
            this.bntSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntSave.UseVisualStyleBackColor = true;
            this.bntSave.Click += new System.EventHandler(this.bntSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Image = global::PopGeorge2021_Project_.Properties.Resources.Load_32x32;
            this.btnLoad.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoad.Location = new System.Drawing.Point(139, 4);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(81, 45);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtSR
            // 
            this.txtSR.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSR.Location = new System.Drawing.Point(12, 12);
            this.txtSR.Name = "txtSR";
            this.txtSR.Size = new System.Drawing.Size(100, 26);
            this.txtSR.TabIndex = 2;
            this.txtSR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSR_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 266);
            this.Controls.Add(this.txtSR);
            this.Controls.Add(this.dtLaod);
            this.Controls.Add(this.btnChart);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.bntSave);
            this.Controls.Add(this.btnLoad);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLaod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button bntSave;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button btnChart;
        public System.Windows.Forms.DataGridView dtLaod;
        private System.Windows.Forms.TextBox txtSR;
    }
}

