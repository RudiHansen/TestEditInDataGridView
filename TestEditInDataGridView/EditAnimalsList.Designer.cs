namespace TestEditInDataGridView
{
    partial class EditAnimalsList
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
            this.animalListDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.animalListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // animalListDataGridView
            // 
            this.animalListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.animalListDataGridView.Location = new System.Drawing.Point(12, 12);
            this.animalListDataGridView.Name = "animalListDataGridView";
            this.animalListDataGridView.Size = new System.Drawing.Size(481, 452);
            this.animalListDataGridView.TabIndex = 0;
            // 
            // EditAnimalsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 476);
            this.Controls.Add(this.animalListDataGridView);
            this.Name = "EditAnimalsList";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditAnimalsList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.animalListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView animalListDataGridView;
    }
}

