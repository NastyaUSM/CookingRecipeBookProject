using System.Windows.Forms;

namespace CookingRecipeBookProject
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftSidebarPanel = new System.Windows.Forms.Panel();
            this.AddRecipeActiveStatePanel = new System.Windows.Forms.Panel();
            this.AddRecipeButton = new System.Windows.Forms.Button();
            this.SelfRecipeActiveStatePanel = new System.Windows.Forms.Panel();
            this.SelfRecipeButton = new System.Windows.Forms.Button();
            this.DesertActiveStatePanel = new System.Windows.Forms.Panel();
            this.DesertButton = new System.Windows.Forms.Button();
            this.DietActiveStatePanel = new System.Windows.Forms.Panel();
            this.DietButton = new System.Windows.Forms.Button();
            this.FishActiveStatePanel = new System.Windows.Forms.Panel();
            this.FishButton = new System.Windows.Forms.Button();
            this.MeetActiveStatePanel = new System.Windows.Forms.Panel();
            this.MeetFoodButton = new System.Windows.Forms.Button();
            this.HomeActiveStatePanel = new System.Windows.Forms.Panel();
            this.HomeButton = new System.Windows.Forms.Button();
            this.BrandPanel = new System.Windows.Forms.Panel();
            this.BrandLabelButton = new System.Windows.Forms.Button();
            this.HorizontalBarPanel = new System.Windows.Forms.Panel();
            this.NavbarPanel = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.MeetFoodPanel = new System.Windows.Forms.Panel();
            this.FishFoodPanel = new System.Windows.Forms.Panel();
            this.FoodPanel = new System.Windows.Forms.Panel();
            this.DietFoodPanel = new System.Windows.Forms.Panel();
            this.DesertFoodPanel = new System.Windows.Forms.Panel();
            this.UserFoodPanel = new System.Windows.Forms.Panel();
            this.AddFoodPanel = new System.Windows.Forms.Panel();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.CuisineLabel = new System.Windows.Forms.Label();
            this.CuisineIcon = new System.Windows.Forms.Label();
            this.CuisineText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.HomeBodyPanel = new System.Windows.Forms.Panel();
            this.LeftSidebarPanel.SuspendLayout();
            this.BrandPanel.SuspendLayout();
            this.NavbarPanel.SuspendLayout();
            this.AddFoodPanel.SuspendLayout();
            this.HomeBodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftSidebarPanel
            // 
            this.LeftSidebarPanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (108)))), ((int) (((byte) (76)))), ((int) (((byte) (53)))));
            this.LeftSidebarPanel.Controls.Add(this.AddRecipeActiveStatePanel);
            this.LeftSidebarPanel.Controls.Add(this.AddRecipeButton);
            this.LeftSidebarPanel.Controls.Add(this.SelfRecipeActiveStatePanel);
            this.LeftSidebarPanel.Controls.Add(this.SelfRecipeButton);
            this.LeftSidebarPanel.Controls.Add(this.DesertActiveStatePanel);
            this.LeftSidebarPanel.Controls.Add(this.DesertButton);
            this.LeftSidebarPanel.Controls.Add(this.DietActiveStatePanel);
            this.LeftSidebarPanel.Controls.Add(this.DietButton);
            this.LeftSidebarPanel.Controls.Add(this.FishActiveStatePanel);
            this.LeftSidebarPanel.Controls.Add(this.FishButton);
            this.LeftSidebarPanel.Controls.Add(this.MeetActiveStatePanel);
            this.LeftSidebarPanel.Controls.Add(this.MeetFoodButton);
            this.LeftSidebarPanel.Controls.Add(this.HomeActiveStatePanel);
            this.LeftSidebarPanel.Controls.Add(this.HomeButton);
            this.LeftSidebarPanel.Controls.Add(this.BrandPanel);
            this.LeftSidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftSidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftSidebarPanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftSidebarPanel.Name = "LeftSidebarPanel";
            this.LeftSidebarPanel.Size = new System.Drawing.Size(279, 615);
            this.LeftSidebarPanel.TabIndex = 0;
            // 
            // AddRecipeActiveStatePanel
            // 
            this.AddRecipeActiveStatePanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.AddRecipeActiveStatePanel.Location = new System.Drawing.Point(272, 553);
            this.AddRecipeActiveStatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddRecipeActiveStatePanel.Name = "AddRecipeActiveStatePanel";
            this.AddRecipeActiveStatePanel.Size = new System.Drawing.Size(7, 59);
            this.AddRecipeActiveStatePanel.TabIndex = 14;
            this.AddRecipeActiveStatePanel.Visible = false;
            // 
            // AddRecipeButton
            // 
            this.AddRecipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddRecipeButton.FlatAppearance.BorderSize = 0;
            this.AddRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecipeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.AddRecipeButton.ForeColor = System.Drawing.Color.White;
            this.AddRecipeButton.Image = global::CookingRecipeBookProject.Properties.Resources.PlusIcon;
            this.AddRecipeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRecipeButton.Location = new System.Drawing.Point(0, 553);
            this.AddRecipeButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddRecipeButton.Name = "AddRecipeButton";
            this.AddRecipeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AddRecipeButton.Size = new System.Drawing.Size(279, 59);
            this.AddRecipeButton.TabIndex = 13;
            this.AddRecipeButton.Text = "  Добавить рецепт";
            this.AddRecipeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddRecipeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddRecipeButton.UseVisualStyleBackColor = true;
            this.AddRecipeButton.Click += new System.EventHandler(this.AddRecipeButton_Click);
            // 
            // SelfRecipeActiveStatePanel
            // 
            this.SelfRecipeActiveStatePanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.SelfRecipeActiveStatePanel.Location = new System.Drawing.Point(272, 432);
            this.SelfRecipeActiveStatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.SelfRecipeActiveStatePanel.Name = "SelfRecipeActiveStatePanel";
            this.SelfRecipeActiveStatePanel.Size = new System.Drawing.Size(7, 59);
            this.SelfRecipeActiveStatePanel.TabIndex = 12;
            this.SelfRecipeActiveStatePanel.Visible = false;
            // 
            // SelfRecipeButton
            // 
            this.SelfRecipeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SelfRecipeButton.FlatAppearance.BorderSize = 0;
            this.SelfRecipeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SelfRecipeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.SelfRecipeButton.ForeColor = System.Drawing.Color.White;
            this.SelfRecipeButton.Image = global::CookingRecipeBookProject.Properties.Resources.SelfRecipeIcon;
            this.SelfRecipeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelfRecipeButton.Location = new System.Drawing.Point(0, 432);
            this.SelfRecipeButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelfRecipeButton.Name = "SelfRecipeButton";
            this.SelfRecipeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelfRecipeButton.Size = new System.Drawing.Size(279, 59);
            this.SelfRecipeButton.TabIndex = 11;
            this.SelfRecipeButton.Text = "  Собсвтвенные\r\n  блюда";
            this.SelfRecipeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelfRecipeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelfRecipeButton.UseVisualStyleBackColor = true;
            this.SelfRecipeButton.Click += new System.EventHandler(this.SelfRecipeButton_Click);
            // 
            // DesertActiveStatePanel
            // 
            this.DesertActiveStatePanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.DesertActiveStatePanel.Location = new System.Drawing.Point(272, 366);
            this.DesertActiveStatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.DesertActiveStatePanel.Name = "DesertActiveStatePanel";
            this.DesertActiveStatePanel.Size = new System.Drawing.Size(7, 59);
            this.DesertActiveStatePanel.TabIndex = 10;
            this.DesertActiveStatePanel.Visible = false;
            // 
            // DesertButton
            // 
            this.DesertButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DesertButton.FlatAppearance.BorderSize = 0;
            this.DesertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DesertButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.DesertButton.ForeColor = System.Drawing.Color.White;
            this.DesertButton.Image = global::CookingRecipeBookProject.Properties.Resources.DesertIcon;
            this.DesertButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DesertButton.Location = new System.Drawing.Point(0, 366);
            this.DesertButton.Margin = new System.Windows.Forms.Padding(4);
            this.DesertButton.Name = "DesertButton";
            this.DesertButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DesertButton.Size = new System.Drawing.Size(279, 59);
            this.DesertButton.TabIndex = 9;
            this.DesertButton.Text = "  Десерты";
            this.DesertButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DesertButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DesertButton.UseVisualStyleBackColor = true;
            this.DesertButton.Click += new System.EventHandler(this.DesertButton_Click);
            // 
            // DietActiveStatePanel
            // 
            this.DietActiveStatePanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.DietActiveStatePanel.Location = new System.Drawing.Point(272, 299);
            this.DietActiveStatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.DietActiveStatePanel.Name = "DietActiveStatePanel";
            this.DietActiveStatePanel.Size = new System.Drawing.Size(7, 59);
            this.DietActiveStatePanel.TabIndex = 8;
            this.DietActiveStatePanel.Visible = false;
            // 
            // DietButton
            // 
            this.DietButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DietButton.FlatAppearance.BorderSize = 0;
            this.DietButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DietButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.DietButton.ForeColor = System.Drawing.Color.White;
            this.DietButton.Image = global::CookingRecipeBookProject.Properties.Resources.DietIcon;
            this.DietButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DietButton.Location = new System.Drawing.Point(0, 299);
            this.DietButton.Margin = new System.Windows.Forms.Padding(4);
            this.DietButton.Name = "DietButton";
            this.DietButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DietButton.Size = new System.Drawing.Size(279, 59);
            this.DietButton.TabIndex = 7;
            this.DietButton.Text = "  Диетич. блюда";
            this.DietButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DietButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DietButton.UseVisualStyleBackColor = true;
            this.DietButton.Click += new System.EventHandler(this.DietButton_Click);
            // 
            // FishActiveStatePanel
            // 
            this.FishActiveStatePanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.FishActiveStatePanel.Location = new System.Drawing.Point(272, 233);
            this.FishActiveStatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.FishActiveStatePanel.Name = "FishActiveStatePanel";
            this.FishActiveStatePanel.Size = new System.Drawing.Size(7, 59);
            this.FishActiveStatePanel.TabIndex = 6;
            this.FishActiveStatePanel.Visible = false;
            // 
            // FishButton
            // 
            this.FishButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FishButton.FlatAppearance.BorderSize = 0;
            this.FishButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FishButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.FishButton.ForeColor = System.Drawing.Color.White;
            this.FishButton.Image = global::CookingRecipeBookProject.Properties.Resources.FishIcon;
            this.FishButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FishButton.Location = new System.Drawing.Point(0, 233);
            this.FishButton.Margin = new System.Windows.Forms.Padding(4);
            this.FishButton.Name = "FishButton";
            this.FishButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FishButton.Size = new System.Drawing.Size(279, 59);
            this.FishButton.TabIndex = 5;
            this.FishButton.Text = "  Рыбные блюда";
            this.FishButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FishButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FishButton.UseVisualStyleBackColor = true;
            this.FishButton.Click += new System.EventHandler(this.FishButton_Click);
            // 
            // MeetActiveStatePanel
            // 
            this.MeetActiveStatePanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.MeetActiveStatePanel.Location = new System.Drawing.Point(272, 166);
            this.MeetActiveStatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.MeetActiveStatePanel.Name = "MeetActiveStatePanel";
            this.MeetActiveStatePanel.Size = new System.Drawing.Size(7, 59);
            this.MeetActiveStatePanel.TabIndex = 4;
            this.MeetActiveStatePanel.Visible = false;
            // 
            // MeetFoodButton
            // 
            this.MeetFoodButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MeetFoodButton.FlatAppearance.BorderSize = 0;
            this.MeetFoodButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeetFoodButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MeetFoodButton.ForeColor = System.Drawing.Color.White;
            this.MeetFoodButton.Image = global::CookingRecipeBookProject.Properties.Resources.MeetIcon;
            this.MeetFoodButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeetFoodButton.Location = new System.Drawing.Point(0, 166);
            this.MeetFoodButton.Margin = new System.Windows.Forms.Padding(4);
            this.MeetFoodButton.Name = "MeetFoodButton";
            this.MeetFoodButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MeetFoodButton.Size = new System.Drawing.Size(279, 59);
            this.MeetFoodButton.TabIndex = 3;
            this.MeetFoodButton.Text = "  Мясные блюда";
            this.MeetFoodButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MeetFoodButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.MeetFoodButton.UseVisualStyleBackColor = true;
            this.MeetFoodButton.Click += new System.EventHandler(this.MeetFoodButton_Click);
            // 
            // HomeActiveStatePanel
            // 
            this.HomeActiveStatePanel.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.HomeActiveStatePanel.Location = new System.Drawing.Point(272, 100);
            this.HomeActiveStatePanel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeActiveStatePanel.Name = "HomeActiveStatePanel";
            this.HomeActiveStatePanel.Size = new System.Drawing.Size(7, 59);
            this.HomeActiveStatePanel.TabIndex = 2;
            // 
            // HomeButton
            // 
            this.HomeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.HomeButton.ForeColor = System.Drawing.Color.White;
            this.HomeButton.Image = global::CookingRecipeBookProject.Properties.Resources.HomeIcon;
            this.HomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.Location = new System.Drawing.Point(0, 100);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(4);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HomeButton.Size = new System.Drawing.Size(279, 59);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "  Главная";
            this.HomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // BrandPanel
            // 
            this.BrandPanel.BackColor = System.Drawing.Color.White;
            this.BrandPanel.Controls.Add(this.BrandLabelButton);
            this.BrandPanel.Controls.Add(this.HorizontalBarPanel);
            this.BrandPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.BrandPanel.Location = new System.Drawing.Point(0, 0);
            this.BrandPanel.Margin = new System.Windows.Forms.Padding(4);
            this.BrandPanel.Name = "BrandPanel";
            this.BrandPanel.Size = new System.Drawing.Size(279, 37);
            this.BrandPanel.TabIndex = 0;
            // 
            // BrandLabelButton
            // 
            this.BrandLabelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrandLabelButton.FlatAppearance.BorderSize = 0;
            this.BrandLabelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.BrandLabelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.BrandLabelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BrandLabelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.BrandLabelButton.ForeColor = System.Drawing.Color.Coral;
            this.BrandLabelButton.Image = global::CookingRecipeBookProject.Properties.Resources.LogoIcon;
            this.BrandLabelButton.Location = new System.Drawing.Point(0, 0);
            this.BrandLabelButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrandLabelButton.Name = "BrandLabelButton";
            this.BrandLabelButton.Size = new System.Drawing.Size(278, 37);
            this.BrandLabelButton.TabIndex = 2;
            this.BrandLabelButton.Text = "COOKING BOOK";
            this.BrandLabelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BrandLabelButton.UseVisualStyleBackColor = true;
            // 
            // HorizontalBarPanel
            // 
            this.HorizontalBarPanel.BackColor = System.Drawing.Color.Silver;
            this.HorizontalBarPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.HorizontalBarPanel.Location = new System.Drawing.Point(278, 0);
            this.HorizontalBarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HorizontalBarPanel.Name = "HorizontalBarPanel";
            this.HorizontalBarPanel.Size = new System.Drawing.Size(1, 37);
            this.HorizontalBarPanel.TabIndex = 1;
            // 
            // NavbarPanel
            // 
            this.NavbarPanel.BackColor = System.Drawing.Color.White;
            this.NavbarPanel.Controls.Add(this.MinimizeButton);
            this.NavbarPanel.Controls.Add(this.CloseButton);
            this.NavbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavbarPanel.Location = new System.Drawing.Point(279, 0);
            this.NavbarPanel.Margin = new System.Windows.Forms.Padding(4);
            this.NavbarPanel.Name = "NavbarPanel";
            this.NavbarPanel.Size = new System.Drawing.Size(854, 37);
            this.NavbarPanel.TabIndex = 1;
            this.NavbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NavbarPanel_MouseDown);
            this.NavbarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NavbarPanel_MouseMove);
            this.NavbarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NavbarPanel_MouseUp);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackColor = System.Drawing.Color.Transparent;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.MinimizeButton.Location = new System.Drawing.Point(720, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(67, 37);
            this.MinimizeButton.TabIndex = 1;
            this.MinimizeButton.Text = "-";
            this.MinimizeButton.UseCompatibleTextRendering = true;
            this.MinimizeButton.UseVisualStyleBackColor = false;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.Transparent;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CloseButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (233)))), ((int) (((byte) (138)))), ((int) (((byte) (138)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (232)))), ((int) (((byte) (17)))), ((int) (((byte) (35)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CloseButton.Location = new System.Drawing.Point(787, 0);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(67, 37);
            this.CloseButton.TabIndex = 0;
            this.CloseButton.Text = "×";
            this.CloseButton.UseCompatibleTextRendering = true;
            this.CloseButton.UseVisualStyleBackColor = false;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.CloseButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CloseButton_MouseDown);
            this.CloseButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.CloseButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // MeetFoodPanel
            // 
            this.MeetFoodPanel.AutoScroll = true;
            this.MeetFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MeetFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.MeetFoodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MeetFoodPanel.Name = "MeetFoodPanel";
            this.MeetFoodPanel.Size = new System.Drawing.Size(1133, 615);
            this.MeetFoodPanel.TabIndex = 4;
            this.MeetFoodPanel.Visible = false;
            // 
            // FishFoodPanel
            // 
            this.FishFoodPanel.AutoScroll = true;
            this.FishFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FishFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.FishFoodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FishFoodPanel.Name = "FishFoodPanel";
            this.FishFoodPanel.Size = new System.Drawing.Size(1133, 615);
            this.FishFoodPanel.TabIndex = 4;
            this.FishFoodPanel.Visible = false;
            // 
            // FoodPanel
            // 
            this.FoodPanel.AutoScroll = true;
            this.FoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FoodPanel.Location = new System.Drawing.Point(0, 0);
            this.FoodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.FoodPanel.Name = "FoodPanel";
            this.FoodPanel.Size = new System.Drawing.Size(1133, 615);
            this.FoodPanel.TabIndex = 4;
            this.FoodPanel.Visible = false;
            // 
            // DietFoodPanel
            // 
            this.DietFoodPanel.AutoScroll = true;
            this.DietFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DietFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.DietFoodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DietFoodPanel.Name = "DietFoodPanel";
            this.DietFoodPanel.Size = new System.Drawing.Size(1133, 615);
            this.DietFoodPanel.TabIndex = 4;
            this.DietFoodPanel.Visible = false;
            // 
            // DesertFoodPanel
            // 
            this.DesertFoodPanel.AutoScroll = true;
            this.DesertFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DesertFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.DesertFoodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.DesertFoodPanel.Name = "DesertFoodPanel";
            this.DesertFoodPanel.Size = new System.Drawing.Size(1133, 615);
            this.DesertFoodPanel.TabIndex = 4;
            this.DesertFoodPanel.Visible = false;
            // 
            // UserFoodPanel
            // 
            this.UserFoodPanel.AutoScroll = true;
            this.UserFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.UserFoodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.UserFoodPanel.Name = "UserFoodPanel";
            this.UserFoodPanel.Size = new System.Drawing.Size(1133, 615);
            this.UserFoodPanel.TabIndex = 4;
            this.UserFoodPanel.Visible = false;
            // 
            // AddFoodPanel
            // 
            this.AddFoodPanel.AutoScroll = true;
            this.AddFoodPanel.Controls.Add(this.TitleLabel);
            this.AddFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddFoodPanel.Location = new System.Drawing.Point(0, 0);
            this.AddFoodPanel.Margin = new System.Windows.Forms.Padding(4);
            this.AddFoodPanel.Name = "AddFoodPanel";
            this.AddFoodPanel.Size = new System.Drawing.Size(1133, 615);
            this.AddFoodPanel.TabIndex = 4;
            this.AddFoodPanel.Visible = false;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Font = new System.Drawing.Font("Century Gothic", 8.861538F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.TitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (108)))), ((int) (((byte) (76)))), ((int) (((byte) (53)))));
            this.TitleLabel.Location = new System.Drawing.Point(315, 77);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(161, 23);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Название блюда";
            // 
            // CuisineLabel
            // 
            this.CuisineLabel.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CuisineLabel.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (108)))), ((int) (((byte) (76)))), ((int) (((byte) (53)))));
            this.CuisineLabel.Location = new System.Drawing.Point(563, 54);
            this.CuisineLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CuisineLabel.Name = "CuisineLabel";
            this.CuisineLabel.Size = new System.Drawing.Size(219, 46);
            this.CuisineLabel.TabIndex = 0;
            this.CuisineLabel.Text = "Кулинария";
            // 
            // CuisineIcon
            // 
            this.CuisineIcon.Image = global::CookingRecipeBookProject.Properties.Resources.ChefIcon;
            this.CuisineIcon.Location = new System.Drawing.Point(767, 38);
            this.CuisineIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CuisineIcon.Name = "CuisineIcon";
            this.CuisineIcon.Size = new System.Drawing.Size(63, 62);
            this.CuisineIcon.TabIndex = 1;
            // 
            // CuisineText
            // 
            this.CuisineText.Font = new System.Drawing.Font("Century Gothic", 8.861538F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.CuisineText.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (108)))), ((int) (((byte) (76)))), ((int) (((byte) (53)))));
            this.CuisineText.Location = new System.Drawing.Point(287, 102);
            this.CuisineText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CuisineText.Name = "CuisineText";
            this.CuisineText.Size = new System.Drawing.Size(843, 256);
            this.CuisineText.TabIndex = 2;
            this.CuisineText.Text = resources.GetString("CuisineText.Text");
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CookingRecipeBookProject.Properties.Resources.CuisineImage;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(493, 366);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(411, 235);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // HomeBodyPanel
            // 
            this.HomeBodyPanel.AutoScroll = true;
            this.HomeBodyPanel.Controls.Add(this.button1);
            this.HomeBodyPanel.Controls.Add(this.CuisineText);
            this.HomeBodyPanel.Controls.Add(this.CuisineIcon);
            this.HomeBodyPanel.Controls.Add(this.CuisineLabel);
            this.HomeBodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HomeBodyPanel.Location = new System.Drawing.Point(0, 0);
            this.HomeBodyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.HomeBodyPanel.Name = "HomeBodyPanel";
            this.HomeBodyPanel.Size = new System.Drawing.Size(1133, 615);
            this.HomeBodyPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (214)))), ((int) (((byte) (205)))), ((int) (((byte) (198)))));
            this.ClientSize = new System.Drawing.Size(1133, 615);
            this.Controls.Add(this.NavbarPanel);
            this.Controls.Add(this.LeftSidebarPanel);
            this.Controls.Add(this.FoodPanel);
            this.Controls.Add(this.AddFoodPanel);
            this.Controls.Add(this.HomeBodyPanel);
            this.Controls.Add(this.FishFoodPanel);
            this.Controls.Add(this.MeetFoodPanel);
            this.Controls.Add(this.DietFoodPanel);
            this.Controls.Add(this.DesertFoodPanel);
            this.Controls.Add(this.UserFoodPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "CookingRecipeForm";
            this.LeftSidebarPanel.ResumeLayout(false);
            this.BrandPanel.ResumeLayout(false);
            this.NavbarPanel.ResumeLayout(false);
            this.AddFoodPanel.ResumeLayout(false);
            this.HomeBodyPanel.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label TitleLabel;

        private System.Windows.Forms.Panel FoodPanel;
        private System.Windows.Forms.Panel FishFoodPanel;
        private System.Windows.Forms.Panel DietFoodPanel;
        private System.Windows.Forms.Panel DesertFoodPanel;
        private System.Windows.Forms.Panel UserFoodPanel;
        private System.Windows.Forms.Panel AddFoodPanel;
        private System.Windows.Forms.Panel MeetFoodPanel;

        private System.Windows.Forms.Button BrandLabelButton;

        private System.Windows.Forms.Panel AddRecipeActiveStatePanel;
        private System.Windows.Forms.Button AddRecipeButton;

        private System.Windows.Forms.Button SelfRecipeButton;

        private System.Windows.Forms.Panel SelfRecipeActiveStatePanel;

        private System.Windows.Forms.Panel DietActiveStatePanel;
        private System.Windows.Forms.Button DesertButton;

        private System.Windows.Forms.Panel FishActiveStatePanel;
        private System.Windows.Forms.Button DietButton;

        private System.Windows.Forms.Panel MeetActiveStatePanel;
        private System.Windows.Forms.Button FishButton;

        private System.Windows.Forms.Button MeetFoodButton;

        private System.Windows.Forms.Panel HorizontalBarPanel;

        private System.Windows.Forms.Panel HomeActiveStatePanel;

        private System.Windows.Forms.Panel DesertActiveStatePanel;

        private System.Windows.Forms.Button HomeButton;

        private System.Windows.Forms.Button MinimizeButton;
        
        private System.Windows.Forms.Button CloseButton;

        private System.Windows.Forms.Panel BrandPanel;

        private System.Windows.Forms.Panel LeftSidebarPanel;

        private System.Windows.Forms.Panel NavbarPanel;

        #endregion

        private System.Windows.Forms.Label CuisineLabel;
        private System.Windows.Forms.Label CuisineIcon;
        private System.Windows.Forms.Label CuisineText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel HomeBodyPanel;
    }
}