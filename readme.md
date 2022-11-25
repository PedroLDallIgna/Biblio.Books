# BiblioBooks - Projeto Integrador II

* Professor: Daniel Menin Tortelli
* Group:
    * Estevão Bonatto (@Estevaobonatto)
    * Henrique Bonatto (@NaTToHen)
    * Pedro Dall' Igna (@PedroLDallIgna)

## Setting up the database
We will use a MSSQLServer runnning in a container. The configuration is in the `Dockerfile`. To build the image of the database container, we must follow these steps below:
```
$ cd Database
$ docker build -t biblio-books .
```
Next, we have to start up a container based in the custom image that we generated. So run:
```
$ docker run -p 1433:1433 --name biblio-books-db -d biblio-books
```
Wait a few seconds (or minutes, depending of your computer), and then the container will be ready and running.

If you want, you can open `bash` inside the container with the follow command:
```
$ docker exec -it biblio-books-db "bash"
```
To exit the container, run:
```
$ exit
```

Afterwork, if you want to stop the container, run:
```
$ docker stop biblio-books-db
```
If you want to start again the same container, run:
```
$ docker start biblio-books-db
```