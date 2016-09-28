namespace Hotel_Reservations
{
    partial class CreateFilesForm
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
            this.btnCreateHotels = new System.Windows.Forms.Button();
            this.btnCreateInventory = new System.Windows.Forms.Button();
            this.btnDisplayHotels = new System.Windows.Forms.Button();
            this.btnDisplayInventory = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CreateHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CreateRoomInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DisplayHotels = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DisplayRoomsInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateHotels
            // 
            this.btnCreateHotels.Location = new System.Drawing.Point(32, 37);
            this.btnCreateHotels.Name = "btnCreateHotels";
            this.btnCreateHotels.Size = new System.Drawing.Size(276, 66);
            this.btnCreateHotels.TabIndex = 0;
            this.btnCreateHotels.Text = "Create the hotels.xml file";
            this.btnCreateHotels.UseVisualStyleBackColor = true;
            this.btnCreateHotels.Click += new System.EventHandler(this.btnCreateHotels_Click);
            // 
            // btnCreateInventory
            // 
            this.btnCreateInventory.Location = new System.Drawing.Point(33, 119);
            this.btnCreateInventory.Name = "btnCreateInventory";
            this.btnCreateInventory.Size = new System.Drawing.Size(276, 66);
            this.btnCreateInventory.TabIndex = 1;
            this.btnCreateInventory.Text = "Create the roominventory.xml file";
            this.btnCreateInventory.UseVisualStyleBackColor = true;
            this.btnCreateInventory.Click += new System.EventHandler(this.btnCreateInventory_Click);
            // 
            // btnDisplayHotels
            // 
            this.btnDisplayHotels.Location = new System.Drawing.Point(339, 37);
            this.btnDisplayHotels.Name = "btnDisplayHotels";
            this.btnDisplayHotels.Size = new System.Drawing.Size(276, 66);
            this.btnDisplayHotels.TabIndex = 2;
            this.btnDisplayHotels.Text = "Display the hotels.xml file in a Web browser window";
            this.btnDisplayHotels.UseVisualStyleBackColor = true;
            this.btnDisplayHotels.Click += new System.EventHandler(this.btnDisplayHotels_Click);
            // 
            // btnDisplayInventory
            // 
            this.btnDisplayInventory.Location = new System.Drawing.Point(339, 119);
            this.btnDisplayInventory.Name = "btnDisplayInventory";
            this.btnDisplayInventory.Size = new System.Drawing.Size(276, 66);
            this.btnDisplayInventory.TabIndex = 3;
            this.btnDisplayInventory.Text = "Display the roominventory.xml file in a Web browser window";
            this.btnDisplayInventory.UseVisualStyleBackColor = true;
            this.btnDisplayInventory.Click += new System.EventHandler(this.btnDisplayInventory_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(28, 224);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(220, 25);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "(status of last operation)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(657, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_CreateHotel,
            this.mnu_CreateRoomInventory,
            this.mnu_DisplayHotels,
            this.mnu_DisplayRoomsInventory});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnu_CreateHotel
            // 
            this.mnu_CreateHotel.Name = "mnu_CreateHotel";
            this.mnu_CreateHotel.Size = new System.Drawing.Size(242, 26);
            this.mnu_CreateHotel.Text = "Create Hotels";
            this.mnu_CreateHotel.Click += new System.EventHandler(this.mnu_CreateHotel_Click);
            // 
            // mnu_CreateRoomInventory
            // 
            this.mnu_CreateRoomInventory.Name = "mnu_CreateRoomInventory";
            this.mnu_CreateRoomInventory.Size = new System.Drawing.Size(242, 26);
            this.mnu_CreateRoomInventory.Text = "Create Room Inventory";
            // 
            // mnu_DisplayHotels
            // 
            this.mnu_DisplayHotels.Name = "mnu_DisplayHotels";
            this.mnu_DisplayHotels.Size = new System.Drawing.Size(242, 26);
            this.mnu_DisplayHotels.Text = "Display Hotels";
            // 
            // mnu_DisplayRoomsInventory
            // 
            this.mnu_DisplayRoomsInventory.Name = "mnu_DisplayRoomsInventory";
            this.mnu_DisplayRoomsInventory.Size = new System.Drawing.Size(242, 26);
            this.mnu_DisplayRoomsInventory.Text = "Display Room Inventory";
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 286);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDisplayInventory);
            this.Controls.Add(this.btnDisplayHotels);
            this.Controls.Add(this.btnCreateInventory);
            this.Controls.Add(this.btnCreateHotels);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservations 1.0";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateHotels;
        private System.Windows.Forms.Button btnCreateInventory;
        private System.Windows.Forms.Button btnDisplayHotels;
        private System.Windows.Forms.Button btnDisplayInventory;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_CreateHotel;
        private System.Windows.Forms.ToolStripMenuItem mnu_CreateRoomInventory;
        private System.Windows.Forms.ToolStripMenuItem mnu_DisplayHotels;
        private System.Windows.Forms.ToolStripMenuItem mnu_DisplayRoomsInventory;
    }
}

