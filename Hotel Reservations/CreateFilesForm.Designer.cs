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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CreateHotel = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_CreateRoomInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DisplayHotels = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DisplayRoomsInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHotelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewHotelsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHotelAndInventoryFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processAllTestReservationsCreateReservationsxmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRun = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(681, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_CreateHotel,
            this.mnu_CreateRoomInventory,
            this.mnu_DisplayHotels,
            this.mnu_DisplayRoomsInventory,
            this.loadHotelsToolStripMenuItem,
            this.createNewHotelsToolStripMenuItem,
            this.loadHotelAndInventoryFilesToolStripMenuItem,
            this.processAllTestReservationsCreateReservationsxmlToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnu_CreateHotel
            // 
            this.mnu_CreateHotel.Name = "mnu_CreateHotel";
            this.mnu_CreateHotel.Size = new System.Drawing.Size(422, 26);
            this.mnu_CreateHotel.Text = "Create Hotels";
            this.mnu_CreateHotel.Click += new System.EventHandler(this.mnu_CreateHotel_Click);
            // 
            // mnu_CreateRoomInventory
            // 
            this.mnu_CreateRoomInventory.Name = "mnu_CreateRoomInventory";
            this.mnu_CreateRoomInventory.Size = new System.Drawing.Size(422, 26);
            this.mnu_CreateRoomInventory.Text = "Create Room Inventory";
            this.mnu_CreateRoomInventory.Click += new System.EventHandler(this.mnu_CreateRoomInventory_Click);
            // 
            // mnu_DisplayHotels
            // 
            this.mnu_DisplayHotels.Name = "mnu_DisplayHotels";
            this.mnu_DisplayHotels.Size = new System.Drawing.Size(422, 26);
            this.mnu_DisplayHotels.Text = "Display Hotels";
            this.mnu_DisplayHotels.Click += new System.EventHandler(this.mnu_DisplayHotels_Click);
            // 
            // mnu_DisplayRoomsInventory
            // 
            this.mnu_DisplayRoomsInventory.Name = "mnu_DisplayRoomsInventory";
            this.mnu_DisplayRoomsInventory.Size = new System.Drawing.Size(422, 26);
            this.mnu_DisplayRoomsInventory.Text = "Display Room Inventory";
            this.mnu_DisplayRoomsInventory.Click += new System.EventHandler(this.mnu_DisplayRoomsInventory_Click);
            // 
            // loadHotelsToolStripMenuItem
            // 
            this.loadHotelsToolStripMenuItem.Name = "loadHotelsToolStripMenuItem";
            this.loadHotelsToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.loadHotelsToolStripMenuItem.Text = "Load Hotels";
            this.loadHotelsToolStripMenuItem.Click += new System.EventHandler(this.loadHotelsToolStripMenuItem_Click);
            // 
            // createNewHotelsToolStripMenuItem
            // 
            this.createNewHotelsToolStripMenuItem.Name = "createNewHotelsToolStripMenuItem";
            this.createNewHotelsToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.createNewHotelsToolStripMenuItem.Text = "Create New Hotels";
            this.createNewHotelsToolStripMenuItem.Click += new System.EventHandler(this.createNewHotelsToolStripMenuItem_Click);
            // 
            // loadHotelAndInventoryFilesToolStripMenuItem
            // 
            this.loadHotelAndInventoryFilesToolStripMenuItem.Name = "loadHotelAndInventoryFilesToolStripMenuItem";
            this.loadHotelAndInventoryFilesToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.loadHotelAndInventoryFilesToolStripMenuItem.Text = "Load Hotel and Inventory files";
            // 
            // processAllTestReservationsCreateReservationsxmlToolStripMenuItem
            // 
            this.processAllTestReservationsCreateReservationsxmlToolStripMenuItem.Name = "processAllTestReservationsCreateReservationsxmlToolStripMenuItem";
            this.processAllTestReservationsCreateReservationsxmlToolStripMenuItem.Size = new System.Drawing.Size(422, 26);
            this.processAllTestReservationsCreateReservationsxmlToolStripMenuItem.Text = "Process all test reservations, create reservations.xml";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(29, 42);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(298, 45);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run Reservation Simulation";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(29, 105);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(623, 200);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Green;
            this.progressBar1.Location = new System.Drawing.Point(345, 51);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 26);
            this.progressBar1.TabIndex = 8;
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 342);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservations 1.0";
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnu_CreateHotel;
        private System.Windows.Forms.ToolStripMenuItem mnu_CreateRoomInventory;
        private System.Windows.Forms.ToolStripMenuItem mnu_DisplayHotels;
        private System.Windows.Forms.ToolStripMenuItem mnu_DisplayRoomsInventory;
        private System.Windows.Forms.ToolStripMenuItem loadHotelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewHotelsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadHotelAndInventoryFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processAllTestReservationsCreateReservationsxmlToolStripMenuItem;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

