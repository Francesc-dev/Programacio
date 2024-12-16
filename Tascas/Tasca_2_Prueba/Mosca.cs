using Heirloom;
using Heirloom.Desktop;

namespace Tasca_2_Prueba;

public class Mosca
{
    private Image _imatge;
    private Vector posicio;
    private int velocitat;

    public Mosca(int x, int y)
    {
        _imatge = new Image("imatges/mosca.png");
        velocitat = 100;
        posicio = new Vector(x, y);
    }

    public void Pinta(GraphicsContext gfx)
    {
        gfx.DrawImage(_imatge, posicio);

    }

    public void Mou(Rectangle finestra)
    {
        var novaPosicio = new Rectangle(posicio, _imatge.Size);
        if(Input.CheckKey(Key.A, ButtonState.Down))
        {
            novaPosicio.X -= velocitat;
        }
        
        if(Input.CheckKey(Key.D, ButtonState.Down))
        {
            novaPosicio.X += velocitat;
        }
        
        if(Input.CheckKey(Key.W, ButtonState.Down))
        {
            novaPosicio.Y -= velocitat;
        }
        
        if(Input.CheckKey(Key.S, ButtonState.Down))
        {
            angle += velocitat;
        }
        
        if(Input.CheckKey(Key.Left, ButtonState.Down))
        {
            angle -= velocitat;
        }
        
        if(Input.CheckKey(Key.Right, ButtonState.Down))
        {
            novaPosicio. += velocitat;
        }
        
        if (finestra.Contains(novaPosicio))
        {
            posicio.X = novaPosicio.X;
            posicio.Y = novaPosicio.Y;
        }
    }
}