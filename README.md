# introducción a la programación

Este es un repositorio que acompaña a el curso de YouTube en el canal de Codealo.

La rama `main` esta diseñada para ser el punto de comienzo de nuestro aprendizaje. Cada diferente rama dentro del repositorio va con un tema en el curso. Allí encontraras los cambios a los archivos.

## Usando Repl.it

Utilizaremos https://repl.it para poder compilar y correr nuestro código de C# sin tener que descargar nada. Dentro de Repl.it podemos correr nuestro código sin ningun problema. Para utilizar el botón de `run` debemos configurar nuestro archivo de `.replit`

### Instrucciones para utilizar el botón de run

1. Abri `.replit`
2. Cambiar el valor de `run=`
  * `run="csc ./{carpeta}/main.cs -out:./{carpeta}/main.exe  && mono ./{carpeta}/main.exe"`

Ejemplo, si queremos correr el código en la carpeta `09-genericos` escribimos
```
run="csc ./09-genericos/main.cs -out:./09-genericos/main.exe  && mono ./09-genericos/main.exe"
```
Si tienes alguna duda escribir a través de [Instagram](https://instagram.com/codealo) o enviame un correo a johnnie@codealo.dev
