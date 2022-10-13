using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Graphics3DS;

namespace Solidos_en_revolucion
{
    public partial class Form1 : Form
    {
        //Objeto de la clase graphics 2D
        Graphics g;
        //Objeto de la clase graphics 3D
        Graphics3D g3;
        //El objeto está compuesto por 13 puntos
        Point3DF[] fig = new Point3DF[13];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Ventana de form se señalan los puntos para empezar a dibujar
            //Dibujar los puntos para empezar a trazar las lineas
            fig[0] = new Point3DF(0, 30, 0); //posición en X, Y, Z --> puedne cambiar dependiendo de lo que se dibuje
            fig[1] = new Point3DF(10, 30, 0);
            fig[2] = new Point3DF(10, 25, 0);
            fig[3] = new Point3DF(8, 23, 0);
            fig[4] = new Point3DF(8, 15, 0);
            fig[5] = new Point3DF(15, 5, 0);
            fig[6] = new Point3DF(0, 100, 0);
            fig[7] = new Point3DF(0, 100, 0);
            fig[8] = new Point3DF(0, 100, 0);
            fig[9] = new Point3DF(0, 100, 0);
            fig[10] = new Point3DF(0, 100, 0);
            fig[11] = new Point3DF(0, 100, 0);
            fig[12] = new Point3DF(0, 100, 0);
        }

        private void dibujar_Paint(object sender, PaintEventArgs e)
        {//PictureBox "dibujar"
            //Intanciar el objeto de Graphics para dibujar en el pictureBox
            g = e.Graphics;
            //Efecto como burbujas en el objeto que vamos a dibujar
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g3 = new Graphics3D(g);
            //Centro la figura en el centro de la pantalla
            e.Graphics.TranslateTransform(dibujar.Width / 2, 50);
            //Variable para tomar el valor de los grados de rotación del campo numerico
            double grados_aux = 0;
            for (int i = 0; i < rotacion.Value; i++)
            {
                fig[0] = RotarXY(new Point3DF( 5, 30, 0), grados_aux, 0); //Valores para X, Y, Z--valores pueden cambiar
                fig[1] = RotarXY(new Point3DF( 15, 30, 0), grados_aux, 0);
                fig[2] = RotarXY(new Point3DF( 15, 40, 0), grados_aux, 0);
                fig[3] = RotarXY(new Point3DF( 13, 42, 0), grados_aux, 0);
                fig[4] = RotarXY(new Point3DF( 13, 65, 0), grados_aux, 0);
                fig[5] = RotarXY(new Point3DF( 22, 90, 0), grados_aux, 0);
                fig[6] = RotarXY(new Point3DF( 27, 150, 0), grados_aux, 0);
                fig[7] = RotarXY(new Point3DF( 22, 185, 0), grados_aux, 0);
                fig[8] = RotarXY(new Point3DF( 25, 205, 0), grados_aux, 0);
                fig[9] = RotarXY(new Point3DF( 27, 210, 0), grados_aux, 0);
                fig[10] = RotarXY(new Point3DF( 27, 220, 0), grados_aux, 0);
                fig[11] = RotarXY(new Point3DF( 27, 225, 0), grados_aux, 0);
                fig[12] = RotarXY(new Point3DF( 5, 23, 0), grados_aux, 0);
                g3.DrawPolygon(new Pen(Color.Green), fig); //Dibujando un poligono (botella) cono, bocina,

                grados_aux += 2; //Los grados los uamento de dos en dos para hacaer más rapido el dibujo.
            }
            //Si quiero rotar sobre el eje de las Y entonces:
            //fig[1] RotarXY(new Point3DF( 13, 30, 0), 0, grados_aux, 0);
        }
        //Método de rotación
        private Point3DF RotarXY(Point3DF p1, double ang_x, double ang_y)
        {
            //Variable queme ayudan a rotar tanto en X como en Y
            Point3DF aux = new Point3DF();
            Point3DF aux2 = new Point3DF();
            //Convertir de grados a radianes para hacer la rotación
            double grados_x = (ang_x * Math.PI) / 180;
            double grados_y = (ang_y * Math.PI) / 180;

            //Rotacion y
            aux.X = Convert.ToSingle(p1.X * Math.Cos(grados_x) - p1.Z * Math.Sin(grados_x));
            aux.Y = p1.Y;
            aux.Z = Convert.ToSingle(p1.Z * Math.Cos(grados_x) + p1.X * Math.Sin(grados_x));
            //Rotación x
            aux2.X = aux.X;
            aux2.Y = Convert.ToSingle(aux.Y * Math.Cos(grados_y) - aux.Z * Math.Sin(grados_y));
            aux2.Z = Convert.ToSingle(aux.Z * Math.Cos(grados_y) + aux.Y * Math.Sin(grados_y));

            return aux2;
        }

        private void rotacion_ValueChanged(object sender, EventArgs e)
        {
            dibujar.Refresh();
        }
    }
}
