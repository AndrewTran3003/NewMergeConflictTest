afjkasjknsjkfjkasnfjksdnfjknfjksnfjksnfjksnfjkafnjkasnjkanjkasnfjkasdnfjkasdnusing System;
using SwinGameSDK;

namespace MyGame
{
    public class GameMain
    {
        private enum ShapeKind
        {pjiovoij ndonio fionvonfasjfiosdjfiosfjioasjfiodfjaosfosijio
            Rectangle,
            Circle,
            Linel;dA;DJDakj lkdjlkjdajnjclkncuiojdkjoiejoisjfoijdsfoijdsfojsaflkjlnclkjskfjslkjflksjflksajf;sal
        }
        public static void Main()
        {
            ShapeKind kindToAdd = ShapeKind.Circle;

            //Open the game window
            SwinGame.OpenGraphicsWindow("GameMain", 800, 600);
            //SwinGame.ShowSwinGameSplashScreen();
            Drawing myDrawing = new Drawing();
            //Run the game loop
            while (false == SwinGame.WindowCloseRequested())
            {
                //Fetch the next batch of UI interaction
                SwinGame.ProcessEvents();

                //Clear the screen and draw the framerate
                SwinGame.ClearScreen(Color.White);
                SwinGame.DrawFramerate(0, 0);

                myDrawing.Draw();
                //Draw onto the screen

                if (SwinGame.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }
                if (SwinGame.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }
                if (SwinGame.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }

                if (SwinGame.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;
                    if (kindToAdd == ShapeKind.Rectangle)
                    {
                        newShape = new Rectangle();
                    }
                    else if (kindToAdd == ShapeKind.Circle)
                    {
                        newShape = new Circle();
                    }
                    else
                    {
                        newShape = new Line();
                    }
                    newShape.X = SwinGame.MouseX();
                    newShape.Y = SwinGame.MouseY();
                    myDrawing.AddShape(newShape);


                }


                if (SwinGame.KeyTyped(KeyCode.SpaceKey))
                {
                    myDrawing.Background = SwinGame.RandomColor();
                }
                if (SwinGame.MouseClicked(MouseButton.RightButton))
                {
                    myDrawing.SelectShapesAt(SwinGame.MousePosition());
                }
                if (SwinGame.KeyTyped(KeyCode.BackspaceKey) ||
                SwinGame.KeyTyped(KeyCode.DeleteKey))
                {
                    foreach (Shape s in myDrawing.SelectedShapes)
                    {
                        myDrawing.RemoveShape(s);
                    }
                }

                SwinGame.RefreshScreen(60);
            }


        }
    }
}