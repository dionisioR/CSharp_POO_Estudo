﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_POO {
    internal class Retangulo {
        public double largura;
        public double altura;

        public double Area() {
            return largura * altura;
        }

        public double Perimetro() {
            return 2 * (largura + altura);
        }
        public double Diagonal() {
            return Math.Sqrt(Math.Pow(largura, 2) + Math.Pow(altura, 2));
        }

        public override string ToString() {
            return $"Área: {Area()} \nPerímetro: {Perimetro()} \nDiagonal: {Diagonal()}.";
        }
    }
}
