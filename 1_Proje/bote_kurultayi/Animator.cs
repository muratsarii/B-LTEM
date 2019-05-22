using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bote_kurultayi
{
    class Animator
    {
            public bool isActive = false;
            public Animator()
            {

            }

            public void activeRipple(Button context, Color rippleColor)
            {
                if (isActive == false)
                {
                    Graphics grap = context.CreateGraphics();
                    Color defaultColor = context.BackColor;

                    Thread thread = new Thread(new ThreadStart(new Action(() =>
                    {
                        int x = 0;
                        while (x < context.Width + 100 || x < context.Height + 100)
                        {
                            x = x + 2;
                            grap.DrawEllipse(new Pen(new SolidBrush(rippleColor)),
                                new Rectangle((context.Width / 2) - (x / 2),
                                (context.Height / 2) - (x / 2), x, x));

                            grap.FillEllipse(new SolidBrush(rippleColor),
                                new Rectangle((context.Width / 2) - (x / 2),
                                (context.Height / 2) - (x / 2), x, x));
                            Thread.Sleep(1);
                        }

                        grap.Clear(defaultColor);
                        context.BackColor = rippleColor;

                        Thread.Sleep(300);

                        changeColor(defaultColor, context);
                    })));
                    thread.Start();
                }
            }

            public void changeColor(Color color, Control context)
            {
                int blue = color.B;
                int green = color.G;
                int red = color.R;

                Thread thread = new Thread(new ThreadStart(new Action(() =>
                {
                    while (context.BackColor.G != green || context.BackColor.B != blue || context.BackColor.R != red)
                    {
                        if (green > context.BackColor.G)
                        {
                            context.BackColor = Color.FromArgb(context.BackColor.A, context.BackColor.R, context.BackColor.G + 1, context.BackColor.B);
                        }
                        else if (green < context.BackColor.G)
                        {
                            context.BackColor = Color.FromArgb(context.BackColor.A, context.BackColor.R, context.BackColor.G - 1, context.BackColor.B);
                        }

                        if (blue > context.BackColor.B)
                        {
                            context.BackColor = Color.FromArgb(context.BackColor.A, context.BackColor.R, context.BackColor.G, context.BackColor.B + 1);
                        }
                        else if (blue < context.BackColor.B)
                        {
                            context.BackColor = Color.FromArgb(context.BackColor.A, context.BackColor.R, context.BackColor.G, context.BackColor.B - 1);
                        }

                        if (red > context.BackColor.R)
                        {
                            context.BackColor = Color.FromArgb(context.BackColor.A, context.BackColor.R + 1, context.BackColor.G, context.BackColor.B);
                        }
                        else if (red < context.BackColor.R)
                        {
                            context.BackColor = Color.FromArgb(context.BackColor.A, context.BackColor.R - 1, context.BackColor.G, context.BackColor.B);
                        }
                        Thread.Sleep(2);
                    }
                })));
                thread.Start();

                isActive = false;
            }
        }
    }
