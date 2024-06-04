using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Threading;

namespace Memory
{
    public partial class GameWindow : Window
    {
        private Game game;
        private DispatcherTimer timer;
        private TimeSpan timeLeft;

        public GameWindow(Game game)
        {
            InitializeComponent();

            this.game = game;

            timeLeft = TimeSpan.FromMinutes(2);
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();

            CombineImages(game.Items);
        }

        private void CombineImages(List<Item> items)
        {
            RenderTargetBitmap renderTarget = new RenderTargetBitmap(750, 640, 96, 96, PixelFormats.Pbgra32);

            DrawingVisual drawingVisual = new DrawingVisual();

            using (DrawingContext drawingContext = drawingVisual.RenderOpen())
            {
                for (int i = 0; i < items.Count; i++)
                {
                    BitmapImage bitmap = new BitmapImage(new Uri(items[i].ItemImage, UriKind.Relative));

                    double aspectRatio = (double)bitmap.PixelWidth / bitmap.PixelHeight;
                    double width, height;

                    if (aspectRatio >= 1)
                    {
                        width = 150;
                        height = width / aspectRatio;
                    }
                    else
                    {
                        height = 150;
                        width = height * aspectRatio;
                    }

                    drawingContext.DrawImage(bitmap, new Rect(i % 5 * 150, i / 5 * 150, width, height));
                }
            }

            renderTarget.Render(drawingVisual);

            Image finalImage = new Image();
            finalImage.Source = renderTarget;
            finalImage.HorizontalAlignment = HorizontalAlignment.Center; // Center horizontally
            finalImage.VerticalAlignment = VerticalAlignment.Center; // Center vertically

            Grid.SetRow(finalImage, 1); // Ensure the image is in the correct row
            MainGrid.Children.Add(finalImage);
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
            TimerLabel.Content = timeLeft.ToString(@"mm\:ss");

            if (timeLeft.TotalSeconds <= 0)
            {
                timer.Stop();

                InputWindow inputWindow = new InputWindow(game);
                inputWindow.Show();
                Close();
            }
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            InputWindow inputWindow = new InputWindow(game);
            inputWindow.Show();
            Close();
        }
    }
}
