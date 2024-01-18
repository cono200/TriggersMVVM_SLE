using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using TriggersMVVM_SLE.VistaModelo;

namespace TriggersMVVM_SLE.Modelo
{
    public class Mcategorias : BaseViewModel
    {
        public string descripcion {  get; set; }
        public int numeroItem { get; set; }
        public string imagen { get; set; }

        //OBKETOS QUE INTERACTUAN CON LA INTERFAZ

        public string _backgroundColor;
        public string _textColor;
        public bool _selected;


        public string backgroundColor
        {
            get { return _backgroundColor; }
            set { SetProperty(ref _backgroundColor, value); }
        }

        public string textColor
        {
            get { return _textColor; }
            set { SetProperty(ref _textColor, value); }
        }

        public bool selected
        {
            get { return _selected; }
            set { SetProperty(ref _selected, value); }
        }
    }
}
