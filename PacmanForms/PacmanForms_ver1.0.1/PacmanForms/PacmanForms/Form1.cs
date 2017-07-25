#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace PacmanForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Public Variables

        //Создание объекта класса
        public GameAppearance Game;
        //Создания массива с файлами
        public FileInfo[] Content;
        //Создание рандома для красного приведения
        public Random rndRed;
        //Создание рандома для розового приведения
        public Random rndPink;
        //Создание рандома для зеленого приведения
        public Random rndGreen;
        //Создание рандома для оранжевого приведения
        public Random rndOrange;

        #endregion

        #region Form1_Load
        /// <summary>
        /// Загрузка данных в pictureBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
        }
        #endregion

        #region Form1_KeyDown
        /// <summary>
        /// Обработчик нажатых клавиш
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            #region Keys.Down
            //При нажатии на клавишу вниз
            if (e.KeyCode == Keys.Down)
            {
                //Если нет снизу стены
                if (!Game.IsWallBottom())
                {
                    //Если снизу привидение - GameOver
                    if (Game.IsRedGhostBottom() || Game.IsPinkGhostBottom() || Game.IsGreenGhostBottom() || Game.IsOrangeGhostBottom())
                    {
                        GameOver();
                    }
                    else
                    {
                        //Если есть еда, то съесть и прибавить к очкам
                        if (Game.IsMealNear())
                        {
                            Game.EatDown();
                            Game.Apperance();
                        }
                        //Иначе просто передвинуться
                        else
                        {
                            Game.MoveDown();
                            Game.Apperance();
                        }
                    }
                }
            }
            #endregion

            #region Keys.Up
            //При нажатии на клавишу Вверх
            if (e.KeyCode == Keys.Up)
            {
                //Если сверху нет стены
                if (!Game.IsWallAbove())
                {
                    //Если сверху приведение - GameOver
                    if (Game.IsRedGhostAbove() || Game.IsPinkGhostAbove() || Game.IsGreenGhostAbove() || Game.IsOrangeGhostAbove())
                    {
                        GameOver();
                    }
                    else
                    {
                        //Если сверху еда, съесть и прибавить к очкам
                        if (Game.IsMealNear())
                        {
                            Game.EatUp();
                            Game.Apperance();
                        }
                        //Иначе просто продвинутся
                        else
                        {
                            Game.MoveUp();
                            Game.Apperance();
                        }
                    }

                }
            }
            #endregion

            #region Keys.Left
            //Если нажата клавиша влево
            if (e.KeyCode == Keys.Left)
            {
                //Если нет стены
                if (!Game.IsWallLeft())
                {
                    //Если слева приведение - GameOver
                    if (Game.IsRedGhostLeft() || Game.IsPinkGhostLeft() || Game.IsGreenGhostLeft() || Game.IsOrangeGhostLeft())
                    {
                        GameOver();
                    }
                    else
                    {
                        //Если слева еда, съесть и привать к счету
                        if (Game.IsMealNear())
                        {
                            Game.EatLeft();
                            Game.Apperance();
                        }
                        //Иначе просто передвинуться
                        else
                        {
                            Game.MoveLeft();
                            Game.Apperance();
                        }
                    }
                }
            }
            #endregion

            #region Keys.Right
            //Если нажата клавиша вправо
            if (e.KeyCode == Keys.Right)
            {
                //Если нет стены
                if (!Game.IsWallRight())
                {
                    //Если справа приведение - GameOver
                    if (Game.IsRedGhostRight() || Game.IsPinkGhostRight() || Game.IsGreenGhostRight() || Game.IsOrangeGhostRight())
                    {
                        GameOver();
                    }
                    else
                    {
                        //Если справо еда, съесть и привать к счету
                        if (Game.IsMealNear())
                        {
                            Game.EatRight();
                            Game.Apperance();
                        }
                        //Иначе просто передвинуться
                        else
                        {
                            Game.MoveRight();
                            Game.Apperance();
                        }
                    }
                }
            }
            #endregion

            #region Игра пройдена
            //Если съели всю еду - игра пройдена
            if (Game.IsMeal())
            {
                timer1.Stop();
                DialogResult result1 = MessageBox.Show("Вы прошли игру! Поздравляю! \nХотите попробовать еще раз?", "Победа!", MessageBoxButtons.YesNo);
                if (result1 == DialogResult.Yes)
                {
                    StartGame();
                }
                else
                {
                    Form1.ActiveForm.Close();
                }
            }
            #endregion

        }
        #endregion

        #region Timer
        /// <summary>
        /// Таймер для управления приведениями
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            #region Передвижения красного приведения
            
            //Создание объекта рандом для красного приведения
            rndRed = new Random();
            //Метод для рандомизации значений
            int r = rndRed.Next(4);

            //Ветвления, зависящие от значий а
            switch (r)
            {
                //При значении 0
                case 0:
                    {
                        //Если нет снизу стены или приведений
                        if (!Game.IsWallBottomRG() && !Game.IsPinkGhostBottomRG() && 
                            !Game.IsGreenGhostBottomRG() && !Game.IsOrangeGhostBottomRG())
                        {
                            //Если снизу пакман снизу-Game over
                            if (Game.IsPackmanBottomRG())
                            {
                                GameOver();
                            }
                            else
                            {
                                    //Передвижение красного приведения вниз
                                    Game.MoveDownRG();
                                    Game.Apperance();
                                
                            }
                        }
                        break;
                    }
                //При заначении 1
                case 1:
                    {
                        //Если нет сверху стены и приведений
                        if (!Game.IsWallAboveRG()&&!Game.IsPinkGhostAboveRG() && 
                            !Game.IsGreenGhostAboveRG() && !Game.IsOrangeGhostAboveRG())
                        {
                            //если пакман сверху - game over
                            if (Game.IsPackmanAboveRG())
                                GameOver();
                            else
                            {
                                //Передвижение красного приведения вверх
                                Game.MoveUpRG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При значении 2
                case 2:
                    {
                        //Если нет слева стены  и приведений
                        if (!Game.IsWallLeftRG() && !Game.IsPinkGhostLeftRG() &&
                            !Game.IsGreenGhostLeftRG() && !Game.IsOrangeGhostLeftRG())
                        {
                            //Если Пакман слева - gameover
                            if (Game.IsPackmanLeftRG())
                                GameOver();
                            else
                            {
                                //Передвижение красного приведения влево
                                Game.MoveLeftRG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При значении 3
                case 3:
                    {
                        //Если нет справа стены и приведений
                        if (!Game.IsWallRightRG() && !Game.IsPinkGhostRightRG() &&
                            !Game.IsGreenGhostRightRG() && !Game.IsOrangeGhostRightRG())
                        {
                            //Если справа пакман - gameover
                            if (Game.IsPackmanRightRG())
                                GameOver();
                            else
                            {
                                //Передвижение красного приведения вниз
                                Game.MoveRightRG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
            }
             
            #endregion 
       
            #region Передвижения розового приведения
            
            //Создание объекта рандом для розового приведения
            rndPink = new Random();
            //Метод для рандомизации значений
            int p = rndPink.Next(4);


            //Ветвления, зависящие от значий а
            switch (p)
            {
                //При значении 0
                case 0:
                    {
                        //Если нет снизу стены и приведений
                        if (!Game.IsWallBottomPG() && !Game.IsRedGhostBottomPG() &&
                            !Game.IsGreenGhostBottomPG() && !Game.IsOrangeGhostBottomPG())
                        {
                            //Если снизу пакман снизу-Game over
                            if (Game.IsPackmanBottomPG())
                            {
                                GameOver();
                            }
                            else
                            {
                                //Передвижение розового приведения вниз
                                Game.MoveDownPG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При заначении 1
                case 1:
                    {
                        //Если нет сверху стены и приведений
                        if (!Game.IsWallAbovePG() && !Game.IsRedGhostAbovePG() &&
                            !Game.IsGreenGhostAbovePG() && !Game.IsOrangeGhostAbovePG())
                        {
                            //если пакман сверху - game over
                            if (Game.IsPackmanAbovePG())
                            {
                                GameOver();
                            }
                            else
                            {
                                //Передвижение розового приведения вверх
                                Game.MoveUpPG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При значении 2
                case 2:
                    {
                        //Если нет слева стены и приведений
                        if (!Game.IsWallLeftPG() && !Game.IsRedGhostLeftPG() &&
                            !Game.IsGreenGhostLeftPG() && !Game.IsOrangeGhostLeftPG())
                        {
                            //Если Пакман слева - gameover
                            if (Game.IsPackmanLeftPG())
                                GameOver();
                            else
                            {
                                //Передвижение розового приведения влево
                                Game.MoveLeftPG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При значении 3
                case 3:
                    {
                        //Если нет справа стены и приведений
                        if (!Game.IsWallRightPG() && !Game.IsRedGhostRightPG() &&
                            !Game.IsGreenGhostRightPG() && !Game.IsOrangeGhostRightPG())
                        {
                            //Если справа пакман - gameover
                            if (Game.IsPackmanRightPG())
                                GameOver();
                            else
                            {
                                //Передвижение розового приведения вправо
                                Game.MoveRightPG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
            }
             
            #endregion 

            #region Передвижения зеленого приведения
            
            //Создание объекта рандом для зеленого приведения
            rndGreen = new Random();
            //Метод для рандомизации значений
            int g = rndGreen.Next(4);

            //Ветвления, зависящие от значий а
            switch (g)
            {
                //При значении 0
                case 0:
                    {
                        //Если нет снизу стены и приведений
                        if (!Game.IsWallBottomGG() && !Game.IsRedGhostBottomGG() &&
                            !Game.IsPinkGhostBottomGG() && !Game.IsOrangeGhostBottomGG())
                        {
                            //Если снизу пакман снизу-Game over
                            if (Game.IsPackmanBottomGG())
                            {
                                GameOver();
                            }
                            else
                            {
                                //Передвижение зеленого приведения вниз
                                Game.MoveDownGG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При заначении 1
                case 1:
                    {
                        //Если нет сверху стены и приведений
                        if (!Game.IsWallAboveGG() && !Game.IsRedGhostAboveGG() &&
                            !Game.IsPinkGhostAboveGG() && !Game.IsOrangeGhostAboveGG())
                        {
                            //если пакман сверху - game over
                            if (Game.IsPackmanAboveGG())
                            {
                                GameOver();
                            }
                            else
                            {
                                //Передвижение зеленого приведения вверх
                                Game.MoveUpGG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При значении 2
                case 2:
                    {
                        //Если нет слева стены и приведений
                        if (!Game.IsWallLeftGG() && !Game.IsRedGhostLeftGG() &&
                            !Game.IsPinkGhostLeftGG() && !Game.IsOrangeGhostLeftGG())
                        {
                            //Если Пакман слева - gameover
                            if (Game.IsPackmanLeftGG())
                                GameOver();
                            else
                            {
                                //Передвижение зеленого приведения влево
                                Game.MoveLeftGG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При значении 3
                case 3:
                    {
                        //Если нет справа стены и приведений
                        if (!Game.IsWallRightGG() && !Game.IsRedGhostRightGG() &&
                            !Game.IsPinkGhostRightGG() && !Game.IsOrangeGhostRightGG())
                        {
                            //Если справа пакман - gameover
                            if (Game.IsPackmanRightGG())
                                GameOver();
                            else
                            {
                                //Передвижение зеленого приведения вправо
                                Game.MoveRightGG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
            }
             
            #endregion 

            #region Передвижения оранжевого приведения
            
            //Создание объекта рандом для оранжевого приведения
            rndOrange = new Random();
            //Метод для рандомизации значений
            int o = rndOrange.Next(4);

            //Ветвления, зависящие от значий а
            switch (o)
            {
                //При значении 0
                case 0:
                    {
                        //Если нет снизу стены и приведений
                        if (!Game.IsWallBottomOG() && !Game.IsRedGhostBottomOG() &&
                            !Game.IsPinkGhostBottomOG() && !Game.IsGreenGhostBottomOG())
                        {
                            //Если снизу пакман снизу-Game over
                            if (Game.IsPackmanBottomOG())
                            {
                                GameOver();
                            }
                            else
                            {
                                //Передвижение оранжевого приведения вниз
                                Game.MoveDownOG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При заначении 1
                case 1:
                    {
                        //Если нет сверху стены и приведений
                        if (!Game.IsWallAboveOG() && !Game.IsRedGhostAboveOG() &&
                            !Game.IsPinkGhostAboveOG() && !Game.IsGreenGhostAboveOG())
                        {
                            //если пакман сверху - game over
                            if (Game.IsPackmanAboveOG())
                            {
                                GameOver();
                            }
                            else
                            {
                                //Передвижение оранжевого приведения вверх
                                Game.MoveUpOG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При значении 2
                case 2:
                    {
                        //Если нет слева стены и приведений
                        if (!Game.IsWallLeftOG() && !Game.IsRedGhostLeftOG() &&
                            !Game.IsPinkGhostLeftOG() && !Game.IsGreenGhostLeftOG())
                        {
                            //Если Пакман слева - gameover
                            if (Game.IsPackmanLeftOG())
                                GameOver();
                            else
                            {
                                //Передвижение оранжевого приведения влево
                                Game.MoveLeftOG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
                //При значении 3
                case 3:
                    {
                        //Если нет справа стены и приведений
                        if (!Game.IsWallRightOG() && !Game.IsRedGhostRightOG() &&
                            !Game.IsPinkGhostRightOG() && !Game.IsGreenGhostRightOG())
                        {
                            //Если справа пакман - gameover
                            if (Game.IsPackmanRightOG())
                                GameOver();
                            else
                            {
                                //Передвижение оранжевого приведения вправо
                                Game.MoveRightOG();
                                Game.Apperance();
                            }
                        }
                        break;
                    }
            }
             
            #endregion 
    
        }
        #endregion

        #region StartGame
        public void StartGame()
        {
            //Создание новой директории игры
            DirectoryInfo directory = new DirectoryInfo("Resourses");
            //Проверка: если директория не путая, берем файлы
            if (directory != null)
            {
                Content = directory.GetFiles();
            }

            //Новый объект игры
            Game = new GameAppearance(pictureBox1, Content);
            //Функция вызова содержимого игры
            Game.Apperance();
            //Запуск таймера
            timer1.Start();
        }
        #endregion

        #region GameOver
        //Завершение игры
        private void GameOver()
        {
            timer1.Stop();
            DialogResult result1 = MessageBox.Show("Вы проиграли. \nХотите начать заново?", "Game Over", MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                StartGame();
            }
            else
            {
                Form1.ActiveForm.Close();

            }
        }
        #endregion
    }
}
