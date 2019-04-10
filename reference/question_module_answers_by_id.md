
Respuestas de Módulos de Preguntas Por Id
=======

## Parámetros

### Headers

Clave | Valor
------- | ------------ 
BQAPPTOK | Api Token de Aplicación
BQMODTOK | Api Token de Módulo

### URL

```
/v1/question-module-answers/:questionAnswerId
```

Campo | Tipo | Requerido | Descripción
-----: | :------ | :-------: | ---------
questionAnswerId | string | Si | Id de la respuesta a consultar
 
## Estructura de Respuesta

Campo | | Nombre | Tipo | Descripción
----: | ----: | ----: | :----: | :----:
&nbsp;| user [Object] | email | string | 
 | | | firstName | string | 
 | | | lastName | string | 
 | |  answers [Array] | [Nombre del campo i] | string o Array | Respuestas registradas para los campos configurados al motor
 | | correctAnswers | | int | En caso de ser tipo trivia
 | | result | | int | En caso de ser tipo trivia
 | | created | | string <br>(ISO Date) | Fecha de Creación


## Notas

- Las respuestas que contengan imágenes se regresara en el api el nombre del archivo, las imágenes se pueden descargar desde el panel del app.
