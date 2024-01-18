using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TriggersMVVM_SLE.Modelo;
using Xamarin.Forms;

namespace TriggersMVVM_SLE.VistaModelo
{
    public class VMcategoria : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
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
        #endregion
        #region COMANDOS
        public  ICommand ProcesoAsyncommand => new Command(async () => await ProcesoAsyncrono());

        public ICommand ProcesoSimpcomand => new Command(MostrarCategorias);
        #endregion

    }
}
