using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace TriggersMVVM_SLE.Triggers.Tcategoria
{
    public class Timagen : TriggerAction<Image>
    {
      public bool activacion {  get; set; }
        protected override async void  Invoke(Image sender)
        {
            if (activacion == true)
            {
                sender.BackgroundColor = Color.Red;
                //ROTACION QUE TENDRA, TIEMPO QUE TARDARA EN MILISEGUNDOS 
                //TIPO DE ANIMACION (EFECTO)
                await sender.RelRotateTo(360, 5000, Easing.BounceOut);
                    
            }

            if (activacion == false)
            {
                //EN ESTA PARTE REUSTARAMOS LOS VALORES A UN ESTADO NORMAL
                sender.BackgroundColor = new Image().BackgroundColor;
                sender.Rotation = new Image().Rotation;
            }
        }
    }
}
