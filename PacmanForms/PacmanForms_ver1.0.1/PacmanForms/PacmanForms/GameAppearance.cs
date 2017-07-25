#region Using
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
#endregion

namespace PacmanForms
{
    public class GameAppearance
    {
        #region Public Variables

        #region Пакман
        /// <summary>
        /// Позиция Пакмана (X)
        /// </summary>
        public int pacmanPositionX;
        /// <summary>
        /// Позиция Пакмана (Y)
        /// </summary>
        public int pacmanPositionY;
        #endregion

        #region Привидения
        /// <summary>
        /// Позиция Красного Привидения (X)
        /// </summary>
        public int RedPositionX;
        /// <summary>
        /// Позиция Красного приведения (Y)
        /// </summary>
        public int RedPositionY;

        /// <summary>
        /// Позиция Розового Привидения (X)
        /// </summary>
        public int PinkPositionX;
        /// <summary>
        /// Позиция Розового приведения (Y)
        /// </summary>
        public int PinkPositionY;

        /// <summary>
        /// Позиция Зеленого Привидения (X)
        /// </summary>
        public int GreenPositionX;
        /// <summary>
        /// Позиция Зеленого приведения (Y)
        /// </summary>
        public int GreenPositionY;

        /// <summary>
        /// Позиция Оранжевого Привидения (X)
        /// </summary>
        public int OrangePositionX;
        /// <summary>
        /// Позиция Оранжевого приведения (Y)
        /// </summary>
        public int OrangePositionY;
        #endregion

        #region Объекты в игре
        /// <summary>
        /// Массив объектов (0-еда, 1-препятствие, 2-пакман, 
        ///                  3-Красное приведение, 4-Розовое,
        ///                  5-Зеленое, 6-Оранжевое
        /// </summary>
        public int[,] GameObjects = { { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                      { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
                                      { 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1},
                                      { 1, 0, 1, 1, 0, 0, 0, 1, 1, 0, 1},
                                      { 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1},
                                      { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                      { 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1},
                                      { 1, 1, 0, 1, 6, 5, 4, 3, 0, 1, 1},
                                      { 1, 1, 0, 1, 1, 1, 1, 1, 0, 1, 1},
                                      { 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1},
                                      { 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1},
                                      { 1, 0, 1, 1, 0, 2, 0, 1, 1, 0, 1},
                                      { 1, 0, 1, 1, 0, 1, 0, 1, 1, 0, 1},
                                      { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1},
                                      { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
                                    };
        #endregion


        #endregion

        #region Private Variables
        /// <summary>
        /// Объект, на котором будет отображаться игра
        /// </summary>
        private PictureBox pictureBox1;
        /// <summary>
        /// Массив используемоего контента
        /// </summary>
        private FileInfo[] Content;
        #endregion

        #region Constructor
        /// <summary>
        /// Конструктор Внешнего вида в игре
        /// </summary>
        /// <param name="pictureBox1">Управляющий компоент, в котором будет отображена игра</param>
        /// <param name="Content">Используемые данные</param>
        public GameAppearance(PictureBox pictureBox1, FileInfo[] Content)
        {
            this.pictureBox1 = pictureBox1;
            this.Content = Content;
            pacmanPositionX = 11;
            pacmanPositionY = 5;
            RedPositionX = 7;
            RedPositionY = 7;
            PinkPositionX = 7;
            PinkPositionY = 6;
            GreenPositionX = 7;
            GreenPositionY = 5;
            OrangePositionX = 7;
            OrangePositionY = 4;
        }
        #endregion

        #region Вывод объектов на экран
        /// <summary>
        /// Появление объектов на экране
        /// </summary>
        public void Apperance()
        {
            //Создание области в которую будем размещать объекты
            Bitmap Images = new Bitmap(GameObjects.GetLength(0) * 60, GameObjects.GetLength(1) * 60);
            Graphics e = Graphics.FromImage(Images);
            e.Clear(SystemColors.AppWorkspace);

            Image texture = null;

            //Заполнение области объектами
            if (Content != null)
            {
                FileInfo File = Content.First();
                FileInfo Meal = Content.ElementAt(0);
                FileInfo Block = Content.ElementAt(1);
                FileInfo Pacman = Content.ElementAt(2);
                FileInfo RedGhost = Content.ElementAt(3);
                FileInfo PinkGhost = Content.ElementAt(4);
                FileInfo GreenGhost = Content.ElementAt(5);
                FileInfo OrangeGhost = Content.ElementAt(6);
                FileInfo EmptySpace = Content.ElementAt(7);
                

                //Проверка и выборка нужных объектов
                if (Meal != null && Block != null && Pacman != null &&
                    RedGhost != null && PinkGhost != null && GreenGhost != null && OrangeGhost != null && 
                    EmptySpace!=null)
                {
                    for (int x = 0; x < GameObjects.GetLength(0); x++)
                    {
                        for (int y = 0; y < GameObjects.GetLength(1); y++)
                        {
                            if (GameObjects[x, y] == 0)
                                texture = Image.FromFile(Meal.FullName);
                            if (GameObjects[x, y] == 1)
                                texture = Image.FromFile(Block.FullName);
                            if (GameObjects[x, y] == 2)
                                texture = Image.FromFile(Pacman.FullName);
                            if (GameObjects[x, y] == 3)
                                texture = Image.FromFile(RedGhost.FullName);
                            if (GameObjects[x, y] == 4)
                                texture = Image.FromFile(PinkGhost.FullName);
                            if (GameObjects[x, y] == 5)
                                texture = Image.FromFile(GreenGhost.FullName);
                            if (GameObjects[x, y] == 6)
                                texture = Image.FromFile(OrangeGhost.FullName);
                            if (GameObjects[x, y] == 7)
                                texture = Image.FromFile(EmptySpace.FullName);

                            e.DrawImage(texture, new Point(x * 60, y * 60));
                        }
                    }
                    pictureBox1.Image = Images;
                }

            }

        }
        #endregion

        #region Проверка наличия еды
        /// <summary>
        /// Проверка наличия еды на экране
        /// </summary>
        /// <returns>Выводит, если еды нет</returns>
        public bool IsMeal()
        {
            int z = 0;
            for (int x = 0; x < GameObjects.GetLength(0); x++)
            {
                for (int y = 0; y < GameObjects.GetLength(1); y++)
                {
                    //Если есть еда прибавляет значение
                    if (GameObjects[x, y] == 0)
                        z++;
                }
            }
            return (z == 0);
        }
        #endregion

        #region Проверяющие функции для Пакмана

        #region Есть ли рядом еда (IsMealNear)
        /// <summary>
        /// Есть ли рядом еда
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsMealNear()
        {
            return (GameObjects[pacmanPositionX + 1, pacmanPositionY] == 0 ||
                GameObjects[pacmanPositionX - 1, pacmanPositionY] == 0 ||
                GameObjects[pacmanPositionX, pacmanPositionY + 1] == 0 ||
                GameObjects[pacmanPositionX, pacmanPositionY - 1] == 0);
        }
        #endregion

        #region Есть ли рядом стена Снизу(IsWallBottom)
        /// <summary>
        /// Проверяет есть ли стена снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsWallBottom()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY + 1] == 1);
        }
        #endregion

        #region Есть ли рядом стена Сверху (IsWallAbove)
        /// <summary>
        /// Проверяет есть ли стена сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsWallAbove()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY - 1] == 1);
        }
        #endregion

        #region Есть ли рядом стена Слева (IsWallLeft)
        /// <summary>
        /// Проверяет есть ли стена слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsWallLeft()
        {
            return (GameObjects[pacmanPositionX - 1, pacmanPositionY] == 1);
        }
        #endregion

        #region Есть ли рядом стена Слева (IsWallRight)
        /// <summary>
        /// Проверяет есть ли стена справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsWallRight()
        {
            return (GameObjects[pacmanPositionX + 1, pacmanPositionY] == 1);
        }
        #endregion


        #region Есть ли красное приведение Снизу(IsRedGhostBottom)
        /// <summary>
        /// Проверяет есть ли красное приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostBottom()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY + 1] == 3);
        }
        #endregion

        #region Есть ли красное приведение Сверху(IsRedGhostAbove)
        /// <summary>
        /// Проверяет есть ли красное приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostAbove()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY - 1] == 3);
        }
        #endregion

