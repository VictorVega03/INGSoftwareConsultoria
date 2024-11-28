using System.Drawing;
using System.Windows.Forms;

public class CustomRenderer : ToolStripProfessionalRenderer
{
    protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
    {
        if (e.Item.Selected) // Cuando el elemento está seleccionado
        {
            // Fondo azul oscuro
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(30, 144, 255)), e.Item.Bounds);

            // Cambia el color del texto a blanco
            e.Item.ForeColor = Color.Black;
        }
        else
        {
            // Fondo normal
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(28, 28, 28)), e.Item.Bounds);

            // Color del texto normal (blanco)
            e.Item.ForeColor = Color.White;
        }
    }

    protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
    {
        // Personalizar el borde del ToolStrip (si lo necesitas)
        e.Graphics.DrawRectangle(new Pen(Color.FromArgb(50, 50, 50)), new Rectangle(Point.Empty, e.ToolStrip.Size - new Size(1, 1)));
    }
}
