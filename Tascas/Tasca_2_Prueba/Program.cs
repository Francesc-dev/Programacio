using Heirloom;
using Heirloom.Desktop;

namespace Tasca_2_Prueba;

class Program
{
    private static Window finestra;
    private static Mosca _mosca;
    
    static void Main()
    {
        Application.Run(() =>
        {
            finestra = new Window("La finestra", (800, 600));
            finestra.MoveToCenter();
            _mosca = new Mosca(10, 10);
            var loop = GameLoop.Create(finestra.Graphics, OnUpdate);
            loop.Start();
        });
    }

    private static void OnUpdate(GraphicsContext gfx, float dt)
    {
        var rectangleFinestra = new Rectangle(0, 0, finestra.Width, finestra.Height);
            gfx.Clear(Color.Blue);
        _mosca.Mou(rectangleFinestra);
        _mosca.Pinta(gfx);
    }
}