        #region Есть ли красное приведение Слева(IsRedGhostLeft)
        /// <summary>
        /// Проверяет есть ли красное приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostLeft()
        {
            return (GameObjects[pacmanPositionX-1, pacmanPositionY] == 3);
        }
        #endregion

        #region Есть ли красное приведение Справа(IsRedGhostRight)
        /// <summary>
        /// Проверяет есть ли красное приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostRight()
        {
            return (GameObjects[pacmanPositionX + 1, pacmanPositionY] == 3);
        }
        #endregion

        #region Есть ли розовое приведение Снизу(IsPinkGhostBottom)
        /// <summary>
        /// Проверяет есть ли розовое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostBottom()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY + 1] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Сверху(IsPinkGhostAbove)
        /// <summary>
        /// Проверяет есть ли розовое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostAbove()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY - 1] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Слева(IsPinkGhostLeft)
        /// <summary>
        /// Проверяет есть ли розовое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostLeft()
        {
            return (GameObjects[pacmanPositionX - 1, pacmanPositionY] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Справа(IsPinkGhostRight)
        /// <summary>
        /// Проверяет есть ли розовое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostRight()
        {
            return (GameObjects[pacmanPositionX + 1, pacmanPositionY] == 4);
        }
        #endregion

        #region Есть ли зеленое приведение Снизу(IsGreenGhostBottom)
        /// <summary>
        /// Проверяет есть ли зеленое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostBottom()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY + 1] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Сверху(IsGreenGhostAbove)
        /// <summary>
        /// Проверяет есть ли зеленое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostAbove()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY - 1] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Слева(IsGreenGhostLeft)
        /// <summary>
        /// Проверяет есть ли зеленое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostLeft()
        {
            return (GameObjects[pacmanPositionX - 1, pacmanPositionY] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Справа(IsGreenGhostRight)
        /// <summary>
        /// Проверяет есть ли зеленое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostRight()
        {
            return (GameObjects[pacmanPositionX + 1, pacmanPositionY] == 5);
        }
        #endregion

        #region Есть ли оранжевое приведение Снизу(IsOrangeGhostBottom)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostBottom()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY + 1] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Сверху(IsOrangeGhostAbove)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostAbove()
        {
            return (GameObjects[pacmanPositionX, pacmanPositionY - 1] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Слева(IsOrangeGhostLeft)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostLeft()
        {
            return (GameObjects[pacmanPositionX - 1, pacmanPositionY] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Справа(IsOrangeGhostRight)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostRight()
        {
            return (GameObjects[pacmanPositionX + 1, pacmanPositionY] == 6);
        }
        #endregion

        #endregion

        #region Движение Пакмана

        #region MoveDown
        /// <summary>
        /// Движение вниз
        /// </summary>
        public void MoveDown()
        {
            int NewPosition = GameObjects[pacmanPositionX, pacmanPositionY + 1];
            GameObjects[pacmanPositionX, pacmanPositionY + 1] = GameObjects[pacmanPositionX, pacmanPositionY];
            GameObjects[pacmanPositionX, pacmanPositionY] = NewPosition;
            pacmanPositionY += 1;
        }
        #endregion

        #region MoveUp
        /// <summary>
        /// Движение вверх
        /// </summary>
        public void MoveUp()
        {
            int NewPosition = GameObjects[pacmanPositionX, pacmanPositionY - 1];
            GameObjects[pacmanPositionX, pacmanPositionY - 1] = GameObjects[pacmanPositionX, pacmanPositionY];
            GameObjects[pacmanPositionX, pacmanPositionY] = NewPosition;
            pacmanPositionY -= 1;

        }
        #endregion

        #region MoveLeft
        /// <summary>
        /// Движение Влево
        /// </summary>
        public void MoveLeft()
        {
            int NewPosition = GameObjects[pacmanPositionX - 1, pacmanPositionY];
            GameObjects[pacmanPositionX - 1, pacmanPositionY] = GameObjects[pacmanPositionX, pacmanPositionY];
            GameObjects[pacmanPositionX, pacmanPositionY] = NewPosition;
            pacmanPositionX -= 1;
        }
        #endregion

        #region MoveRight
        /// <summary>
        /// Движение Вправо
        /// </summary>
        public void MoveRight()
        {
            int NewPosition = GameObjects[pacmanPositionX + 1, pacmanPositionY];
            GameObjects[pacmanPositionX + 1, pacmanPositionY] = GameObjects[pacmanPositionX, pacmanPositionY];
            GameObjects[pacmanPositionX, pacmanPositionY] = NewPosition;
            pacmanPositionX += 1;
        }
        #endregion

        #endregion

        #region Eat

        #region EatDown
        /// <summary>
        /// Съесть шарик
        /// </summary>
        public void EatDown()
        {
            int NewPosition = GameObjects[pacmanPositionX, pacmanPositionY+1];
            GameObjects[pacmanPositionX, pacmanPositionY+1] = GameObjects[pacmanPositionX, pacmanPositionY];
            NewPosition = 7;
            GameObjects[pacmanPositionX, pacmanPositionY] = NewPosition;
            pacmanPositionY += 1;
        }
        #endregion

        #region EatUp
        /// <summary>
        /// Съесть шарик
        /// </summary>
        public void EatUp()
        {
            int NewPosition = GameObjects[pacmanPositionX, pacmanPositionY-1];
            GameObjects[pacmanPositionX, pacmanPositionY-1] = GameObjects[pacmanPositionX, pacmanPositionY];
            NewPosition = 7;
            GameObjects[pacmanPositionX, pacmanPositionY] = NewPosition;
            pacmanPositionY -= 1;
        }
        #endregion

        #region EatLeft
        /// <summary>
        /// Съесть шарик
        /// </summary>
        public void EatLeft()
        {
            int NewPosition = GameObjects[pacmanPositionX - 1, pacmanPositionY];
            GameObjects[pacmanPositionX - 1, pacmanPositionY] = GameObjects[pacmanPositionX, pacmanPositionY];
            NewPosition = 7;
            GameObjects[pacmanPositionX, pacmanPositionY] = NewPosition;
            pacmanPositionX -= 1;
        }
        #endregion

        #region EatRight
        /// <summary>
        /// Съесть шарик
        /// </summary>
        public void EatRight()
        {
            int NewPosition = GameObjects[pacmanPositionX + 1, pacmanPositionY];
            GameObjects[pacmanPositionX + 1, pacmanPositionY] = GameObjects[pacmanPositionX, pacmanPositionY];
            NewPosition = 7;
            GameObjects[pacmanPositionX, pacmanPositionY] = NewPosition;
            pacmanPositionX += 1;
        }
        #endregion


        #endregion

        #region Функции проверки для приведений

        #region Красное

        #region IsWallBottomRG
        /// <summary>
        /// Проверяет, есть ли снизу стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallBottomRG()
        {
            return (GameObjects[RedPositionX, RedPositionY + 1] == 1);
        }
        #endregion

        #region IsWallAboveRG
        /// <summary>
        /// Проверяет, есть ли сверху стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallAboveRG()
        {
            return (GameObjects[RedPositionX, RedPositionY - 1] == 1);
        }
        #endregion

        #region IsWallLeftRG
        /// <summary>
        /// Проверяет, есть ли снизу стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallLeftRG()
        {
            return (GameObjects[RedPositionX - 1, RedPositionY] == 1);
        }
        #endregion

        #region IsWallRightRG
        /// <summary>
        /// Проверяет, есть ли справа стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallRightRG()
        {
            return (GameObjects[RedPositionX + 1, RedPositionY] == 1);
        }
        #endregion

        #region IsPacmanBottom
        /// <summary>
        /// Проверка есть ли снизу пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanBottomRG()
        {
            return (GameObjects[RedPositionX, RedPositionY + 1] == 2);
        }
        #endregion

        #region IsPacmanAbove
        /// <summary>
        /// Проверка есть ли сверху пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanAboveRG()
        {
            return (GameObjects[RedPositionX, RedPositionY - 1] == 2);
        }
        #endregion

        #region IsPacmanLeft
        /// <summary>
        /// Проверка есть ли слева пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanLeftRG()
        {
            return (GameObjects[RedPositionX-1, RedPositionY] == 2);
        }
        #endregion

        #region IsPacmanRight
        /// <summary>
        /// Проверка есть ли справа пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanRightRG()
        {
            return (GameObjects[RedPositionX+1, RedPositionY] == 2);
        }
        #endregion

        #region Есть ли розовое приведение Снизу(IsPinkGhostBottomRG)
        /// <summary>
        /// Проверяет есть ли розовое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostBottomRG()
        {
            return (GameObjects[RedPositionX, RedPositionY + 1] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Сверху(IsPinkGhostAboveRG)
        /// <summary>
        /// Проверяет есть ли розовое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostAboveRG()
        {
            return (GameObjects[RedPositionX, RedPositionY - 1] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Слева(IsPinkGhostLeftRG)
        /// <summary>
        /// Проверяет есть ли розовое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostLeftRG()
        {
            return (GameObjects[RedPositionX - 1, RedPositionY] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Справа(IsPinkGhostRightRG)
        /// <summary>
        /// Проверяет есть ли розовое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostRightRG()
        {
            return (GameObjects[RedPositionX + 1, RedPositionY] == 4);
        }
        #endregion

        #region Есть ли зеленое приведение Снизу(IsGreenGhostBottomRG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostBottomRG()
        {
            return (GameObjects[RedPositionX, RedPositionY + 1] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Сверху(IsGreenGhostAboveRG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostAboveRG()
        {
            return (GameObjects[RedPositionX, RedPositionY - 1] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Слева(IsGreenGhostLeftRG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostLeftRG()
        {
            return (GameObjects[RedPositionX - 1, RedPositionY] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Справа(IsGreenGhostRightRG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostRightRG()
        {
            return (GameObjects[RedPositionX + 1, RedPositionY] == 5);
        }
        #endregion

        #region Есть ли оранжевое приведение Снизу(IsOrangeGhostBottomRG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostBottomRG()
        {
            return (GameObjects[RedPositionX, RedPositionY + 1] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Сверху(IsOrangeGhostAboveRG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostAboveRG()
        {
            return (GameObjects[RedPositionX, RedPositionY - 1] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Слева(IsOrangeGhostLeftRG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostLeftRG()
        {
            return (GameObjects[RedPositionX - 1, RedPositionY] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Справа(IsOrangeGhostRightRG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostRightRG()
        {
            return (GameObjects[RedPositionX + 1, RedPositionY] == 6);
        }
        #endregion

        #region Есть ли рядом еда (IsMealNearRG)
        /// <summary>
        /// Есть ли рядом еда
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsMealNearRG()
        {
            return (GameObjects[RedPositionX + 1, RedPositionY] == 0 ||
                GameObjects[RedPositionX - 1, RedPositionY] == 0 ||
                GameObjects[RedPositionX, RedPositionY + 1] == 0 ||
                GameObjects[RedPositionX, RedPositionY - 1] == 0);
        }
        #endregion

        #endregion

        #region Розовое

        #region IsWallBottomPG
        /// <summary>
        /// Проверяет, есть ли снизу стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallBottomPG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY + 1] == 1);
        }
        #endregion

        #region IsWallAbovePG
        /// <summary>
        /// Проверяет, есть ли сверху стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallAbovePG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY - 1] == 1);
        }
        #endregion

        #region IsWallLeftPG
        /// <summary>
        /// Проверяет, есть ли снизу стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallLeftPG()
        {
            return (GameObjects[PinkPositionX - 1, PinkPositionY] == 1);
        }
        #endregion

        #region IsWallRightPG
        /// <summary>
        /// Проверяет, есть ли справа стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallRightPG()
        {
            return (GameObjects[PinkPositionX + 1, PinkPositionY] == 1);
        }
        #endregion

        #region IsPacmanBottom
        /// <summary>
        /// Проверка есть ли снизу пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanBottomPG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY + 1] == 2);
        }
        #endregion

        #region IsPacmanAbove
        /// <summary>
        /// Проверка есть ли сверху пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanAbovePG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY - 1] == 2);
        }
        #endregion

        #region IsPacmanLeft
        /// <summary>
        /// Проверка есть ли слева пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanLeftPG()
        {
            return (GameObjects[PinkPositionX - 1, PinkPositionY] == 2);
        }
        #endregion

        #region IsPacmanRight
        /// <summary>
        /// Проверка есть ли справа пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanRightPG()
        {
            return (GameObjects[PinkPositionX + 1, PinkPositionY] == 2);
        }
        #endregion

        #region Есть ли красное приведение Снизу(IsRedGhostBottomPG)
        /// <summary>
        /// Проверяет есть ли красное приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostBottomPG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY + 1] == 3);
        }
        #endregion

        #region Есть ли красное приведение Сверху(IsRedGhostAbovePG)
        /// <summary>
        /// Проверяет есть ли красное приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostAbovePG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY - 1] == 3);
        }
        #endregion

        #region Есть ли красное приведение Слева(IsRedGhostLeftPG)
        /// <summary>
        /// Проверяет есть ли красное приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostLeftPG()
        {
            return (GameObjects[PinkPositionX - 1, PinkPositionY] == 3);
        }
        #endregion

        #region Есть ли красное приведение Справа(IsRedGhostRightPG)
        /// <summary>
        /// Проверяет есть ли красное приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostRightPG()
        {
            return (GameObjects[PinkPositionX + 1, PinkPositionY] == 3);
        }
        #endregion

        #region Есть ли зеленое приведение Снизу(IsGreenGhostBottomPG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostBottomPG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY + 1] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Сверху(IsGreenGhostAbovePG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostAbovePG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY - 1] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Слева(IsGreenGhostLeftPG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostLeftPG()
        {
            return (GameObjects[PinkPositionX - 1, PinkPositionY] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Справа(IsGreenGhostRightPG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostRightPG()
        {
            return (GameObjects[PinkPositionX + 1, PinkPositionY] == 5);
        }
        #endregion

        #region Есть ли оранжевое приведение Снизу(IsOrangeGhostBottomPG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostBottomPG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY + 1] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Сверху(IsOrangeGhostAbovePG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostAbovePG()
        {
            return (GameObjects[PinkPositionX, PinkPositionY - 1] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Слева(IsOrangeGhostLeftPG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostLeftPG()
        {
            return (GameObjects[PinkPositionX - 1, PinkPositionY] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Справа(IsOrangeGhostRightPG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostRightPG()
        {
            return (GameObjects[PinkPositionX + 1, PinkPositionY] == 6);
        }
        #endregion

        #region Есть ли рядом еда (IsMealNearPG)
        /// <summary>
        /// Есть ли рядом еда
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsMealNearPG()
        {
            return (GameObjects[PinkPositionX + 1, PinkPositionY] == 0 ||
                GameObjects[PinkPositionX - 1, PinkPositionY] == 0 ||
                GameObjects[PinkPositionX, PinkPositionY + 1] == 0 ||
                GameObjects[PinkPositionX, PinkPositionY - 1] == 0);
        }
        #endregion

        #endregion

        #region Зеленое

        #region IsWallBottomGG
        /// <summary>
        /// Проверяет, есть ли снизу стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallBottomGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY + 1] == 1);
        }
        #endregion

        #region IsWallAboveGG
        /// <summary>
        /// Проверяет, есть ли сверху стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallAboveGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY - 1] == 1);
        }
        #endregion

        #region IsWallLeftGG
        /// <summary>
        /// Проверяет, есть ли снизу стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallLeftGG()
        {
            return (GameObjects[GreenPositionX - 1, GreenPositionY] == 1);
        }
        #endregion

        #region IsWallRightGG
        /// <summary>
        /// Проверяет, есть ли справа стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallRightGG()
        {
            return (GameObjects[GreenPositionX + 1, GreenPositionY] == 1);
        }
        #endregion

        #region IsPacmanBottom
        /// <summary>
        /// Проверка есть ли снизу пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanBottomGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY + 1] == 2);
        }
        #endregion

        #region IsPacmanAbove
        /// <summary>
        /// Проверка есть ли сверху пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanAboveGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY - 1] == 2);
        }
        #endregion

        #region IsPacmanLeft
        /// <summary>
        /// Проверка есть ли слева пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanLeftGG()
        {
            return (GameObjects[GreenPositionX - 1, GreenPositionY] == 2);
        }
        #endregion

        #region IsPacmanRight
        /// <summary>
        /// Проверка есть ли справа пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanRightGG()
        {
            return (GameObjects[GreenPositionX + 1, GreenPositionY] == 2);
        }
        #endregion

        #region Есть ли красное приведение Снизу(IsRedGhostBottomGG)
        /// <summary>
        /// Проверяет есть ли красное приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostBottomGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY + 1] == 3);
        }
        #endregion

        #region Есть ли красное приведение Сверху(IsRedGhostAboveGG)
        /// <summary>
        /// Проверяет есть ли красное приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostAboveGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY - 1] == 3);
        }
        #endregion

        #region Есть ли красное приведение Слева(IsRedGhostLeftGG)
        /// <summary>
        /// Проверяет есть ли красное приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostLeftGG()
        {
            return (GameObjects[GreenPositionX - 1, GreenPositionY] == 3);
        }
        #endregion

        #region Есть ли красное приведение Справа(IsRedGhostRightGG)
        /// <summary>
        /// Проверяет есть ли красное приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostRightGG()
        {
            return (GameObjects[GreenPositionX + 1, GreenPositionY] == 3);
        }
        #endregion

        #region Есть ли розовое приведение Снизу(IsPinkGhostBottomGG)
        /// <summary>
        /// Проверяет есть ли розовое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostBottomGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY + 1] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Сверху(IsPinkGhostAboveGG)
        /// <summary>
        /// Проверяет есть ли розовое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostAboveGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY - 1] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Слева(IsPinkGhostLeftGG)
        /// <summary>
        /// Проверяет есть ли розовое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostLeftGG()
        {
            return (GameObjects[GreenPositionX - 1, GreenPositionY] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Справа(IsPinkGhostRightGG)
        /// <summary>
        /// Проверяет есть ли розовое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostRightGG()
        {
            return (GameObjects[GreenPositionX + 1, GreenPositionY] == 4);
        }
        #endregion

        #region Есть ли оранжевое приведение Снизу(IsOrangeGhostBottomGG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostBottomGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY + 1] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Сверху(IsOrangeGhostAboveGG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostAboveGG()
        {
            return (GameObjects[GreenPositionX, GreenPositionY - 1] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Слева(IsOrangeGhostLeftGG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostLeftGG()
        {
            return (GameObjects[GreenPositionX - 1, GreenPositionY] == 6);
        }
        #endregion

        #region Есть ли оранжевое приведение Справа(IsOrangeGhostRightGG)
        /// <summary>
        /// Проверяет есть ли оранжевое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsOrangeGhostRightGG()
        {
            return (GameObjects[GreenPositionX + 1, GreenPositionY] == 6);
        }
        #endregion

        #region Есть ли рядом еда (IsMealNearGG)
        /// <summary>
        /// Есть ли рядом еда
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsMealNearGG()
        {
            return (GameObjects[GreenPositionX + 1, GreenPositionY] == 0 ||
                GameObjects[GreenPositionX - 1, GreenPositionY] == 0 ||
                GameObjects[GreenPositionX, GreenPositionY + 1] == 0 ||
                GameObjects[GreenPositionX, GreenPositionY - 1] == 0);
        }
        #endregion


        #endregion

        #region Оранжевое

        #region IsWallBottomOG
        /// <summary>
        /// Проверяет, есть ли снизу стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallBottomOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY + 1] == 1);
        }
        #endregion

        #region IsWallAboveOG
        /// <summary>
        /// Проверяет, есть ли сверху стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallAboveOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY - 1] == 1);
        }
        #endregion

        #region IsWallLeftOG
        /// <summary>
        /// Проверяет, есть ли снизу стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallLeftOG()
        {
            return (GameObjects[OrangePositionX - 1, OrangePositionY] == 1);
        }
        #endregion

        #region IsWallRightOG
        /// <summary>
        /// Проверяет, есть ли справа стена
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsWallRightOG()
        {
            return (GameObjects[OrangePositionX + 1, OrangePositionY] == 1);
        }
        #endregion

        #region IsPacmanBottom
        /// <summary>
        /// Проверка есть ли снизу пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanBottomOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY + 1] == 2);
        }
        #endregion

        #region IsPacmanAbove
        /// <summary>
        /// Проверка есть ли сверху пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanAboveOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY - 1] == 2);
        }
        #endregion

        #region IsPacmanLeft
        /// <summary>
        /// Проверка есть ли слева пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanLeftOG()
        {
            return (GameObjects[OrangePositionX - 1, OrangePositionY] == 2);
        }
        #endregion

        #region IsPacmanRight
        /// <summary>
        /// Проверка есть ли справа пакман
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsPackmanRightOG()
        {
            return (GameObjects[OrangePositionX + 1, OrangePositionY] == 2);
        }
        #endregion

        #region Есть ли красное приведение Снизу(IsRedGhostBottomOG)
        /// <summary>
        /// Проверяет есть ли красное приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostBottomOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY + 1] == 3);
        }
        #endregion

        #region Есть ли красное приведение Сверху(IsRedGhostAboveOG)
        /// <summary>
        /// Проверяет есть ли красное приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostAboveOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY - 1] == 3);
        }
        #endregion

        #region Есть ли красное приведение Слева(IsRedGhostLeftOG)
        /// <summary>
        /// Проверяет есть ли красное приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostLeftOG()
        {
            return (GameObjects[OrangePositionX - 1, OrangePositionY] == 3);
        }
        #endregion

        #region Есть ли красное приведение Справа(IsRedGhostRightOG)
        /// <summary>
        /// Проверяет есть ли красное приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsRedGhostRightOG()
        {
            return (GameObjects[OrangePositionX + 1, OrangePositionY] == 3);
        }
        #endregion

        #region Есть ли розовое приведение Снизу(IsPinkGhostBottomOG)
        /// <summary>
        /// Проверяет есть ли розовое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostBottomOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY + 1] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Сверху(IsPinkGhostAboveOG)
        /// <summary>
        /// Проверяет есть ли розовое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostAboveOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY - 1] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Слева(IsPinkGhostLeftOG)
        /// <summary>
        /// Проверяет есть ли розовое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostLeftOG()
        {
            return (GameObjects[OrangePositionX - 1, OrangePositionY] == 4);
        }
        #endregion

        #region Есть ли розовое приведение Справа(IsPinkGhostRightOG)
        /// <summary>
        /// Проверяет есть ли розовое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsPinkGhostRightOG()
        {
            return (GameObjects[OrangePositionX + 1, OrangePositionY] == 4);
        }
        #endregion

        #region Есть ли зеленое приведение Снизу(IsGreenGhostBottomOG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение снизу
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostBottomOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY + 1] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Сверху(IsGreenGhostAboveOG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение сверху
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostAboveOG()
        {
            return (GameObjects[OrangePositionX, OrangePositionY - 1] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Слева(IsGreenGhostLeftOG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение слева
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostLeftOG()
        {
            return (GameObjects[OrangePositionX - 1, OrangePositionY] == 5);
        }
        #endregion

        #region Есть ли зеленое приведение Справа(IsGreenGhostRightOG)
        /// <summary>
        /// Проверяет есть ли зеленое приведение справа
        /// </summary>
        /// <returns>Возвращает,если есть</returns>
        public bool IsGreenGhostRightOG()
        {
            return (GameObjects[OrangePositionX + 1, OrangePositionY] == 5);
        }
        #endregion

        #region Есть ли рядом еда (IsMealNearOG)
        /// <summary>
        /// Есть ли рядом еда
        /// </summary>
        /// <returns>Возвращает, если есть</returns>
        public bool IsMealNearOG()
        {
            return (GameObjects[OrangePositionX + 1, OrangePositionY] == 0 ||
                GameObjects[OrangePositionX - 1, OrangePositionY] == 0 ||
                GameObjects[OrangePositionX, OrangePositionY + 1] == 0 ||
                GameObjects[OrangePositionX, OrangePositionY - 1] == 0);
        }
        #endregion

        #endregion

        #endregion

        #region Движение приведений

        #region Красное

        //Переменная для запоминания того, что было впереди
        int ObjRed = 7;

        #region MoveDownRG
        /// <summary>
        /// Движение вниз
        /// </summary>
        public void MoveDownRG()
        {
            GameObjects[RedPositionX, RedPositionY] = ObjRed;
            ObjRed = GameObjects[RedPositionX, RedPositionY + 1];
            GameObjects[RedPositionX, RedPositionY + 1]=3;
            RedPositionY += 1;
        }
        #endregion

        #region MoveUpRG
        /// <summary>
        /// Движение вверх
        /// </summary>
        
        public void MoveUpRG()
        {
            GameObjects[RedPositionX, RedPositionY] = ObjRed;
            ObjRed = GameObjects[RedPositionX, RedPositionY - 1];
            GameObjects[RedPositionX, RedPositionY - 1] = 3;
            RedPositionY -= 1;
        }
        #endregion

        #region MoveLeftRG
        /// <summary>
        /// Движение влево
        /// </summary>
        public void MoveLeftRG()
        {
            GameObjects[RedPositionX, RedPositionY] = ObjRed;
            ObjRed = GameObjects[RedPositionX-1, RedPositionY];
            GameObjects[RedPositionX-1, RedPositionY] = 3;
            RedPositionX -= 1;
        }
        #endregion

        #region MoveRightRG
        /// <summary>
        /// Движение вправо
        /// </summary>
        public void MoveRightRG()
        {
            GameObjects[RedPositionX, RedPositionY] = ObjRed;
            ObjRed = GameObjects[RedPositionX+1, RedPositionY];
            GameObjects[RedPositionX+1, RedPositionY] = 3;
            RedPositionX += 1;
        }
        #endregion

        #endregion

        #region Розовое

        //Переменная для запоминания того, что было впереди
        int ObjPink = 7;

        #region MoveDownPG
        /// <summary>
        /// Движение вниз
        /// </summary>
        public void MoveDownPG()
        {
            GameObjects[PinkPositionX, PinkPositionY] = ObjPink;
            ObjPink = GameObjects[PinkPositionX, PinkPositionY + 1];
            GameObjects[PinkPositionX, PinkPositionY + 1] = 4;
            PinkPositionY += 1;
        }
        #endregion

        #region MoveUpPG
        /// <summary>
        /// Движение вверх
        /// </summary>
        public void MoveUpPG()
        {
            GameObjects[PinkPositionX, PinkPositionY] = ObjPink;
            ObjPink = GameObjects[PinkPositionX, PinkPositionY - 1];
            GameObjects[PinkPositionX, PinkPositionY - 1] = 4;
            PinkPositionY -= 1;
        }
        #endregion

        #region MoveLeftPG
        /// <summary>
        /// Движение влево
        /// </summary>
        public void MoveLeftPG()
        {
            GameObjects[PinkPositionX, PinkPositionY] = ObjPink;
            ObjPink = GameObjects[PinkPositionX - 1, PinkPositionY];
            GameObjects[PinkPositionX - 1, PinkPositionY] = 4;
            PinkPositionX -= 1;
        }
        #endregion

        #region MoveRightPG
        /// <summary>
        /// Движение вправо
        /// </summary>
        public void MoveRightPG()
        {
            GameObjects[PinkPositionX, PinkPositionY] = ObjPink;
            ObjPink = GameObjects[PinkPositionX + 1, PinkPositionY];
            GameObjects[PinkPositionX+1, PinkPositionY] = 4;
            PinkPositionX += 1;
        }
        #endregion

        #endregion

        #region Зеленое

        //Переменная для запоминания того, что было впереди
        int ObjGreen = 7;

        #region MoveDownGG
        /// <summary>
        /// Движение вниз
        /// </summary>
        public void MoveDownGG()
        {
            GameObjects[GreenPositionX, GreenPositionY] = ObjGreen;
            ObjGreen = GameObjects[GreenPositionX, GreenPositionY + 1];
            GameObjects[GreenPositionX, GreenPositionY + 1] = 5;
            GreenPositionY += 1;
        }
        #endregion

        #region MoveUpGG
        /// <summary>
        /// Движение вверх
        /// </summary>
        public void MoveUpGG()
        {
            GameObjects[GreenPositionX, GreenPositionY] = ObjGreen;
            ObjGreen = GameObjects[GreenPositionX, GreenPositionY - 1];
            GameObjects[GreenPositionX, GreenPositionY - 1] = 5;
            GreenPositionY -= 1;
        }
        #endregion

        #region MoveLeftGG
        /// <summary>
        /// Движение влево
        /// </summary>
        public void MoveLeftGG()
        {
            GameObjects[GreenPositionX, GreenPositionY] = ObjGreen;
            ObjGreen = GameObjects[GreenPositionX - 1, GreenPositionY];
            GameObjects[GreenPositionX - 1, GreenPositionY] = 5;
            GreenPositionX -= 1;
        }
        #endregion

        #region MoveRightGG
        /// <summary>
        /// Движение вправо
        /// </summary>
        public void MoveRightGG()
        {
            GameObjects[GreenPositionX, GreenPositionY] = ObjGreen;
            ObjGreen = GameObjects[GreenPositionX + 1, GreenPositionY];
            GameObjects[GreenPositionX + 1, GreenPositionY] = 5;
            GreenPositionX += 1;
        }
        #endregion

        #endregion

        #region Оранжевое

        //Переменная для запоминания того, что было впереди
        int ObjOrange = 7;

        #region MoveDownOG
        /// <summary>
        /// Движение вниз
        /// </summary>
        public void MoveDownOG()
        {
            GameObjects[OrangePositionX, OrangePositionY] = ObjOrange;
            ObjOrange = GameObjects[OrangePositionX, OrangePositionY + 1];
            GameObjects[OrangePositionX, OrangePositionY + 1] = 6;
            OrangePositionY += 1;
        }
        #endregion

        #region MoveUpOG
        /// <summary>
        /// Движение вверх
        /// </summary>
        public void MoveUpOG()
        {
            GameObjects[OrangePositionX, OrangePositionY] = ObjOrange;
            ObjOrange = GameObjects[OrangePositionX, OrangePositionY - 1];
            GameObjects[OrangePositionX, OrangePositionY - 1] = 6;
            OrangePositionY -= 1;
        }
        #endregion

        #region MoveLeftOG
        /// <summary>
        /// Движение влево
        /// </summary>
        public void MoveLeftOG()
        {
            GameObjects[OrangePositionX, OrangePositionY] = ObjOrange;
            ObjOrange = GameObjects[OrangePositionX - 1, OrangePositionY];
            GameObjects[OrangePositionX - 1, OrangePositionY] = 6;
            OrangePositionX -= 1;
        }
        #endregion

        #region MoveRightOG
        /// <summary>
        /// Движение вправо
        /// </summary>
        public void MoveRightOG()
        {
            GameObjects[OrangePositionX, OrangePositionY] = ObjOrange;
            ObjOrange = GameObjects[OrangePositionX + 1, OrangePositionY];
            GameObjects[OrangePositionX + 1, OrangePositionY] = 6;
            OrangePositionX += 1;
        }
        #endregion

        #endregion

        #endregion
    }
}
