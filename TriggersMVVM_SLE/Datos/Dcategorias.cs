using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TriggersMVVM_SLE.Modelo;

namespace TriggersMVVM_SLE.Datos
{
    public class Dcategorias
    {
        public static ObservableCollection<Mcategorias> MostrarCategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
                new Mcategorias()
                {
                    descripcion = "Cena",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/SmTvgyz/placa-de-tenedor-y-cuchillo.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Hotel",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/JC0CGJq/hotel.jpg",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                     descripcion = "Fiesta",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/s9C7RP4/partido.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                },
                new Mcategorias()
                {
                    descripcion = "Flores",
                    numeroItem=4512,
                    imagen="https://i.ibb.co/R2j225W/maceta.png",
                    backgroundColor="#EAEDF6",
                    textColor="#000000"
                }
            };
        }












    }
}
