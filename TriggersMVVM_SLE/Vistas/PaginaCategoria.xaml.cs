using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggersMVVM_SLE.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TriggersMVVM_SLE.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaCategoria : ContentPage
    {
        public PaginaCategoria()
        {
            InitializeComponent();
            BindingContext = new VMcategoria(Navigation);
        }
    }
}