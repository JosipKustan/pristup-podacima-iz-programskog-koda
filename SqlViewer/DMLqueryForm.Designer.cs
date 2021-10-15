
namespace Zadatak0102
{
    partial class DMLqueryForm
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
            this.tbDML = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dgvQueryView = new System.Windows.Forms.DataGridView();
            this.tbMessage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDML
            // 
            this.tbDML.BackColor = System.Drawing.SystemColors.Desktop;
            this.tbDML.ForeColor = System.Drawing.Color.LimeGreen;
            this.tbDML.Location = new System.Drawing.Point(41, 16);
            this.tbDML.Margin = new System.Windows.Forms.Padding(2);
            this.tbDML.Multiline = true;
            this.tbDML.Name = "tbDML";
            this.tbDML.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbDML.Size = new System.Drawing.Size(696, 185);
            this.tbDML.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(584, 156);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 45);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dgvQueryView
            // 
            this.dgvQueryView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQueryView.Location = new System.Drawing.Point(41, 221);
            this.dgvQueryView.Name = "dgvQueryView";
            this.dgvQueryView.Size = new System.Drawing.Size(696, 234);
            this.dgvQueryView.TabIndex = 2;
            // 
            // tbMessage
            // 
            this.tbMessage.Location = new System.Drawing.Point(41, 477);
            this.tbMessage.Multiline = true;
            this.tbMessage.Name = "tbMessage";
            this.tbMessage.ReadOnly = true;
            this.tbMessage.Size = new System.Drawing.Size(696, 77);
            this.tbMessage.TabIndex = 3;
            // 
            // DMLqueryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(782, 582);
            this.Controls.Add(this.tbMessage);
            this.Controls.Add(this.dgvQueryView);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbDML);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DMLqueryForm";
            this.Text = "DMLqueryForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvQueryView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDML;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.DataGridView dgvQueryView;
        private System.Windows.Forms.TextBox tbMessage;
    }
}