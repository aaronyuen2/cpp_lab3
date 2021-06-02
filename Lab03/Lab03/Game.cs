using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace Lab03
{
    class Game
    {
        GameWindow window;

        public Game(GameWindow window)
        {
            this.window = window;
            start();
        }

        void start()
        {
            window.Load += loaded;

            window.Resize += resize;
            window.RenderFrame += renderF;

            window.Run(1.0 / 60.0);
        }

        void resize(object ob, EventArgs e)
        {
            GL.Viewport(0, 0, window.Width, window.Height);
            GL.MatrixMode(MatrixMode.Projection);
            GL.LoadIdentity();
            GL.Ortho(0, 50, 0, 50, -1, 1);  // left, right, bottom, top, near, far
            GL.MatrixMode(MatrixMode.Modelview);
        }

        void renderF(object o, EventArgs e)
        {
            GL.Clear(ClearBufferMask.ColorBufferBit);

            GL.Begin(BeginMode.Triangles);
            GL.Vertex2(1, 1);
            GL.Vertex2(49, 1);
            GL.Vertex2(25, 49);
            GL.End();

            //GL.Begin(BeginMode.Quads);
            //GL.Color3(1.0f, 0.5f, 1.0f);
            //GL.Vertex2(1, 5);
            //GL.Vertex2(1, 10);
            //GL.Vertex2(49, 15);
            //GL.Vertex2(49, 10);
            //GL.End();

            //GL.Begin(BeginMode.Quads);
            //GL.Color3(1.0f, 0.5f, 1.0f);
            //GL.Vertex2(1, 25);
            //GL.Vertex2(1, 30);
            //GL.Vertex2(49, 25);
            //GL.Vertex2(49, 20);
            //GL.End();

            //GL.Begin(BeginMode.Quads);
            //GL.Color3(1.0f, 0.5f, 1.0f);
            //GL.Vertex2(1, 30);
            //GL.Vertex2(1, 35);
            //GL.Vertex2(49, 45);
            //GL.Vertex2(49, 40);
            //GL.End();
            
            //GL.Begin(BeginMode.Triangles);
            //GL.Color3(0.0f, 0.0f, 1.0f);
            //GL.Vertex2(25, 65);
            //GL.Vertex2(29, 56.5);
            //GL.Vertex2(18, 50);
            //GL.End();

            //GL.Begin(BeginMode.Triangles);
            //GL.Color3(1.0f, 0.0f, 0.0f);
            //GL.Vertex2(25, 65);
            //GL.Vertex2(21, 56.5);
            //GL.Vertex2(32, 50);
            //GL.End();

            //GL.Begin(BeginMode.Triangles);
            //GL.Color3(0.0f, 1.0f, 0.0f);
            //GL.Vertex2(15, 60);
            //GL.Vertex2(35, 60);
            //GL.Vertex2(25, 54);
            //GL.End();

            window.SwapBuffers();

            
        }

        void loaded(object o,EventArgs e)
        {
            GL.ClearColor(0.0f, 0.0f, 0.0f, 0.0f);
        }
    }
}
