using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CookingRecipeBookProject
{
    public partial class Form1 : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        private static MongoClient CLIENT = new MongoClient("mongodb+srv://root:root@cookingrecipecluster" +
                                                            ".wtgjt.mongodb.net/recipe_book?retryWrites=true&w=majority");

        private static IMongoDatabase DATABASE = CLIENT.GetDatabase("recipe_book");

        private static IMongoCollection<MinimizedRecipe> MINIMIZED_RECIPES =
            DATABASE.GetCollection<MinimizedRecipe>("minimized_recipes");
        
        private static List<MinimizedRecipe> FULL_MINIMIZED_RECIPE_LIST = MINIMIZED_RECIPES.AsQueryable().ToList();


        public Form1()
        {
            InitializeComponent();
            
            fillPanel("MEET", MeetFoodPanel);
            fillPanel("FISH", FishFoodPanel);
            fillPanel("DIET", DietFoodPanel);
            fillPanel("DESERT", DesertFoodPanel);
            fillPanel("USER", UserFoodPanel);
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CloseButton_MouseDown(object sender, MouseEventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Black;
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.White;
        }

        private void MinimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void NavbarPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void NavbarPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(Location.X - lastLocation.X + e.X, Location.Y - lastLocation.Y + e.Y);
                Update();
            }
        }

        private void NavbarPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (!HomeActiveStatePanel.Visible)
            {
                MeetActiveStatePanel.Visible = false;
                DietActiveStatePanel.Visible = false;
                FishActiveStatePanel.Visible = false;
                DesertActiveStatePanel.Visible = false;
                SelfRecipeActiveStatePanel.Visible = false;
                AddRecipeActiveStatePanel.Visible = false;
                HomeActiveStatePanel.Visible = true;

                MeetFoodPanel.Visible = false;
                DietFoodPanel.Visible = false;
                FishFoodPanel.Visible = false;
                DesertFoodPanel.Visible = false;
                UserFoodPanel.Visible = false;
                AddFoodPanel.Visible = false;
                HomeBodyPanel.Visible = true;
            }
        }

        private async void MeetFoodButton_Click(object sender, EventArgs e)
        {
            if (!MeetActiveStatePanel.Visible)
            {
                HomeActiveStatePanel.Visible = false;
                DietActiveStatePanel.Visible = false;
                FishActiveStatePanel.Visible = false;
                DesertActiveStatePanel.Visible = false;
                SelfRecipeActiveStatePanel.Visible = false;
                AddRecipeActiveStatePanel.Visible = false;
                MeetActiveStatePanel.Visible = true;

                DietFoodPanel.Visible = false;
                FishFoodPanel.Visible = false;
                DesertFoodPanel.Visible = false;
                UserFoodPanel.Visible = false;
                AddFoodPanel.Visible = false;
                HomeBodyPanel.Visible = false;
                MeetFoodPanel.Visible = true;
            }
        }

        private void FishButton_Click(object sender, EventArgs e)
        {
            if (!FishActiveStatePanel.Visible)
            {
                HomeActiveStatePanel.Visible = false;
                MeetActiveStatePanel.Visible = false;
                DietActiveStatePanel.Visible = false;
                DesertActiveStatePanel.Visible = false;
                SelfRecipeActiveStatePanel.Visible = false;
                AddRecipeActiveStatePanel.Visible = false;
                FishActiveStatePanel.Visible = true;

                MeetFoodPanel.Visible = false;
                DietFoodPanel.Visible = false;
                DesertFoodPanel.Visible = false;
                UserFoodPanel.Visible = false;
                AddFoodPanel.Visible = false;
                HomeBodyPanel.Visible = false;
                FishFoodPanel.Visible = true;
            }
        }

        private void DietButton_Click(object sender, EventArgs e)
        {
            if (!DietActiveStatePanel.Visible)
            {
                HomeActiveStatePanel.Visible = false;
                MeetActiveStatePanel.Visible = false;
                FishActiveStatePanel.Visible = false;
                DesertActiveStatePanel.Visible = false;
                SelfRecipeActiveStatePanel.Visible = false;
                AddRecipeActiveStatePanel.Visible = false;
                DietActiveStatePanel.Visible = true;

                MeetFoodPanel.Visible = false;
                FishFoodPanel.Visible = false;
                DesertFoodPanel.Visible = false;
                UserFoodPanel.Visible = false;
                AddFoodPanel.Visible = false;
                HomeBodyPanel.Visible = false;
                DietFoodPanel.Visible = true;
            }
        }

        private void DesertButton_Click(object sender, EventArgs e)
        {
            if (!DesertActiveStatePanel.Visible)
            {
                HomeActiveStatePanel.Visible = false;
                MeetActiveStatePanel.Visible = false;
                DietActiveStatePanel.Visible = false;
                FishActiveStatePanel.Visible = false;
                SelfRecipeActiveStatePanel.Visible = false;
                AddRecipeActiveStatePanel.Visible = false;
                DesertActiveStatePanel.Visible = true;

                MeetFoodPanel.Visible = false;
                DietFoodPanel.Visible = false;
                FishFoodPanel.Visible = false;
                UserFoodPanel.Visible = false;
                AddFoodPanel.Visible = false;
                HomeBodyPanel.Visible = false;
                DesertFoodPanel.Visible = true;
            }
        }

        private void SelfRecipeButton_Click(object sender, EventArgs e)
        {
            if (!SelfRecipeActiveStatePanel.Visible)
            {
                HomeActiveStatePanel.Visible = false;
                MeetActiveStatePanel.Visible = false;
                DietActiveStatePanel.Visible = false;
                FishActiveStatePanel.Visible = false;
                DesertActiveStatePanel.Visible = false;
                AddRecipeActiveStatePanel.Visible = false;
                SelfRecipeActiveStatePanel.Visible = true;

                MeetFoodPanel.Visible = false;
                DietFoodPanel.Visible = false;
                FishFoodPanel.Visible = false;
                DesertFoodPanel.Visible = false;
                AddFoodPanel.Visible = false;
                HomeBodyPanel.Visible = false;
                UserFoodPanel.Visible = true;
            }
        }

        private void AddRecipeButton_Click(object sender, EventArgs e)
        {
            if (!AddRecipeActiveStatePanel.Visible)
            {
                HomeActiveStatePanel.Visible = false;
                MeetActiveStatePanel.Visible = false;
                DietActiveStatePanel.Visible = false;
                FishActiveStatePanel.Visible = false;
                DesertActiveStatePanel.Visible = false;
                SelfRecipeActiveStatePanel.Visible = false;
                AddRecipeActiveStatePanel.Visible = true;
                
                MeetFoodPanel.Visible = false;
                DietFoodPanel.Visible = false;
                FishFoodPanel.Visible = false;
                DesertFoodPanel.Visible = false;
                UserFoodPanel.Visible = false;
                HomeBodyPanel.Visible = false;
                AddFoodPanel.Visible = true;
            }
        }

        private int minimizedRecipeCounter = 0;
        private Panel createMinimizedRecipe(MinimizedRecipe minimizedRecipe, int xLocation, int yLocation)
        {
            Label MinimizedRecipeTitle = new Label();
            MinimizedRecipeTitle.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            MinimizedRecipeTitle.ForeColor = Color.FromArgb(108, 76, 53);
            MinimizedRecipeTitle.Location = new Point(170, 0);
            MinimizedRecipeTitle.Name = "MinimizedRecipeTitle-" + minimizedRecipeCounter;
            MinimizedRecipeTitle.Size = new Size(399, 37);
            MinimizedRecipeTitle.Text = minimizedRecipe.Title;
            MinimizedRecipeTitle.TextAlign = ContentAlignment.MiddleLeft;

            Panel MinimizedRecipeVericalDivider = new Panel();
            MinimizedRecipeVericalDivider.BorderStyle = BorderStyle.FixedSingle;
            MinimizedRecipeVericalDivider.Dock = DockStyle.Left;
            MinimizedRecipeVericalDivider.Location = new Point(170, 0);
            MinimizedRecipeVericalDivider.Name = "VerticalDivider-" + minimizedRecipeCounter;
            MinimizedRecipeVericalDivider.Size = new Size(1, 168);
            
            Panel MinimizedRecipeHorizontalDivider = new Panel();
            MinimizedRecipeHorizontalDivider.BorderStyle = BorderStyle.FixedSingle;
            MinimizedRecipeHorizontalDivider.Location = new Point(170, 40);
            MinimizedRecipeHorizontalDivider.Name = "HorizontalDivider-" + minimizedRecipeCounter;
            MinimizedRecipeHorizontalDivider.Size = new Size(399, 1);
            
            //TODO: вставлять фотку рецепта по ссылке
            Panel minimizedRecipeImage = new Panel();
            
            var request = WebRequest.Create(minimizedRecipe.ImageUrl);

            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                minimizedRecipeImage.BackgroundImage = Bitmap.FromStream(stream);
            }
            minimizedRecipeImage.BackgroundImageLayout = ImageLayout.Stretch;
            minimizedRecipeImage.Dock = DockStyle.Left;
            minimizedRecipeImage.Location = new Point(0, 0);
            minimizedRecipeImage.Name = "Image-" + minimizedRecipeCounter;
            minimizedRecipeImage.Size = new Size(170, 168);

            Button OpenFullRecipeButton = new Button();
            OpenFullRecipeButton.FlatStyle = FlatStyle.Flat;
            OpenFullRecipeButton.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            OpenFullRecipeButton.ForeColor = Color.FromArgb(108, 76, 53);
            OpenFullRecipeButton.Location = new Point(490, 143);
            OpenFullRecipeButton.Name = "OpenFullRecipeButton-" + minimizedRecipeCounter;
            OpenFullRecipeButton.Size = new Size(75, 23);
            OpenFullRecipeButton.Text = "Далее...";
            OpenFullRecipeButton.UseCompatibleTextRendering = true;
            OpenFullRecipeButton.UseVisualStyleBackColor = true;

            Label MinimizedRecipeSummary = new Label();
            MinimizedRecipeSummary.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            MinimizedRecipeSummary.ForeColor = Color.FromArgb(108, 76, 53);
            MinimizedRecipeSummary.Location = new Point(174, 44);
            MinimizedRecipeSummary.Name = "MinimizedRecipeSummary-" + minimizedRecipeCounter;
            MinimizedRecipeSummary.Size = new Size(391, 87);
            MinimizedRecipeSummary.Text = minimizedRecipe.Summary;
            
            Panel MinimizedRecipe = new Panel();
            MinimizedRecipe.BorderStyle = BorderStyle.FixedSingle;
            MinimizedRecipe.Controls.Add(OpenFullRecipeButton);
            MinimizedRecipe.Controls.Add(MinimizedRecipeSummary);
            MinimizedRecipe.Controls.Add(MinimizedRecipeVericalDivider);
            MinimizedRecipe.Controls.Add(MinimizedRecipeHorizontalDivider);
            MinimizedRecipe.Controls.Add(minimizedRecipeImage);
            MinimizedRecipe.Controls.Add(MinimizedRecipeTitle);
            MinimizedRecipe.Location = new Point(xLocation, yLocation);
            MinimizedRecipe.Name = "MinimizedRecipe-" + minimizedRecipeCounter++;
            MinimizedRecipe.Size = new Size(570, 170);

            return MinimizedRecipe;
        }

        private void fillPanel(string category, Panel panel)
        {
            int y = 82;
            int x = 230;
            foreach (var minimizedRecipe in FULL_MINIMIZED_RECIPE_LIST)
            {
                if (category.Equals(minimizedRecipe.Category))
                {
                    var createdMinimizedRecipe = createMinimizedRecipe(minimizedRecipe, x, y);
                    y += 200;
                    panel.Controls.Add(createdMinimizedRecipe);
                }
            }
        }
    }
}