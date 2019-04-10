Respuestas de Visitas
=======

## Parámetros

### Headers

Clave | Valor
------- | ------------ 
BQAPPTOK | Api Token de Aplicación
BQVISTOK | Api Token de Visita

### Query String

Campo | Tipo | Requerido | Descripción
-----: | :------ | :-------: | ---------
users | string | No <br>(Default todos) | Uno o mas emails de usuarios separados por comas
initialDate | string  <br>ISO Dates (Date-Time) | Si | Rango inicial de Búsqueda 
finalDate | string  <br>ISO Dates (Date-Time) | No | Rango Final de Búsqueda
limit | int | Si | Límite de registros de consulta
skip | int | No <br>(Default 0) | Número de registros a saltar
 
## Estructura de Respuesta

Campo | | Nombre | Tipo | Descripción
----: | ----: | ----: | :----: | :----:
total | | | int | Número de resultados de query
list  | visitId                   |                      | string                | Id de la visita
      | checkInDate               |                      | string <br>(ISO Date) | Fecha de entrada para la visita
      | checkOutDate              |                      | string <br>(ISO Date) | Fecha de salida para la visita
      | checkIn [Object]          | module               | string                | Id del modulo
      |                           | moduleName           | string                | Nombre del Modulo
      |                           | moduleAnswerId       | string                | Id de la respuesta
      | checkOut [Object]         | module               | string                | Id del modulo
      |                           | moduleName           | string                | Nombre del Modulo
      |                           | moduleAnswerId       | string                | Id de la respuesta
      | activities [Array Object] | module               | string                | Id del modulo
      |                           | moduleName           | string                | Nombre del Modulo
      |                           | moduleAnswerId       | string                | Id de la respuesta
      | user [Object]             | email                | string                | 
      |                           | firstName            | string                | 
      |                           | lastName             | string                | 
      | userId                    |                      | string                | Id de usuario
      | folio                     |                      | string                | Folio generado si esta configurado en la visita
      | keys                      |                      | string array          | Claves de los campos clave de esta visita
      | keysAnswers [Object]      | [Nombre del campo i] | string o Array        | Respuestas registradas para los campos configurados al motor
      | created                   |                      | string <br>(ISO Date) | Fecha de Creación


## Notas

- Los campos moduleName y module podrian regresar vacios o no regresar en los diferentes objetos en los que se encuentran.
- Las visitas no cerradas regresaran con la informacion de *checkOut* y *checkOutDate* como vacia.
- Una visita puede tener una lista de actividades vacia.
- El campo *keys* refleja los campos clave donde.  