public class Libros {
// Atributos 

private String ISBN=""; //esta linea muestra el atributo privado del ISBN 
private String Titulo=""; // esta linea muestra el atributo privado del titulo
private String Autor=""; // esta linea muestra el atributo pruivado del autor
private int numpaginas; // esta linea muestra el atributo privado del numero de paginas

//Metodos - creamos el listado de metodos para consultar y configurar
public void ConsultarISBN () {  // en esta linea encontramos la consulta del ISBN
   Console.WriteLine (this.ISBN); 
}
public void ConsultarTitulo () { // en esta linea encontramos la consulta del titulo
   Console.WriteLine  (this.Titulo);
}
public void Consultarautor () { // en esta linea encontramos la consulta del autor
  Console.WriteLine ( this.Autor);
}
public int Consultarnumpaginas () { // en esta linea encontramos la consulta del numero de paginas
   return this.numpaginas; 
}
public void  SetISBN (string ISBN) { async // a partir de esta linea hallamos las configuraciones, en este caso la de ISBN
    this.ISBN = ISBN;
}
public void SetTitulo (string Titulo) { // en esta linea tenemos la configuracion del titulo
    this.Titulo = Titulo;
}
public void SetAutor (string Autor) { // en esta linea está la configuracion del autor 
    this.Autor = Autor;
}
public void Setnumpaginas (int numpaginas) { // por ultimo en esta linea esta la configuracion del numero de paginas
    this.numpaginas = numpaginas; }
public void tostring (){ // aqui ejecutamos el tostring 
   Console.WriteLine("El libro "+this.Titulo+" del autor "+this.Autor+" tiene "+this.numpaginas+" paginas"); //unimos a tostring el console writeline para mostrar en pantalla 
}
 }
 /Creamos una clase libro
public class Libreta{

//Creamos un producto Main y creamos dos libros 
 public static void Main(string[] args){

    Libros Pinocho= new Libros();
    Pinocho.Setnumpaginas(169);
    Pinocho.SetISBN("312546764532");
    Pinocho.SetAutor("Carlos collodi");
    Pinocho.SetTitulo("Pinocho");
    Pinocho.tostring();

    Libros NACHO = new Libros ();
    NACHO.Setnumpaginas(50);
    NACHO.SetISBN("312897654323");
    NACHO.SetAutor("Melanio Hernandez");
   NACHO.SetTitulo("Nacho");
    NACHO.tostring();
  
if (NACHO.Consultarnumpaginas() >= Pinocho.Consultarnumpaginas())  {

   Console.WriteLine("Pinocho tiene mas paginas");
}
   else
   {
    Console.WriteLine("NACHO tiene menos pagina");
   }
   }

 }
//Creamos una clase llamada libreta
public class Libreta{

//Creamos un producto Main y creamos dos libros 
 public static void Main(string[] args){
//creamos un libro llamado pinocho
    Libros Pinocho= new Libros();
    //ultilizamos un setnumpaginas para conectar las dos hojas y darle un valor de paginas
    Pinocho.Setnumpaginas(169);
    //ultilizamos un SetISBN para conectar las dos hoja Y darle un valor de ISBN
    Pinocho.SetISBN("312546764532");
    //ultilizamos un setAutor para conectar las dos hoja y darle el nombre del autor dle libro
    Pinocho.SetAutor("Carlos collodi");
    //ultilizamos un setitulo para conectar las dos hoja y darle un titulo al libro
    Pinocho.SetTitulo("Pinocho");
    //por ultmo en ese fase ultizamos un tostring para que nos muestre en pantalla
    Pinocho.tostring();

    //creamos otro libro llamado NACHO
    Libros NACHO = new Libros ();
    //ultilizamos un setnumpaginas para conectar las dos hoja Y dar un valor a las hojas
    NACHO.Setnumpaginas(50);
    //ultilizamos un setISBN para conectar las dos hoja y dar un valor de ISBN
    NACHO.SetISBN("312897654323");
    //ultilizamos un setAutor para conectar las dos hoja y dar un nombre de autor
    NACHO.SetAutor("Melanio Hernandez");
    //ultilizamos un settitulo para conectar las dos hoja y dar titulo al libro
   NACHO.SetTitulo("Nacho");
   //por ultmo en ese fase ultizamos un tostring para que nos muestre en pantalla
    NACHO.tostring();
  
  //utilizamos un si para definir que libro tiene mas paginas
if (NACHO.Consultarnumpaginas() >= Pinocho.Consultarnumpaginas())  {

//consolewriteline para que muestre en pantalla
   Console.WriteLine("Pinocho tiene mas paginas");
}
//un else para decir que el otro libro tiene menos
   else
   {
      //consolewriteline para que muestre en pantalla
    Console.WriteLine("NACHO tiene menos pagina");
   }
   }

 }