using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.modelo
{
    public class Automovil
    {

        private int NumeroChasis;
        private string Marca;
        private string Tipo;
        private string Capacidad;
        private int Kilometraje;
        private string Color;
        private int Velocidad;
        private bool on_off;
        private bool Pintado;
        private bool Disponible;

        public Automovil() { }

        public Automovil(int NumeroChasis, string Marca, string Tipo, string Capacidad, int Kilometraje, string Color, int Velocidad, bool on_off, bool pintado,bool disponible)
        {
            this.NumeroChasis = NumeroChasis;
            this.Marca = Marca;
            this.Tipo = Tipo;
            this.Capacidad = Capacidad;
            this.Kilometraje = Kilometraje;
            this.Color = Color;
            this.Velocidad = Velocidad;
            this.on_off = on_off;
            this.Pintado = pintado;
            this.Disponible = disponible;
        }
        public int getNchasis() //get
        {
            return this.NumeroChasis;
        }
        public void setNchasis(int NumeroChasis) //set
        {
            this.NumeroChasis = NumeroChasis;
        }
        public string getMarca() { return this.Marca; }//get
        public void setMarca(string Marca) { this.Marca = Marca; }//set
        public string tipo() { return this.Tipo; }
        public void setTipo(string Tipo) { this.Tipo = Tipo; }
        public string capacidad() { return this.Capacidad; }
        public void setCapacidad(string capacidad) { this.Capacidad = capacidad; }
        public int getKilometraje() { return this.Kilometraje; }
        public void setKilometraje(int kilometraje) { this.Kilometraje = kilometraje; }
        public string getColor() { return this.Color; }
        public void setColor(string Color) { this.Color = Color; }
        public int getVelocidad() { return this.Velocidad; }
        public void setVelocidad(int Velocidad) { this.Velocidad = Velocidad; }
        public bool geton_off() { return this.on_off; }
        public void seton_off(bool on_off) { this.on_off = on_off; }
        public bool getPintado() { return this.Pintado; }
        private void setPintado(bool Pintado) { this.Pintado =  Pintado; }
        public bool getDisponible() { return this.Disponible; }
        private void setDisponible(bool disponible) { this.Disponible = disponible; }

       





    }
}
