
namespace Inlämningsuppgift_2___F
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgUsers = new System.Windows.Forms.DataGridView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpEditUsers = new System.Windows.Forms.TabPage();
            this.tpUserMonth = new System.Windows.Forms.TabPage();
            this.tbUsersByMonth = new System.Windows.Forms.TextBox();
            this.lblHeaderBirthday = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.btnPreviousMonth = new System.Windows.Forms.Button();
            this.btnNextMonth = new System.Windows.Forms.Button();
            this.tpBlockedUsers = new System.Windows.Forms.TabPage();
            this.lblHeaderBlockedUsers = new System.Windows.Forms.Label();
            this.tbBlockedUsers = new System.Windows.Forms.TextBox();
            this.tpGhostedUsers = new System.Windows.Forms.TabPage();
            this.lblHeaderGhostedUsers = new System.Windows.Forms.Label();
            this.tbGhostedUsers = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblYearsOld = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).BeginInit();
            this.tabControl.SuspendLayout();
            this.tpEditUsers.SuspendLayout();
            this.tpUserMonth.SuspendLayout();
            this.tpBlockedUsers.SuspendLayout();
            this.tpGhostedUsers.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(536, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 115);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgUsers
            // 
            this.dgUsers.AllowUserToAddRows = false;
            this.dgUsers.AllowUserToDeleteRows = false;
            this.dgUsers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUsers.GridColor = System.Drawing.Color.Black;
            this.dgUsers.Location = new System.Drawing.Point(6, 57);
            this.dgUsers.MultiSelect = false;
            this.dgUsers.Name = "dgUsers";
            this.dgUsers.RowHeadersWidth = 51;
            this.dgUsers.RowTemplate.Height = 29;
            this.dgUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUsers.Size = new System.Drawing.Size(1282, 497);
            this.dgUsers.TabIndex = 2;
            this.dgUsers.SelectionChanged += new System.EventHandler(this.dgUsers_SelectionChanged);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.Location = new System.Drawing.Point(118, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(106, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLoad.Location = new System.Drawing.Point(6, 6);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(106, 45);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRefresh.Location = new System.Drawing.Point(230, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 45);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(1182, 6);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(106, 45);
            this.btnAddUser.TabIndex = 3;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.Location = new System.Drawing.Point(1027, 6);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(149, 45);
            this.btnDeleteUser.TabIndex = 3;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpEditUsers);
            this.tabControl.Controls.Add(this.tpUserMonth);
            this.tabControl.Controls.Add(this.tpBlockedUsers);
            this.tabControl.Controls.Add(this.tpGhostedUsers);
            this.tabControl.Location = new System.Drawing.Point(12, 133);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1302, 593);
            this.tabControl.TabIndex = 4;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tpEditUsers
            // 
            this.tpEditUsers.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tpEditUsers.Controls.Add(this.dgUsers);
            this.tpEditUsers.Controls.Add(this.btnDeleteUser);
            this.tpEditUsers.Controls.Add(this.btnSave);
            this.tpEditUsers.Controls.Add(this.btnAddUser);
            this.tpEditUsers.Controls.Add(this.btnLoad);
            this.tpEditUsers.Controls.Add(this.btnRefresh);
            this.tpEditUsers.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpEditUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpEditUsers.Location = new System.Drawing.Point(4, 29);
            this.tpEditUsers.Name = "tpEditUsers";
            this.tpEditUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tpEditUsers.Size = new System.Drawing.Size(1294, 560);
            this.tpEditUsers.TabIndex = 0;
            this.tpEditUsers.Text = "Edit Users";
            // 
            // tpUserMonth
            // 
            this.tpUserMonth.Controls.Add(this.tbUsersByMonth);
            this.tpUserMonth.Controls.Add(this.lblHeaderBirthday);
            this.tpUserMonth.Controls.Add(this.lblMonth);
            this.tpUserMonth.Controls.Add(this.btnPreviousMonth);
            this.tpUserMonth.Controls.Add(this.btnNextMonth);
            this.tpUserMonth.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpUserMonth.Location = new System.Drawing.Point(4, 29);
            this.tpUserMonth.Name = "tpUserMonth";
            this.tpUserMonth.Padding = new System.Windows.Forms.Padding(3);
            this.tpUserMonth.Size = new System.Drawing.Size(1294, 560);
            this.tpUserMonth.TabIndex = 1;
            this.tpUserMonth.Text = "Find Users by Birthday Month";
            this.tpUserMonth.UseVisualStyleBackColor = true;
            // 
            // tbUsersByMonth
            // 
            this.tbUsersByMonth.Location = new System.Drawing.Point(355, 259);
            this.tbUsersByMonth.Multiline = true;
            this.tbUsersByMonth.Name = "tbUsersByMonth";
            this.tbUsersByMonth.ReadOnly = true;
            this.tbUsersByMonth.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbUsersByMonth.Size = new System.Drawing.Size(590, 228);
            this.tbUsersByMonth.TabIndex = 4;
            // 
            // lblHeaderBirthday
            // 
            this.lblHeaderBirthday.AutoSize = true;
            this.lblHeaderBirthday.Font = new System.Drawing.Font("Calibri", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblHeaderBirthday.Location = new System.Drawing.Point(301, 3);
            this.lblHeaderBirthday.Name = "lblHeaderBirthday";
            this.lblHeaderBirthday.Size = new System.Drawing.Size(737, 97);
            this.lblHeaderBirthday.TabIndex = 3;
            this.lblHeaderBirthday.Text = "Birthdays this month";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(537, 129);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(225, 73);
            this.lblMonth.TabIndex = 1;
            this.lblMonth.Text = "January";
            this.lblMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPreviousMonth
            // 
            this.btnPreviousMonth.Location = new System.Drawing.Point(301, 141);
            this.btnPreviousMonth.Name = "btnPreviousMonth";
            this.btnPreviousMonth.Size = new System.Drawing.Size(65, 61);
            this.btnPreviousMonth.TabIndex = 0;
            this.btnPreviousMonth.Text = "<";
            this.btnPreviousMonth.UseVisualStyleBackColor = true;
            this.btnPreviousMonth.Click += new System.EventHandler(this.btnPreviousMonth_Click);
            // 
            // btnNextMonth
            // 
            this.btnNextMonth.Location = new System.Drawing.Point(928, 141);
            this.btnNextMonth.Name = "btnNextMonth";
            this.btnNextMonth.Size = new System.Drawing.Size(65, 61);
            this.btnNextMonth.TabIndex = 0;
            this.btnNextMonth.Text = ">";
            this.btnNextMonth.UseVisualStyleBackColor = true;
            this.btnNextMonth.Click += new System.EventHandler(this.btnNextMonth_Click);
            // 
            // tpBlockedUsers
            // 
            this.tpBlockedUsers.Controls.Add(this.lblHeaderBlockedUsers);
            this.tpBlockedUsers.Controls.Add(this.tbBlockedUsers);
            this.tpBlockedUsers.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tpBlockedUsers.Location = new System.Drawing.Point(4, 29);
            this.tpBlockedUsers.Name = "tpBlockedUsers";
            this.tpBlockedUsers.Size = new System.Drawing.Size(1294, 560);
            this.tpBlockedUsers.TabIndex = 2;
            this.tpBlockedUsers.Text = "Blocked Users";
            this.tpBlockedUsers.UseVisualStyleBackColor = true;
            // 
            // lblHeaderBlockedUsers
            // 
            this.lblHeaderBlockedUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderBlockedUsers.AutoSize = true;
            this.lblHeaderBlockedUsers.Font = new System.Drawing.Font("Calibri", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblHeaderBlockedUsers.Location = new System.Drawing.Point(300, 20);
            this.lblHeaderBlockedUsers.Name = "lblHeaderBlockedUsers";
            this.lblHeaderBlockedUsers.Size = new System.Drawing.Size(720, 97);
            this.lblHeaderBlockedUsers.TabIndex = 4;
            this.lblHeaderBlockedUsers.Text = "List of Blocked Users";
            this.lblHeaderBlockedUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbBlockedUsers
            // 
            this.tbBlockedUsers.Location = new System.Drawing.Point(368, 141);
            this.tbBlockedUsers.Multiline = true;
            this.tbBlockedUsers.Name = "tbBlockedUsers";
            this.tbBlockedUsers.ReadOnly = true;
            this.tbBlockedUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbBlockedUsers.Size = new System.Drawing.Size(590, 228);
            this.tbBlockedUsers.TabIndex = 0;
            // 
            // tpGhostedUsers
            // 
            this.tpGhostedUsers.Controls.Add(this.lblHeaderGhostedUsers);
            this.tpGhostedUsers.Controls.Add(this.tbGhostedUsers);
            this.tpGhostedUsers.Location = new System.Drawing.Point(4, 29);
            this.tpGhostedUsers.Name = "tpGhostedUsers";
            this.tpGhostedUsers.Size = new System.Drawing.Size(1294, 560);
            this.tpGhostedUsers.TabIndex = 3;
            this.tpGhostedUsers.Text = "Ghosted Users";
            this.tpGhostedUsers.UseVisualStyleBackColor = true;
            // 
            // lblHeaderGhostedUsers
            // 
            this.lblHeaderGhostedUsers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHeaderGhostedUsers.AutoSize = true;
            this.lblHeaderGhostedUsers.Font = new System.Drawing.Font("Calibri", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblHeaderGhostedUsers.Location = new System.Drawing.Point(290, 20);
            this.lblHeaderGhostedUsers.Name = "lblHeaderGhostedUsers";
            this.lblHeaderGhostedUsers.Size = new System.Drawing.Size(738, 97);
            this.lblHeaderGhostedUsers.TabIndex = 5;
            this.lblHeaderGhostedUsers.Text = "List of Ghosted Users";
            this.lblHeaderGhostedUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbGhostedUsers
            // 
            this.tbGhostedUsers.Location = new System.Drawing.Point(368, 141);
            this.tbGhostedUsers.Multiline = true;
            this.tbGhostedUsers.Name = "tbGhostedUsers";
            this.tbGhostedUsers.ReadOnly = true;
            this.tbGhostedUsers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbGhostedUsers.Size = new System.Drawing.Size(590, 228);
            this.tbGhostedUsers.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(22, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(94, 20);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Select a User";
            // 
            // lblYearsOld
            // 
            this.lblYearsOld.AutoSize = true;
            this.lblYearsOld.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblYearsOld.Location = new System.Drawing.Point(22, 54);
            this.lblYearsOld.Name = "lblYearsOld";
            this.lblYearsOld.Size = new System.Drawing.Size(0, 20);
            this.lblYearsOld.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1322, 876);
            this.Controls.Add(this.lblYearsOld);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "F CHAT ADMINISTRATION TOOL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgUsers)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.tpEditUsers.ResumeLayout(false);
            this.tpUserMonth.ResumeLayout(false);
            this.tpUserMonth.PerformLayout();
            this.tpBlockedUsers.ResumeLayout(false);
            this.tpBlockedUsers.PerformLayout();
            this.tpGhostedUsers.ResumeLayout(false);
            this.tpGhostedUsers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgUsers;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpEditUsers;
        private System.Windows.Forms.TabPage tpUserMonth;
        private System.Windows.Forms.TabPage tpBlockedUsers;
        private System.Windows.Forms.TabPage tpGhostedUsers;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblYearsOld;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnPreviousMonth;
        private System.Windows.Forms.Button btnNextMonth;
        private System.Windows.Forms.Label lblHeaderBirthday;
        private System.Windows.Forms.TextBox tbBlockedUsers;
        private System.Windows.Forms.Label lblHeaderBlockedUsers;
        private System.Windows.Forms.Label lblHeaderGhostedUsers;
        private System.Windows.Forms.TextBox tbGhostedUsers;
        private System.Windows.Forms.TextBox tbUsersByMonth;
    }
}

