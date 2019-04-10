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
&nbsp;| checkInDate               |                      | string <br>(ISO Date) | Fecha de entrada para la visita
&nbsp;| checkOutDate              |                      | string <br>(ISO Date) | Fecha de salida para la visita
&nbsp;| checkIn [Object]          | module               | string                | Id del modulo
&nbsp;|                           | moduleName           | string                | Nombre del Modulo
&nbsp;|                           | moduleAnswerId       | string                | Id de la respuesta
&nbsp;| checkOut [Object]         | module               | string                | Id del modulo
&nbsp;|                           | moduleName           | string                | Nombre del Modulo
&nbsp;|                           | moduleAnswerId       | string                | Id de la respuesta
&nbsp;| activities [Array Object] | module               | string                | Id del modulo
&nbsp;|                           | moduleName           | string                | Nombre del Modulo
&nbsp;|                           | moduleAnswerId       | string                | Id de la respuesta
&nbsp;| user [Object]             | email                | string                | 
&nbsp;|                           | firstName            | string                | 
&nbsp;|                           | lastName             | string                | 
&nbsp;| userId                    |                      | string                | Id de usuario
&nbsp;| folio                     |                      | string                | Folio generado si esta configurado en la visita
&nbsp;| keys                      |                      | string array          | Claves de los campos clave de esta visita
&nbsp;| keysAnswers [Object]      | [Nombre del campo i] | string o Array        | Respuestas registradas para los campos configurados al motor
&nbsp;| created                   |                      | string <br>(ISO Date) | Fecha de Creación


## Notas

- Los campos moduleName y module podrian regresar vacios o no regresar en los diferentes objetos en los que se encuentran.
- Las visitas no cerradas regresaran con la informacion de *checkOut* y *checkOutDate* como vacia.
- Una visita puede tener una lista de actividades vacia.
- El campo *keys* refleja los campos clave donde.  
