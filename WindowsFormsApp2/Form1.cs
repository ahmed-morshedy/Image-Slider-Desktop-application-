using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ImageSlideShowApp
{
    public partial class Form1 : Form
    {
        // List to store the paths of images
        private List<string> imagePaths;
        private int currentIndex = 0;

        public Form1()
        {
            InitializeComponent();
            LoadImages();
            ShowImage();
        }

        private void LoadImages()
        {
            // Use the "images" folder within the project's output directory
            string imagesFolder = System.IO.Path.Combine(Application.StartupPath, "images");

            // Initialize the list with the paths to the images in the "images" folder
            imagePaths = new List<string>
    {
        System.IO.Path.Combine(imagesFolder, "1729514005359-543649132.jpg"),
        System.IO.Path.Combine(imagesFolder, "1729513941011-75960478.jpg"),
        System.IO.Path.Combine(imagesFolder, "1729514161955-940403391.jpg"),
        System.IO.Path.Combine(imagesFolder, "1729514244552-890562009.jpg"),
        System.IO.Path.Combine(imagesFolder, "1729514327995-438255237.jpg"),
       
        // Add more image filenames as needed
    };
        }

        private void ShowImage()
        {
            if (imagePaths.Count > 0)
            {
                try
                {
                    pictureBox1.ImageLocation = imagePaths[currentIndex];
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message, "Image Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                currentIndex--;
                if (currentIndex < 0)
                {
                    currentIndex = imagePaths.Count - 1; // Loop back to the last image
                }
                ShowImage();
            }
        }

      
        private void btnNext_Click_1(object sender, EventArgs e)
        {
            if (imagePaths.Count > 0)
            {
                currentIndex++;
                if (currentIndex >= imagePaths.Count)
                {
                    currentIndex = 0; // Loop back to the first image
                }
                ShowImage();
            }

        }
    }
}
