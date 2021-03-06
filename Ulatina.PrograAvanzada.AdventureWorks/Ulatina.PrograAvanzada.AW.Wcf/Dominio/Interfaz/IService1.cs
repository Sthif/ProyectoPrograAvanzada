﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Ulatina.PrograAvanzada.AW.Wcf
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);


        [OperationContract]
        Model.Product EncontrarProductoPorNumero(string elNumero);

        [OperationContract]
        IList<Model.Product> ListarTodos();

        [OperationContract]
        IList <Model.Product> BuscarProductoPorRangoDePrecio(decimal elPrecioInferior, decimal elPrecioSuperior);


		//STHIF ARCE GUERRERO

		/// 2.  lista de artículos cuya fecha de vencimiento sea menor o igual a una determinada.

		[OperationContract]
		IList<Model.Product> BuscarProductoFechaVencimiento(DateTime elFechaVencimiento);

		/// 5.  lista de artículos cuyo nombre de la categoría contenga una hilera determinada.
		[OperationContract]
		IList<Model.Product> BuscarProductoNombreCategoria(string elCategoria);

		/// 7.  lista de artículos que contengan al menos un review.
		[OperationContract]
		IList<Model.Product> BuscarProductoContegaReview();




	}


    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
