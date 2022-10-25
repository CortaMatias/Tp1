## **ROYAL CRUISES**

## SOBRE MI :  

### Mi nombre es **Matias Corta**
*Este trabajo fue un gran desafio para mi porque nunca habia hecho algo tan "Grande", me llevo muchisimo tiempo pero me gusto mucho hacerlo porque aprendi un monton de cosas, me hubiese gustado conocer un poco mas sobre algunas herramientas que me hubiesen facilitado bastante las cosas. Sin embargo considero que el trabajo esteticamente y el funcionamiento es correcto y esta bueno asique espero que les guste.*


  <h2>RESUMEN DE LA APLICACION </h2>
<ul>
  <li><h3>Login</h3>
   La aplicacion comienza con el login el cual esta preparado para recibir 4 vendedores
- Usuario: "Matias Corta"    Contaseña: "mati1234"
- Usuario: "Maximiliano Neiner"   Contraseña: "maxi1234"
- Usuario: "Facundo Rocha"    Contraseña: "facu1234"
- Usuario: "Felipe Bustos"  Contraseña: "feli1234"

![Image text](https://github.com/CortaMatias/Tp1/blob/Recuperatorio/login.jpeg)</li>
  
  <li><h3>Home</h3>
  Con esta vista comienza la aplicacion mostrando los destinos en un lado y en el otro el menu de opciones para navegar por la aplicacion
  
  ![Image text](https://github.com/CortaMatias/Tp1/blob/Recuperatorio/home.jpeg)
  
  - Con el boton 'Home' vamos a volver siempre a esta vista que es la principal.
    
  - Con los botones del Menu vamos accediendo a los distintos funcionamientos de la aplicacion.
  </li>
  
<li><h3>Viajes</h3>
  Apretando el boton 'Viajes' del menu vamos a obtener esta vista.
  
 ![Image text](https://github.com/CortaMatias/Tp1/blob/Recuperatorio/viajes.jpeg)
 
 Aqui podremos ver informacion de los viajes ya existentes y tambien podremos agregar nuevos viajes.
  
 -Para poder ver la informacion de un viaje debemos elegir el nombre del crucero y la fecha de salida y de esta forma se cargaran automaticamente la informacion de dicho viaje.
  
 -Para poder agregar un viaje deberemos hacer click en el boton 'agregar viaje' alli quedaran habilitadas solo las opciones que necesitamos para agregar viajes como lo son:
 
 -Crucero
 -Fecha de salida
 -Fecha de vuelta
 -Destino
 
 El resto de los campos son informacion que se obtiene con esos datos y se utilizan solamente para mostrar informacion.
</li>

<li><h3>Pasajeros</h3>
 En esta apartado vamos a poder ver la informacion individual de los pasajeros en funcion de algun viaje y tambien tendremos la opcion de agregar pasajeros a un determinado viaje.
 
 ![Image text](https://github.com/CortaMatias/Tp1/blob/Recuperatorio/pasajeros.jpeg)

-Para poder ver la informacion de un pasajero debemos elegir un viaje accediendo al mismo a traves de su crucero asignado y la fecha de salida(Ya que no podra haber 2 viajes con el mismo crucero en esa fecha), una vez seleccionado el viaje podremos acceder a la lista de pasajeros en el campo "Nombre del Pasajero" .
  
-Para poder agregar un pasajero a un viaje tenemos que hacer el mismo procedimiento que para verlo, debemos seleccionar el viaje al que deseamos agregarlo(Si es que ese no salio.) Y apretar el boton "Vender pasaje", Una vez apretado este boton se habilitara el boton "validar datos" el cual valida que los datos ingresados esten sean correctos, se desabilitaran los campos que no correspondan ingresar ya que algunos de ellos se calculan automaticamente(Como por ej. la edad). Si se pasa las validaciones correspondientes se mostrara un cartel con el precio del pasaje y se preguntara por la confirmacion de la compra.

<h4>Consultar Grupo familiar </h4>

![Image text](https://github.com/CortaMatias/Tp1/blob/Recuperatorio/consultar.jpeg)

-Este boton esta con la intencion de ayudar al usuario que utilice la aplicacion para consultar en la lista de viajes los requisitos que pueda tener un grupo familiar a la hora de comprar un pasaje, ya sea los salones que pretenden que tengan los cruceros o la cantidad de personas que compongan el grupo familiar para poder consultar la disponibilidad de los cruceros en los viajes, en la lista se cargaran los viajes que cumplan con los requisitos ingresados. Si necesitan conocer mas caracteristicas del viaje o del crucero siempre esta la opcion de entrar a la opciones "Viajes" o "Cruceros" y poder analizar todo lo que se desee.
</li>
  
<li><h3>Cruceros</h3>
En esta opcion se podra acceder a la informacion de cada uno de los cruceros de los que dispone la aplicacion. Tambien se podra agregar cruceros nuevos en caso de que sea necesario.

![Image text](https://github.com/CortaMatias/Tp1/blob/Recuperatorio/cruceros.jpeg)

-Para poder ver la informacion del crucero simplemente habra que elegirlo en la opcion "Nombre" y la informacion se completara automaticamente.

-Si se quiere agregar un crucero nuevo a la lista de cruceros disponibles se debe tocar el boton "Nuevo crucero", cuando esto ocurra quedaran habilitados los campos que sean necesarios para agregar un nuevo crucero ya que algunos de los datos son de informacion obtenida con los datos principales.

</li>
<li><h3>Historial</h3></li>
En esta opcion se podra ver los datos historicos de la aplicacion, donde habra 4 opciones principales.

![Image text](https://github.com/CortaMatias/Tp1/blob/Recuperatorio/historial.jpeg)

-En la parte de abajo estaran el total recaudado ya sea por los viajes regionales, los extra regionales y el total facturado.
-Dentro de las 4 opciones que estaran disponibles para navegar tendremos las que vemos en la imagen.
-Una vez que elijamos la opcion "Todos los pasajeros" se hara visible el control que permita el filtrado de los mismos.
-Pueden aparecer pasajeros repetidos y esto es debido a que este pasajero esta vinculado a diferentes Viajes y es necesario volver a mostrarlo para saber a que diferentes viajes esta asignado ese pasajero, ya que a la hora de mostrarlo no solo tenemos en cuenta sus datos sino tambien los del viaje.
 </ul>


<h2>Diagrama de Clases </h2>

![Image text](https://github.com/CortaMatias/Tp1/blob/Recuperatorio/Diagrama.png)



#### JUSTIFICACION TECNICA

Se pudieron aplicar los temas visto hasta el momento en clase, la abstraccion a la hora de crear las clases, se utilizo sobrecarga de metodos, constructores y tambien de operadores para facilitar las validaciones, los calculos y las asignaciones a las listas correspondientes. Utilizamos la Herencia tanto en las clases como en los formularios yendo de los mas general a lo particular. Tanto en las clases como en los formularios utilizamos el Encapsulamiento para cuidar el acceso a los metodos como los atributos y los componentes de los formularios para poder acceder desde sus hijos y sobreescribir los metodos y poder modificar los componentes. Se utilizaron las colecciones para listas de cruceros, pasajeros y viajes y tambien se utilizo el Dictionary y algunos de sus metodos para facilitar algunos calculos, la clase abstracta persona de la cual sale la clase pasajero, la herencia de los formularios la utilizamos con 2 formularios que la idea era que tengan la misma implementacion de elegir un crucero y una fecha de salida para poder elegir un viaje y que de esa forma exista una sola posibilidad disponible lo cual tambien se tuvo en cuenta a la hora de crear las clases y como iban a estar relacionadas las mismas. 


## PROPUESTA DE VALOR AGREGADO

-Se agrego la opcion de añadir cruceros a la lista de cruceros con todas sus validaciones correspondientes y poder mostrarlo y agregarlo a un viaje si asi se desea.

-Se agrego la opcion de añadir viajes a la lista de viajes con todas sus validaciones correspondientes y poder mostrarlo y agregarle pasajeros a este viaje.
 
