using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;
using System.Threading;
using System.Windows.Threading;
using System.IO.IsolatedStorage;

namespace MemoryGame
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }
        ImageSource imgc1, imgc2, imgc3, imgc4, imgc5, imgc6, imgc7, imgc8, imgc9, imgc10, imgc11, imgc12, imgc13, imgc14, imgc15, imgc16, imgc17, imgc18, imgc19, imgc20, imgc21, imgc22, imgc23, imgc24, imgc25, imgc26, imgc27, imgc28, imgc29, imgc30;
        int[] r1, r2, randList; int t = 0, counter = 0,ct=0,c=0,score=0; int[] match = new int[2];
        DispatcherTimer dt = new DispatcherTimer();
        DispatcherTimer checkgame = new DispatcherTimer();
        private void PhoneApplicationPage_Loaded_1(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
             r1 = Enumerable.Range(1, 15)
                                          .Select(x => new { val = x, order = rnd.Next() })
                                          .OrderBy(i => i.order)
                                          .Select(x => x.val)
                                          .ToArray();
             r2 = Enumerable.Range(1, 15)
                                          .Select(x => new { val = x, order = rnd.Next() })
                                          .OrderBy(i => i.order)
                                          .Select(x => x.val)
                                          .ToArray();
            randList = r1.Concat(r2).ToArray();
             imgc1 = new BitmapImage(new Uri("images/" + randList[0].ToString() + ".jpg", UriKind.Relative));
             imgc2 = new BitmapImage(new Uri("images/" + randList[1].ToString() + ".jpg", UriKind.Relative));
             imgc3 = new BitmapImage(new Uri("images/" + randList[2].ToString() + ".jpg", UriKind.Relative));
             imgc4 = new BitmapImage(new Uri("images/" + randList[3].ToString() + ".jpg", UriKind.Relative));
             imgc5 = new BitmapImage(new Uri("images/" + randList[4].ToString() + ".jpg", UriKind.Relative));
             imgc6 = new BitmapImage(new Uri("images/" + randList[5].ToString() + ".jpg", UriKind.Relative));
             imgc7 = new BitmapImage(new Uri("images/" + randList[6].ToString() + ".jpg", UriKind.Relative));
             imgc8 = new BitmapImage(new Uri("images/" + randList[7].ToString() + ".jpg", UriKind.Relative));
             imgc9 = new BitmapImage(new Uri("images/" + randList[8].ToString() + ".jpg", UriKind.Relative));
             imgc10 = new BitmapImage(new Uri("images/" + randList[9].ToString() + ".jpg", UriKind.Relative));
             imgc11 = new BitmapImage(new Uri("images/" + randList[10].ToString() + ".jpg", UriKind.Relative));
             imgc12 = new BitmapImage(new Uri("images/" + randList[11].ToString() + ".jpg", UriKind.Relative));
             imgc13 = new BitmapImage(new Uri("images/" + randList[12].ToString() + ".jpg", UriKind.Relative));
             imgc14 = new BitmapImage(new Uri("images/" + randList[13].ToString() + ".jpg", UriKind.Relative));
             imgc15 = new BitmapImage(new Uri("images/" + randList[14].ToString() + ".jpg", UriKind.Relative));
             imgc16 = new BitmapImage(new Uri("images/" + randList[15].ToString() + ".jpg", UriKind.Relative));
             imgc17 = new BitmapImage(new Uri("images/" + randList[16].ToString() + ".jpg", UriKind.Relative));
             imgc18 = new BitmapImage(new Uri("images/" + randList[17].ToString() + ".jpg", UriKind.Relative));
             imgc19 = new BitmapImage(new Uri("images/" + randList[18].ToString() + ".jpg", UriKind.Relative));
             imgc20 = new BitmapImage(new Uri("images/" + randList[19].ToString() + ".jpg", UriKind.Relative));
             imgc21 = new BitmapImage(new Uri("images/" + randList[20].ToString() + ".jpg", UriKind.Relative));
             imgc22 = new BitmapImage(new Uri("images/" + randList[21].ToString() + ".jpg", UriKind.Relative));
             imgc23 = new BitmapImage(new Uri("images/" + randList[22].ToString() + ".jpg", UriKind.Relative));
             imgc24 = new BitmapImage(new Uri("images/" + randList[23].ToString() + ".jpg", UriKind.Relative));
             imgc25 = new BitmapImage(new Uri("images/" + randList[24].ToString() + ".jpg", UriKind.Relative));
             imgc26 = new BitmapImage(new Uri("images/" + randList[25].ToString() + ".jpg", UriKind.Relative));
             imgc27 = new BitmapImage(new Uri("images/" + randList[26].ToString() + ".jpg", UriKind.Relative));
             imgc28 = new BitmapImage(new Uri("images/" + randList[27].ToString() + ".jpg", UriKind.Relative));
             imgc29 = new BitmapImage(new Uri("images/" + randList[28].ToString() + ".jpg", UriKind.Relative));
             imgc30 = new BitmapImage(new Uri("images/" + randList[29].ToString() + ".jpg", UriKind.Relative));
            dt.Interval = TimeSpan.FromMilliseconds(300);
            dt.Tick += dt_Tick;
            checkgame.Interval = TimeSpan.FromMilliseconds(300);
            checkgame.Tick += checkgame_Tick;
            dt.Start();             
        }

        void dt_Tick(object sender, EventArgs e)
        {
            if (t == 0)
            {
                c1.Source = imgc1;
                c2.Source = imgc2;
                c3.Source = imgc3;
                c4.Source = imgc4;
                c17.Source = imgc17;
                c21.Source = imgc21;
                c30.Source = imgc30;
            }
            if (t == 1)
            {
                c5.Source = imgc5;
                c6.Source = imgc6;
                c7.Source = imgc7;
                c8.Source = imgc8;
                c18.Source = imgc18;
                c22.Source = imgc22;
                c29.Source = imgc29;
                c25.Source = imgc25;
            }
            if (t == 2)
            {
                c9.Source = imgc9;
                c10.Source = imgc10;
                c11.Source = imgc11;
                c12.Source = imgc12;
                c19.Source = imgc19;
                c23.Source = imgc23;
                c28.Source = imgc28;
            }
            if (t == 3)
            {
                c13.Source = imgc13;
                c14.Source = imgc14;
                c15.Source = imgc15;
                c16.Source = imgc16;
                c20.Source = imgc20;
                c24.Source = imgc24;
                c24.Source = imgc27;
                c26.Source = imgc26;
            }
            if (t == 4)
            {
                prepare();
                dt.Stop();
            }
            t++;
        }

        private void c1_Tap(object sender, GestureEventArgs e)
        {
            if (randList[0] != 31 && c != 1)
            {
                c = 1;
                c1.Source = imgc1;
                move(0);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c2_Tap(object sender, GestureEventArgs e)
        {
            if (randList[1] != 31 && c != 2)
            {
                c = 2;
                c2.Source = imgc2;
                move(1);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c3_Tap(object sender, GestureEventArgs e)
        {
            if (randList[2] != 31 && c != 3)
            {
                c = 3;
                c3.Source = imgc3;
                move(2);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c4_Tap(object sender, GestureEventArgs e)
        {
            if (randList[3] != 31 && c != 4)
            {
                c = 4;
                c4.Source = imgc4;
                move(3);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c5_Tap(object sender, GestureEventArgs e)
        {
            if (randList[4] != 31 && c != 5)
            {
                c = 5;
                c5.Source = imgc5;
                move(4);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c6_Tap(object sender, GestureEventArgs e)
        {
            if (randList[5] != 31 && c != 6)
            {
                c = 6;
                c6.Source = imgc6;
                move(5);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c7_Tap(object sender, GestureEventArgs e)
        {
            if (randList[6] != 31 && c != 7)
            {
                c = 7;
                c7.Source = imgc7;
                move(6);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c8_Tap(object sender, GestureEventArgs e)
        {
            if (randList[7] != 31 && c != 8)
            {
                c = 8;
                c8.Source = imgc8;
                move(7);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c9_Tap(object sender, GestureEventArgs e)
        {
            if (randList[8] != 31 && c != 9)
            {
                c = 9;
                c9.Source = imgc9;
                move(8);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c10_Tap(object sender, GestureEventArgs e)
        {
            if (randList[9] != 31 && c != 10)
            {
                c = 10; 
                c10.Source = imgc10;
                move(9);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c11_Tap(object sender, GestureEventArgs e)
        {
            if (randList[10] != 31 && c != 11)
            {
                c = 11;
                c11.Source = imgc11;
                move(10);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c12_Tap(object sender, GestureEventArgs e)
        {
            if (randList[11] != 31 && c != 12)
            {
                c = 12;
                c12.Source = imgc12;
                move(11);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c13_Tap(object sender, GestureEventArgs e)
        {
            if (randList[12] != 31 && c != 13)
            {
                c = 13;
                c13.Source = imgc13;
                move(12);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c14_Tap(object sender, GestureEventArgs e)
        {
            if (randList[13] != 31 && c != 14)
            {
                c = 14;
                c14.Source = imgc14;
                move(13);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c15_Tap(object sender, GestureEventArgs e)
        {
            if (randList[14] != 31 && c != 15)
            {
                c = 15;
                c15.Source = imgc15;
                move(14);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c16_Tap(object sender, GestureEventArgs e)
        {
            if (randList[15] != 31 && c != 16)
            {
                c = 16;
                c16.Source = imgc16;
                move(15);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c17_Tap(object sender, GestureEventArgs e)
        {
            if (randList[16] != 31 && c != 17)
            {
                c = 17;
                c17.Source = imgc17;
                move(16);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c18_Tap(object sender, GestureEventArgs e)
        {
            if (randList[17] != 31 && c != 18)
            {
                c = 18;
                c18.Source = imgc18;
                move(17);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c19_Tap(object sender, GestureEventArgs e)
        {
            if (randList[18] != 31 && c != 19)
            {
                c = 19;
                c19.Source = imgc19;
                move(18);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c20_Tap(object sender, GestureEventArgs e)
        {
            if (randList[19] != 31 && c != 20)
            {
                c = 20;
                c20.Source = imgc20;
                move(19);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c21_Tap(object sender, GestureEventArgs e)
        {
            if (randList[20] != 31 && c != 21)
            {
                c = 21;
                c21.Source = imgc21;
                move(20);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c22_Tap(object sender, GestureEventArgs e)
        {
            if (randList[21] != 31 && c != 22)
            {
                c = 22;
                c22.Source = imgc22;
                move(21);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c23_Tap(object sender, GestureEventArgs e)
        {
            if (randList[22] != 31 && c != 23)
            {
                c = 23;
                c23.Source = imgc23;
                move(22);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c24_Tap(object sender, GestureEventArgs e)
        {
            if (randList[23] != 31 && c != 24)
            {
                c = 24;
                c24.Source = imgc24;
                move(23);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c25_Tap(object sender, GestureEventArgs e)
        {
            if (randList[24] != 31 && c != 25)
            {
                c = 25;
                c25.Source = imgc25;
                move(24);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c26_Tap(object sender, GestureEventArgs e)
        {
            if (randList[25] != 31 && c != 26)
            {
                c = 26;
                c26.Source = imgc26;
                move(25);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c27_Tap(object sender, GestureEventArgs e)
        {
            if (randList[26] != 31 && c != 27)
            {
                c = 27;
                c27.Source = imgc27;
                move(26);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void c28_Tap(object sender, GestureEventArgs e)
        {
            if (randList[27] != 31 && c != 28)
            {
                c = 28;
                c28.Source = imgc28;
                move(27);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c29_Tap(object sender, GestureEventArgs e)
        {
            if (randList[28] != 31 && c != 29)
            {
                c = 29;
                c29.Source = imgc29;
                move(28);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }
        private void c30_Tap(object sender, GestureEventArgs e)
        {
            if (randList[29] != 31 && c != 30)
            {
                c = 30;
                c30.Source = imgc30;
                move(29);
                score++;
            }
            else
                Microsoft.Devices.VibrateController.Default.Start(TimeSpan.FromSeconds(0.2));
        }

        private void move(int r)
        {
            if (counter == 0)
            {
                match[0] = randList[r];
                counter++;
            }
            else
            {
                match[1] = randList[r];
                counter = 0;
                checkgame.Start();
            }
        }

        void checkgame_Tick(object sender, EventArgs e)
        {
            if (ct == 1)
            {
                checkGame();
                ct = 0;
                checkgame.Stop();
            }
            ct++;
        }

        private void checkGame()
        {
            int cc=0;
            if(match[0] == match[1])
            {
                for (int i = 0; i < 30; i++)
                {
                    if (randList[i] == match[0])
                        randList[i] = 31;
                }
            }
            for (int i = 0; i < 30; i++)
            {
                if (randList[i] == 31)
                    cc++;
            }
            if (cc == 30)
            {
                int cheers = 0; string msg;
                if (IsolatedStorageSettings.ApplicationSettings.Contains("score"))
                {
                    int lastScore = (int)IsolatedStorageSettings.ApplicationSettings["score"];
                    if (score < lastScore)
                    {
                        cheers = 1;
                        IsolatedStorageSettings.ApplicationSettings["score"] = score;
                    }
                }
                else
                {
                    try
                    {
                        IsolatedStorageSettings.ApplicationSettings["score"] = score;
                    }
                    catch (Exception e)
                    {
                    }
                }
                if (cheers == 1)
                    msg = "Congratulations you have new high score : ";
                else
                    msg = "You played well, you score is : ";
                MessageBoxResult mb =  MessageBox.Show(msg + score.ToString() + ". Lets play again ?", "Game Result", MessageBoxButton.OKCancel);
                if (mb == MessageBoxResult.OK)
                    NavigationService.Navigate(new Uri("/MainPage.xaml?Refresh=true", UriKind.Relative));
                else if (mb == MessageBoxResult.Cancel)
                    NavigationService.Navigate(new Uri("/Home.xaml", UriKind.Relative));
            }
            prepare();
        }

        private void prepare()
        {
            if(randList[0] < 30)
                c1.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if(randList[0] > 30)
                c1.Source = new BitmapImage(new Uri("images/" + randList[0].ToString() + ".jpg", UriKind.Relative));
            if (randList[1] < 30)
                c2.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[1] > 30)
                c2.Source = new BitmapImage(new Uri("images/" + randList[1].ToString() + ".jpg", UriKind.Relative));
            if (randList[2] < 30)
                c3.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[2] > 30)
                c3.Source = new BitmapImage(new Uri("images/" + randList[2].ToString() + ".jpg", UriKind.Relative));
            if (randList[3] < 30)
                c4.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[3] > 30)
                c4.Source = new BitmapImage(new Uri("images/" + randList[3].ToString() + ".jpg", UriKind.Relative));
            if (randList[4] < 30)
                c5.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[4] > 30)
                c5.Source = new BitmapImage(new Uri("images/" + randList[4].ToString() + ".jpg", UriKind.Relative));
            if (randList[5] < 30)
                c6.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[5] > 30)
                c6.Source = new BitmapImage(new Uri("images/" + randList[5].ToString() + ".jpg", UriKind.Relative));
            if (randList[6] < 30)
                c7.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[6] > 30)
                c7.Source = new BitmapImage(new Uri("images/" + randList[6].ToString() + ".jpg", UriKind.Relative));
            if (randList[7] < 30)
                c8.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[7] > 30)
                c8.Source = new BitmapImage(new Uri("images/" + randList[7].ToString() + ".jpg", UriKind.Relative));
            if (randList[8] < 30)
                c9.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[8] > 30)
                c9.Source = new BitmapImage(new Uri("images/" + randList[8].ToString() + ".jpg", UriKind.Relative));
            if (randList[9] < 30)
                c10.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[9] > 30)
                c10.Source = new BitmapImage(new Uri("images/" + randList[9].ToString() + ".jpg", UriKind.Relative));
            if (randList[10] < 30)
                c11.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[10] > 30)
                c11.Source = new BitmapImage(new Uri("images/" + randList[10].ToString() + ".jpg", UriKind.Relative));
            if (randList[11] < 30)
                c12.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[11] > 30)
                c12.Source = new BitmapImage(new Uri("images/" + randList[11].ToString() + ".jpg", UriKind.Relative));
            if (randList[12] < 30)
                c13.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[12] > 30)
                c13.Source = new BitmapImage(new Uri("images/" + randList[12].ToString() + ".jpg", UriKind.Relative));
            if (randList[13] < 30)
                c14.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[13] > 30)
                c14.Source = new BitmapImage(new Uri("images/" + randList[13].ToString() + ".jpg", UriKind.Relative));
            if (randList[14] < 30)
                c15.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[14] > 30)
                c15.Source = new BitmapImage(new Uri("images/" + randList[14].ToString() + ".jpg", UriKind.Relative));
            if (randList[15] < 30)
                c16.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[15] > 30)
                c16.Source = new BitmapImage(new Uri("images/" + randList[15].ToString() + ".jpg", UriKind.Relative));
            if (randList[16] < 30)
                c17.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[16] > 30)
                c17.Source = new BitmapImage(new Uri("images/" + randList[16].ToString() + ".jpg", UriKind.Relative));
            if (randList[17] < 30)
                c18.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[17] > 30)
                c18.Source = new BitmapImage(new Uri("images/" + randList[17].ToString() + ".jpg", UriKind.Relative));
            if (randList[18] < 30)
                c19.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[18] > 30)
                c19.Source = new BitmapImage(new Uri("images/" + randList[18].ToString() + ".jpg", UriKind.Relative));
            if (randList[19] < 30)
                c20.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[19] > 30)
                c20.Source = new BitmapImage(new Uri("images/" + randList[19].ToString() + ".jpg", UriKind.Relative));
            if (randList[20] < 30)
                c21.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[20] > 30)
                c21.Source = new BitmapImage(new Uri("images/" + randList[20].ToString() + ".jpg", UriKind.Relative));
            if (randList[21] < 30)
                c22.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[21] > 30)
                c22.Source = new BitmapImage(new Uri("images/" + randList[21].ToString() + ".jpg", UriKind.Relative));
            if (randList[22] < 30)
                c23.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[22] > 30)
                c23.Source = new BitmapImage(new Uri("images/" + randList[22].ToString() + ".jpg", UriKind.Relative));
            if (randList[23] < 30)
                c24.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[23] > 30)
                c24.Source = new BitmapImage(new Uri("images/" + randList[23].ToString() + ".jpg", UriKind.Relative));
            if (randList[24] < 30)
                c25.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[24] > 30)
                c25.Source = new BitmapImage(new Uri("images/" + randList[24].ToString() + ".jpg", UriKind.Relative));
            if (randList[25] < 30)
                c26.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[25] > 30)
                c26.Source = new BitmapImage(new Uri("images/" + randList[25].ToString() + ".jpg", UriKind.Relative));
            if (randList[26] < 30)
                c27.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[26] > 30)
                c27.Source = new BitmapImage(new Uri("images/" + randList[26].ToString() + ".jpg", UriKind.Relative));
            if (randList[27] < 30)
                c28.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[27] > 30)
                c28.Source = new BitmapImage(new Uri("images/" + randList[27].ToString() + ".jpg", UriKind.Relative));
            if (randList[28] < 30)
                c29.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[28] > 30)
                c29.Source = new BitmapImage(new Uri("images/" + randList[28].ToString() + ".jpg", UriKind.Relative));
            if (randList[29] < 30)
                c30.Source = new BitmapImage(new Uri("images/blank.jpg", UriKind.Relative));
            else if (randList[29] > 30)
                c30.Source = new BitmapImage(new Uri("images/" + randList[29].ToString() + ".jpg", UriKind.Relative));
        }
    }
}