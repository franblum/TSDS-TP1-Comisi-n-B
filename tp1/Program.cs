using System;

class TabajoPracticoUno
{
    static void Main()
    {
        //Datos generales.
        string nombreUsuario = "";
        string apellidoUsuario = "";
        int edadDeUsuario = 0;
        string dniPasajero = "";
        string dniPadreMadreTutorDeMenor = "";
        string destinoDeVuelo = "";
        int claseVuelo = 0;
        double precioEquipajeDeMas = 0;
        string servicioMenorNoAcompañado = "";
        double pesoEquipajeNoFacturado = 0;
        string codigoEmbarque = "";

        //PRIMERO RECOJEMOS LOS DATOS DEL USUARIO
        Console.WriteLine("BIENVENIDOS AL PROCESO DE CHECK-IN");
        Console.WriteLine("Nombre/nombres de pasajero");
        nombreUsuario = Console.ReadLine();

        Console.WriteLine("Apellido/apellidos de pasajero:");
        apellidoUsuario = Console.ReadLine();
        string nombreCompleto = "Nombre: " + nombreUsuario + " " + apellidoUsuario + " ";

        Console.WriteLine("Ingrse el número '1'/'2'/'3' según la clase: 1-Clase Económica 2-Clase Ejecutiva 3-Primera Clase");
        claseVuelo = int.Parse(Console.ReadLine());

        Console.WriteLine("Edad del pasajero");
        edadDeUsuario = int.Parse(Console.ReadLine());

        // Numero/codigo de ambarque:
        Random rnd = new Random();
        char letraARndUno = (char)rnd.Next('A', 'Z' + 1);
        char letraRndDos = (char)rnd.Next('A', 'Z' + 1);
        string numRndUno = rnd.Next(0, 10).ToString();
        string numRdnDos = rnd.Next(0, 10).ToString();
        string numRndTres = rnd.Next(0, 10).ToString();
        string numRndCuatro = rnd.Next(0, 10).ToString();
        string numRndCinco = rnd.Next(0, 10).ToString();

        codigoEmbarque = letraARndUno.ToString() + letraRndDos.ToString() + numRndUno + numRdnDos + numRndTres + numRndCuatro + numRndCinco;

        //Console.WriteLine("Código de embarque: " + codigoEmbarque);

        if (edadDeUsuario <= 4)
        {
            Console.WriteLine("Ingrese número de documento de identidad del pasajero:");
            dniPasajero = Console.ReadLine();
            Console.WriteLine("Ingrese número de documento de identidad del padre/madre/tutor del pasajero:");
            string dniTutorDeMenor = Console.ReadLine();
            Console.WriteLine("Destino del vuelo:");
            destinoDeVuelo = Console.ReadLine();

            Console.WriteLine(nombreCompleto + " Edad: " + edadDeUsuario + " DNI del responsable: " + dniTutorDeMenor + " DNI del pasajero: " + dniPasajero + " Destino: " + destinoDeVuelo + " Clase: " + claseVuelo + " Código de Embarque " + codigoEmbarque);
            // cierre de niño menor a 5
        }

        //consulto si quiere el servicio menor sin acompaniante
        if ((edadDeUsuario > 4) && (edadDeUsuario < 12))
        {
            Console.WriteLine("El menor entra en el rango de servicio 'Menor no acompañado'. ¿Desa tomar ese servicio?");
            Console.WriteLine("Indique por 'Si' o por 'No'");

            servicioMenorNoAcompañado = Console.ReadLine().ToUpper();
            if (servicioMenorNoAcompañado == "NO")
            {
                Console.WriteLine("Servicio denegado");
            }
        }

        if (edadDeUsuario >= 5)
        {

            Console.WriteLine("Ingrese número de documento de identidad del pasajero:");
            dniPasajero = Console.ReadLine();
            Console.WriteLine("Destino del vuelo:");
            destinoDeVuelo = Console.ReadLine();

            //Equipaje facturado
            Console.WriteLine("Lleva equipaje no facturado? ingese '0' para indicar que 'No' y '1' para indicar que 'Si' ");
            int equipajeFacturado = int.Parse(Console.ReadLine());
            if (equipajeFacturado == 1)
            {
                Console.WriteLine("Indique el número de kilos el peso de su equipaje: ");
                pesoEquipajeNoFacturado = double.Parse(Console.ReadLine());

                switch (claseVuelo)
                {
                    case 1:
                        if (pesoEquipajeNoFacturado <= 5)
                        {
                            Console.WriteLine("Cantidad de peso permitida para su clase");

                        }
                        if (pesoEquipajeNoFacturado > 5)
                        {
                            precioEquipajeDeMas = (pesoEquipajeNoFacturado - 5) * 10;
                            Console.WriteLine("Solo se permite llevar hasta 5k para la Clase Económica, por ende deberá abonar un monto de $ " + precioEquipajeDeMas + ", referidos a $10 por kilo sobrante ");

                        }
                        break;
                    case 2:
                        if (pesoEquipajeNoFacturado <= 10)
                        {
                            Console.WriteLine("Cantidad de peso permitida para Clase Económica");

                        }
                        if (pesoEquipajeNoFacturado > 10)
                        {
                            precioEquipajeDeMas = (pesoEquipajeNoFacturado - 10) * 10;
                            Console.WriteLine("Solo se permite llevar hasta 10k para la Clase Ejecutiva, por ende deberá abonar un monto de $ " + precioEquipajeDeMas + ", referidos a $10 por kilo sobrante ");

                        }
                        break;
                    case 3:
                        if (pesoEquipajeNoFacturado <= 20)
                        {
                            Console.WriteLine("Cantidad de peso permitida para su clase");
                        }
                        if (pesoEquipajeNoFacturado > 20)
                        {
                            precioEquipajeDeMas = (pesoEquipajeNoFacturado - 20) * 10;
                            Console.WriteLine("Solo se permite llevar hasta 20k para Primera Clase, por ende deberá abonar un monto de $ " + precioEquipajeDeMas + ", referidos a $10 por kilo sobrante ");

                        }
                        break;
                }
                //cierre del if de equipaje no facturado
            }

            //Equipaje en mano 
            Console.WriteLine("Indique por 'Si' o por 'NO' si lleva equipaje en mano");
            string equipajeEnMano = Console.ReadLine().ToUpper();
            if (equipajeEnMano == "SI")
            {
                Console.WriteLine("Indique la cantidad de unidades de bosos en mano '1'/'2'/'3'..)");
                int equipajeEnManoCantidad = int.Parse(Console.ReadLine());
                if (equipajeEnManoCantidad > 3)
                {
                    Console.WriteLine("El límite de equipaje son 3 unidades");
                }
                if (equipajeEnManoCantidad <= 3)
                {

                    //cierre del if que dice si el equipaje en mano son tres o menos entonces sigue
                }
                //cierre del if equipaje en mano
            }
            //Masecotass

            Console.WriteLine("¿Lleva mascota a bordo? Indique por 'SI' o por 'NO':");
            string llevaMascota = Console.ReadLine().ToUpper();
            if (llevaMascota == "SI")
            {
                Console.WriteLine("¿Su mascota se encuentra debidamente identificada con chaleco y contiene sujetador de cinturón para el viaje? Indique por 'SI' o por 'NO':");
                string mascotaReady = Console.ReadLine().ToUpper();
            }

            //devolucion total si es menor preo no tan menor
            if (((edadDeUsuario > 4) && (edadDeUsuario < 11)) && (servicioMenorNoAcompañado == "SI"))
            {
                Console.WriteLine(nombreCompleto + "Edad: " + edadDeUsuario + "Servicio: Menor no acompañado" + "DNI del pasajero:" + dniPasajero + "Destino:" + destinoDeVuelo + "Clase:" + claseVuelo + "Código de Embarque" + codigoEmbarque);

            }
            else
            {
                if (precioEquipajeDeMas > 0)
                {
                    Console.WriteLine(nombreCompleto + " Edad: " + edadDeUsuario + " Servicio: Menor no acompañado " + " DNI del pasajero: " + dniPasajero + " Destino: " + destinoDeVuelo + " Clase: " + claseVuelo + " Monto por equipaje excedente: $ " + precioEquipajeDeMas + " Código de Embarque " + codigoEmbarque);
                }
                else
                {
                    Console.WriteLine(nombreCompleto + " Edad: " + edadDeUsuario + " Servicio: Menor no acompañado " + " DNI del pasajero: " + dniPasajero + " Destino: " + destinoDeVuelo + " Clase: " + claseVuelo + " Código de Embarque " + codigoEmbarque);

                }
            }

        }



        // cierre de la llave static void main
    }
    //cierre de llaves de la clase tp1
}

