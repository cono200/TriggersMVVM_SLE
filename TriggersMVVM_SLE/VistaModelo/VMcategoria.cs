using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TriggersMVVM_SLE.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace TriggersMVVM_SLE.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        string _imagen;
        bool _activadorAnimacionImg;
        ObservableCollection<Mcategorias> _listaCategorias;
        #endregion
        #region CONSTRUCTOR
        public VMcategoria(INavigation navigation)
        {
            Navigation = navigation;
            MostrarCategorias();
        }

        #endregion

        #region OBJETOS
        public ObservableCollection<Mcategorias> ListaCategorias
        {
            get { return _listaCategorias; }
            set { SetValue(ref _listaCategorias, value); }
        }

        public bool ActivadorAnimacionImg
        {
            get { return _activadorAnimacionImg; }
            set { SetValue(ref _activadorAnimacionImg, value); }
        }

        public string Imagen
        {
            get { return _imagen; }
            set { SetValue(ref _imagen, value);}
        }

        #endregion

        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }
        public void MostrarCategorias()
        {
            //AL HACER ESTO ESTAMOS JALANDO TODA LA DATA
            ListaCategorias = new ObservableCollection<Mcategorias>(Datos.Dcategorias.MostrarCategorias());
        }

        public void Seleccionar(Mcategorias modelo)
        {
            //CON EL INDEX IODENTIFCICAMOS A QUE IMAGEN LE HEMOS DADO CLICK
            var index = ListaCategorias
                .ToList()
                .FindIndex(p => p.descripcion == modelo.descripcion);

            Imagen = modelo.imagen;
            if (index > -1)
            {
                Deseleccionar();
                ActivadorAnimacionImg=true;
                ListaCategorias[index].selected=true;
                ListaCategorias[index].textColor = "#FFFFFF";
                ListaCategorias[index].backgroundColor = "#FF506B";
            }
        }


        public void Deseleccionar()
        {
            ListaCategorias.ForEach((item) =>
            {
                ActivadorAnimacionImg = false;
                item.selected = false;
                item.textColor = "#000000";
                item.backgroundColor = "#EAEDF6";
            });
        }




        #endregion
        #region COMANDOS
        public ICommand ProcesoAsynCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSimpCommand => new Command(MostrarCategorias);
        public ICommand ProcesoSimpleSeleccionar => new Command<Mcategorias>((p) => Seleccionar(p));
        #endregion

    }
}
