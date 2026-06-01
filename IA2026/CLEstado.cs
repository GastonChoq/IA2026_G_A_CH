using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA2026
{
    public class CLEstado
    {
        #region Campos
            private int[,] _tablero;
            private int _nivel;
            private CLEstado _padre;
        #endregion

        #region Propiedades
        public int[,] tablero 
        { 
            get => _tablero; 
            set => _tablero = value; 
        }
        public int nivel 
        { 
            get => _nivel; 
            set => _nivel = value; 
        }
        public CLEstado padre 
        { 
            get => _padre; 
            set => _padre = value; 
        }
        #endregion

        #region Constructor
        public CLEstado()
        {
            this._tablero = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                this._tablero[i, j] = 0;
            this._nivel = 0;
            this._padre = null;
        }
        public CLEstado(int p00, int p01, int p02,
                        int p10, int p11, int p12,
                        int p20, int p21, int p22
                        )
        {
            this._tablero = new int[3, 3];
            this._tablero[0, 0] = p00;
            this._tablero[1, 0] = p10;
            this._tablero[2, 0] = p20;
            this._tablero[0, 1] = p01;
            this._tablero[1, 1] = p11;
            this._tablero[2, 1] = p21;
            this._tablero[0, 2] = p02;
            this._tablero[1, 2] = p12;
            this._tablero[2, 2] = p22;
            this._nivel = 0;
            this._padre = null;
        }



        #endregion

        #region Métodos
        public List<CLEstado> GenerarHijos()
        {
            List<CLEstado> Respuesta = new List<CLEstado>();
            String pos0 = "";
            int[,] aux = new int[3, 3];
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (this._tablero[i, j] == 0)
                    {
                        pos0 = i.ToString() + j.ToString();
                    }
            CLEstado A = new CLEstado();
            switch (pos0)
            {
                case "00":
                    A = new CLEstado(this._tablero[0, 1],
                                             this._tablero[0, 0],
                                             this._tablero[0, 2],
                                             this._tablero[1, 0],
                                             this._tablero[1, 1],
                                             this._tablero[1, 2],
                                             this._tablero[2, 0],
                                             this._tablero[2, 1],
                                             this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[1, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[0, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "01":
                    A = new CLEstado(this._tablero[0, 1],
                                         this._tablero[0, 0],
                                         this._tablero[0, 2],
                                         this._tablero[1, 0],
                                         this._tablero[1, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                         this._tablero[1, 1],
                                         this._tablero[0, 2],
                                         this._tablero[1, 0],
                                         this._tablero[0, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                         this._tablero[0, 2],
                                         this._tablero[0, 1],
                                         this._tablero[1, 0],
                                         this._tablero[1, 1],
                                         this._tablero[1, 2],
                                         this._tablero[2, 0],
                                         this._tablero[2, 1],
                                         this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "02":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 2],
                                     this._tablero[0, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "10":
                    A = new CLEstado(this._tablero[0, 1],
                                     this._tablero[0, 0],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "11":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 1],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[1, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[0, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[1, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2]);

                    A.nivel = this.nivel + 1; 
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "12":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 2],
                                     this._tablero[1, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "20":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "21":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 1],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);

                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2],
                                     this._tablero[2, 1]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
                case "22":
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[2, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 1],
                                     this._tablero[1, 2]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    A = new CLEstado(this._tablero[0, 0],
                                     this._tablero[0, 1],
                                     this._tablero[0, 2],
                                     this._tablero[1, 0],
                                     this._tablero[1, 1],
                                     this._tablero[1, 2],
                                     this._tablero[2, 0],
                                     this._tablero[2, 2],
                                     this._tablero[2, 1]);
                    A.nivel = this.nivel + 1;
                    A.padre = this;
                    Respuesta.Add(A);
                    break;
            }
            return Respuesta;
        }

        public bool EsFinal()
        {
            bool res = false;
            if (_tablero[0, 0] == 1 &&
                _tablero[0, 1] == 2 &&
                _tablero[0, 2] == 3 &&
                _tablero[1, 0] == 4 &&
                _tablero[1, 1] == 5 &&
                _tablero[1, 2] == 6 &&
                _tablero[2, 0] == 7 &&
                _tablero[2, 1] == 8 &&
                _tablero[2, 2] == 0)
            {
                res = true;
            }
            return res;
        }

        public bool EsIgual(CLEstado a)
        {            
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (a.tablero[i, j] != this.tablero[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        public int H1()
        {
            int h1 = 0;
            CLEstado final = new CLEstado(
                1, 2, 3,
                8, 0, 4,
                7, 6, 5
                );

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int pieza = _tablero[i, j];


                    if (pieza != 0)
                    {

                        if (pieza != final.tablero[i, j])
                        {
                            h1++;
                        }

                    }
                }
            }

            return h1;
        }

        public int H2()
        {
            int h2 = 0;
            CLEstado final = new CLEstado(
                1, 2, 3,
                8, 0, 4,
                7, 6, 5
                );

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int pieza = _tablero[i, j];


                    if (pieza != 0)
                    {

                        int filaFinal = 0;
                        int colFinal = 0;

                        for (int f = 0; f < 3; f++)
                        {
                            for (int c = 0; c < 3; c++)
                            {
                                if (final.tablero[f, c] == pieza)
                                {
                                    filaFinal = f;
                                    colFinal = c;
                                }
                            }
                        }


                        h2 += Math.Abs(i - filaFinal) + Math.Abs(j - colFinal);
                    }
                }
            }
            return h2;
        }

        public int S()
        {

            int s = 0;


            int[,] borde = new int[8, 2]
            {
                { 0, 0 },
                { 0, 1 },
                { 0, 2 },
                { 1, 2 },
                { 2, 2 },
                { 2, 1 },
                { 2, 0 },
                { 1, 0 }
            };

            for (int pieza = 1; pieza <= 8; pieza++)
            {
                int filaPieza = -1;
                int colPieza = -1;


                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (_tablero[i, j] == pieza)
                        {
                            filaPieza = i;
                            colPieza = j;
                        }
                    }
                }


                if (filaPieza == 1 && colPieza == 1)
                {
                    s += 1;
                }
                else
                {
                    int indiceBorde = -1;


                    for (int k = 0; k < 8; k++)
                    {
                        if (borde[k, 0] == filaPieza && borde[k, 1] == colPieza)
                        {
                            indiceBorde = k;
                            break;
                        }
                    }

                    if (indiceBorde != -1)
                    {

                        int sucesorCorrecto = pieza == 8 ? 1 : pieza + 1;


                        int siguienteIndice = (indiceBorde + 1) % 8;
                        int filaSiguiente = borde[siguienteIndice, 0];
                        int colSiguiente = borde[siguienteIndice, 1];

                        int sucesorActual = _tablero[filaSiguiente, colSiguiente];

                        if (sucesorActual == sucesorCorrecto)
                        {
                            s += 0;
                        }
                        else
                        {
                            s += 2;
                        }
                    }
                }
            }


            return s;
        }

        #endregion
    }
}
