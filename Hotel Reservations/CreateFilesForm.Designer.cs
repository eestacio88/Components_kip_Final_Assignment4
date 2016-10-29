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
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CreateHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CreateRoomInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DisplayHotels = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DisplayRoomsInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.btn = new System.Windows.Forms.Button();
            this.btnCreateNewHotel = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(29, 238);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(181, 20);
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
            this.menuStrip1.Size = new System.Drawing.Size(657, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnu_CreateHotel
            // 
            this.mnu_CreateHotel.Name = "mnu_CreateHotel";
            this.mnu_CreateHotel.Size = new System.Drawing.Size(200, 22);
            this.mnu_CreateHotel.Text = "Create Hotels";
            this.mnu_CreateHotel.Click += new System.EventHandler(this.mnu_CreateHotel_Click);
            // 
            // mnu_CreateRoomInventory
            // 
            this.mnu_CreateRoomInventory.Name = "mnu_CreateRoomInventory";
            this.mnu_CreateRoomInventory.Size = new System.Drawing.Size(200, 22);
            this.mnu_CreateRoomInventory.Text = "Create Room Inventory";
            this.mnu_CreateRoomInventory.Click += new System.EventHandler(this.mnu_CreateRoomInventory_Click);
            // 
            // mnu_DisplayHotels
            // 
            this.mnu_DisplayHotels.Name = "mnu_DisplayHotels";
            this.mnu_DisplayHotels.Size = new System.Drawing.Size(200, 22);
            this.mnu_DisplayHotels.Text = "Display Hotels";
            this.mnu_DisplayHotels.Click += new System.EventHandler(this.mnu_DisplayHotels_Click);
            // 
            // mnu_DisplayRoomsInventory
            // 
            this.mnu_DisplayRoomsInventory.Name = "mnu_DisplayRoomsInventory";
            this.mnu_DisplayRoomsInventory.Size = new System.Drawing.Size(200, 22);
            this.mnu_DisplayRoomsInventory.Text = "Display Room Inventory";
            this.mnu_DisplayRoomsInventory.Click += new System.EventHandler(this.mnu_DisplayRoomsInventory_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(32, 40);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(599, 66);
            this.btn.TabIndex = 6;
            this.btn.Text = "Load Hotel File (Click this before clicking any other button)";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btnLoadHotel_Click);
            // 
            // btnCreateNewHotel
            // 
            this.btnCreateNewHotel.Location = new System.Drawing.Point(32, 130);
            this.btnCreateNewHotel.Name = "btnCreateNewHotel";
            this.btnCreateNewHotel.Size = new System.Drawing.Size(599, 68);
            this.btnCreateNewHotel.TabIndex = 7;
            this.btnCreateNewHotel.Text = "Create a list of all hotels and display them in a browser.";
            this.btnCreateNewHotel.UseVisualStyleBackColor = true;
            this.btnCreateNewHotel.Click += new System.EventHandler(this.btnCreateNewHotel_Click);
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 286);
            this.Controls.Add(this.btnCreateNewHotel);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.lblStatus);
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
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_CreateHotel;
        private System.Windows.Forms.ToolStripMenuItem mnu_CreateRoomInventory;
        private System.Windows.Forms.ToolStripMenuItem mnu_DisplayHotels;
        private System.Windows.Forms.ToolStripMenuItem mnu_DisplayRoomsInventory;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnCreateNewHotel;
    }
}

