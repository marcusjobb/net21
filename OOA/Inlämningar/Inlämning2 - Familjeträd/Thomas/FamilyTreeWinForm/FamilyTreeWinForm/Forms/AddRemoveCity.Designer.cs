// -----------------------------------------------------------------------------------------------
//  AddRemoveCity.Designer.cs by Thomas Thorin, Copyright (C) 2021.
//  Published under GNU General Public License v3 (GPL-3)
// -----------------------------------------------------------------------------------------------

namespace FamilyTreeWF.Forms
{
    partial class AddRemoveCity
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
            this.b_add = new System.Windows.Forms.Button();
            this.l_city = new System.Windows.Forms.Label();
            this.cb_cities = new System.Windows.Forms.ComboBox();
            this.l_explanation1 = new System.Windows.Forms.Label();
            this.l_explanation2 = new System.Windows.Forms.Label();
            this.b_cancel = new System.Windows.Forms.Button();
            this.b_removeEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // b_add
            // 
            this.b_add.AutoSize = true;
            this.b_add.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_add.Location = new System.Drawing.Point(40, 94);
            this.b_add.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(85, 33);
            this.b_add.TabIndex = 4;
            this.b_add.Text = "Add";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.B_addCity_Click);
            // 
            // l_city
            // 
            this.l_city.AutoSize = true;
            this.l_city.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_city.Location = new System.Drawing.Point(13, 61);
            this.l_city.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_city.Name = "l_city";
            this.l_city.Size = new System.Drawing.Size(39, 23);
            this.l_city.TabIndex = 2;
            this.l_city.Text = "City";
            // 
            // cb_cities
            // 
            this.cb_cities.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_cities.FormattingEnabled = true;
            this.cb_cities.Location = new System.Drawing.Point(59, 58);
            this.cb_cities.Name = "cb_cities";
            this.cb_cities.Size = new System.Drawing.Size(296, 30);
            this.cb_cities.TabIndex = 3;
            this.cb_cities.SelectedIndexChanged += new System.EventHandler(this.Cb_cities_SelectedIndexChanged);
            this.cb_cities.TextChanged += new System.EventHandler(this.Cb_cities_TextChanged);
            // 
            // l_explanation1
            // 
            this.l_explanation1.AutoSize = true;
            this.l_explanation1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_explanation1.Location = new System.Drawing.Point(12, 9);
            this.l_explanation1.Name = "l_explanation1";
            this.l_explanation1.Size = new System.Drawing.Size(321, 23);
            this.l_explanation1.TabIndex = 0;
            this.l_explanation1.Text = "Enter the name of a new city to create or";
            // 
            // l_explanation2
            // 
            this.l_explanation2.AutoSize = true;
            this.l_explanation2.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.l_explanation2.Location = new System.Drawing.Point(12, 32);
            this.l_explanation2.Name = "l_explanation2";
            this.l_explanation2.Size = new System.Drawing.Size(343, 23);
            this.l_explanation2.TabIndex = 1;
            this.l_explanation2.Text = "select an existing city to rename or remove.";
            // 
            // b_cancel
            // 
            this.b_cancel.AutoSize = true;
            this.b_cancel.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_cancel.Location = new System.Drawing.Point(226, 94);
            this.b_cancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(85, 33);
            this.b_cancel.TabIndex = 5;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // b_removeEdit
            // 
            this.b_removeEdit.AutoSize = true;
            this.b_removeEdit.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.b_removeEdit.Location = new System.Drawing.Point(133, 94);
            this.b_removeEdit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_removeEdit.Name = "b_removeEdit";
            this.b_removeEdit.Size = new System.Drawing.Size(85, 33);
            this.b_removeEdit.TabIndex = 6;
            this.b_removeEdit.Text = "Remove";
            this.b_removeEdit.UseVisualStyleBackColor = true;
            this.b_removeEdit.Click += new System.EventHandler(this.B_removeEdit_Click);
            // 
            // AddRemoveCity
            // 
            this.AcceptButton = this.b_add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.b_cancel;
            this.ClientSize = new System.Drawing.Size(371, 137);
            this.Controls.Add(this.b_removeEdit);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.l_explanation2);
            this.Controls.Add(this.l_explanation1);
            this.Controls.Add(this.cb_cities);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.l_city);
            this.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AddRemoveCity";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add or remove city";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b_add;
        private Label l_city;
        private ComboBox cb_cities;
        private Label l_explanation1;
        private Label l_explanation2;
        private Button b_cancel;
        private Button b_removeEdit;
    }
}