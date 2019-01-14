# Raffle-Codes-Maker
A Basic but useful Software to make Raffles, maintaining randomness and equity with all participants and preventing fraud, pairing every participant with an Id-card and a Unique Raffle Code, even if they take many Raffle Numbers, everyone of them has a Unique Raffle Code.

Informe de Errores. Levantado el 26/11/2017

Lista de Bugs a Corregir:

Total de Bugs y Errores: 14
Bugs / Errores Corregidos: 4
Bugs / Errores Pendientes: 10
Porcentaje de Completado: 29%
Procentaje Faltante: 71%

Total de Aspectos por Optimizar, Refactorizar e Implementar: 12
Número de Aspectos Implementados: 0
Número de Aspectos Pendientes: 12
Porcentaje de Completado: 0%
Procentaje Faltante: 100%

*** Lista de Bugs y Errores: 
CORREGIDO: 28/11/2017 04:03AM - FormAbrirSerie: El Error de Para poder abrir una serie debe seleccionarla antes de la lista debe lanzarce al Presionar el Boton Abrir y no el de buscar
CORREGIDO: 28/11/2017 04:03AM - Hacer que los errores desaparezcan cuando se busque algo y se encuentre correctamente.
CORREGIDO: 28/11/2017 04:03AM - Que los Códigos no desaparezcan cuando la Ventana de Abrir se abra nuevamente.
CORREGIDO: 14/12/2017 02:00AM - Al abrir una serie y avanzar al FormCompleted, el botón de Atrás siempre te lleva directamente a FormPorLotes saltandose el orden y desahibilta a los dos botones Adelante y Atras, el bug occure al presionar el botón Atras, parece ser que ahí esta el error, tal vel por una variable relacionada o algo que conecta por el estilo.
- Al Exportar como Excel, La Barra Global de Progreso solo avanza hasta 80% en vez de 100 y luego desaparece.
- Cuando se abre una serie guardada y se la exporta a Excel no se escriben los espacios de los numeros de rifa en la primera pestaña de usuario
- Problema al Abrir un archivo de excel si el DataGridView de FormPorLote ya ha sido usado anteriormente al abrir una serie guardada y por estilo, se combinan registros o sucede algo raro, terminan desapareciendo algunos montandose en desorden otros, etc.
- Cuando se abre un archivo de Excel el Boton de Guardar Serie se habilita pero el Menú de Guardar Serie no, así que el botón no puede llamar al perform del menú y no realiza ninguna acción

- Cuando Abro dos veces seguidas un archivo de Excel, y pongo Exportar como Excel, en el nombre del Archivo se escribe la ruta completa en vez del nombre
- Cuando se guarda por esta segunda vez los códigos se escriben erroneos en las dos pestañas, en la primera en cantidad y en la segunda tal cual estan en el DataGridview

- Cuando se abre una serie guardada y se requiere iniciar una nueva serie al darle Ok para iniciar salta una excepción que indica que no se pueden agregar mas filas al DataGridView si esta enlazado a datos, entonces hay que romper el enlace o desenlazarlo de los datos al iniciar una nueva serie siempre luego de haber abierto una guardada antes. 
- Al abrir una serie guardada, en ocasiones ProgressBarGlobal no desaparece al final, reparar esto.
- No permitir que el formulario principal se pueda cambiar de tamaño de la esquina inferior derecha, y si se lo permite, establecer bien las opciones de Anchor para que los controles se extiendan adecuadamente al modificar el tamaño o maximizar y establecer un min size para que no se pueda disminuir mas de su tamaño original.
- Al dar Click en el Menú Salir, la Aplicación no muestra el Formulario de despedida ni se cierra la Aplicación

*** Aspectos por Optimizar, Refactorizar e Implementar:
-Ver la Forma de Escribir el Código y nombre de Serie como metadato en un Archivo de Excel o escribirlo de alguna forma para al abrir este archivo de Excel leer esos datos y ponerlos en sus labels respectivos, de no encontrar estos datos en el archivo, escribir: <No se encontró Nombre de Serie en archivo de Excel>, <No se encontró Código de Serie en archivo de Excel>, o algo mas corto que describa esto.
- Revisar como se copia la celda actuar seleccionada en el DataGridView y ver si ya se utiliza o se puede utilizar: DataGridViewPorLotes.Cells.Currentcell()
- Revisar el Logotipo de la Aplicación y evaluar el diseño de un logo más original. Establecer un Ícono para la aplicación.
- Revisar el Diseño de la GUI y mejorarla (Tipo y Tamaño de Tipografía, colores, etc).
- Revisar opciones de Reportes para Implementar la Impresión, e implementarla.
- Implementar Menú de Preferencias/Configuración para la aplicación.
- Implementar la Base de Datos con la que trabaja al Proyecto, para que sea local siempre.
- Implementar un Menú de Ayuda en el cual evaluar el incluír un recurso de ayuda donde describa la aplicación y como usarla, y la opción Acerca de.
- Implementar Control de Versión.
- Revisar la Posibilidad de hacer la Aplicación Actualizable.
- Revisar la Posibilidad de hacer la aplicación Multilanguage y que esté disponible al menos en español e inglés.
- Revisar la Posibilidad de Exportar o Convertir el Proyecto a UWP (Universal Windows Platform).
- Revisar la opción de crear un Instalador de la Aplicación.
