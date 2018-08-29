Respuestas de Módulos de Preguntas
=======

## Parámetros

### Headers

Clave | Valor
------- | ------------ 
BQAPPTOK | Api Token de Aplicación
BQMODTOK | Api Token de Módulo

### Query String

Campo | Tipo | Requerido | Descripción
-----: | :------ | :-------: | ---------
users | string | No <br>(Default todos) | Uno o mas emails de usuarios separados por comas
initialDate | string  <br>ISO Dates (Date-Time) | Si | Rango inicial de Búsqueda 
finalDate | string  <br>ISO Dates (Date-Time) | No | Rango Final de Búsqueda
limit | int | Si | Límite de registros de consulta
skip | int | No <br>(Default 0) | Número de registros a saltar
 
## Estructura de Respuesta

Parámetro | | Nombre | Tipo | Descripción
----: | ----: | ----: | :----: | :----:
total | | | int | Número de resultados de query
list | user [Object] | email | string | 
 | | | firstName | string | 
 | | | lastName | string | 
 | |  answers [Array] | [Nombre del campo i] | string o Array | Respuestas registradas para los campos configurados al motor
 | | correctAnswers | | int | En caso de ser tipo trivia
 | | result | | int | En caso de ser tipo trivia
 | | created | | string <br>(ISO Date) | Fecha de Creación




## Notas

- Las respuestas que contengan imágenes se regresara en el api el nombre del archivo, las imágenes se pueden descargar desde el panel del app.
